namespace kursa4
{
    partial class mainlist
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainlist));
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sebox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowObr = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.insertbutton = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonDeleteObr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(467, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 20);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск по:";
            // 
            // searchbox
            // 
            this.searchbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbox.Location = new System.Drawing.Point(12, 49);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(449, 20);
            this.searchbox.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Year",
            "Country",
            "Firm",
            "Model",
            "Form",
            "Material",
            "Num"});
            this.listBox1.Location = new System.Drawing.Point(75, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 30);
            this.listBox1.TabIndex = 3;
            // 
            // sebox
            // 
            this.sebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sebox.FormattingEnabled = true;
            this.sebox.Location = new System.Drawing.Point(12, 102);
            this.sebox.Name = "sebox";
            this.sebox.Size = new System.Drawing.Size(560, 212);
            this.sebox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Результаты";
            // 
            // buttonShowObr
            // 
            this.buttonShowObr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShowObr.Location = new System.Drawing.Point(12, 332);
            this.buttonShowObr.Name = "buttonShowObr";
            this.buttonShowObr.Size = new System.Drawing.Size(75, 23);
            this.buttonShowObr.TabIndex = 6;
            this.buttonShowObr.Text = "Показать";
            this.buttonShowObr.UseVisualStyleBackColor = true;
            this.buttonShowObr.Click += new System.EventHandler(this.buttonShowObr_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(497, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Настройки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // insertbutton
            // 
            this.insertbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.insertbutton.Location = new System.Drawing.Point(202, 332);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(103, 23);
            this.insertbutton.TabIndex = 8;
            this.insertbutton.Text = "Внести образец";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowAll.Location = new System.Drawing.Point(467, 20);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(105, 23);
            this.buttonShowAll.TabIndex = 9;
            this.buttonShowAll.Text = "Показать все";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonDeleteObr
            // 
            this.buttonDeleteObr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteObr.Location = new System.Drawing.Point(93, 332);
            this.buttonDeleteObr.Name = "buttonDeleteObr";
            this.buttonDeleteObr.Size = new System.Drawing.Size(103, 23);
            this.buttonDeleteObr.TabIndex = 10;
            this.buttonDeleteObr.Text = "Удалить образец";
            this.buttonDeleteObr.UseVisualStyleBackColor = true;
            this.buttonDeleteObr.Click += new System.EventHandler(this.buttonDeleteObr_Click);
            // 
            // mainlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 365);
            this.Controls.Add(this.buttonDeleteObr);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonShowObr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sebox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "mainlist";
            this.Text = "GUItarDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox sebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonShowObr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonDeleteObr;
    }
}

