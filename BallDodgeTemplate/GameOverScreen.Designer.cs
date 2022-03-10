
namespace BallDodgeTemplate
{
    partial class GameOverScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.goLabel = new System.Windows.Forms.Label();
            this.finalScoreLabel = new System.Windows.Forms.Label();
            this.mmButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goLabel
            // 
            this.goLabel.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goLabel.Location = new System.Drawing.Point(159, 33);
            this.goLabel.Name = "goLabel";
            this.goLabel.Size = new System.Drawing.Size(574, 178);
            this.goLabel.TabIndex = 0;
            this.goLabel.Text = "Game Over";
            // 
            // finalScoreLabel
            // 
            this.finalScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalScoreLabel.Location = new System.Drawing.Point(332, 177);
            this.finalScoreLabel.Name = "finalScoreLabel";
            this.finalScoreLabel.Size = new System.Drawing.Size(336, 60);
            this.finalScoreLabel.TabIndex = 1;
            this.finalScoreLabel.Text = "finalScoreLabel";
            // 
            // mmButton
            // 
            this.mmButton.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmButton.Location = new System.Drawing.Point(342, 308);
            this.mmButton.Name = "mmButton";
            this.mmButton.Size = new System.Drawing.Size(226, 95);
            this.mmButton.TabIndex = 2;
            this.mmButton.Text = "Main Menu";
            this.mmButton.UseVisualStyleBackColor = true;
            this.mmButton.Click += new System.EventHandler(this.mmButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(342, 502);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(226, 95);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mmButton);
            this.Controls.Add(this.finalScoreLabel);
            this.Controls.Add(this.goLabel);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(900, 923);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label goLabel;
        private System.Windows.Forms.Label finalScoreLabel;
        private System.Windows.Forms.Button mmButton;
        private System.Windows.Forms.Button exitButton;
    }
}
