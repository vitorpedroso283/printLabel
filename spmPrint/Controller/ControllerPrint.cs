using System;
using System.IO;

namespace spmPrint.Controller
{
    class ControllerPrint
    {
        private ControllerLog log;

        public ControllerPrint(ControllerLog l)
        {
            log = l;
        }

        public void codigoNumber(string codigo)
        {
            try
            {
                string filePrint = openFile("motor");
                filePrint = filePrint.Replace("[codigo]", codigo);
                createFile(filePrint);
            }
            catch (Exception ex)
            {
                string message = $"Erro na impressão: {ex.Message}";
                log.escreveMensagem(message);
                throw new Exception(message);
            }
        }

        private string openFile(string name)
        {
            try
            {
                string fileName = @"Print\" + name + ".prn";
                System.Text.Encoding encoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
                StreamReader sr = new System.IO.StreamReader(fileName, encoding);
                return sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void createFile(string filePrint)
        {
            try
            {
                string fileName = @"Print\print.prn";
                if (File.Exists(fileName))
                    File.Delete(fileName);
                StreamWriter sw = new StreamWriter(fileName);
                sw.AutoFlush = true;
                sw.WriteLine(filePrint);
                sw.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
