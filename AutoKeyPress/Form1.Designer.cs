﻿namespace AutoKeyPress
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtSpamBtn = new System.Windows.Forms.TextBox();
            this.txtbxTimeSpam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "SPAM!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(89, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(251, 109);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "This program will span the character only to the window you open after clicking t" +
    "he spam button. Once you alt tab out of that window it will stop.";
            // 
            // txtSpamBtn
            // 
            this.txtSpamBtn.Location = new System.Drawing.Point(181, 180);
            this.txtSpamBtn.Name = "txtSpamBtn";
            this.txtSpamBtn.Size = new System.Drawing.Size(100, 20);
            this.txtSpamBtn.TabIndex = 2;
            this.txtSpamBtn.Text = "E";
            this.txtSpamBtn.TextChanged += new System.EventHandler(this.txtSpamBtn_TextChanged);
            // 
            // txtbxTimeSpam
            // 
            this.txtbxTimeSpam.Location = new System.Drawing.Point(181, 227);
            this.txtbxTimeSpam.Name = "txtbxTimeSpam";
            this.txtbxTimeSpam.Size = new System.Drawing.Size(100, 20);
            this.txtbxTimeSpam.TabIndex = 3;
            this.txtbxTimeSpam.Text = "300";
            this.txtbxTimeSpam.TextChanged += new System.EventHandler(this.txtbxTimeSpam_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text To Send";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time in ms between key presses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 403);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxTimeSpam);
            this.Controls.Add(this.txtSpamBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtSpamBtn;
        private System.Windows.Forms.TextBox txtbxTimeSpam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

