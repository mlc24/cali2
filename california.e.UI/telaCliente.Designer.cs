
namespace california.e.UI
{
    partial class telaCliente
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nometxt = new System.Windows.Forms.TextBox();
            this.endtxt = new System.Windows.Forms.TextBox();
            this.telefonetxt = new System.Windows.Forms.TextBox();
            this.cpftxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CadCli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nome";
            // 
            // nometxt
            // 
            this.nometxt.Location = new System.Drawing.Point(266, 141);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(232, 20);
            this.nometxt.TabIndex = 48;
            // 
            // endtxt
            // 
            this.endtxt.Location = new System.Drawing.Point(266, 277);
            this.endtxt.Name = "endtxt";
            this.endtxt.Size = new System.Drawing.Size(232, 20);
            this.endtxt.TabIndex = 47;
            // 
            // telefonetxt
            // 
            this.telefonetxt.Location = new System.Drawing.Point(266, 233);
            this.telefonetxt.Name = "telefonetxt";
            this.telefonetxt.Size = new System.Drawing.Size(232, 20);
            this.telefonetxt.TabIndex = 46;
            // 
            // cpftxt
            // 
            this.cpftxt.Location = new System.Drawing.Point(266, 180);
            this.cpftxt.Name = "cpftxt";
            this.cpftxt.Size = new System.Drawing.Size(232, 20);
            this.cpftxt.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 61;
            this.label4.Text = "Cadastro Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 48);
            this.label11.TabIndex = 60;
            this.label11.Text = "California ";
            // 
            // CadCli
            // 
            this.CadCli.Location = new System.Drawing.Point(224, 347);
            this.CadCli.Name = "CadCli";
            this.CadCli.Size = new System.Drawing.Size(313, 42);
            this.CadCli.TabIndex = 62;
            this.CadCli.Text = "Cadastrar";
            this.CadCli.UseVisualStyleBackColor = true;
            this.CadCli.Click += new System.EventHandler(this.CadCli_Click);
            // 
            // telaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CadCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nometxt);
            this.Controls.Add(this.endtxt);
            this.Controls.Add(this.telefonetxt);
            this.Controls.Add(this.cpftxt);
            this.Name = "telaCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.telaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nometxt;
        private System.Windows.Forms.TextBox endtxt;
        private System.Windows.Forms.TextBox telefonetxt;
        private System.Windows.Forms.TextBox cpftxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CadCli;
    }
}

