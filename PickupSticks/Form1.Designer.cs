namespace PickupSticks
{
    partial class Main
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
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.TotalSticksLabel = new System.Windows.Forms.Label();
            this.PickUpRangeLabel = new System.Windows.Forms.Label();
            this.TotalPlayersLabel = new System.Windows.Forms.Label();
            this.TotalPlayersTextbox = new System.Windows.Forms.TextBox();
            this.TotalSticksTextbox = new System.Windows.Forms.TextBox();
            this.PickUpRangeTextbox = new System.Windows.Forms.TextBox();
            this.CurrentPlayerLabel = new System.Windows.Forms.Label();
            this.CurrentSticksLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.PickUpAmountTextbox = new System.Windows.Forms.TextBox();
            this.PickUpButton = new System.Windows.Forms.Button();
            this.PickUpAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.Location = new System.Drawing.Point(9, 65);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(72, 17);
            this.SettingsLabel.TabIndex = 0;
            this.SettingsLabel.Text = "Settings:";
            // 
            // TotalSticksLabel
            // 
            this.TotalSticksLabel.AutoSize = true;
            this.TotalSticksLabel.Location = new System.Drawing.Point(12, 126);
            this.TotalSticksLabel.Name = "TotalSticksLabel";
            this.TotalSticksLabel.Size = new System.Drawing.Size(66, 13);
            this.TotalSticksLabel.TabIndex = 1;
            this.TotalSticksLabel.Text = "Total Sticks:";
            // 
            // PickUpRangeLabel
            // 
            this.PickUpRangeLabel.AutoSize = true;
            this.PickUpRangeLabel.Location = new System.Drawing.Point(12, 157);
            this.PickUpRangeLabel.Name = "PickUpRangeLabel";
            this.PickUpRangeLabel.Size = new System.Drawing.Size(83, 13);
            this.PickUpRangeLabel.TabIndex = 2;
            this.PickUpRangeLabel.Text = "Pick Up Range:";
            // 
            // TotalPlayersLabel
            // 
            this.TotalPlayersLabel.AutoSize = true;
            this.TotalPlayersLabel.Location = new System.Drawing.Point(12, 95);
            this.TotalPlayersLabel.Name = "TotalPlayersLabel";
            this.TotalPlayersLabel.Size = new System.Drawing.Size(71, 13);
            this.TotalPlayersLabel.TabIndex = 3;
            this.TotalPlayersLabel.Text = "Total Players:";
            // 
            // TotalPlayersTextbox
            // 
            this.TotalPlayersTextbox.Location = new System.Drawing.Point(98, 92);
            this.TotalPlayersTextbox.Name = "TotalPlayersTextbox";
            this.TotalPlayersTextbox.Size = new System.Drawing.Size(50, 20);
            this.TotalPlayersTextbox.TabIndex = 5;
            this.TotalPlayersTextbox.Text = "2";
            // 
            // TotalSticksTextbox
            // 
            this.TotalSticksTextbox.Location = new System.Drawing.Point(98, 124);
            this.TotalSticksTextbox.Name = "TotalSticksTextbox";
            this.TotalSticksTextbox.Size = new System.Drawing.Size(50, 20);
            this.TotalSticksTextbox.TabIndex = 6;
            this.TotalSticksTextbox.Text = "12";
            // 
            // PickUpRangeTextbox
            // 
            this.PickUpRangeTextbox.Location = new System.Drawing.Point(98, 154);
            this.PickUpRangeTextbox.Name = "PickUpRangeTextbox";
            this.PickUpRangeTextbox.Size = new System.Drawing.Size(50, 20);
            this.PickUpRangeTextbox.TabIndex = 7;
            this.PickUpRangeTextbox.Text = "3";
            // 
            // CurrentPlayerLabel
            // 
            this.CurrentPlayerLabel.AutoSize = true;
            this.CurrentPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CurrentPlayerLabel.Location = new System.Drawing.Point(250, 15);
            this.CurrentPlayerLabel.Name = "CurrentPlayerLabel";
            this.CurrentPlayerLabel.Size = new System.Drawing.Size(113, 31);
            this.CurrentPlayerLabel.TabIndex = 8;
            this.CurrentPlayerLabel.Text = "Player #";
            // 
            // CurrentSticksLabel
            // 
            this.CurrentSticksLabel.AutoSize = true;
            this.CurrentSticksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.CurrentSticksLabel.Location = new System.Drawing.Point(271, 69);
            this.CurrentSticksLabel.Name = "CurrentSticksLabel";
            this.CurrentSticksLabel.Size = new System.Drawing.Size(64, 46);
            this.CurrentSticksLabel.TabIndex = 9;
            this.CurrentSticksLabel.Text = "##";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(79, 34);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PickUpAmountTextbox
            // 
            this.PickUpAmountTextbox.Enabled = false;
            this.PickUpAmountTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickUpAmountTextbox.Location = new System.Drawing.Point(279, 145);
            this.PickUpAmountTextbox.Name = "PickUpAmountTextbox";
            this.PickUpAmountTextbox.Size = new System.Drawing.Size(50, 26);
            this.PickUpAmountTextbox.TabIndex = 12;
            this.PickUpAmountTextbox.Text = "1";
            this.PickUpAmountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PickUpButton
            // 
            this.PickUpButton.Enabled = false;
            this.PickUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickUpButton.Location = new System.Drawing.Point(335, 148);
            this.PickUpButton.Name = "PickUpButton";
            this.PickUpButton.Size = new System.Drawing.Size(75, 23);
            this.PickUpButton.TabIndex = 13;
            this.PickUpButton.Text = "Pick up";
            this.PickUpButton.UseVisualStyleBackColor = true;
            this.PickUpButton.Click += new System.EventHandler(this.PickUpButton_Click);
            // 
            // PickUpAmountLabel
            // 
            this.PickUpAmountLabel.AutoSize = true;
            this.PickUpAmountLabel.Location = new System.Drawing.Point(219, 153);
            this.PickUpAmountLabel.Name = "PickUpAmountLabel";
            this.PickUpAmountLabel.Size = new System.Drawing.Size(49, 13);
            this.PickUpAmountLabel.TabIndex = 14;
            this.PickUpAmountLabel.Text = "Amount: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 224);
            this.Controls.Add(this.PickUpAmountLabel);
            this.Controls.Add(this.PickUpButton);
            this.Controls.Add(this.PickUpAmountTextbox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CurrentSticksLabel);
            this.Controls.Add(this.CurrentPlayerLabel);
            this.Controls.Add(this.PickUpRangeTextbox);
            this.Controls.Add(this.TotalSticksTextbox);
            this.Controls.Add(this.TotalPlayersTextbox);
            this.Controls.Add(this.TotalPlayersLabel);
            this.Controls.Add(this.PickUpRangeLabel);
            this.Controls.Add(this.TotalSticksLabel);
            this.Controls.Add(this.SettingsLabel);
            this.Name = "Main";
            this.Text = "Pick Up Sticks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Label TotalSticksLabel;
        private System.Windows.Forms.Label PickUpRangeLabel;
        private System.Windows.Forms.Label TotalPlayersLabel;
        private System.Windows.Forms.TextBox TotalPlayersTextbox;
        private System.Windows.Forms.TextBox TotalSticksTextbox;
        private System.Windows.Forms.TextBox PickUpRangeTextbox;
        private System.Windows.Forms.Label CurrentPlayerLabel;
        private System.Windows.Forms.Label CurrentSticksLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox PickUpAmountTextbox;
        private System.Windows.Forms.Button PickUpButton;
        private System.Windows.Forms.Label PickUpAmountLabel;
    }
}

