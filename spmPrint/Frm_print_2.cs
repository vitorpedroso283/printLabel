using System;
using System.Drawing;
using System.Windows.Forms;
using spmPrint.Controller;

namespace spmPrint
{
    public partial class Frm_print_2 : Form
    {
        private static ControllerLog log;
        private ControllerRun controllerRun = new ControllerRun(log);
        private ControllerPrint controllerPrint = new ControllerPrint(log);
        private string path = Application.StartupPath;

        public Frm_print_2()
        {
            InitializeComponent();
        }

        private void tbCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                lbMessage.Visible = false;

                if (e.KeyCode == Keys.Enter)
                {
                    if (tbCodigo.Text.Length == 16)
                    {
                        string codigoDigitado = tbCodigo.Text.ToString().Trim().ToUpper();
                        controllerPrint.codigoNumber(codigoDigitado);
                        //Manda imprimir
                        controllerRun.Run(@"C:\Windows\System32\", "cmd.exe", $"/C type {path}\\print\\print.prn > LPT1");

                        Success();
                    }
                    else
                    {
                        lbMessage.Text = "Número não corresponde do produto!";
                        lbMessage.BackColor = Color.Orange;
                        lbMessage.ForeColor = Color.White;
                        lbMessage.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                lbMessage.Text = $"Erro: {ex.Message}";
                lbMessage.Visible = true;
                return;
            }
        }

        private void Success()
        {
            tbCodigo.Text = "";
            lbMessage.Text = "Sucesso";
            lbMessage.BackColor = Color.Green;
            lbMessage.ForeColor = Color.White;
            lbMessage.Visible = true;
        }

        private void Frm_print_2_Load(object sender, EventArgs e)
        {
            controllerRun.Run(@"Tools\", "DOSPrintUI.exe");
        }

        private void Frm_print_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            controllerRun.Run(@"C:\Windows\System32\", "taskkill.exe", "/F /IM DOSPrintUI.exe /T");
        }

    }
}
