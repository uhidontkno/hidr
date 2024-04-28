using Microsoft.Deployment.Compression.Cab;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hidr
{
    internal class cabfiles
    {


        public static void ExtractCabFile(string cabFile, string extractPath)
        {
            CabInfo cab = new CabInfo(cabFile);
            cab.Unpack(extractPath);
        }

       
       public static string RunMathSolverCab(string cabFile, string parameters)
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
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    return output;
                }
            }
            finally
            {
              Directory.Delete(extractPath, true);
            }
        }

    }
}
