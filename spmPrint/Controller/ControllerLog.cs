using System;
using System.IO;

namespace spmPrint.Controller
{
    class ControllerLog
    {
        private StreamWriter streamWriter;

        public ControllerLog()
        {
            try
            {
                streamWriter = new StreamWriter("Log-Print.txt");
                streamWriter.AutoFlush = true;
                streamWriter.WriteLine(DateTime.Now + ":\tInício de Log");
            }
            catch (Exception e)
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                    streamWriter = null;
                }
                string mensagem = "Erro na inicialização do log: " + e.Message;
                Console.WriteLine(mensagem);
                throw new Exception(mensagem);
            }
        }

        public void escreveMensagem(string mensagem)
        {
            try
            {
                streamWriter.WriteLine(DateTime.Now + ":\t" + mensagem);

            }
            catch (Exception e)
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                    streamWriter = null;
                }
                Console.WriteLine("Erro escrevendo entrada no log: " + e.Message);
            }
        }

        public void closeFile()
        {
            try
            {

                streamWriter.WriteLine("Processo Concluido");
                streamWriter.Close();

            }
            catch (Exception e)
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                    streamWriter = null;
                }
                Console.WriteLine("Erro escrevendo entrada no log: " + e.Message);
            }
        }
    }
}
