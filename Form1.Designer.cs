namespace CG
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.растяжениеГистограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйМирToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.идеальныйОтражательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волна30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волна60ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрГауссаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матМорфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.фильтрРезкостиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сдвигToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйФильтрToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.topHatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blackHatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gradToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить ";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.растяжениеГистограммыToolStripMenuItem,
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.матМорфологияToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            this.фильтрыToolStripMenuItem.Click += new System.EventHandler(this.ФильтрыToolStripMenuItem_Click);
            // 
            // растяжениеГистограммыToolStripMenuItem
            // 
            this.растяжениеГистограммыToolStripMenuItem.Name = "растяжениеГистограммыToolStripMenuItem";
            this.растяжениеГистограммыToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.растяжениеГистограммыToolStripMenuItem.Text = "Растяжение гистограммы";
            this.растяжениеГистограммыToolStripMenuItem.Click += new System.EventHandler(this.РастяжениеГистограммыToolStripMenuItem_Click);
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.серыйМирToolStripMenuItem2,
            this.идеальныйОтражательToolStripMenuItem,
            this.волна30ToolStripMenuItem,
            this.волна60ToolStripMenuItem1,
            this.сдвигToolStripMenuItem1});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.ИнверсияToolStripMenuItem_Click_1);
            // 
            // серыйМирToolStripMenuItem2
            // 
            this.серыйМирToolStripMenuItem2.Name = "серыйМирToolStripMenuItem2";
            this.серыйМирToolStripMenuItem2.Size = new System.Drawing.Size(257, 26);
            this.серыйМирToolStripMenuItem2.Text = "Серый мир";
            this.серыйМирToolStripMenuItem2.Click += new System.EventHandler(this.СерыйМирToolStripMenuItem2_Click);
            // 
            // идеальныйОтражательToolStripMenuItem
            // 
            this.идеальныйОтражательToolStripMenuItem.Name = "идеальныйОтражательToolStripMenuItem";
            this.идеальныйОтражательToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.идеальныйОтражательToolStripMenuItem.Text = "Идеальный отражатель";
            this.идеальныйОтражательToolStripMenuItem.Click += new System.EventHandler(this.ИдеальныйОтражательToolStripMenuItem_Click_1);
            // 
            // волна30ToolStripMenuItem
            // 
            this.волна30ToolStripMenuItem.Name = "волна30ToolStripMenuItem";
            this.волна30ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.волна30ToolStripMenuItem.Text = "Волна 30";
            this.волна30ToolStripMenuItem.Click += new System.EventHandler(this.Волна30ToolStripMenuItem_Click_1);
            // 
            // волна60ToolStripMenuItem1
            // 
            this.волна60ToolStripMenuItem1.Name = "волна60ToolStripMenuItem1";
            this.волна60ToolStripMenuItem1.Size = new System.Drawing.Size(257, 26);
            this.волна60ToolStripMenuItem1.Text = "Волна 60";
            this.волна60ToolStripMenuItem1.Click += new System.EventHandler(this.Волна60ToolStripMenuItem1_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фильтрГауссаToolStripMenuItem1,
            this.размытиеToolStripMenuItem,
            this.фильтрРезкостиToolStripMenuItem1,
            this.медианныйФильтрToolStripMenuItem1});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // фильтрГауссаToolStripMenuItem1
            // 
            this.фильтрГауссаToolStripMenuItem1.Name = "фильтрГауссаToolStripMenuItem1";
            this.фильтрГауссаToolStripMenuItem1.Size = new System.Drawing.Size(191, 26);
            this.фильтрГауссаToolStripMenuItem1.Text = "Фильтр Гаусса";
            this.фильтрГауссаToolStripMenuItem1.Click += new System.EventHandler(this.ФильтрГауссаToolStripMenuItem1_Click);
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.РазмытиеToolStripMenuItem_Click);
            // 
            // матМорфологияToolStripMenuItem
            // 
            this.матМорфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topHatToolStripMenuItem1,
            this.blackHatToolStripMenuItem1,
            this.gradToolStripMenuItem1,
            this.closingToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.maxCountToolStripMenuItem});
            this.матМорфологияToolStripMenuItem.Name = "матМорфологияToolStripMenuItem";
            this.матМорфологияToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.матМорфологияToolStripMenuItem.Text = "Мат морфология";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 434);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(799, 24);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // фильтрРезкостиToolStripMenuItem1
            // 
            this.фильтрРезкостиToolStripMenuItem1.Name = "фильтрРезкостиToolStripMenuItem1";
            this.фильтрРезкостиToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.фильтрРезкостиToolStripMenuItem1.Text = "Фильтр резкости";
            this.фильтрРезкостиToolStripMenuItem1.Click += new System.EventHandler(this.ФильтрРезкостиToolStripMenuItem1_Click);
            // 
            // сдвигToolStripMenuItem1
            // 
            this.сдвигToolStripMenuItem1.Name = "сдвигToolStripMenuItem1";
            this.сдвигToolStripMenuItem1.Size = new System.Drawing.Size(257, 26);
            this.сдвигToolStripMenuItem1.Text = "Сдвиг";
            this.сдвигToolStripMenuItem1.Click += new System.EventHandler(this.СдвигToolStripMenuItem1_Click);
            // 
            // медианныйФильтрToolStripMenuItem1
            // 
            this.медианныйФильтрToolStripMenuItem1.Name = "медианныйФильтрToolStripMenuItem1";
            this.медианныйФильтрToolStripMenuItem1.Size = new System.Drawing.Size(230, 26);
            this.медианныйФильтрToolStripMenuItem1.Text = "Медианный фильтр";
            this.медианныйФильтрToolStripMenuItem1.Click += new System.EventHandler(this.МедианныйФильтрToolStripMenuItem1_Click);
            // 
            // topHatToolStripMenuItem1
            // 
            this.topHatToolStripMenuItem1.Name = "topHatToolStripMenuItem1";
            this.topHatToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.topHatToolStripMenuItem1.Text = "Top Hat";
            this.topHatToolStripMenuItem1.Click += new System.EventHandler(this.TopHatToolStripMenuItem1_Click);
            // 
            // blackHatToolStripMenuItem1
            // 
            this.blackHatToolStripMenuItem1.Name = "blackHatToolStripMenuItem1";
            this.blackHatToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.blackHatToolStripMenuItem1.Text = "Black Hat";
            this.blackHatToolStripMenuItem1.Click += new System.EventHandler(this.BlackHatToolStripMenuItem1_Click);
            // 
            // gradToolStripMenuItem1
            // 
            this.gradToolStripMenuItem1.Name = "gradToolStripMenuItem1";
            this.gradToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.gradToolStripMenuItem1.Text = "Grad";
            this.gradToolStripMenuItem1.Click += new System.EventHandler(this.GradToolStripMenuItem1_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.ClosingToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.OpeningToolStripMenuItem_Click);
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dilationToolStripMenuItem.Text = "Dilation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.DilationToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.ErosionToolStripMenuItem_Click);
            // 
            // maxCountToolStripMenuItem
            // 
            this.maxCountToolStripMenuItem.Name = "maxCountToolStripMenuItem";
            this.maxCountToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.maxCountToolStripMenuItem.Text = "MaxCount";
            this.maxCountToolStripMenuItem.Click += new System.EventHandler(this.MaxCountToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem растяжениеГистограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серыйМирToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem идеальныйОтражательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрГауссаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem матМорфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волна30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волна60ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фильтрРезкостиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сдвигToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem медианныйФильтрToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem topHatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem blackHatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gradToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxCountToolStripMenuItem;
    }
}

