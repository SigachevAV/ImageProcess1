
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
            this.бинаризацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фаилToolStripMenuItem
            // 
            this.фаилToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.фаилToolStripMenuItem.Name = "фаилToolStripMenuItem";
            this.фаилToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.фаилToolStripMenuItem.Text = "Фаил";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
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
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // серыйToolStripMenuItem
            // 
            this.серыйToolStripMenuItem.Name = "серыйToolStripMenuItem";
            this.серыйToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.серыйToolStripMenuItem.Text = "Серый";
            this.серыйToolStripMenuItem.Click += new System.EventHandler(this.серыйToolStripMenuItem_Click);
            // 
            // блюрToolStripMenuItem
            // 
            this.блюрToolStripMenuItem.Name = "блюрToolStripMenuItem";
            this.блюрToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.блюрToolStripMenuItem.Text = "Блюр";
            this.блюрToolStripMenuItem.Click += new System.EventHandler(this.блюрToolStripMenuItem_Click);
            // 
            // растягиваниеГистограмыToolStripMenuItem
            // 
            this.растягиваниеГистограмыToolStripMenuItem.Name = "растягиваниеГистограмыToolStripMenuItem";
            this.растягиваниеГистограмыToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
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
            this.бинаризацияToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.бинаризацияToolStripMenuItem.Text = "Бинаризация";
            // 
            // пороговаяToolStripMenuItem
            // 
            this.пороговаяToolStripMenuItem.Name = "пороговаяToolStripMenuItem";
            this.пороговаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пороговаяToolStripMenuItem.Text = "пороговая";
            this.пороговаяToolStripMenuItem.Click += new System.EventHandler(this.пороговаяToolStripMenuItem_Click);
            // 
            // ниблэкToolStripMenuItem
            // 
            this.ниблэкToolStripMenuItem.Name = "ниблэкToolStripMenuItem";
            this.ниблэкToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ниблэкToolStripMenuItem.Text = "Ниблэк";
            this.ниблэкToolStripMenuItem.Click += new System.EventHandler(this.ниблэкToolStripMenuItem_Click);
            // 
            // гистограмнаяToolStripMenuItem
            // 
            this.гистограмнаяToolStripMenuItem.Name = "гистограмнаяToolStripMenuItem";
            this.гистограмнаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.гистограмнаяToolStripMenuItem.Text = "Гистограмная";
            this.гистограмнаяToolStripMenuItem.Click += new System.EventHandler(this.гистограмнаяToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}

