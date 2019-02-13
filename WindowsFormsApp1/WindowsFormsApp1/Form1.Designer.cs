namespace WindowsFormsApp1
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
            this.labelTest = new System.Windows.Forms.Label();
            this.pictureBoxTest = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_addFile = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_button_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_obj2_end = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_obj2_start = new System.Windows.Forms.NumericUpDown();
            this.comboBox_obj2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_obj1_end = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_obj1_start = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_obj1 = new System.Windows.Forms.ComboBox();
            this.button_in_PicBox = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_obj2_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_obj2_start)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_obj1_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_obj1_start)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(643, 197);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(35, 13);
            this.labelTest.TabIndex = 1;
            this.labelTest.Text = "label1";
            // 
            // pictureBoxTest
            // 
            this.pictureBoxTest.Location = new System.Drawing.Point(643, 82);
            this.pictureBoxTest.Name = "pictureBoxTest";
            this.pictureBoxTest.Size = new System.Drawing.Size(136, 108);
            this.pictureBoxTest.TabIndex = 0;
            this.pictureBoxTest.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_addFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_addFile
            // 
            this.toolStripButton_addFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_addFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_addFile.Image")));
            this.toolStripButton_addFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_addFile.Name = "toolStripButton_addFile";
            this.toolStripButton_addFile.Size = new System.Drawing.Size(95, 22);
            this.toolStripButton_addFile.Text = "Добавить файл";
            this.toolStripButton_addFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_name,
            this.Column_Count,
            this.Column_button_delete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(398, 102);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column_name
            // 
            this.Column_name.Frozen = true;
            this.Column_name.HeaderText = "Название объектов";
            this.Column_name.Name = "Column_name";
            this.Column_name.ReadOnly = true;
            this.Column_name.Width = 200;
            // 
            // Column_Count
            // 
            this.Column_Count.Frozen = true;
            this.Column_Count.HeaderText = "Количество объектов";
            this.Column_Count.Name = "Column_Count";
            this.Column_Count.ReadOnly = true;
            this.Column_Count.Width = 75;
            // 
            // Column_button_delete
            // 
            this.Column_button_delete.Frozen = true;
            this.Column_button_delete.HeaderText = "";
            this.Column_button_delete.Name = "Column_button_delete";
            this.Column_button_delete.ReadOnly = true;
            this.Column_button_delete.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 121);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подключенные файлы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 115);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown_obj2_end);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.numericUpDown_obj2_start);
            this.groupBox4.Controls.Add(this.comboBox_obj2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(198, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 86);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Объект №2";
            // 
            // numericUpDown_obj2_end
            // 
            this.numericUpDown_obj2_end.Location = new System.Drawing.Point(128, 48);
            this.numericUpDown_obj2_end.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_obj2_end.Name = "numericUpDown_obj2_end";
            this.numericUpDown_obj2_end.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_obj2_end.TabIndex = 2;
            this.numericUpDown_obj2_end.Tag = "Obj2";
            this.numericUpDown_obj2_end.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_obj2_end.ValueChanged += new System.EventHandler(this.numericUpDown_obj_end_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "по";
            // 
            // numericUpDown_obj2_start
            // 
            this.numericUpDown_obj2_start.Location = new System.Drawing.Point(25, 48);
            this.numericUpDown_obj2_start.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_obj2_start.Name = "numericUpDown_obj2_start";
            this.numericUpDown_obj2_start.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_obj2_start.TabIndex = 2;
            this.numericUpDown_obj2_start.Tag = "Obj2";
            this.numericUpDown_obj2_start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_obj2_start.ValueChanged += new System.EventHandler(this.numericUpDown_obj_start_ValueChanged);
            // 
            // comboBox_obj2
            // 
            this.comboBox_obj2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_obj2.FormattingEnabled = true;
            this.comboBox_obj2.Location = new System.Drawing.Point(6, 19);
            this.comboBox_obj2.Name = "comboBox_obj2";
            this.comboBox_obj2.Size = new System.Drawing.Size(187, 21);
            this.comboBox_obj2.TabIndex = 0;
            this.comboBox_obj2.Tag = "Obj2";
            this.comboBox_obj2.SelectedIndexChanged += new System.EventHandler(this.comboBox_obj_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "с";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown_obj1_end);
            this.groupBox3.Controls.Add(this.numericUpDown_obj1_start);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBox_obj1);
            this.groupBox3.Location = new System.Drawing.Point(6, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 86);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Объект №1";
            // 
            // numericUpDown_obj1_end
            // 
            this.numericUpDown_obj1_end.Location = new System.Drawing.Point(117, 46);
            this.numericUpDown_obj1_end.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_obj1_end.Name = "numericUpDown_obj1_end";
            this.numericUpDown_obj1_end.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_obj1_end.TabIndex = 2;
            this.numericUpDown_obj1_end.Tag = "Obj1";
            this.numericUpDown_obj1_end.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_obj1_end.ValueChanged += new System.EventHandler(this.numericUpDown_obj_end_ValueChanged);
            // 
            // numericUpDown_obj1_start
            // 
            this.numericUpDown_obj1_start.Location = new System.Drawing.Point(26, 46);
            this.numericUpDown_obj1_start.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_obj1_start.Name = "numericUpDown_obj1_start";
            this.numericUpDown_obj1_start.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_obj1_start.TabIndex = 2;
            this.numericUpDown_obj1_start.Tag = "Obj1";
            this.numericUpDown_obj1_start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_obj1_start.ValueChanged += new System.EventHandler(this.numericUpDown_obj_start_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "с";
            // 
            // comboBox_obj1
            // 
            this.comboBox_obj1.DisplayMember = "(нет)";
            this.comboBox_obj1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_obj1.FormattingEnabled = true;
            this.comboBox_obj1.Location = new System.Drawing.Point(7, 20);
            this.comboBox_obj1.Name = "comboBox_obj1";
            this.comboBox_obj1.Size = new System.Drawing.Size(173, 21);
            this.comboBox_obj1.TabIndex = 0;
            this.comboBox_obj1.Tag = "Obj1";
            this.comboBox_obj1.SelectedIndexChanged += new System.EventHandler(this.comboBox_obj_SelectedIndexChanged);
            // 
            // button_in_PicBox
            // 
            this.button_in_PicBox.Enabled = false;
            this.button_in_PicBox.Location = new System.Drawing.Point(6, 22);
            this.button_in_PicBox.Name = "button_in_PicBox";
            this.button_in_PicBox.Size = new System.Drawing.Size(138, 23);
            this.button_in_PicBox.TabIndex = 6;
            this.button_in_PicBox.Text = "Показать визуально";
            this.button_in_PicBox.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.button_in_PicBox);
            this.groupBox5.Location = new System.Drawing.Point(12, 277);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(401, 59);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Вывод результатов";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Экспорт в Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.pictureBoxTest);
            this.Controls.Add(this.groupBox5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_obj2_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_obj2_start)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_obj1_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_obj1_start)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.PictureBox pictureBoxTest;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_addFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Count;
        private System.Windows.Forms.DataGridViewButtonColumn Column_button_delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox_obj2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox_obj1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_in_PicBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown_obj1_start;
        private System.Windows.Forms.NumericUpDown numericUpDown_obj2_end;
        private System.Windows.Forms.NumericUpDown numericUpDown_obj2_start;
        private System.Windows.Forms.NumericUpDown numericUpDown_obj1_end;
    }
}

