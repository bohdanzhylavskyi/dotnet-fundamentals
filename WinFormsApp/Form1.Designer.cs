namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            submitBtn = new Button();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(180, 165);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(95, 25);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(292, 165);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(198, 31);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(516, 165);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(112, 34);
            submitBtn.TabIndex = 2;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submitBtn);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private TextBox usernameTextBox;
        private Button submitBtn;
    }
}
