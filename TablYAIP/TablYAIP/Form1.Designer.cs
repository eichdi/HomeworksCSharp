namespace TablYAIP
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
            this.TablPeople = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.MainBox = new System.Windows.Forms.GroupBox();
            this.DeleteID = new System.Windows.Forms.TextBox();
            this.DeleteLabel = new System.Windows.Forms.Label();
            this.Box = new System.Windows.Forms.GroupBox();
            this.AddADDRESS = new System.Windows.Forms.TextBox();
            this.AddNTEL = new System.Windows.Forms.TextBox();
            this.AddSEX = new System.Windows.Forms.TextBox();
            this.AddDATARO = new System.Windows.Forms.TextBox();
            this.AddMESTORO = new System.Windows.Forms.TextBox();
            this.AddFIO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablPeople)).BeginInit();
            this.MainBox.SuspendLayout();
            this.Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablPeople
            // 
            this.TablPeople.AllowUserToAddRows = false;
            this.TablPeople.AllowUserToDeleteRows = false;
            this.TablPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablPeople.Location = new System.Drawing.Point(1, 0);
            this.TablPeople.Name = "TablPeople";
            this.TablPeople.ReadOnly = true;
            this.TablPeople.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TablPeople.RowHeadersWidth = 20;
            this.TablPeople.Size = new System.Drawing.Size(580, 225);
            this.TablPeople.TabIndex = 0;
            this.TablPeople.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablPeople_RowEnter);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(1, 234);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(191, 34);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(198, 234);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(191, 34);
            this.edit.TabIndex = 2;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(395, 234);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(191, 34);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // MainBox
            // 
            this.MainBox.Controls.Add(this.DeleteID);
            this.MainBox.Controls.Add(this.delete);
            this.MainBox.Controls.Add(this.DeleteLabel);
            this.MainBox.Controls.Add(this.edit);
            this.MainBox.Controls.Add(this.add);
            this.MainBox.Controls.Add(this.TablPeople);
            this.MainBox.Location = new System.Drawing.Point(15, 6);
            this.MainBox.Name = "MainBox";
            this.MainBox.Size = new System.Drawing.Size(594, 330);
            this.MainBox.TabIndex = 4;
            this.MainBox.TabStop = false;
            this.MainBox.Text = "groupBox1";
            // 
            // DeleteID
            // 
            this.DeleteID.Location = new System.Drawing.Point(395, 283);
            this.DeleteID.Name = "DeleteID";
            this.DeleteID.Size = new System.Drawing.Size(185, 20);
            this.DeleteID.TabIndex = 4;
            this.DeleteID.Visible = false;
            this.DeleteID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeleteID_KeyPress);
            // 
            // DeleteLabel
            // 
            this.DeleteLabel.AutoSize = true;
            this.DeleteLabel.Location = new System.Drawing.Point(123, 286);
            this.DeleteLabel.Name = "DeleteLabel";
            this.DeleteLabel.Size = new System.Drawing.Size(248, 13);
            this.DeleteLabel.TabIndex = 5;
            this.DeleteLabel.Text = "Введитe id человека которого желаете удалить";
            this.DeleteLabel.Visible = false;
            // 
            // Box
            // 
            this.Box.Controls.Add(this.AddADDRESS);
            this.Box.Controls.Add(this.AddNTEL);
            this.Box.Controls.Add(this.AddSEX);
            this.Box.Controls.Add(this.AddDATARO);
            this.Box.Controls.Add(this.AddMESTORO);
            this.Box.Controls.Add(this.AddFIO);
            this.Box.Controls.Add(this.label6);
            this.Box.Controls.Add(this.label5);
            this.Box.Controls.Add(this.label4);
            this.Box.Controls.Add(this.label3);
            this.Box.Controls.Add(this.label2);
            this.Box.Controls.Add(this.label1);
            this.Box.Controls.Add(this.send);
            this.Box.Location = new System.Drawing.Point(7, 6);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(602, 389);
            this.Box.TabIndex = 6;
            this.Box.TabStop = false;
            this.Box.Text = "Box";
            // 
            // AddADDRESS
            // 
            this.AddADDRESS.Location = new System.Drawing.Point(98, 75);
            this.AddADDRESS.Name = "AddADDRESS";
            this.AddADDRESS.Size = new System.Drawing.Size(162, 20);
            this.AddADDRESS.TabIndex = 12;
            // 
            // AddNTEL
            // 
            this.AddNTEL.Location = new System.Drawing.Point(98, 125);
            this.AddNTEL.Name = "AddNTEL";
            this.AddNTEL.Size = new System.Drawing.Size(162, 20);
            this.AddNTEL.TabIndex = 11;
            // 
            // AddSEX
            // 
            this.AddSEX.Location = new System.Drawing.Point(98, 167);
            this.AddSEX.Name = "AddSEX";
            this.AddSEX.Size = new System.Drawing.Size(162, 20);
            this.AddSEX.TabIndex = 10;
            // 
            // AddDATARO
            // 
            this.AddDATARO.Location = new System.Drawing.Point(98, 215);
            this.AddDATARO.Name = "AddDATARO";
            this.AddDATARO.Size = new System.Drawing.Size(162, 20);
            this.AddDATARO.TabIndex = 9;
            // 
            // AddMESTORO
            // 
            this.AddMESTORO.Location = new System.Drawing.Point(98, 270);
            this.AddMESTORO.Name = "AddMESTORO";
            this.AddMESTORO.Size = new System.Drawing.Size(162, 20);
            this.AddMESTORO.TabIndex = 8;
            // 
            // AddFIO
            // 
            this.AddFIO.Location = new System.Drawing.Point(98, 31);
            this.AddFIO.Name = "AddFIO";
            this.AddFIO.Size = new System.Drawing.Size(162, 20);
            this.AddFIO.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "MESTORO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DATARO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SEX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NTEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADDRESS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FIO";
            // 
            // send
            // 
            this.send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.send.Location = new System.Drawing.Point(505, 336);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(82, 27);
            this.send.TabIndex = 0;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 407);
            this.Controls.Add(this.MainBox);
            this.Controls.Add(this.Box);
            this.Name = "Form1";
            this.Text = "Таблица людей";
            ((System.ComponentModel.ISupportInitialize)(this.TablPeople)).EndInit();
            this.MainBox.ResumeLayout(false);
            this.MainBox.PerformLayout();
            this.Box.ResumeLayout(false);
            this.Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablPeople;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.GroupBox MainBox;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.TextBox AddADDRESS;
        private System.Windows.Forms.TextBox AddNTEL;
        private System.Windows.Forms.TextBox AddSEX;
        private System.Windows.Forms.TextBox AddDATARO;
        private System.Windows.Forms.TextBox AddMESTORO;
        private System.Windows.Forms.TextBox AddFIO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox DeleteID;
        private System.Windows.Forms.Label DeleteLabel;

    }
}

