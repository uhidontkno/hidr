using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hidr Shell");
        while (true)
        {
            Console.Write($"{Environment.CurrentDirectory}>");
            string command = Console.ReadLine();

            if (command.ToLower() == "exit")
                break;

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c echo !{command} | ftp";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            output = process.StandardError.ReadToEnd();
            Console.WriteLine(output);
            process.WaitForExit();
        }
    }
}