namespace ZadanieDomowe1
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
            this.simulatorTimer = new System.Windows.Forms.Timer(this.components);
            this.producerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cashTextBox = new System.Windows.Forms.TextBox();
            this.cashLabel = new System.Windows.Forms.Label();
            this.sellPerSecTextBox = new System.Windows.Forms.TextBox();
            this.sellPerSecLabel = new System.Windows.Forms.Label();
            this.minMaxLabel = new System.Windows.Forms.Label();
            this.upgradeProductionButton = new System.Windows.Forms.Button();
            this.minMaxTextBox = new System.Windows.Forms.TextBox();
            this.carPerSecLabel = new System.Windows.Forms.Label();
            this.upgradeSellButton = new System.Windows.Forms.Button();
            this.carPerSecTextBox = new System.Windows.Forms.TextBox();
            this.upgradeQuwalityButton = new System.Windows.Forms.Button();
            this.cardealerPictureBox1 = new System.Windows.Forms.PictureBox();
            this.productionPictureBox = new System.Windows.Forms.PictureBox();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.carsListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producerTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardealerPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionPictureBox)).BeginInit();
            this.mainTableLayoutPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simulatorTimer
            // 
            this.simulatorTimer.Enabled = true;
            this.simulatorTimer.Tick += new System.EventHandler(this.simulatorTimer_Tick);
            // 
            // producerTableLayoutPanel
            // 
            this.producerTableLayoutPanel.ColumnCount = 3;
            this.producerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.producerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.producerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.producerTableLayoutPanel.Controls.Add(this.cashTextBox, 2, 3);
            this.producerTableLayoutPanel.Controls.Add(this.cashLabel, 0, 3);
            this.producerTableLayoutPanel.Controls.Add(this.sellPerSecTextBox, 2, 2);
            this.producerTableLayoutPanel.Controls.Add(this.sellPerSecLabel, 1, 2);
            this.producerTableLayoutPanel.Controls.Add(this.minMaxLabel, 1, 1);
            this.producerTableLayoutPanel.Controls.Add(this.upgradeProductionButton, 0, 0);
            this.producerTableLayoutPanel.Controls.Add(this.minMaxTextBox, 2, 1);
            this.producerTableLayoutPanel.Controls.Add(this.carPerSecLabel, 1, 0);
            this.producerTableLayoutPanel.Controls.Add(this.upgradeSellButton, 0, 2);
            this.producerTableLayoutPanel.Controls.Add(this.carPerSecTextBox, 2, 0);
            this.producerTableLayoutPanel.Controls.Add(this.upgradeQuwalityButton, 0, 1);
            this.producerTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.producerTableLayoutPanel.Name = "producerTableLayoutPanel";
            this.producerTableLayoutPanel.RowCount = 4;
            this.producerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.producerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.producerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.producerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.producerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.producerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.producerTableLayoutPanel.Size = new System.Drawing.Size(685, 244);
            this.producerTableLayoutPanel.TabIndex = 2;
            // 
            // cashTextBox
            // 
            this.cashTextBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.cashTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.cashTextBox.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashTextBox.ForeColor = System.Drawing.Color.Gold;
            this.cashTextBox.Location = new System.Drawing.Point(459, 186);
            this.cashTextBox.Multiline = true;
            this.cashTextBox.Name = "cashTextBox";
            this.cashTextBox.ReadOnly = true;
            this.cashTextBox.Size = new System.Drawing.Size(223, 55);
            this.cashTextBox.TabIndex = 10;
            this.cashTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cashLabel
            // 
            this.producerTableLayoutPanel.SetColumnSpan(this.cashLabel, 2);
            this.cashLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.cashLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashLabel.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLabel.ForeColor = System.Drawing.Color.Gold;
            this.cashLabel.Location = new System.Drawing.Point(3, 183);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(450, 61);
            this.cashLabel.TabIndex = 9;
            this.cashLabel.Text = "Pieniadze:";
            this.cashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sellPerSecTextBox
            // 
            this.sellPerSecTextBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.sellPerSecTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.sellPerSecTextBox.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellPerSecTextBox.Location = new System.Drawing.Point(459, 125);
            this.sellPerSecTextBox.Multiline = true;
            this.sellPerSecTextBox.Name = "sellPerSecTextBox";
            this.sellPerSecTextBox.ReadOnly = true;
            this.sellPerSecTextBox.Size = new System.Drawing.Size(223, 55);
            this.sellPerSecTextBox.TabIndex = 8;
            this.sellPerSecTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sellPerSecLabel
            // 
            this.sellPerSecLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.sellPerSecLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellPerSecLabel.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellPerSecLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.sellPerSecLabel.Location = new System.Drawing.Point(231, 122);
            this.sellPerSecLabel.Name = "sellPerSecLabel";
            this.sellPerSecLabel.Size = new System.Drawing.Size(222, 61);
            this.sellPerSecLabel.TabIndex = 7;
            this.sellPerSecLabel.Text = "sprzedaz/sekunde";
            this.sellPerSecLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minMaxLabel
            // 
            this.minMaxLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.minMaxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minMaxLabel.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minMaxLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.minMaxLabel.Location = new System.Drawing.Point(231, 61);
            this.minMaxLabel.Name = "minMaxLabel";
            this.minMaxLabel.Size = new System.Drawing.Size(222, 61);
            this.minMaxLabel.TabIndex = 5;
            this.minMaxLabel.Text = "wartosc min/max";
            this.minMaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upgradeProductionButton
            // 
            this.upgradeProductionButton.Location = new System.Drawing.Point(3, 3);
            this.upgradeProductionButton.Name = "upgradeProductionButton";
            this.upgradeProductionButton.Size = new System.Drawing.Size(222, 55);
            this.upgradeProductionButton.TabIndex = 0;
            this.upgradeProductionButton.Text = "Przyspiesz produkcje\r\n(koszt 150k)";
            this.upgradeProductionButton.UseVisualStyleBackColor = true;
            this.upgradeProductionButton.Click += new System.EventHandler(this.upgradeProductionButton_Click);
            // 
            // minMaxTextBox
            // 
            this.minMaxTextBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.minMaxTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.minMaxTextBox.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minMaxTextBox.Location = new System.Drawing.Point(459, 64);
            this.minMaxTextBox.Multiline = true;
            this.minMaxTextBox.Name = "minMaxTextBox";
            this.minMaxTextBox.ReadOnly = true;
            this.minMaxTextBox.Size = new System.Drawing.Size(223, 55);
            this.minMaxTextBox.TabIndex = 3;
            this.minMaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // carPerSecLabel
            // 
            this.carPerSecLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.carPerSecLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carPerSecLabel.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carPerSecLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.carPerSecLabel.Location = new System.Drawing.Point(231, 0);
            this.carPerSecLabel.Name = "carPerSecLabel";
            this.carPerSecLabel.Size = new System.Drawing.Size(222, 61);
            this.carPerSecLabel.TabIndex = 4;
            this.carPerSecLabel.Text = "samochody/sekunde";
            this.carPerSecLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upgradeSellButton
            // 
            this.upgradeSellButton.Location = new System.Drawing.Point(3, 125);
            this.upgradeSellButton.Name = "upgradeSellButton";
            this.upgradeSellButton.Size = new System.Drawing.Size(222, 55);
            this.upgradeSellButton.TabIndex = 6;
            this.upgradeSellButton.Text = "Ulepsz sprzedaż\r\n(koszt 100k)";
            this.upgradeSellButton.UseVisualStyleBackColor = true;
            this.upgradeSellButton.Click += new System.EventHandler(this.upgradeSellButton_Click);
            // 
            // carPerSecTextBox
            // 
            this.carPerSecTextBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.carPerSecTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.carPerSecTextBox.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carPerSecTextBox.Location = new System.Drawing.Point(459, 3);
            this.carPerSecTextBox.Multiline = true;
            this.carPerSecTextBox.Name = "carPerSecTextBox";
            this.carPerSecTextBox.ReadOnly = true;
            this.carPerSecTextBox.Size = new System.Drawing.Size(223, 55);
            this.carPerSecTextBox.TabIndex = 2;
            this.carPerSecTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // upgradeQuwalityButton
            // 
            this.upgradeQuwalityButton.Location = new System.Drawing.Point(3, 64);
            this.upgradeQuwalityButton.Name = "upgradeQuwalityButton";
            this.upgradeQuwalityButton.Size = new System.Drawing.Size(222, 55);
            this.upgradeQuwalityButton.TabIndex = 1;
            this.upgradeQuwalityButton.Text = "Ulepsz jakość\r\n(koszt 100k)";
            this.upgradeQuwalityButton.UseVisualStyleBackColor = true;
            this.upgradeQuwalityButton.Click += new System.EventHandler(this.upgradeQualityButton_Click);
            // 
            // cardealerPictureBox1
            // 
            this.cardealerPictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.cardealerPictureBox1.Image = global::ZadanieDomowe1.Properties.Resources.Car_dealership;
            this.cardealerPictureBox1.Location = new System.Drawing.Point(694, 253);
            this.cardealerPictureBox1.Name = "cardealerPictureBox1";
            this.cardealerPictureBox1.Size = new System.Drawing.Size(685, 370);
            this.cardealerPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardealerPictureBox1.TabIndex = 1;
            this.cardealerPictureBox1.TabStop = false;
            // 
            // productionPictureBox
            // 
            this.productionPictureBox.Cursor = System.Windows.Forms.Cursors.No;
            this.productionPictureBox.Image = global::ZadanieDomowe1.Properties.Resources.assemblyLine;
            this.productionPictureBox.Location = new System.Drawing.Point(3, 253);
            this.productionPictureBox.Name = "productionPictureBox";
            this.productionPictureBox.Size = new System.Drawing.Size(685, 370);
            this.productionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productionPictureBox.TabIndex = 0;
            this.productionPictureBox.TabStop = false;
            this.productionPictureBox.Click += new System.EventHandler(this.productionPictureBox_Click);
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.productionPictureBox, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.cardealerPictureBox1, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.producerTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.carsListBox, 1, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 33);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1383, 626);
            this.mainTableLayoutPanel.TabIndex = 0;
            this.mainTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainTableLayoutPanel_Paint);
            // 
            // carsListBox
            // 
            this.carsListBox.BackColor = System.Drawing.Color.Khaki;
            this.carsListBox.Cursor = System.Windows.Forms.Cursors.No;
            this.carsListBox.FormattingEnabled = true;
            this.carsListBox.ItemHeight = 20;
            this.carsListBox.Location = new System.Drawing.Point(694, 3);
            this.carsListBox.Name = "carsListBox";
            this.carsListBox.ScrollAlwaysVisible = true;
            this.carsListBox.Size = new System.Drawing.Size(685, 244);
            this.carsListBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.oProgramieToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1383, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 659);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.producerTableLayoutPanel.ResumeLayout(false);
            this.producerTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardealerPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionPictureBox)).EndInit();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer simulatorTimer;
        private System.Windows.Forms.TableLayoutPanel producerTableLayoutPanel;
        private System.Windows.Forms.TextBox sellPerSecTextBox;
        private System.Windows.Forms.Label sellPerSecLabel;
        private System.Windows.Forms.Label minMaxLabel;
        private System.Windows.Forms.Button upgradeProductionButton;
        private System.Windows.Forms.Button upgradeQuwalityButton;
        private System.Windows.Forms.TextBox minMaxTextBox;
        private System.Windows.Forms.Label carPerSecLabel;
        private System.Windows.Forms.Button upgradeSellButton;
        private System.Windows.Forms.TextBox carPerSecTextBox;
        private System.Windows.Forms.PictureBox cardealerPictureBox1;
        private System.Windows.Forms.PictureBox productionPictureBox;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.ListBox carsListBox;
        private System.Windows.Forms.TextBox cashTextBox;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
    }
}

