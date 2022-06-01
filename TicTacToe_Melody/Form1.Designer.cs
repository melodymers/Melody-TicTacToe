namespace TicTacToe_Melody
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.title = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.title, "title");
            this.title.Image = global::TicTacToe_Melody.Properties.Resources.title1;
            this.title.Name = "title";
            this.title.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TicTacToe_Melody.Properties.Resources.bg;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnA1
            // 
            resources.ApplyResources(this.btnA1, "btnA1");
            this.btnA1.Name = "btnA1";
            this.btnA1.UseVisualStyleBackColor = true;
            // 
            // btnA2
            // 
            resources.ApplyResources(this.btnA2, "btnA2");
            this.btnA2.Name = "btnA2";
            this.btnA2.UseVisualStyleBackColor = true;
            // 
            // btnA3
            // 
            resources.ApplyResources(this.btnA3, "btnA3");
            this.btnA3.Name = "btnA3";
            this.btnA3.UseVisualStyleBackColor = true;
            // 
            // btnB1
            // 
            resources.ApplyResources(this.btnB1, "btnB1");
            this.btnB1.Name = "btnB1";
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.btnB1_Click);
            // 
            // btnB2
            // 
            resources.ApplyResources(this.btnB2, "btnB2");
            this.btnB2.Name = "btnB2";
            this.btnB2.UseVisualStyleBackColor = true;
            // 
            // btnB3
            // 
            resources.ApplyResources(this.btnB3, "btnB3");
            this.btnB3.Name = "btnB3";
            this.btnB3.UseVisualStyleBackColor = true;
            // 
            // btnC1
            // 
            resources.ApplyResources(this.btnC1, "btnC1");
            this.btnC1.Name = "btnC1";
            this.btnC1.UseVisualStyleBackColor = true;
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
            // 
            // TicTacToe
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::TicTacToe_Melody.Properties.Resources.bgg;
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnB1);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnA3);
            this.Controls.Add(this.btnA2);
            this.Controls.Add(this.btnA1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TicTacToe";
            this.ShowIcon = false;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC3;
    }
}

