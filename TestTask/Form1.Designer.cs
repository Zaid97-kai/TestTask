namespace TestTask
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
            this.tbInputData = new System.Windows.Forms.RichTextBox();
            this.tbOutputData = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnGenerate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInputData
            // 
            this.tbInputData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInputData.Location = new System.Drawing.Point(3, 16);
            this.tbInputData.Name = "tbInputData";
            this.tbInputData.Size = new System.Drawing.Size(244, 304);
            this.tbInputData.TabIndex = 1;
            this.tbInputData.Text = "";
            // 
            // tbOutputData
            // 
            this.tbOutputData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOutputData.Location = new System.Drawing.Point(3, 16);
            this.tbOutputData.Name = "tbOutputData";
            this.tbOutputData.ReadOnly = true;
            this.tbOutputData.Size = new System.Drawing.Size(244, 341);
            this.tbOutputData.TabIndex = 2;
            this.tbOutputData.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbInputData);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 323);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные данные";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbOutputData);
            this.groupBox2.Location = new System.Drawing.Point(272, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 360);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выходные данные";
            // 
            // bnGenerate
            // 
            this.bnGenerate.Location = new System.Drawing.Point(12, 338);
            this.bnGenerate.Name = "bnGenerate";
            this.bnGenerate.Size = new System.Drawing.Size(250, 31);
            this.bnGenerate.TabIndex = 5;
            this.bnGenerate.Text = "Решить задачу";
            this.bnGenerate.UseVisualStyleBackColor = true;
            this.bnGenerate.Click += new System.EventHandler(this.bnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 382);
            this.Controls.Add(this.bnGenerate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Основное меню";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbInputData;
        private System.Windows.Forms.RichTextBox tbOutputData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bnGenerate;
    }
}

