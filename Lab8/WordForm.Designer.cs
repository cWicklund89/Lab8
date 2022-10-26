namespace Lab8
{
    partial class WordForm
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
            this.wordIndexButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // wordIndexButton
            // 
            this.wordIndexButton.Location = new System.Drawing.Point(248, 103);
            this.wordIndexButton.Name = "wordIndexButton";
            this.wordIndexButton.Size = new System.Drawing.Size(265, 49);
            this.wordIndexButton.TabIndex = 0;
            this.wordIndexButton.Text = "Generate Word Index";
            this.wordIndexButton.UseVisualStyleBackColor = true;
            this.wordIndexButton.Click += new System.EventHandler(this.wordIndexButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // WordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wordIndexButton);
            this.Name = "WordForm";
            this.Text = "WordForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wordIndexButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}