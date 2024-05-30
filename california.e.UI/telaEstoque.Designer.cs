
namespace california.e.UI
{
    partial class telaEstoque
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
            this.label9 = new System.Windows.Forms.Label();
            this.AddProd = new System.Windows.Forms.Button();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ValProd = new System.Windows.Forms.TextBox();
            this.CatProd = new System.Windows.Forms.TextBox();
            this.CodProd = new System.Windows.Forms.TextBox();
            this.QuantProd = new System.Windows.Forms.TextBox();
            this.NomeProd = new System.Windows.Forms.TextBox();
            this.lklVoltar = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(463, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "Produtos";
            // 
            // AddProd
            // 
            this.AddProd.Location = new System.Drawing.Point(88, 406);
            this.AddProd.Name = "AddProd";
            this.AddProd.Size = new System.Drawing.Size(113, 27);
            this.AddProd.TabIndex = 35;
            this.AddProd.Text = "Adicionar";
            this.AddProd.UseVisualStyleBackColor = true;
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(255, 113);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(490, 269);
            this.dgvProd.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Código do produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Categoria do produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, -4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 48);
            this.label4.TabIndex = 26;
            this.label4.Text = "California ";
            // 
            // ValProd
            // 
            this.ValProd.Location = new System.Drawing.Point(32, 232);
            this.ValProd.Name = "ValProd";
            this.ValProd.Size = new System.Drawing.Size(59, 20);
            this.ValProd.TabIndex = 25;
            // 
            // CatProd
            // 
            this.CatProd.Location = new System.Drawing.Point(35, 147);
            this.CatProd.Name = "CatProd";
            this.CatProd.Size = new System.Drawing.Size(144, 20);
            this.CatProd.TabIndex = 24;
            // 
            // CodProd
            // 
            this.CodProd.Location = new System.Drawing.Point(35, 190);
            this.CodProd.Name = "CodProd";
            this.CodProd.Size = new System.Drawing.Size(106, 20);
            this.CodProd.TabIndex = 23;
            // 
            // QuantProd
            // 
            this.QuantProd.Location = new System.Drawing.Point(32, 336);
            this.QuantProd.Name = "QuantProd";
            this.QuantProd.Size = new System.Drawing.Size(100, 20);
            this.QuantProd.TabIndex = 21;
            // 
            // NomeProd
            // 
            this.NomeProd.Location = new System.Drawing.Point(32, 279);
            this.NomeProd.Name = "NomeProd";
            this.NomeProd.Size = new System.Drawing.Size(174, 20);
            this.NomeProd.TabIndex = 20;
            // 
            // lklVoltar
            // 
            this.lklVoltar.AutoSize = true;
            this.lklVoltar.Location = new System.Drawing.Point(682, 31);
            this.lklVoltar.Name = "lklVoltar";
            this.lklVoltar.Size = new System.Drawing.Size(78, 13);
            this.lklVoltar.TabIndex = 37;
            this.lklVoltar.TabStop = true;
            this.lklVoltar.Text = "Voltar ao menu";
            this.lklVoltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklVoltar_LinkClicked);
            // 
            // telaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lklVoltar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AddProd);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ValProd);
            this.Controls.Add(this.CatProd);
            this.Controls.Add(this.CodProd);
            this.Controls.Add(this.QuantProd);
            this.Controls.Add(this.NomeProd);
            this.Name = "telaEstoque";
            this.Text = "telaEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddProd;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ValProd;
        private System.Windows.Forms.TextBox CatProd;
        private System.Windows.Forms.TextBox CodProd;
        private System.Windows.Forms.TextBox QuantProd;
        private System.Windows.Forms.TextBox NomeProd;
        private System.Windows.Forms.LinkLabel lklVoltar;
    }
}