using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace V2Ray.SDK.Tool
{
    class SourceFolder
    {
        private Dictionary<string, SourceFolder> _Children = new Dictionary<string, SourceFolder>();
        private Dictionary<string, string> _Protos = new Dictionary<string, string>();

        private readonly string _Target;

        public SourceFolder(string source, string targetBase)
        {
            if (Directory.Exists(source))
            {
                var info = new DirectoryInfo(source);
              
                var index = info.FullName.IndexOf(@"v2ray.com");
                if (index >= 0)
                {
                    _Target = targetBase + info.FullName.Substring(index + 14);
                }

                var children = info.GetDirectories();
                foreach(var child in children)
                {
                    if (!child.Name.StartsWith("."))
                    {
                        _Children.Add(child.Name, new SourceFolder(child.FullName, targetBase));
                    }                    
                }

                var files = info.GetFiles("*.proto");
                foreach(var file in files)
                {
                    _Protos.Add(file.Name, file.FullName);
                }
            }
        }

        public async Task Generate(params string[] includes)
        {
            foreach(var child in _Children)
            {
                await child.Value.Generate(includes);
            }

            if (!string.IsNullOrEmpty(_Target))
            {
                foreach (var proto in _Protos)
                {
                    await Protoc.Execute(_Target, proto.Value, includes);
                }
            }
        }
    }
}
