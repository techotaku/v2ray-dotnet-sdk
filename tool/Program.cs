using System;
using System.IO;

namespace V2Ray.SDK.Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                var path = Path.Combine(args[0], "v2ray.com", "core");
                if (Directory.Exists(args[0]) && Directory.Exists(path))
                {
                    if (Directory.Exists(args[1]))
                    {
                        Protoc.Init();

                        var sdk = new DirectoryInfo(args[1]).FullName;
                        var include = new DirectoryInfo(args[0]).FullName;

                        var source = new SourceFolder(path, sdk);

                        Console.WriteLine("Started.");
                        source.Generate(include).Wait();
                        Console.WriteLine("Completed.");
                    } 
                    else
                    {
                        Console.WriteLine($@"Can not found sdk path.");
                    }
                }
                else
                {
                    Console.WriteLine($@"Can not found v2ray.com\core under your go source.");
                }
            }
            else
            {
                Console.WriteLine("V2Ray DotNet SDK Tool");
                Console.WriteLine();
                Console.WriteLine("Usage:");
                Console.WriteLine(@".\v2sdktool <go source path> <cshart target path>");
                Console.WriteLine();
                Console.WriteLine(@".\v2sdktool ..\..\..\Go ..\sdk");
            }
        }
    }
}
