﻿namespace WindowsFormsApp
{
    partial class Form2
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
            this.greetingMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // greetingMessageLabel
            // 
            this.greetingMessageLabel.AutoSize = true;
            this.greetingMessageLabel.Location = new System.Drawing.Point(365, 174);
            this.greetingMessageLabel.Name = "greetingMessageLabel";
            this.greetingMessageLabel.Size = new System.Drawing.Size(51, 20);
            this.greetingMessageLabel.TabIndex = 0;
            this.greetingMessageLabel.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.greetingMessageLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingMessageLabel;
    }
}