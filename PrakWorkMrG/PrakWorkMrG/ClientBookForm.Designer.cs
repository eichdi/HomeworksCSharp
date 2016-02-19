namespace PrakWorkMrG
{
    partial class ClientBookForm
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
            this.Name = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Recive = new System.Windows.Forms.Button();
            this.qtBox = new System.Windows.Forms.TextBox();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(19, 15);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(19, 41);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(38, 13);
            this.Author.TabIndex = 1;
            this.Author.Text = "Author";
            // 
            // Recive
            // 
            this.Recive.Location = new System.Drawing.Point(180, 204);
            this.Recive.Name = "Recive";
            this.Recive.Size = new System.Drawing.Size(86, 34);
            this.Recive.TabIndex = 2;
            this.Recive.Text = "Recive";
            this.Recive.UseVisualStyleBackColor = true;
            // 
            // qtBox
            // 
            this.qtBox.Location = new System.Drawing.Point(140, 212);
            this.qtBox.Name = "qtBox";
            this.qtBox.Size = new System.Drawing.Size(34, 20);
            this.qtBox.TabIndex = 3;
            this.qtBox.Text = "1";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(19, 79);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(78, 13);
            this.StartTimeLabel.TabIndex = 4;
            this.StartTimeLabel.Text = "StartTimeLabel";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(19, 116);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(75, 13);
            this.EndTimeLabel.TabIndex = 5;
            this.EndTimeLabel.Text = "EndTimeLabel";
            // 
            // ClientBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.qtBox);
            this.Controls.Add(this.Recive);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Name);
            this.Name = "ClientBookForm";
            this.Text = "ClientBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Button Recive;
        private System.Windows.Forms.TextBox qtBox;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label EndTimeLabel;
    }
}