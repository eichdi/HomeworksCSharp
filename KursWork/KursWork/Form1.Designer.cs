namespace KursWork
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.QueAnsTable = new System.Windows.Forms.DataGridView();
            this.question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionLable = new System.Windows.Forms.Label();
            this.createquestion = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.AnswerCommbo = new System.Windows.Forms.ComboBox();
            this.Send = new System.Windows.Forms.Button();
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какСоздаватьВопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документацияКСистемеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.QueAnsTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QueAnsTable
            // 
            this.QueAnsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueAnsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.question,
            this.answer});
            this.QueAnsTable.Location = new System.Drawing.Point(14, 283);
            this.QueAnsTable.Name = "QueAnsTable";
            this.QueAnsTable.Size = new System.Drawing.Size(307, 227);
            this.QueAnsTable.TabIndex = 0;
            // 
            // question
            // 
            this.question.FillWeight = 150F;
            this.question.HeaderText = "question";
            this.question.Name = "question";
            this.question.ReadOnly = true;
            this.question.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // answer
            // 
            this.answer.FillWeight = 150F;
            this.answer.HeaderText = "answer";
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            // 
            // questionLable
            // 
            this.questionLable.AutoSize = true;
            this.questionLable.Location = new System.Drawing.Point(17, 24);
            this.questionLable.Name = "questionLable";
            this.questionLable.Size = new System.Drawing.Size(73, 13);
            this.questionLable.TabIndex = 1;
            this.questionLable.Text = "questionLable";
            this.questionLable.UseWaitCursor = true;
            // 
            // createquestion
            // 
            this.createquestion.Location = new System.Drawing.Point(180, 244);
            this.createquestion.Name = "createquestion";
            this.createquestion.Size = new System.Drawing.Size(140, 26);
            this.createquestion.TabIndex = 2;
            this.createquestion.Text = "Create question";
            this.createquestion.UseVisualStyleBackColor = true;
            this.createquestion.Click += new System.EventHandler(this.CreateQuestion_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(14, 244);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(145, 25);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // AnswerCommbo
            // 
            this.AnswerCommbo.FormattingEnabled = true;
            this.AnswerCommbo.Location = new System.Drawing.Point(20, 81);
            this.AnswerCommbo.Name = "AnswerCommbo";
            this.AnswerCommbo.Size = new System.Drawing.Size(166, 21);
            this.AnswerCommbo.TabIndex = 4;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(180, 199);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(139, 27);
            this.Send.TabIndex = 5;
            this.Send.Text = "OK";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // AnswerText
            // 
            this.AnswerText.Location = new System.Drawing.Point(20, 82);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(139, 20);
            this.AnswerText.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свойстваToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.какСоздаватьВопросыToolStripMenuItem,
            this.документацияКСистемеToolStripMenuItem});
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.свойстваToolStripMenuItem.Text = "Свойства";
            // 
            // какСоздаватьВопросыToolStripMenuItem
            // 
            this.какСоздаватьВопросыToolStripMenuItem.Name = "какСоздаватьВопросыToolStripMenuItem";
            this.какСоздаватьВопросыToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.какСоздаватьВопросыToolStripMenuItem.Text = "Как создавать вопросы";
            this.какСоздаватьВопросыToolStripMenuItem.Click += new System.EventHandler(this.какСоздаватьВопросыToolStripMenuItem_Click);
            // 
            // документацияКСистемеToolStripMenuItem
            // 
            this.документацияКСистемеToolStripMenuItem.Name = "документацияКСистемеToolStripMenuItem";
            this.документацияКСистемеToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.документацияКСистемеToolStripMenuItem.Text = "Документация к системе";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(336, 520);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.AnswerCommbo);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.createquestion);
            this.Controls.Add(this.questionLable);
            this.Controls.Add(this.QueAnsTable);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.QueAnsTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView QueAnsTable;
        private System.Windows.Forms.Label questionLable;
        private System.Windows.Forms.Button createquestion;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox AnswerCommbo;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox AnswerText;
        private System.Windows.Forms.DataGridViewTextBoxColumn question;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какСоздаватьВопросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документацияКСистемеToolStripMenuItem;
    }
}

