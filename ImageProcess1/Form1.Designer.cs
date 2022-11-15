
namespace ImageProcess1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фаилToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блюрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.растягиваниеГистограмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бинаризацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пороговаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ниблэкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гистограмнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.шумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.равномерныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гаммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.снятиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гаусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.билатеральныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фаилToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.бинаризацияToolStripMenuItem,
            this.шумToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // фаилToolStripMenuItem
            // 
            this.фаилToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.фаилToolStripMenuItem.Name = "фаилToolStripMenuItem";
            this.фаилToolStripMenuItem.Size = new System.Drawing.Size(80, 34);
            this.фаилToolStripMenuItem.Text = "Фаил";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(233, 40);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(233, 40);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.серыйToolStripMenuItem,
            this.блюрToolStripMenuItem,
            this.растягиваниеГистограмыToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(116, 34);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // серыйToolStripMenuItem
            // 
            this.серыйToolStripMenuItem.Name = "серыйToolStripMenuItem";
            this.серыйToolStripMenuItem.Size = new System.Drawing.Size(379, 40);
            this.серыйToolStripMenuItem.Text = "Серый";
            this.серыйToolStripMenuItem.Click += new System.EventHandler(this.серыйToolStripMenuItem_Click);
            // 
            // блюрToolStripMenuItem
            // 
            this.блюрToolStripMenuItem.Name = "блюрToolStripMenuItem";
            this.блюрToolStripMenuItem.Size = new System.Drawing.Size(379, 40);
            this.блюрToolStripMenuItem.Text = "Блюр";
            this.блюрToolStripMenuItem.Click += new System.EventHandler(this.блюрToolStripMenuItem_Click);
            // 
            // растягиваниеГистограмыToolStripMenuItem
            // 
            this.растягиваниеГистограмыToolStripMenuItem.Name = "растягиваниеГистограмыToolStripMenuItem";
            this.растягиваниеГистограмыToolStripMenuItem.Size = new System.Drawing.Size(379, 40);
            this.растягиваниеГистограмыToolStripMenuItem.Text = "Растягивание гистограмы";
            this.растягиваниеГистограмыToolStripMenuItem.Click += new System.EventHandler(this.растягиваниеГистограмыToolStripMenuItem_Click);
            // 
            // бинаризацияToolStripMenuItem
            // 
            this.бинаризацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пороговаяToolStripMenuItem,
            this.ниблэкToolStripMenuItem,
            this.гистограмнаяToolStripMenuItem});
            this.бинаризацияToolStripMenuItem.Name = "бинаризацияToolStripMenuItem";
            this.бинаризацияToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.бинаризацияToolStripMenuItem.Text = "Бинаризация";
            // 
            // пороговаяToolStripMenuItem
            // 
            this.пороговаяToolStripMenuItem.Name = "пороговаяToolStripMenuItem";
            this.пороговаяToolStripMenuItem.Size = new System.Drawing.Size(264, 40);
            this.пороговаяToolStripMenuItem.Text = "пороговая";
            this.пороговаяToolStripMenuItem.Click += new System.EventHandler(this.пороговаяToolStripMenuItem_Click);
            // 
            // ниблэкToolStripMenuItem
            // 
            this.ниблэкToolStripMenuItem.Name = "ниблэкToolStripMenuItem";
            this.ниблэкToolStripMenuItem.Size = new System.Drawing.Size(264, 40);
            this.ниблэкToolStripMenuItem.Text = "Ниблэк";
            this.ниблэкToolStripMenuItem.Click += new System.EventHandler(this.ниблэкToolStripMenuItem_Click);
            // 
            // гистограмнаяToolStripMenuItem
            // 
            this.гистограмнаяToolStripMenuItem.Name = "гистограмнаяToolStripMenuItem";
            this.гистограмнаяToolStripMenuItem.Size = new System.Drawing.Size(264, 40);
            this.гистограмнаяToolStripMenuItem.Text = "Гистограмная";
            this.гистограмнаяToolStripMenuItem.Click += new System.EventHandler(this.гистограмнаяToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1164, 610);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // шумToolStripMenuItem
            // 
            this.шумToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.снятиеToolStripMenuItem});
            this.шумToolStripMenuItem.Name = "шумToolStripMenuItem";
            this.шумToolStripMenuItem.Size = new System.Drawing.Size(76, 34);
            this.шумToolStripMenuItem.Text = "Шум";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.равномерныйToolStripMenuItem,
            this.гаммаToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // равномерныйToolStripMenuItem
            // 
            this.равномерныйToolStripMenuItem.Name = "равномерныйToolStripMenuItem";
            this.равномерныйToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.равномерныйToolStripMenuItem.Text = "Равномерный";
            this.равномерныйToolStripMenuItem.Click += new System.EventHandler(this.равномерныйToolStripMenuItem_Click);
            // 
            // гаммаToolStripMenuItem
            // 
            this.гаммаToolStripMenuItem.Name = "гаммаToolStripMenuItem";
            this.гаммаToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.гаммаToolStripMenuItem.Text = "Гамма";
            // 
            // снятиеToolStripMenuItem
            // 
            this.снятиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гаусаToolStripMenuItem,
            this.билатеральныйToolStripMenuItem});
            this.снятиеToolStripMenuItem.Name = "снятиеToolStripMenuItem";
            this.снятиеToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.снятиеToolStripMenuItem.Text = "Снятие";
            // 
            // гаусаToolStripMenuItem
            // 
            this.гаусаToolStripMenuItem.Name = "гаусаToolStripMenuItem";
            this.гаусаToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.гаусаToolStripMenuItem.Text = "Гауса";
            // 
            // билатеральныйToolStripMenuItem
            // 
            this.билатеральныйToolStripMenuItem.Name = "билатеральныйToolStripMenuItem";
            this.билатеральныйToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.билатеральныйToolStripMenuItem.Text = "Билатеральный";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 676);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фаилToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem блюрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem растягиваниеГистограмыToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бинаризацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пороговаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ниблэкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гистограмнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шумToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem равномерныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гаммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem снятиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гаусаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem билатеральныйToolStripMenuItem;
    }
}

