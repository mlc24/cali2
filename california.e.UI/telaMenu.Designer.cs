
namespace california.e.UI
{
    partial class telaMenu
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
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnCadcli = new System.Windows.Forms.Button();
            this.btnCadfun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(48, 86);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(205, 79);
            this.btnEstoque.TabIndex = 1;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(292, 86);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(205, 79);
            this.btnVendas.TabIndex = 3;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(531, 86);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(205, 79);
            this.btnHistorico.TabIndex = 4;
            this.btnHistorico.Text = "Historico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnCadcli
            // 
            this.btnCadcli.Location = new System.Drawing.Point(425, 297);
            this.btnCadcli.Name = "btnCadcli";
            this.btnCadcli.Size = new System.Drawing.Size(205, 79);
            this.btnCadcli.TabIndex = 5;
            this.btnCadcli.Text = "Cadastrar cliente";
            this.btnCadcli.UseVisualStyleBackColor = true;
            this.btnCadcli.Click += new System.EventHandler(this.btnCadcli_Click);
            // 
            // btnCadfun
            // 
            this.btnCadfun.Location = new System.Drawing.Point(166, 297);
            this.btnCadfun.Name = "btnCadfun";
            this.btnCadfun.Size = new System.Drawing.Size(205, 79);
            this.btnCadfun.TabIndex = 6;
            this.btnCadfun.Text = "Cadastrar funcionario";
            this.btnCadfun.UseVisualStyleBackColor = true;
            this.btnCadfun.Click += new System.EventHandler(this.btnCadfun_Click);
            // 
            // telaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadfun);
            this.Controls.Add(this.btnCadcli);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnEstoque);
            this.Name = "telaMenu";
            this.Text = "telaMenu";
            this.Load += new System.EventHandler(this.telaMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnCadcli;
        private System.Windows.Forms.Button btnCadfun;
    }
}