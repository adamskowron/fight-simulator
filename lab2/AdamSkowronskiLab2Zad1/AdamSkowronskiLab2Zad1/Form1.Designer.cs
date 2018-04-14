namespace AdamSkowronskiLab2Zad1
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
            this.buttonAttack = new System.Windows.Forms.Button();
            this.buttonUseHealthPotion = new System.Windows.Forms.Button();
            this.buttonUseConditionPotion = new System.Windows.Forms.Button();
            this.pictureBoxOpponent = new System.Windows.Forms.PictureBox();
            this.pictureBoxHero = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.progressBarHeroHealth = new System.Windows.Forms.ProgressBar();
            this.progressBarMonsterHealth = new System.Windows.Forms.ProgressBar();
            this.labelHealth = new System.Windows.Forms.Label();
            this.progressBarCondition = new System.Windows.Forms.ProgressBar();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.labelHealthPotion = new System.Windows.Forms.Label();
            this.labelCashCounter = new System.Windows.Forms.Label();
            this.labelConditionPotion = new System.Windows.Forms.Label();
            this.labelConditionPotionCounter = new System.Windows.Forms.Label();
            this.labelHealthPotionCounter = new System.Windows.Forms.Label();
            this.timerAttackAnimation = new System.Windows.Forms.Timer(this.components);
            this.buttonUpgradeAttack = new System.Windows.Forms.Button();
            this.buttonBuyHealthPotion = new System.Windows.Forms.Button();
            this.buttonConditionPotion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAttack
            // 
            this.buttonAttack.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttack.Location = new System.Drawing.Point(12, 211);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(162, 81);
            this.buttonAttack.TabIndex = 1;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // buttonUseHealthPotion
            // 
            this.buttonUseHealthPotion.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUseHealthPotion.Location = new System.Drawing.Point(12, 298);
            this.buttonUseHealthPotion.Name = "buttonUseHealthPotion";
            this.buttonUseHealthPotion.Size = new System.Drawing.Size(162, 89);
            this.buttonUseHealthPotion.TabIndex = 2;
            this.buttonUseHealthPotion.Text = "Use Health Potion";
            this.buttonUseHealthPotion.UseVisualStyleBackColor = true;
            this.buttonUseHealthPotion.Click += new System.EventHandler(this.buttonUseHealthPotion_Click);
            // 
            // buttonUseConditionPotion
            // 
            this.buttonUseConditionPotion.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUseConditionPotion.Location = new System.Drawing.Point(12, 393);
            this.buttonUseConditionPotion.Name = "buttonUseConditionPotion";
            this.buttonUseConditionPotion.Size = new System.Drawing.Size(162, 98);
            this.buttonUseConditionPotion.TabIndex = 3;
            this.buttonUseConditionPotion.Text = "Use Condition Potion";
            this.buttonUseConditionPotion.UseVisualStyleBackColor = true;
            this.buttonUseConditionPotion.Click += new System.EventHandler(this.buttonUseConditionPotion_Click);
            // 
            // pictureBoxOpponent
            // 
            this.pictureBoxOpponent.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOpponent.Location = new System.Drawing.Point(710, 194);
            this.pictureBoxOpponent.Name = "pictureBoxOpponent";
            this.pictureBoxOpponent.Size = new System.Drawing.Size(265, 414);
            this.pictureBoxOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOpponent.TabIndex = 5;
            this.pictureBoxOpponent.TabStop = false;
            // 
            // pictureBoxHero
            // 
            this.pictureBoxHero.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHero.Image = global::AdamSkowronskiLab2Zad1.Properties.Resources.StandingHero;
            this.pictureBoxHero.Location = new System.Drawing.Point(447, 194);
            this.pictureBoxHero.Name = "pictureBoxHero";
            this.pictureBoxHero.Size = new System.Drawing.Size(265, 414);
            this.pictureBoxHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHero.TabIndex = 4;
            this.pictureBoxHero.TabStop = false;
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackground.Image = global::AdamSkowronskiLab2Zad1.Properties.Resources.background;
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 33);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(1278, 592);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 0;
            this.pictureBoxBackground.TabStop = false;
            // 
            // progressBarHeroHealth
            // 
            this.progressBarHeroHealth.Location = new System.Drawing.Point(12, 36);
            this.progressBarHeroHealth.Name = "progressBarHeroHealth";
            this.progressBarHeroHealth.Size = new System.Drawing.Size(433, 42);
            this.progressBarHeroHealth.TabIndex = 6;
            this.progressBarHeroHealth.Value = 100;
            // 
            // progressBarMonsterHealth
            // 
            this.progressBarMonsterHealth.Location = new System.Drawing.Point(795, 36);
            this.progressBarMonsterHealth.Name = "progressBarMonsterHealth";
            this.progressBarMonsterHealth.Size = new System.Drawing.Size(433, 42);
            this.progressBarMonsterHealth.TabIndex = 7;
            this.progressBarMonsterHealth.Value = 100;
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.BackColor = System.Drawing.Color.Transparent;
            this.labelHealth.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealth.ForeColor = System.Drawing.Color.DarkRed;
            this.labelHealth.Location = new System.Drawing.Point(531, 9);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(180, 40);
            this.labelHealth.TabIndex = 8;
            this.labelHealth.Text = "HEALTH";
            // 
            // progressBarCondition
            // 
            this.progressBarCondition.Location = new System.Drawing.Point(12, 128);
            this.progressBarCondition.Name = "progressBarCondition";
            this.progressBarCondition.Size = new System.Drawing.Size(322, 29);
            this.progressBarCondition.TabIndex = 9;
            this.progressBarCondition.Value = 100;
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.BackColor = System.Drawing.Color.Transparent;
            this.labelCondition.Font = new System.Drawing.Font("Modern No. 20", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCondition.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelCondition.Location = new System.Drawing.Point(5, 50);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(221, 40);
            this.labelCondition.TabIndex = 10;
            this.labelCondition.Text = "CONDITION";
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.BackColor = System.Drawing.Color.Transparent;
            this.labelCash.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCash.ForeColor = System.Drawing.Color.Gold;
            this.labelCash.Location = new System.Drawing.Point(338, 56);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(105, 34);
            this.labelCash.TabIndex = 11;
            this.labelCash.Text = "CASH:";
            // 
            // labelHealthPotion
            // 
            this.labelHealthPotion.AutoSize = true;
            this.labelHealthPotion.BackColor = System.Drawing.Color.Transparent;
            this.labelHealthPotion.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealthPotion.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelHealthPotion.Location = new System.Drawing.Point(513, 56);
            this.labelHealthPotion.Name = "labelHealthPotion";
            this.labelHealthPotion.Size = new System.Drawing.Size(302, 34);
            this.labelHealthPotion.TabIndex = 12;
            this.labelHealthPotion.Text = "HEALTH POTIONS:";
            // 
            // labelCashCounter
            // 
            this.labelCashCounter.AutoSize = true;
            this.labelCashCounter.BackColor = System.Drawing.Color.Transparent;
            this.labelCashCounter.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashCounter.ForeColor = System.Drawing.Color.Gold;
            this.labelCashCounter.Location = new System.Drawing.Point(449, 56);
            this.labelCashCounter.Name = "labelCashCounter";
            this.labelCashCounter.Size = new System.Drawing.Size(30, 34);
            this.labelCashCounter.TabIndex = 14;
            this.labelCashCounter.Text = "0";
            // 
            // labelConditionPotion
            // 
            this.labelConditionPotion.AutoSize = true;
            this.labelConditionPotion.BackColor = System.Drawing.Color.Transparent;
            this.labelConditionPotion.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConditionPotion.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelConditionPotion.Location = new System.Drawing.Point(857, 56);
            this.labelConditionPotion.Name = "labelConditionPotion";
            this.labelConditionPotion.Size = new System.Drawing.Size(335, 34);
            this.labelConditionPotion.TabIndex = 15;
            this.labelConditionPotion.Text = "CONDITION POTIONS:";
            // 
            // labelConditionPotionCounter
            // 
            this.labelConditionPotionCounter.AutoSize = true;
            this.labelConditionPotionCounter.BackColor = System.Drawing.Color.Transparent;
            this.labelConditionPotionCounter.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConditionPotionCounter.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelConditionPotionCounter.Location = new System.Drawing.Point(1198, 56);
            this.labelConditionPotionCounter.Name = "labelConditionPotionCounter";
            this.labelConditionPotionCounter.Size = new System.Drawing.Size(30, 34);
            this.labelConditionPotionCounter.TabIndex = 16;
            this.labelConditionPotionCounter.Text = "0";
            // 
            // labelHealthPotionCounter
            // 
            this.labelHealthPotionCounter.AutoSize = true;
            this.labelHealthPotionCounter.BackColor = System.Drawing.Color.Transparent;
            this.labelHealthPotionCounter.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealthPotionCounter.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelHealthPotionCounter.Location = new System.Drawing.Point(821, 56);
            this.labelHealthPotionCounter.Name = "labelHealthPotionCounter";
            this.labelHealthPotionCounter.Size = new System.Drawing.Size(30, 34);
            this.labelHealthPotionCounter.TabIndex = 17;
            this.labelHealthPotionCounter.Text = "0";
            // 
            // timerAttackAnimation
            // 
            this.timerAttackAnimation.Tick += new System.EventHandler(this.timerAttackAnimation_Tick);
            // 
            // buttonUpgradeAttack
            // 
            this.buttonUpgradeAttack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpgradeAttack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonUpgradeAttack.Location = new System.Drawing.Point(340, 128);
            this.buttonUpgradeAttack.Name = "buttonUpgradeAttack";
            this.buttonUpgradeAttack.Size = new System.Drawing.Size(312, 45);
            this.buttonUpgradeAttack.TabIndex = 18;
            this.buttonUpgradeAttack.Text = "UPGRADE ATTACK (150$)";
            this.buttonUpgradeAttack.UseVisualStyleBackColor = true;
            this.buttonUpgradeAttack.Click += new System.EventHandler(this.buttonUpgradeAttack_Click);
            // 
            // buttonBuyHealthPotion
            // 
            this.buttonBuyHealthPotion.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuyHealthPotion.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonBuyHealthPotion.Location = new System.Drawing.Point(658, 128);
            this.buttonBuyHealthPotion.Name = "buttonBuyHealthPotion";
            this.buttonBuyHealthPotion.Size = new System.Drawing.Size(257, 45);
            this.buttonBuyHealthPotion.TabIndex = 19;
            this.buttonBuyHealthPotion.Text = "BuyHealthPotion(50$)";
            this.buttonBuyHealthPotion.UseVisualStyleBackColor = true;
            this.buttonBuyHealthPotion.Click += new System.EventHandler(this.buttonBuyHealthPotion_Click);
            // 
            // buttonConditionPotion
            // 
            this.buttonConditionPotion.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConditionPotion.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonConditionPotion.Location = new System.Drawing.Point(921, 128);
            this.buttonConditionPotion.Name = "buttonConditionPotion";
            this.buttonConditionPotion.Size = new System.Drawing.Size(329, 45);
            this.buttonConditionPotion.TabIndex = 20;
            this.buttonConditionPotion.Text = "Buy Condition Potion(25$)";
            this.buttonConditionPotion.UseVisualStyleBackColor = true;
            this.buttonConditionPotion.Click += new System.EventHandler(this.buttonConditionPotion_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1278, 33);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            this.ClientSize = new System.Drawing.Size(1278, 625);
            this.Controls.Add(this.buttonConditionPotion);
            this.Controls.Add(this.buttonBuyHealthPotion);
            this.Controls.Add(this.buttonUpgradeAttack);
            this.Controls.Add(this.labelHealthPotionCounter);
            this.Controls.Add(this.labelConditionPotionCounter);
            this.Controls.Add(this.labelConditionPotion);
            this.Controls.Add(this.labelCashCounter);
            this.Controls.Add(this.labelHealthPotion);
            this.Controls.Add(this.labelCash);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.progressBarCondition);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.progressBarMonsterHealth);
            this.Controls.Add(this.progressBarHeroHealth);
            this.Controls.Add(this.pictureBoxOpponent);
            this.Controls.Add(this.pictureBoxHero);
            this.Controls.Add(this.buttonUseConditionPotion);
            this.Controls.Add(this.buttonUseHealthPotion);
            this.Controls.Add(this.buttonAttack);
            this.Controls.Add(this.pictureBoxBackground);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button buttonUseHealthPotion;
        private System.Windows.Forms.Button buttonUseConditionPotion;
        private System.Windows.Forms.PictureBox pictureBoxHero;
        private System.Windows.Forms.PictureBox pictureBoxOpponent;
        private System.Windows.Forms.ProgressBar progressBarHeroHealth;
        private System.Windows.Forms.ProgressBar progressBarMonsterHealth;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.ProgressBar progressBarCondition;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.Label labelHealthPotion;
        private System.Windows.Forms.Label labelCashCounter;
        private System.Windows.Forms.Label labelConditionPotion;
        private System.Windows.Forms.Label labelConditionPotionCounter;
        private System.Windows.Forms.Label labelHealthPotionCounter;
        private System.Windows.Forms.Timer timerAttackAnimation;
        private System.Windows.Forms.Button buttonUpgradeAttack;
        private System.Windows.Forms.Button buttonBuyHealthPotion;
        private System.Windows.Forms.Button buttonConditionPotion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
    }
}

