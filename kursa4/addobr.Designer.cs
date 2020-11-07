namespace kursa4
{
    partial class addobr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addobr));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxFirm = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxForm = new System.Windows.Forms.TextBox();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelFirm = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelForm = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.addObj = new System.Windows.Forms.Button();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выбрать файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.choosefile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ИЛИ";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(273, 36);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(144, 20);
            this.textBoxModel.TabIndex = 3;
            // 
            // textBoxFirm
            // 
            this.textBoxFirm.Location = new System.Drawing.Point(273, 62);
            this.textBoxFirm.Name = "textBoxFirm";
            this.textBoxFirm.Size = new System.Drawing.Size(144, 20);
            this.textBoxFirm.TabIndex = 4;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(273, 88);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(144, 20);
            this.textBoxYear.TabIndex = 5;
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYear_KeyPress);
            // 
            // textBoxForm
            // 
            this.textBoxForm.Location = new System.Drawing.Point(273, 140);
            this.textBoxForm.Name = "textBoxForm";
            this.textBoxForm.Size = new System.Drawing.Size(144, 20);
            this.textBoxForm.TabIndex = 6;
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(273, 166);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(144, 20);
            this.textBoxMaterial.TabIndex = 7;
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(273, 192);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(144, 20);
            this.textBoxNum.TabIndex = 8;
            this.textBoxNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNum_KeyPress);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(168, 39);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(46, 13);
            this.labelModel.TabIndex = 9;
            this.labelModel.Text = "Модель";
            // 
            // labelFirm
            // 
            this.labelFirm.AutoSize = true;
            this.labelFirm.Location = new System.Drawing.Point(168, 65);
            this.labelFirm.Name = "labelFirm";
            this.labelFirm.Size = new System.Drawing.Size(44, 13);
            this.labelFirm.TabIndex = 10;
            this.labelFirm.Text = "Фирма";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(168, 91);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(25, 13);
            this.labelYear.TabIndex = 11;
            this.labelYear.Text = "Год";
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Location = new System.Drawing.Point(168, 143);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(44, 13);
            this.labelForm.TabIndex = 12;
            this.labelForm.Text = "Форма";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(168, 169);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(57, 13);
            this.labelMaterial.TabIndex = 13;
            this.labelMaterial.Text = "Материал";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(168, 195);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(97, 13);
            this.labelNum.TabIndex = 14;
            this.labelNum.Text = "Количество струн";
            // 
            // addObj
            // 
            this.addObj.Location = new System.Drawing.Point(273, 232);
            this.addObj.Name = "addObj";
            this.addObj.Size = new System.Drawing.Size(144, 23);
            this.addObj.TabIndex = 15;
            this.addObj.Text = "Добавить запись";
            this.addObj.UseVisualStyleBackColor = true;
            this.addObj.Click += new System.EventHandler(this.addObj_Click);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(273, 114);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(144, 20);
            this.textBoxCountry.TabIndex = 16;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(168, 117);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 17;
            this.labelCountry.Text = "Страна";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kursa4.Properties.Resources.Без_имени_1;
            this.pictureBox1.Location = new System.Drawing.Point(30, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // addobr
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 270);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.addObj);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelForm);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelFirm);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.textBoxForm);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxFirm);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(460, 305);
            this.MinimumSize = new System.Drawing.Size(460, 305);
            this.Name = "addobr";
            this.Text = "GUItarDB";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxFirm;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxForm;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelFirm;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Button addObj;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label label2;
    }
}