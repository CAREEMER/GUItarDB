namespace kursa4
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.changepwd = new System.Windows.Forms.Label();
            this.changepwdbutton = new System.Windows.Forms.Button();
            this.oldpwd = new System.Windows.Forms.Label();
            this.newpwd = new System.Windows.Forms.Label();
            this.textboxoldpwd = new System.Windows.Forms.TextBox();
            this.textboxnewpwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // changepwd
            // 
            this.changepwd.AutoSize = true;
            this.changepwd.Location = new System.Drawing.Point(22, 9);
            this.changepwd.Name = "changepwd";
            this.changepwd.Size = new System.Drawing.Size(90, 13);
            this.changepwd.TabIndex = 0;
            this.changepwd.Text = "Сменить пароль";
            // 
            // changepwdbutton
            // 
            this.changepwdbutton.Location = new System.Drawing.Point(12, 160);
            this.changepwdbutton.Name = "changepwdbutton";
            this.changepwdbutton.Size = new System.Drawing.Size(110, 23);
            this.changepwdbutton.TabIndex = 1;
            this.changepwdbutton.Text = "Подтвердить";
            this.changepwdbutton.UseMnemonic = false;
            this.changepwdbutton.UseVisualStyleBackColor = true;
            this.changepwdbutton.Click += new System.EventHandler(this.changepwdbutton_Click);
            // 
            // oldpwd
            // 
            this.oldpwd.AutoSize = true;
            this.oldpwd.Location = new System.Drawing.Point(12, 38);
            this.oldpwd.Name = "oldpwd";
            this.oldpwd.Size = new System.Drawing.Size(84, 13);
            this.oldpwd.TabIndex = 2;
            this.oldpwd.Text = "Старый пароль";
            // 
            // newpwd
            // 
            this.newpwd.AutoSize = true;
            this.newpwd.Location = new System.Drawing.Point(12, 103);
            this.newpwd.Name = "newpwd";
            this.newpwd.Size = new System.Drawing.Size(80, 13);
            this.newpwd.TabIndex = 3;
            this.newpwd.Text = "Новый пароль";
            // 
            // textboxoldpwd
            // 
            this.textboxoldpwd.Location = new System.Drawing.Point(15, 54);
            this.textboxoldpwd.Name = "textboxoldpwd";
            this.textboxoldpwd.Size = new System.Drawing.Size(107, 20);
            this.textboxoldpwd.TabIndex = 4;
            // 
            // textboxnewpwd
            // 
            this.textboxnewpwd.Location = new System.Drawing.Point(12, 119);
            this.textboxnewpwd.Name = "textboxnewpwd";
            this.textboxnewpwd.Size = new System.Drawing.Size(110, 20);
            this.textboxnewpwd.TabIndex = 5;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(134, 195);
            this.Controls.Add(this.textboxnewpwd);
            this.Controls.Add(this.textboxoldpwd);
            this.Controls.Add(this.newpwd);
            this.Controls.Add(this.oldpwd);
            this.Controls.Add(this.changepwdbutton);
            this.Controls.Add(this.changepwd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(150, 230);
            this.MinimumSize = new System.Drawing.Size(150, 230);
            this.Name = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label changepwd;
        private System.Windows.Forms.Button changepwdbutton;
        private System.Windows.Forms.Label oldpwd;
        private System.Windows.Forms.Label newpwd;
        private System.Windows.Forms.TextBox textboxoldpwd;
        private System.Windows.Forms.TextBox textboxnewpwd;
    }
}