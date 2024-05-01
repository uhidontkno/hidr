using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hidr Shell");
        Console.Title = "Hidr Shell";
        while (true)
        {
            Console.Write($"{Environment.CurrentDirectory}>");
            string command = Console.ReadLine();

            if (command.ToLower() == "exit")
                break;
            else if (command.Split(' ')[0].ToLower() == "title")
            {
                string[] cmdargs = command.Split(' ');
                Console.Title = command.Replace("title ","");
            }
            else
            {

                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/c echo !{command} | ftp";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                Console.Write(output);
                output = process.StandardError.ReadToEnd();
                Console.Write(output);
                process.WaitForExit();
            }
        }
    }
}