namespace AdamSkowronskiLab
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
            this.components = new System.ComponentModel.Container();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CollorButton = new System.Windows.Forms.Button();
            this.timerColor = new System.Windows.Forms.Timer(this.components);
            this.arg1TextBox1 = new System.Windows.Forms.TextBox();
            this.arg2TextBox = new System.Windows.Forms.TextBox();
            this.equalLabel = new System.Windows.Forms.Label();
            this.retTextBox = new System.Windows.Forms.TextBox();
            this.charComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.Info;
            this.NameLabel.Font = new System.Drawing.Font("Mistral", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.NameLabel.Location = new System.Drawing.Point(151, 240);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(355, 67);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Adam Skowronski";
            // 
            // CollorButton
            // 
            this.CollorButton.Location = new System.Drawing.Point(612, 240);
            this.CollorButton.Name = "CollorButton";
            this.CollorButton.Size = new System.Drawing.Size(122, 84);
            this.CollorButton.TabIndex = 1;
            this.CollorButton.Text = "Change Collor";
            this.CollorButton.UseVisualStyleBackColor = true;
            this.CollorButton.Click += new System.EventHandler(this.collorButton_Click);
            // 
            // timerColor
            // 
            this.timerColor.Tick += new System.EventHandler(this.timerColor_Tick);
            // 
            // arg1TextBox1
            // 
            this.arg1TextBox1.Location = new System.Drawing.Point(140, 110);
            this.arg1TextBox1.Name = "arg1TextBox1";
            this.arg1TextBox1.Size = new System.Drawing.Size(100, 26);
            this.arg1TextBox1.TabIndex = 2;
            this.arg1TextBox1.Text = "0";
            this.arg1TextBox1.TextChanged += new System.EventHandler(this.arg1TextBox1_TextChanged);
            // 
            // arg2TextBox
            // 
            this.arg2TextBox.Location = new System.Drawing.Point(373, 110);
            this.arg2TextBox.Name = "arg2TextBox";
            this.arg2TextBox.Size = new System.Drawing.Size(100, 26);
            this.arg2TextBox.TabIndex = 4;
            this.arg2TextBox.Text = "0";
            this.arg2TextBox.TextChanged += new System.EventHandler(this.arg2TextBox_TextChanged);
            // 
            // equalLabel
            // 
            this.equalLabel.AutoSize = true;
            this.equalLabel.Location = new System.Drawing.Point(479, 108);
            this.equalLabel.Name = "equalLabel";
            this.equalLabel.Size = new System.Drawing.Size(18, 20);
            this.equalLabel.TabIndex = 5;
            this.equalLabel.Text = "=";
            this.equalLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // retTextBox
            // 
            this.retTextBox.Location = new System.Drawing.Point(503, 110);
            this.retTextBox.Name = "retTextBox";
            this.retTextBox.Size = new System.Drawing.Size(100, 26);
            this.retTextBox.TabIndex = 6;
            this.retTextBox.TextChanged += new System.EventHandler(this.retTextBox_TextChanged);
            // 
            // charComboBox
            // 
            this.charComboBox.FormattingEnabled = true;
            this.charComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.charComboBox.Location = new System.Drawing.Point(246, 108);
            this.charComboBox.Name = "charComboBox";
            this.charComboBox.Size = new System.Drawing.Size(121, 28);
            this.charComboBox.TabIndex = 7;
            this.charComboBox.SelectedIndexChanged += new System.EventHandler(this.charComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 408);
            this.Controls.Add(this.charComboBox);
            this.Controls.Add(this.retTextBox);
            this.Controls.Add(this.equalLabel);
            this.Controls.Add(this.arg2TextBox);
            this.Controls.Add(this.arg1TextBox1);
            this.Controls.Add(this.CollorButton);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button CollorButton;
        private System.Windows.Forms.Timer timerColor;
        private System.Windows.Forms.TextBox arg1TextBox1;
        private System.Windows.Forms.TextBox arg2TextBox;
        private System.Windows.Forms.Label equalLabel;
        private System.Windows.Forms.TextBox retTextBox;
        private System.Windows.Forms.ComboBox charComboBox;
    }
}

