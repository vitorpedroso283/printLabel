
namespace spmPrint
{
    partial class Frm_print
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(1006, 48);
            this.label2.TabIndex = 16;
            this.label2.Text = "Leia a etiqueta do código do motor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.tbCodigo.Location = new System.Drawing.Point(12, 221);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(1007, 83);
            this.tbCodigo.TabIndex = 17;
            this.tbCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodigo_KeyDown);
            // 
            // lbMessage
            // 
            this.lbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.Lime;
            this.lbMessage.Location = new System.Drawing.Point(13, 339);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMessage.Size = new System.Drawing.Size(1006, 88);
            this.lbMessage.TabIndex = 18;
            this.lbMessage.Text = "Mensagem!";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMessage.Visible = false;
            // 
            // Frm_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 448);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label2);
            this.Name = "Frm_print";
            this.Text = "Print";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_print_FormClosing);
            this.Load += new System.EventHandler(this.Frm_print_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Timer timer1;
    }
}

