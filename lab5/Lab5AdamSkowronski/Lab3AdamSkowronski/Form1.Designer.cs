namespace Lab3AdamSkowronski
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonViewGrades = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adam Skowronski";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(831, 380);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonViewGrades
            // 
            this.buttonViewGrades.Location = new System.Drawing.Point(898, 9);
            this.buttonViewGrades.Name = "buttonViewGrades";
            this.buttonViewGrades.Size = new System.Drawing.Size(175, 105);
            this.buttonViewGrades.TabIndex = 2;
            this.buttonViewGrades.Text = "pokaz";
            this.buttonViewGrades.UseVisualStyleBackColor = true;
            this.buttonViewGrades.Click += new System.EventHandler(this.ButtonViewGrades_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(950, 243);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 26);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(946, 344);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(100, 26);
            this.textBoxCourse.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(946, 208);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(141, 20);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "nazwa wykladowcy";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(946, 305);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(100, 20);
            this.labelCourse.TabIndex = 8;
            this.labelCourse.Text = "Nazwa kursu";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(936, 401);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(151, 63);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Dodaj nowy kurs";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 503);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonViewGrades);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonViewGrades;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Button buttonAdd;
    }
}

