namespace PlayGame
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
            this.playbutton = new System.Windows.Forms.Button();
            this.gamestartingtext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playbutton
            // 
            this.playbutton.BackColor = System.Drawing.Color.Black;
            this.playbutton.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbutton.ForeColor = System.Drawing.Color.White;
            this.playbutton.Location = new System.Drawing.Point(94, 42);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(605, 247);
            this.playbutton.TabIndex = 2;
            this.playbutton.Text = "PLAY GAME";
            this.playbutton.UseVisualStyleBackColor = false;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // gamestartingtext
            // 
            this.gamestartingtext.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamestartingtext.Location = new System.Drawing.Point(94, 349);
            this.gamestartingtext.Name = "gamestartingtext";
            this.gamestartingtext.Size = new System.Drawing.Size(605, 79);
            this.gamestartingtext.TabIndex = 4;
            this.gamestartingtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gamestartingtext);
            this.Controls.Add(this.playbutton);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "there\'s a starman";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playbutton;
        private System.Windows.Forms.Label gamestartingtext;
    }
}

