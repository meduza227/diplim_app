
namespace diplim_app
{
    partial class autoriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autoriz));
            this.label6 = new System.Windows.Forms.Label();
            this.passw = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAvtoriz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Informal Roman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(89, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 59);
            this.label6.TabIndex = 11;
            this.label6.Text = "Welcome";
            // 
            // passw
            // 
            this.passw.Location = new System.Drawing.Point(94, 206);
            this.passw.Name = "passw";
            this.passw.Size = new System.Drawing.Size(197, 23);
            this.passw.TabIndex = 13;
            this.passw.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(94, 122);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(197, 23);
            this.login.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "пароль";
            // 
            // buttonAvtoriz
            // 
            this.buttonAvtoriz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAvtoriz.Location = new System.Drawing.Point(115, 266);
            this.buttonAvtoriz.Name = "buttonAvtoriz";
            this.buttonAvtoriz.Size = new System.Drawing.Size(155, 31);
            this.buttonAvtoriz.TabIndex = 17;
            this.buttonAvtoriz.Text = "Вход";
            this.buttonAvtoriz.UseVisualStyleBackColor = true;
            this.buttonAvtoriz.Click += new System.EventHandler(this.buttonAvtoriz_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.buttonAvtoriz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passw);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passw;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAvtoriz;
    }
}