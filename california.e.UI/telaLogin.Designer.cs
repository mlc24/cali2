
namespace california.e.UI
{
    partial class telaLogin
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
            this.CadFun = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.EnterUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogPwd = new System.Windows.Forms.TextBox();
            this.LogUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CadFun
            // 
            this.CadFun.AutoSize = true;
            this.CadFun.Location = new System.Drawing.Point(417, 401);
            this.CadFun.Name = "CadFun";
            this.CadFun.Size = new System.Drawing.Size(66, 13);
            this.CadFun.TabIndex = 15;
            this.CadFun.TabStop = true;
            this.CadFun.Text = "Cadastre-se!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 48);
            this.label4.TabIndex = 14;
            this.label4.Text = "California ";
            // 
            // EnterUser
            // 
            this.EnterUser.Location = new System.Drawing.Point(340, 334);
            this.EnterUser.Name = "EnterUser";
            this.EnterUser.Size = new System.Drawing.Size(121, 37);
            this.EnterUser.TabIndex = 13;
            this.EnterUser.Text = "Entrar";
            this.EnterUser.UseVisualStyleBackColor = true;
            this.EnterUser.Click += new System.EventHandler(this.EnterUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login";
            // 
            // LogPwd
            // 
            this.LogPwd.Location = new System.Drawing.Point(308, 256);
            this.LogPwd.Name = "LogPwd";
            this.LogPwd.Size = new System.Drawing.Size(193, 20);
            this.LogPwd.TabIndex = 9;
            // 
            // LogUser
            // 
            this.LogUser.Location = new System.Drawing.Point(308, 180);
            this.LogUser.Name = "LogUser";
            this.LogUser.Size = new System.Drawing.Size(193, 20);
            this.LogUser.TabIndex = 8;
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CadFun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnterUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogPwd);
            this.Controls.Add(this.LogUser);
            this.Name = "telaLogin";
            this.Text = "telaLogin";
            this.Load += new System.EventHandler(this.telaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel CadFun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EnterUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LogPwd;
        private System.Windows.Forms.TextBox LogUser;
    }
}