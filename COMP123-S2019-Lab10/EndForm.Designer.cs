﻿namespace COMP123_S2019_Lab10
{
    partial class EndForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.WelcomeEndFormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(276, 281);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(248, 38);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back to Main Form";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // WelcomeEndFormLabel
            // 
            this.WelcomeEndFormLabel.AutoSize = true;
            this.WelcomeEndFormLabel.Location = new System.Drawing.Point(254, 195);
            this.WelcomeEndFormLabel.Name = "WelcomeEndFormLabel";
            this.WelcomeEndFormLabel.Size = new System.Drawing.Size(289, 31);
            this.WelcomeEndFormLabel.TabIndex = 1;
            this.WelcomeEndFormLabel.Text = "Welcome to End Form!";
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.WelcomeEndFormLabel);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "EndForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EndForm_Close);
            this.Load += new System.EventHandler(this.EndForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label WelcomeEndFormLabel;
    }
}