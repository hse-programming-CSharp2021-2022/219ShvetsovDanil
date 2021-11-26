
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
            this.nextRowMember = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextRowMember
            // 
            this.nextRowMember.Location = new System.Drawing.Point(241, 160);
            this.nextRowMember.Name = "nextRowMember";
            this.nextRowMember.Size = new System.Drawing.Size(286, 80);
            this.nextRowMember.TabIndex = 0;
            this.nextRowMember.Text = "Следующий член ряда";
            this.nextRowMember.UseVisualStyleBackColor = true;
            this.nextRowMember.Click += new System.EventHandler(this.nextRowMember_Click);
            // 
            // outputText
            // 
            this.outputText.AutoSize = true;
            this.outputText.Location = new System.Drawing.Point(241, 304);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(0, 32);
            this.outputText.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.nextRowMember);
            this.Name = "Form1";
            this.Text = "Первое Windows-приложение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextRowMember;
        private System.Windows.Forms.Label outputText;
    }
}

