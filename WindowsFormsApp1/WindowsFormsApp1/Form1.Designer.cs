﻿namespace WindowsFormsApp1
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
            this.pictureBoxTest = new System.Windows.Forms.PictureBox();
            this.labelTest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTest
            // 
            this.pictureBoxTest.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxTest.Name = "pictureBoxTest";
            this.pictureBoxTest.Size = new System.Drawing.Size(136, 108);
            this.pictureBoxTest.TabIndex = 0;
            this.pictureBoxTest.TabStop = false;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(13, 128);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(35, 13);
            this.labelTest.TabIndex = 1;
            this.labelTest.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.pictureBoxTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTest;
        private System.Windows.Forms.Label labelTest;
    }
}
