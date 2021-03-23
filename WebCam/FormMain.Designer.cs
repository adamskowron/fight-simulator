namespace WindowsFormsApp1
{
    partial class FormMain
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.buttonPhoto = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonContrast = new System.Windows.Forms.Button();
            this.textBoxContrast = new System.Windows.Forms.TextBox();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.buttonBrightness = new System.Windows.Forms.Button();
            this.textBoxBrightness = new System.Windows.Forms.TextBox();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonStartRecording = new System.Windows.Forms.Button();
            this.buttonStopRecording = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(242, 10);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(459, 341);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 2);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(453, 337);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(11, 10);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(225, 39);
            this.comboBox.TabIndex = 2;
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPhoto.Location = new System.Drawing.Point(10, 123);
            this.buttonPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(226, 68);
            this.buttonPhoto.TabIndex = 3;
            this.buttonPhoto.Text = "Photo";
            this.buttonPhoto.UseVisualStyleBackColor = true;
            this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(242, 355);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(453, 336);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(447, 332);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // buttonContrast
            // 
            this.buttonContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonContrast.Location = new System.Drawing.Point(10, 196);
            this.buttonContrast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonContrast.Name = "buttonContrast";
            this.buttonContrast.Size = new System.Drawing.Size(226, 68);
            this.buttonContrast.TabIndex = 5;
            this.buttonContrast.Text = "Enable Contrast";
            this.buttonContrast.UseVisualStyleBackColor = true;
            this.buttonContrast.Click += new System.EventHandler(this.buttonContrast_Click);
            // 
            // textBoxContrast
            // 
            this.textBoxContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxContrast.Location = new System.Drawing.Point(10, 270);
            this.textBoxContrast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContrast.Name = "textBoxContrast";
            this.textBoxContrast.Size = new System.Drawing.Size(226, 26);
            this.textBoxContrast.TabIndex = 6;
            this.textBoxContrast.Text = "Value of contrast here...";
            // 
            // buttonNegative
            // 
            this.buttonNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNegative.Location = new System.Drawing.Point(10, 300);
            this.buttonNegative.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(226, 68);
            this.buttonNegative.TabIndex = 7;
            this.buttonNegative.Text = "Enable Negative";
            this.buttonNegative.UseVisualStyleBackColor = true;
            this.buttonNegative.Click += new System.EventHandler(this.buttonNegative_Click);
            // 
            // buttonBrightness
            // 
            this.buttonBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBrightness.Location = new System.Drawing.Point(10, 373);
            this.buttonBrightness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBrightness.Name = "buttonBrightness";
            this.buttonBrightness.Size = new System.Drawing.Size(226, 68);
            this.buttonBrightness.TabIndex = 8;
            this.buttonBrightness.Text = "Brightness";
            this.buttonBrightness.UseVisualStyleBackColor = true;
            this.buttonBrightness.Click += new System.EventHandler(this.buttonBrightness_Click);
            // 
            // textBoxBrightness
            // 
            this.textBoxBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBrightness.Location = new System.Drawing.Point(10, 446);
            this.textBoxBrightness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBrightness.Name = "textBoxBrightness";
            this.textBoxBrightness.Size = new System.Drawing.Size(226, 26);
            this.textBoxBrightness.TabIndex = 9;
            this.textBoxBrightness.Text = "Value of brightness here...";
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveToFile.Location = new System.Drawing.Point(10, 474);
            this.buttonSaveToFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(226, 68);
            this.buttonSaveToFile.TabIndex = 10;
            this.buttonSaveToFile.Text = "Save to file";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonStartRecording
            // 
            this.buttonStartRecording.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStartRecording.Location = new System.Drawing.Point(10, 547);
            this.buttonStartRecording.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStartRecording.Name = "buttonStartRecording";
            this.buttonStartRecording.Size = new System.Drawing.Size(226, 68);
            this.buttonStartRecording.TabIndex = 11;
            this.buttonStartRecording.Text = "Start Recording";
            this.buttonStartRecording.UseVisualStyleBackColor = true;
            this.buttonStartRecording.Click += new System.EventHandler(this.buttonStartRecording_Click);
            // 
            // buttonStopRecording
            // 
            this.buttonStopRecording.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStopRecording.Location = new System.Drawing.Point(10, 620);
            this.buttonStopRecording.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStopRecording.Name = "buttonStopRecording";
            this.buttonStopRecording.Size = new System.Drawing.Size(226, 68);
            this.buttonStopRecording.TabIndex = 12;
            this.buttonStopRecording.Text = "Stop Recording";
            this.buttonStopRecording.UseVisualStyleBackColor = true;
            this.buttonStopRecording.Click += new System.EventHandler(this.buttonStopRecording_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 700);
            this.Controls.Add(this.buttonStopRecording);
            this.Controls.Add(this.buttonStartRecording);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.textBoxBrightness);
            this.Controls.Add(this.buttonBrightness);
            this.Controls.Add(this.buttonNegative);
            this.Controls.Add(this.textBoxContrast);
            this.Controls.Add(this.buttonContrast);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.buttonPhoto);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Kamera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button buttonPhoto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonContrast;
        private System.Windows.Forms.TextBox textBoxContrast;
        private System.Windows.Forms.Button buttonNegative;
        private System.Windows.Forms.Button buttonBrightness;
        private System.Windows.Forms.TextBox textBoxBrightness;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonStartRecording;
        private System.Windows.Forms.Button buttonStopRecording;
    }
}

