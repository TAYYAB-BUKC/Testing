﻿namespace TestingGit
{
	partial class MySecondForm
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
            this.MyButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyButton
            // 
            this.MyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyButton.Location = new System.Drawing.Point(51, 12);
            this.MyButton.Name = "MyButton";
            this.MyButton.Size = new System.Drawing.Size(154, 65);
            this.MyButton.TabIndex = 0;
            this.MyButton.Text = "Click Me!!! ";
            this.MyButton.UseVisualStyleBackColor = true;
            this.MyButton.Click += new System.EventHandler(this.MyButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MySecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(255, 157);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MyButton);
            this.Name = "MySecondForm";
            this.Text = "MySecondForm";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button MyButton;
        private System.Windows.Forms.Button button1;
    }
}