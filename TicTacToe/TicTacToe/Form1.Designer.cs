namespace TicTacToe
{
    partial class TicTacToeForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playerWinsLabel = new System.Windows.Forms.Label();
            this.aiWinsLabel = new System.Windows.Forms.Label();
            this.tile1 = new System.Windows.Forms.Button();
            this.tile2 = new System.Windows.Forms.Button();
            this.tile3 = new System.Windows.Forms.Button();
            this.tile4 = new System.Windows.Forms.Button();
            this.tile5 = new System.Windows.Forms.Button();
            this.tile6 = new System.Windows.Forms.Button();
            this.tile7 = new System.Windows.Forms.Button();
            this.tile8 = new System.Windows.Forms.Button();
            this.tile9 = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.AImoves = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // playerWinsLabel
            // 
            this.playerWinsLabel.AutoSize = true;
            this.playerWinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerWinsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playerWinsLabel.Location = new System.Drawing.Point(12, 9);
            this.playerWinsLabel.Name = "playerWinsLabel";
            this.playerWinsLabel.Size = new System.Drawing.Size(188, 29);
            this.playerWinsLabel.TabIndex = 0;
            this.playerWinsLabel.Text = "Player Wins - 0";
            // 
            // aiWinsLabel
            // 
            this.aiWinsLabel.AutoSize = true;
            this.aiWinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiWinsLabel.ForeColor = System.Drawing.Color.Red;
            this.aiWinsLabel.Location = new System.Drawing.Point(516, 9);
            this.aiWinsLabel.Name = "aiWinsLabel";
            this.aiWinsLabel.Size = new System.Drawing.Size(137, 29);
            this.aiWinsLabel.TabIndex = 1;
            this.aiWinsLabel.Text = "AI Wins - 0";
            // 
            // tile1
            // 
            this.tile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile1.Location = new System.Drawing.Point(63, 62);
            this.tile1.Name = "tile1";
            this.tile1.Size = new System.Drawing.Size(177, 160);
            this.tile1.TabIndex = 2;
            this.tile1.Tag = "play";
            this.tile1.Text = "?";
            this.tile1.UseVisualStyleBackColor = true;
            this.tile1.Click += new System.EventHandler(this.playerClick);
            // 
            // tile2
            // 
            this.tile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile2.Location = new System.Drawing.Point(246, 62);
            this.tile2.Name = "tile2";
            this.tile2.Size = new System.Drawing.Size(177, 160);
            this.tile2.TabIndex = 3;
            this.tile2.Tag = "play";
            this.tile2.Text = "?";
            this.tile2.UseVisualStyleBackColor = true;
            this.tile2.Click += new System.EventHandler(this.playerClick);
            // 
            // tile3
            // 
            this.tile3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile3.Location = new System.Drawing.Point(429, 62);
            this.tile3.Name = "tile3";
            this.tile3.Size = new System.Drawing.Size(177, 160);
            this.tile3.TabIndex = 4;
            this.tile3.Tag = "play";
            this.tile3.Text = "?";
            this.tile3.UseVisualStyleBackColor = true;
            this.tile3.Click += new System.EventHandler(this.playerClick);
            // 
            // tile4
            // 
            this.tile4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile4.Location = new System.Drawing.Point(63, 228);
            this.tile4.Name = "tile4";
            this.tile4.Size = new System.Drawing.Size(177, 160);
            this.tile4.TabIndex = 5;
            this.tile4.Tag = "play";
            this.tile4.Text = "?";
            this.tile4.UseVisualStyleBackColor = true;
            this.tile4.Click += new System.EventHandler(this.playerClick);
            // 
            // tile5
            // 
            this.tile5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile5.Location = new System.Drawing.Point(246, 228);
            this.tile5.Name = "tile5";
            this.tile5.Size = new System.Drawing.Size(177, 160);
            this.tile5.TabIndex = 6;
            this.tile5.Tag = "play";
            this.tile5.Text = "?";
            this.tile5.UseVisualStyleBackColor = true;
            this.tile5.Click += new System.EventHandler(this.playerClick);
            // 
            // tile6
            // 
            this.tile6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile6.Location = new System.Drawing.Point(429, 228);
            this.tile6.Name = "tile6";
            this.tile6.Size = new System.Drawing.Size(177, 160);
            this.tile6.TabIndex = 7;
            this.tile6.Tag = "play";
            this.tile6.Text = "?";
            this.tile6.UseVisualStyleBackColor = true;
            this.tile6.Click += new System.EventHandler(this.playerClick);
            // 
            // tile7
            // 
            this.tile7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile7.Location = new System.Drawing.Point(63, 394);
            this.tile7.Name = "tile7";
            this.tile7.Size = new System.Drawing.Size(177, 160);
            this.tile7.TabIndex = 8;
            this.tile7.Tag = "play";
            this.tile7.Text = "?";
            this.tile7.UseVisualStyleBackColor = true;
            this.tile7.Click += new System.EventHandler(this.playerClick);
            // 
            // tile8
            // 
            this.tile8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile8.Location = new System.Drawing.Point(246, 394);
            this.tile8.Name = "tile8";
            this.tile8.Size = new System.Drawing.Size(177, 160);
            this.tile8.TabIndex = 9;
            this.tile8.Tag = "play";
            this.tile8.Text = "?";
            this.tile8.UseVisualStyleBackColor = true;
            this.tile8.Click += new System.EventHandler(this.playerClick);
            // 
            // tile9
            // 
            this.tile9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile9.Location = new System.Drawing.Point(429, 394);
            this.tile9.Name = "tile9";
            this.tile9.Size = new System.Drawing.Size(177, 160);
            this.tile9.TabIndex = 10;
            this.tile9.Tag = "play";
            this.tile9.Text = "?";
            this.tile9.UseVisualStyleBackColor = true;
            this.tile9.Click += new System.EventHandler(this.playerClick);
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(246, 579);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(177, 44);
            this.restartButton.TabIndex = 11;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartGame);
            // 
            // AImoves
            // 
            this.AImoves.Interval = 1000;
            this.AImoves.Tick += new System.EventHandler(this.AImove);
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 662);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.tile9);
            this.Controls.Add(this.tile8);
            this.Controls.Add(this.tile7);
            this.Controls.Add(this.tile6);
            this.Controls.Add(this.tile5);
            this.Controls.Add(this.tile4);
            this.Controls.Add(this.tile3);
            this.Controls.Add(this.tile2);
            this.Controls.Add(this.tile1);
            this.Controls.Add(this.aiWinsLabel);
            this.Controls.Add(this.playerWinsLabel);
            this.Name = "TicTacToeForm";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerWinsLabel;
        private System.Windows.Forms.Label aiWinsLabel;
        private System.Windows.Forms.Button tile1;
        private System.Windows.Forms.Button tile2;
        private System.Windows.Forms.Button tile3;
        private System.Windows.Forms.Button tile4;
        private System.Windows.Forms.Button tile5;
        private System.Windows.Forms.Button tile6;
        private System.Windows.Forms.Button tile7;
        private System.Windows.Forms.Button tile8;
        private System.Windows.Forms.Button tile9;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Timer AImoves;
    }
}

