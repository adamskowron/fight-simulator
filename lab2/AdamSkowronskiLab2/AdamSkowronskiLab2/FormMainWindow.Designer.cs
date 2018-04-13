namespace AdamSkowronskiLab2
{
    partial class FormMainWindow
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
            this.labelName = new System.Windows.Forms.Label();
            this.buttonNewWindow = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxConsol = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(29, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(206, 29);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Adam Skowronski";
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.Location = new System.Drawing.Point(34, 57);
            this.buttonNewWindow.Name = "buttonNewWindow";
            this.buttonNewWindow.Size = new System.Drawing.Size(188, 95);
            this.buttonNewWindow.TabIndex = 1;
            this.buttonNewWindow.Text = "nowe okno";
            this.buttonNewWindow.UseVisualStyleBackColor = true;
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBoxConsol
            // 
            this.textBoxConsol.Location = new System.Drawing.Point(176, 188);
            this.textBoxConsol.Multiline = true;
            this.textBoxConsol.Name = "textBoxConsol";
            this.textBoxConsol.Size = new System.Drawing.Size(266, 212);
            this.textBoxConsol.TabIndex = 3;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(555, 210);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(186, 88);
            this.buttonShow.TabIndex = 4;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 510);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.textBoxConsol);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonNewWindow);
            this.Controls.Add(this.labelName);
            this.Name = "FormMainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonNewWindow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxConsol;
        private System.Windows.Forms.Button buttonShow;
    }
}

