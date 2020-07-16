using System;
using System.IO;
using System.Threading.Tasks;

namespace V2Ray.SDK.Tool
{
    static class Protoc
    {
        private static string _Protoc;
        private static string _Plugin;

        public static void Init()
        {
            var userProfile = Environment.GetEnvironmentVariable("UserProfile");
            var protoc = Path.Combine(userProfile, ".nuget", "packages", "Google.Protobuf.Tools", "3.12.3", "tools", "windows_x64", "protoc.exe");
            var plugin = Path.Combine(userProfile, ".nuget", "packages", "Grpc.Tools", "2.30.0", "tools", "windows_x64", "grpc_csharp_plugin.exe");
            if (File.Exists(protoc))
            {
                _Protoc = protoc;
            }
            if (File.Exists(plugin))
            {
                _Plugin = plugin;
            }
        }

        public static async Task Execute(string target, string proto, params string[] includes)
        {
            if (!string.IsNullOrEmpty(_Protoc) && !string.IsNullOrEmpty(_Plugin) && File.Exists(proto))
            {
                await Task.Run(() =>
                {
                    if (!Directory.Exists(target))
                    {
                        Directory.CreateDirectory(target);
                    }

                    var process = new System.Diagnostics.Process();
                    var startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = _Protoc;
                    startInfo.Arguments = $"--csharp_out {target} --grpc_out {target} --plugin=protoc-gen-grpc={_Plugin}";
                    foreach(var i in includes)
                    {
                        startInfo.Arguments += $" -I {i}";
                    }
                    startInfo.Arguments += $" {proto}";
                    process.StartInfo = startInfo;
                    Console.Write($"Generating for {proto}...");
                    process.Start();
                    process.WaitForExit(1000);
                    if (process.ExitCode == 0)
                    {
                        Console.WriteLine("success.");
                    } 
                    else
                    {
                        Console.WriteLine("fail.");
                    }
                });
            }
        }
    }
}
