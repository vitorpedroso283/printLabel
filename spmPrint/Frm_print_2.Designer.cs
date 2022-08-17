
namespace spmPrint
{
    partial class Frm_print_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMessage = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.Lime;
            this.lbMessage.Location = new System.Drawing.Point(36, 279);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMessage.Size = new System.Drawing.Size(1006, 88);
            this.lbMessage.TabIndex = 21;
            this.lbMessage.Text = "Mensagem!";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMessage.Visible = false;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.tbCodigo.Location = new System.Drawing.Point(35, 161);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(1007, 83);
            this.tbCodigo.TabIndex = 20;
            this.tbCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodigo_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(1006, 48);
            this.label2.TabIndex = 19;
            this.label2.Text = "Leia a etiqueta do código do motor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm_print_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label2);
            this.Name = "Frm_print_2";
            this.Text = "Frm_prin2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_print_2_FormClosing);
            this.Load += new System.EventHandler(this.Frm_print_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label2;
    }
}