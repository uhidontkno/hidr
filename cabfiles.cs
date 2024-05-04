using Microsoft.Deployment.Compression.Cab;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hidr
{
    public static class ProcessExtensions
{
    public static Task<bool> WaitForExitAsync(this Process process)
    {
        var tcs = new TaskCompletionSource<bool>();

        process.EnableRaisingEvents = true;
        process.Exited += (sender, args) => tcs.TrySetResult(true);

        return tcs.Task;
    }
}
    internal class cabfiles
    {


        public static void ExtractCabFile(string cabFile, string extractPath)
        {
            CabInfo cab = new CabInfo(cabFile);
            cab.Unpack(extractPath);
        }
        async public static Task<bool> RunTMCab(string cabFile)
        {
            string extractPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(extractPath);
            ExtractCabFile(cabFile, extractPath);
            string procPath = Path.Combine(extractPath, "procexp.exe");
            if (!File.Exists(procPath))
            {
                throw new FileNotFoundException("procexp.exe not found in the CAB file.");
            }
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = procPath;
            psi.Arguments = "/accepteula";
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            await Task.Delay(33);
            while (!p.Responding)
            {
                await Task.Delay(33);
            }
            await Task.Delay(500);
            return true;
        }

        async public static Task<string> RunMathSolverCab(string cabFile, string parameters)
        {
            string extractPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());

            try
            {
                Directory.CreateDirectory(extractPath);
                ExtractCabFile(cabFile, extractPath);
                string mathSolverPath = Path.Combine(extractPath, "mathsolver.exe");
                if (!File.Exists(mathSolverPath))
                {
                    throw new FileNotFoundException("MathSolver.exe not found in the CAB file.");
                }
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = mathSolverPath;
                psi.Arguments = parameters;
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                using (Process process = Process.Start(psi))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        StringBuilder outputBuilder = new StringBuilder();
                        string line;
                        while ((line = await reader.ReadLineAsync()) != null)
                        {
                            outputBuilder.AppendLine(line);
                        }
                        await process.WaitForExitAsync();
                        return outputBuilder.ToString();
                    }
                }
            }
            finally
            {
              Directory.Delete(extractPath, true);
            }
        }

    }
}
