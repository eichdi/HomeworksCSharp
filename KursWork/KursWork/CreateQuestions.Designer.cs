namespace KursWork
{
    partial class CreateQuestions
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
            this.questionLable = new System.Windows.Forms.Label();
            this.OkAndYes = new System.Windows.Forms.Button();
            this.NextAndNo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какСоздаватьДиалогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фаилToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionLable
            // 
            this.questionLable.AutoSize = true;
            this.questionLable.Location = new System.Drawing.Point(20, 18);
            this.questionLable.Name = "questionLable";
            this.questionLable.Size = new System.Drawing.Size(47, 13);
            this.questionLable.TabIndex = 0;
            this.questionLable.Text = "question";
            // 
            // OkAndYes
            // 
            this.OkAndYes.Location = new System.Drawing.Point(26, 372);
            this.OkAndYes.Name = "OkAndYes";
            this.OkAndYes.Size = new System.Drawing.Size(89, 29);
            this.OkAndYes.TabIndex = 1;
            this.OkAndYes.Text = "ok";
            this.OkAndYes.UseVisualStyleBackColor = true;
            this.OkAndYes.Click += new System.EventHandler(this.OkAndYes_Click);
            // 
            // NextAndNo
            // 
            this.NextAndNo.Location = new System.Drawing.Point(266, 371);
            this.NextAndNo.Name = "NextAndNo";
            this.NextAndNo.Size = new System.Drawing.Size(89, 30);
            this.NextAndNo.TabIndex = 2;
            this.NextAndNo.Text = "next";
            this.NextAndNo.UseVisualStyleBackColor = true;
            this.NextAndNo.Click += new System.EventHandler(this.NextAndNo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фаилToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.какСоздаватьДиалогToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // какСоздаватьДиалогToolStripMenuItem
            // 
            this.какСоздаватьДиалогToolStripMenuItem.Name = "какСоздаватьДиалогToolStripMenuItem";
            this.какСоздаватьДиалогToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.какСоздаватьДиалогToolStripMenuItem.Text = "Как создавать диалог";
            this.какСоздаватьДиалогToolStripMenuItem.Click += new System.EventHandler(this.какСоздаватьДиалогToolStripMenuItem_Click);
            // 
            // фаилToolStripMenuItem
            // 
            this.фаилToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.фаилToolStripMenuItem.Name = "фаилToolStripMenuItem";
            this.фаилToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.фаилToolStripMenuItem.Text = "Фаил";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(26, 59);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(328, 212);
            this.listBox.TabIndex = 4;
            // 
            // CreateQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 413);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.NextAndNo);
            this.Controls.Add(this.OkAndYes);
            this.Controls.Add(this.questionLable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateQuestions";
            this.Text = "CreateQuestions";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLable;
        private System.Windows.Forms.Button OkAndYes;
        private System.Windows.Forms.Button NextAndNo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какСоздаватьДиалогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фаилToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox;
    }
}