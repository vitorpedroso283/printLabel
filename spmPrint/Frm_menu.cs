using System;
using System.Windows.Forms;

namespace spmPrint
{
    public partial class Frm_menu : Form
    {
        public Frm_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Frm_print"] as Frm_print) == null)
            {
                Frm_print fp = new Frm_print();
                fp.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Frm_print_2"] as Frm_print_2) == null)
            {
                Frm_print_2 fp = new Frm_print_2();
                fp.Show();
            }
        }
    }
}
