using System;
using System.Diagnostics;

namespace spmPrint.Controller
{
    class ControllerRun
    {
        private ControllerLog log;

        public ControllerRun(ControllerLog l)
        {
            log = l;
        }

        public void Run(string path, string fileName, string arguments = null)
        {
            Process p = null;
            try
            {
                p = new Process();
                p.StartInfo.FileName = path + fileName;
                if (!string.IsNullOrEmpty(arguments))
                    p.StartInfo.Arguments = arguments;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.Start();
            }
            catch (Exception e)
            {
                string message = $"Erro na execução {fileName}: {e.Message}";
                log.escreveMensagem(message);
                throw new Exception(message);
            }
            finally
            {
                if (p != null)
                    p.Close();
            }
        }

    }
}
