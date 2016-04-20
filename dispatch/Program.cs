using System;
using System.Diagnostics;

namespace ConsoleApplication
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "reflect.exe",
                    Arguments = $"áé",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            proc.WaitForExit();
            var stdOut = proc.StandardOutput.ReadToEnd();

            if(stdOut == "áé")
            {
                Console.WriteLine("passed");
                return 0;
            }
            else
            {
                Console.WriteLine($"Failed: áé != {stdOut}");
                return 1;
            }
        }
    }
}
