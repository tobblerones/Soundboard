namespace SoundBox
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
            this.CoinButton = new System.Windows.Forms.Button();
            this.sword_swoosh_sfx = new System.Windows.Forms.Button();
            this.Car_Crash_SFX = new System.Windows.Forms.Button();
            this.Chomp_SFX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoinButton
            // 
            this.CoinButton.Location = new System.Drawing.Point(56, 105);
            this.CoinButton.Name = "CoinButton";
            this.CoinButton.Size = new System.Drawing.Size(100, 25);
            this.CoinButton.TabIndex = 0;
            this.CoinButton.Text = "Coin";
            this.CoinButton.UseVisualStyleBackColor = true;
            this.CoinButton.Click += new System.EventHandler(this.CoinButton_Click);
            // 
            // sword_swoosh_sfx
            // 
            this.sword_swoosh_sfx.Location = new System.Drawing.Point(56, 146);
            this.sword_swoosh_sfx.Name = "sword_swoosh_sfx";
            this.sword_swoosh_sfx.Size = new System.Drawing.Size(100, 25);
            this.sword_swoosh_sfx.TabIndex = 1;
            this.sword_swoosh_sfx.Text = "Sword Swing";
            this.sword_swoosh_sfx.UseVisualStyleBackColor = true;
            this.sword_swoosh_sfx.Click += new System.EventHandler(this.sword_swoosh_sfx_Click);
            // 
            // Car_Crash_SFX
            // 
            this.Car_Crash_SFX.Location = new System.Drawing.Point(56, 187);
            this.Car_Crash_SFX.Name = "Car_Crash_SFX";
            this.Car_Crash_SFX.Size = new System.Drawing.Size(100, 25);
            this.Car_Crash_SFX.TabIndex = 2;
            this.Car_Crash_SFX.Text = "Car Crash";
            this.Car_Crash_SFX.UseVisualStyleBackColor = true;
            this.Car_Crash_SFX.Click += new System.EventHandler(this.Car_Crash_SFX_Click);
            // 
            // Chomp_SFX
            // 
            this.Chomp_SFX.Location = new System.Drawing.Point(56, 229);
            this.Chomp_SFX.Name = "Chomp_SFX";
            this.Chomp_SFX.Size = new System.Drawing.Size(100, 25);
            this.Chomp_SFX.TabIndex = 3;
            this.Chomp_SFX.Text = "Chomp";
            this.Chomp_SFX.UseVisualStyleBackColor = true;
            this.Chomp_SFX.Click += new System.EventHandler(this.Chomp_SFX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Chomp_SFX);
            this.Controls.Add(this.Car_Crash_SFX);
            this.Controls.Add(this.sword_swoosh_sfx);
            this.Controls.Add(this.CoinButton);
            this.Name = "Form1";
            this.Text = "Soundboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CoinButton;
        private System.Windows.Forms.Button sword_swoosh_sfx;
        private System.Windows.Forms.Button Car_Crash_SFX;
        private System.Windows.Forms.Button Chomp_SFX;
    }
}

