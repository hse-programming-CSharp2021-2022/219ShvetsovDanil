
namespace Task_02
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
            this.initButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.changedList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initButton
            // 
            this.initButton.Location = new System.Drawing.Point(291, 74);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(176, 82);
            this.initButton.TabIndex = 0;
            this.initButton.Text = "show initial list";
            this.initButton.UseVisualStyleBackColor = true;
            this.initButton.Click += new System.EventHandler(this.initButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 184);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 138);
            this.textBox1.TabIndex = 1;
            // 
            // changedList
            // 
            this.changedList.Location = new System.Drawing.Point(291, 354);
            this.changedList.Name = "changedList";
            this.changedList.Size = new System.Drawing.Size(176, 84);
            this.changedList.TabIndex = 2;
            this.changedList.Text = "show changed list";
            this.changedList.UseVisualStyleBackColor = true;
            this.changedList.Click += new System.EventHandler(this.changedList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changedList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.initButton);
            this.Name = "Form1";
            this.Text = "TextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button changedList;
    }
}

