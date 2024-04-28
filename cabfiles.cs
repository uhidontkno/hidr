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
                [DllImport("cabinet.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr FDICreate(
            ExtractCallbackDelegate pfnalloc,
            ExtractCallbackDelegate pfnfree,
            ExtractCallbackDelegate pfnopen,
            ExtractCallbackDelegate pfnread,
            ExtractCallbackDelegate pfnwrite,
            ExtractCallbackDelegate pfnclose,
            ExtractCallbackDelegate pfnseek,
            int cpuType,
            ref int erf);

        [DllImport("cabinet.dll")]
        private static extern bool FDICopy(
            IntPtr hfdi,
            string pszCabinet,
            string pszCabPath,
            int flags,
            ExtractCallbackDelegate pfnfdin,
            ExtractCallbackDelegate pfnfdid,
            IntPtr pv);

        [DllImport("cabinet.dll")]
        private static extern bool FDIDestroy(IntPtr hfdi);

                private delegate IntPtr ExtractCallbackDelegate();


        static void ExtractCabFile(string cabFile, string extractPath)
        {
               ExtractCallbackDelegate extractCallbackDelegate = ExtractCallback;
               int error = 0;
               IntPtr hfdi = FDICreate(
                extractCallbackDelegate,
                extractCallbackDelegate,
                extractCallbackDelegate,
                extractCallbackDelegate,
                extractCallbackDelegate,
                extractCallbackDelegate,
                extractCallbackDelegate,
                0,
                ref error);

            if (hfdi == IntPtr.Zero)
            {
                throw new Exception($"Failed to create cabinet handle. Error code: {error}");
            }

            try
            {
               if (!FDICopy(hfdi, cabFile, extractPath, 0, null, null, IntPtr.Zero))
                {
                    throw new Exception($"Failed to extract files from cabinet. Error code: {error}");
                }
            }
            finally
            {
              FDIDestroy(hfdi);
            }
        }

       private static IntPtr ExtractCallback()
        {
            return IntPtr.Zero;
        }
        static string RunMathSolverCab(string cabFile, string parameters)
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
