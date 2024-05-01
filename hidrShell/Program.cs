using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hidrShell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.StartInfo.FileName = "ftp";
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.StartInfo.UseShellExecute = false;

            process.Start();

            // Start a thread to handle FTP output
            Thread outputThread = new Thread(() =>
            {
                string line;
                while ((line = process.StandardOutput.ReadLine()) != "")
                {
                    Console.WriteLine(line);
                }
            });
            outputThread.Start();

            // Start a thread to handle user input
            Thread inputThread = new Thread(() =>
            {
                string line;
                
                while (true)
                {
                    
                    line = Console.ReadLine();
                    if (line.ToLower() == "") { }
                    else
                    {
                        if (line.ToLower() == "cmd") { Process.Start("cmd"); }
                        else if (line.ToLower() == "powershell")
                        {
                            Process.Start("powershell");
                        }
                        else
                        {
                            Console.WriteLine("!" + line);
                            process.StandardInput.WriteLine("!" + line);
                            if (line.ToLower() == "exit")
                                break;
                        }
                    }
                }
            });
            inputThread.Start();

            // Wait for the input thread to finish
            inputThread.Join();

            // Kill the process after the user exits
            process.Kill();
        }
    }
}
