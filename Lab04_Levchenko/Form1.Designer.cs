namespace Lab04_Levchenko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_fileOUT = new System.Windows.Forms.Button();
            this.button_fileIN = new System.Windows.Forms.Button();
            this.textBox_fileOUT = new System.Windows.Forms.TextBox();
            this.textBox_fileIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_KEYgenerator = new System.Windows.Forms.Button();
            this.textBox_fileKEY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_fileKEYsave = new System.Windows.Forms.Button();
            this.button_fileKEYopen = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.labelsize = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_fileOUT);
            this.groupBox1.Controls.Add(this.button_fileIN);
            this.groupBox1.Controls.Add(this.textBox_fileOUT);
            this.groupBox1.Controls.Add(this.textBox_fileIN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файли";
            // 
            // button_fileOUT
            // 
            this.button_fileOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button_fileOUT.Location = new System.Drawing.Point(551, 56);
            this.button_fileOUT.Name = "button_fileOUT";
            this.button_fileOUT.Size = new System.Drawing.Size(32, 23);
            this.button_fileOUT.TabIndex = 5;
            this.button_fileOUT.Text = "...";
            this.button_fileOUT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_fileOUT.UseVisualStyleBackColor = true;
            this.button_fileOUT.Click += new System.EventHandler(this.button_fileOUT_Click);
            // 
            // button_fileIN
            // 
            this.button_fileIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button_fileIN.Location = new System.Drawing.Point(551, 28);
            this.button_fileIN.Name = "button_fileIN";
            this.button_fileIN.Size = new System.Drawing.Size(32, 23);
            this.button_fileIN.TabIndex = 4;
            this.button_fileIN.Text = "...";
            this.button_fileIN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_fileIN.UseVisualStyleBackColor = true;
            this.button_fileIN.Click += new System.EventHandler(this.button_fileIN_Click);
            // 
            // textBox_fileOUT
            // 
            this.textBox_fileOUT.Location = new System.Drawing.Point(135, 56);
            this.textBox_fileOUT.Name = "textBox_fileOUT";
            this.textBox_fileOUT.Size = new System.Drawing.Size(410, 22);
            this.textBox_fileOUT.TabIndex = 3;
            // 
            // textBox_fileIN
            // 
            this.textBox_fileIN.Location = new System.Drawing.Point(135, 28);
            this.textBox_fileIN.Name = "textBox_fileIN";
            this.textBox_fileIN.Size = new System.Drawing.Size(410, 22);
            this.textBox_fileIN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зберегти у файл:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Відкрити файл:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelsize);
            this.groupBox2.Controls.Add(this.button_KEYgenerator);
            this.groupBox2.Controls.Add(this.textBox_fileKEY);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button_fileKEYsave);
            this.groupBox2.Controls.Add(this.button_fileKEYopen);
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // button_KEYgenerator
            // 
            this.button_KEYgenerator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_KEYgenerator.BackgroundImage")));
            this.button_KEYgenerator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_KEYgenerator.Location = new System.Drawing.Point(289, 50);
            this.button_KEYgenerator.Name = "button_KEYgenerator";
            this.button_KEYgenerator.Size = new System.Drawing.Size(65, 39);
            this.button_KEYgenerator.TabIndex = 4;
            this.button_KEYgenerator.UseVisualStyleBackColor = true;
            this.button_KEYgenerator.Click += new System.EventHandler(this.button_KEYgenerator_Click);
            // 
            // textBox_fileKEY
            // 
            this.textBox_fileKEY.Location = new System.Drawing.Point(135, 22);
            this.textBox_fileKEY.Name = "textBox_fileKEY";
            this.textBox_fileKEY.Size = new System.Drawing.Size(367, 22);
            this.textBox_fileKEY.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Файл з ключем:";
            // 
            // button_fileKEYsave
            // 
            this.button_fileKEYsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_fileKEYsave.BackgroundImage")));
            this.button_fileKEYsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_fileKEYsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button_fileKEYsave.Location = new System.Drawing.Point(554, 22);
            this.button_fileKEYsave.Name = "button_fileKEYsave";
            this.button_fileKEYsave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_fileKEYsave.Size = new System.Drawing.Size(44, 43);
            this.button_fileKEYsave.TabIndex = 1;
            this.button_fileKEYsave.UseVisualStyleBackColor = true;
            this.button_fileKEYsave.Click += new System.EventHandler(this.button_fileKEYsave_Click);
            // 
            // button_fileKEYopen
            // 
            this.button_fileKEYopen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_fileKEYopen.BackgroundImage")));
            this.button_fileKEYopen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_fileKEYopen.Location = new System.Drawing.Point(508, 21);
            this.button_fileKEYopen.Name = "button_fileKEYopen";
            this.button_fileKEYopen.Size = new System.Drawing.Size(44, 43);
            this.button_fileKEYopen.TabIndex = 0;
            this.button_fileKEYopen.UseVisualStyleBackColor = true;
            this.button_fileKEYopen.Click += new System.EventHandler(this.button_fileKEYopen_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(520, 251);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(90, 26);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.Location = new System.Drawing.Point(29, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тривалість шифрування (хв:сек.мс):";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label_time.Location = new System.Drawing.Point(280, 251);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(72, 17);
            this.label_time.TabIndex = 4;
            this.label_time.Text = "00:00.000";
            // 
            // labelsize
            // 
            this.labelsize.AutoSize = true;
            this.labelsize.Location = new System.Drawing.Point(35, 50);
            this.labelsize.Name = "labelsize";
            this.labelsize.Size = new System.Drawing.Size(0, 16);
            this.labelsize.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_fileOUT;
        private System.Windows.Forms.Button button_fileIN;
        private System.Windows.Forms.TextBox textBox_fileOUT;
        private System.Windows.Forms.TextBox textBox_fileIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_KEYgenerator;
        private System.Windows.Forms.TextBox textBox_fileKEY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_fileKEYsave;
        private System.Windows.Forms.Button button_fileKEYopen;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label labelsize;
    }
}

