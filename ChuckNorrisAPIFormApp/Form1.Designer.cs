
namespace ChuckNorrisAPIFormApp
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
            this.jokeButton = new System.Windows.Forms.Button();
            this.jokeText = new System.Windows.Forms.Label();
            this.jokeCombBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jokeButton
            // 
            this.jokeButton.Location = new System.Drawing.Point(12, 75);
            this.jokeButton.Name = "jokeButton";
            this.jokeButton.Size = new System.Drawing.Size(307, 115);
            this.jokeButton.TabIndex = 0;
            this.jokeButton.Text = "Push me for a joke";
            this.jokeButton.UseVisualStyleBackColor = true;
            this.jokeButton.Click += new System.EventHandler(this.jokeButton_Click);
            // 
            // jokeText
            // 
            this.jokeText.AutoSize = true;
            this.jokeText.Location = new System.Drawing.Point(381, 75);
            this.jokeText.Name = "jokeText";
            this.jokeText.Size = new System.Drawing.Size(27, 13);
            this.jokeText.TabIndex = 1;
            this.jokeText.Text = "joke";
            // 
            // jokeCombBox
            // 
            this.jokeCombBox.FormattingEnabled = true;
            this.jokeCombBox.Location = new System.Drawing.Point(384, 191);
            this.jokeCombBox.Name = "jokeCombBox";
            this.jokeCombBox.Size = new System.Drawing.Size(121, 21);
            this.jokeCombBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exclude This Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Joke Category:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.AutoSize = true;
            this.categoryTextBox.Location = new System.Drawing.Point(457, 259);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(35, 13);
            this.categoryTextBox.TabIndex = 5;
            this.categoryTextBox.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jokeCombBox);
            this.Controls.Add(this.jokeText);
            this.Controls.Add(this.jokeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jokeButton;
        private System.Windows.Forms.Label jokeText;
        private System.Windows.Forms.ComboBox jokeCombBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label categoryTextBox;
    }
}

