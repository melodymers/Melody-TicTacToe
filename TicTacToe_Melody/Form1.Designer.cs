using System;

namespace TicTacToe_Melody
{
    partial class TicTacToe
    {
        private const bool V = false;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.titleHeader = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.playerButtons = new System.Windows.Forms.PictureBox();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titleHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerButtons)).BeginInit();
            this.SuspendLayout();
            // 
            // titleHeader
            // 
            this.titleHeader.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.titleHeader, "titleHeader");
            this.titleHeader.Image = global::TicTacToe_Melody.Properties.Resources.ff;
            this.titleHeader.Name = "titleHeader";
            this.titleHeader.TabStop = false;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.background, "background");
            this.background.Image = global::TicTacToe_Melody.Properties.Resources.bg;
            this.background.Name = "background";
            this.background.TabStop = false;
            // 
            // btnA1
            // 
            resources.ApplyResources(this.btnA1, "btnA1");
            this.btnA1.Name = "btnA1";
            this.btnA1.UseVisualStyleBackColor = true;
            this.btnA1.Click += new System.EventHandler(this.btnA1_Click_1);
            // 
            // btnA2
            // 
            resources.ApplyResources(this.btnA2, "btnA2");
            this.btnA2.Name = "btnA2";
            this.btnA2.UseVisualStyleBackColor = true;
            this.btnA2.Click += new System.EventHandler(this.btnA2_Click);
            // 
            // btnA3
            // 
            resources.ApplyResources(this.btnA3, "btnA3");
            this.btnA3.Name = "btnA3";
            this.btnA3.UseVisualStyleBackColor = true;
            this.btnA3.Click += new System.EventHandler(this.btnA3_Click_1);
            // 
            // btnB1
            // 
            resources.ApplyResources(this.btnB1, "btnB1");
            this.btnB1.Name = "btnB1";
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.btnB1_Click_1);
            // 
            // btnB2
            // 
            resources.ApplyResources(this.btnB2, "btnB2");
            this.btnB2.Name = "btnB2";
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.Click += new System.EventHandler(this.btnB2_Click_1);
            // 
            // btnB3
            // 
            resources.ApplyResources(this.btnB3, "btnB3");
            this.btnB3.Name = "btnB3";
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.btnB3_Click_1);
            // 
            // btnC1
            // 
            resources.ApplyResources(this.btnC1, "btnC1");
            this.btnC1.Name = "btnC1";
            this.btnC1.UseVisualStyleBackColor = true;
            this.btnC1.Click += new System.EventHandler(this.btnC1_Click);
            // 
            // btnC2
            // 
            resources.ApplyResources(this.btnC2, "btnC2");
            this.btnC2.Name = "btnC2";
            this.btnC2.UseVisualStyleBackColor = true;
            this.btnC2.Click += new System.EventHandler(this.btnC2_Click);
            // 
            // btnC3
            // 
            resources.ApplyResources(this.btnC3, "btnC3");
            this.btnC3.Name = "btnC3";
            this.btnC3.UseVisualStyleBackColor = true;
            this.btnC3.Click += new System.EventHandler(this.btnC3_Click);
            // 
            // playerButtons
            // 
            this.playerButtons.BackColor = System.Drawing.Color.Transparent;
            this.playerButtons.Image = global::TicTacToe_Melody.Properties.Resources.BTSN;
            this.playerButtons.InitialImage = global::TicTacToe_Melody.Properties.Resources.BTSN1;
            resources.ApplyResources(this.playerButtons, "playerButtons");
            this.playerButtons.Name = "playerButtons";
            this.playerButtons.TabStop = false;
            // 
            // newGameBtn
            // 
            resources.ApplyResources(this.newGameBtn, "newGameBtn");
            this.newGameBtn.BackColor = System.Drawing.Color.Transparent;
            this.newGameBtn.ForeColor = System.Drawing.Color.Transparent;
            this.newGameBtn.Image = global::TicTacToe_Melody.Properties.Resources.green1;
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.UseVisualStyleBackColor = false;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ExitBtn, "ExitBtn");
            this.ExitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Image = global::TicTacToe_Melody.Properties.Resources.green1;
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.helpBtn, "helpBtn");
            this.helpBtn.ForeColor = System.Drawing.Color.Transparent;
            this.helpBtn.Image = global::TicTacToe_Melody.Properties.Resources.green1;
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click_1);
            // 
            // TicTacToe
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::TicTacToe_Melody.Properties.Resources.bgg;
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.playerButtons);
            this.Controls.Add(this.titleHeader);
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnB1);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnA3);
            this.Controls.Add(this.btnA2);
            this.Controls.Add(this.btnA1);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TicTacToe";
            this.ShowIcon = false;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titleHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerButtons)).EndInit();
            this.ResumeLayout(false);

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.PictureBox titleHeader;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.PictureBox playerButtons;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button helpBtn;
    }
}

