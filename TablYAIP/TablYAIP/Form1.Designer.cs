﻿namespace TablYAIP
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
            this.AddBox = new System.Windows.Forms.GroupBox();
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
            this.EditBox = new System.Windows.Forms.GroupBox();
            this.SearchID = new System.Windows.Forms.Button();
            this.IdEdit = new System.Windows.Forms.TextBox();
            this.EAddADDRESS = new System.Windows.Forms.TextBox();
            this.EAddNTEL = new System.Windows.Forms.TextBox();
            this.EAddSEX = new System.Windows.Forms.TextBox();
            this.EAddDATARO = new System.Windows.Forms.TextBox();
            this.EAddMESTORO = new System.Windows.Forms.TextBox();
            this.EAddFIO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ESend = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablPeople)).BeginInit();
            this.MainBox.SuspendLayout();
            this.AddBox.SuspendLayout();
            this.EditBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablPeople
            // 
            this.TablPeople.AllowUserToAddRows = false;
            this.TablPeople.AllowUserToDeleteRows = false;
            this.TablPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablPeople.Location = new System.Drawing.Point(1, 3);
            this.TablPeople.Name = "TablPeople";
            this.TablPeople.ReadOnly = true;
            this.TablPeople.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TablPeople.RowHeadersWidth = 20;
            this.TablPeople.Size = new System.Drawing.Size(580, 222);
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
            this.MainBox.Location = new System.Drawing.Point(15, 12);
            this.MainBox.Name = "MainBox";
            this.MainBox.Size = new System.Drawing.Size(594, 324);
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
            // AddBox
            // 
            this.AddBox.Controls.Add(this.AddADDRESS);
            this.AddBox.Controls.Add(this.AddNTEL);
            this.AddBox.Controls.Add(this.AddSEX);
            this.AddBox.Controls.Add(this.AddDATARO);
            this.AddBox.Controls.Add(this.AddMESTORO);
            this.AddBox.Controls.Add(this.AddFIO);
            this.AddBox.Controls.Add(this.label6);
            this.AddBox.Controls.Add(this.label5);
            this.AddBox.Controls.Add(this.label4);
            this.AddBox.Controls.Add(this.label3);
            this.AddBox.Controls.Add(this.label2);
            this.AddBox.Controls.Add(this.label1);
            this.AddBox.Controls.Add(this.send);
            this.AddBox.Location = new System.Drawing.Point(7, 6);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(602, 389);
            this.AddBox.TabIndex = 6;
            this.AddBox.TabStop = false;
            this.AddBox.Text = "AddBox";
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
            // EditBox
            // 
            this.EditBox.Controls.Add(this.SearchID);
            this.EditBox.Controls.Add(this.IdEdit);
            this.EditBox.Controls.Add(this.EAddADDRESS);
            this.EditBox.Controls.Add(this.EAddNTEL);
            this.EditBox.Controls.Add(this.EAddSEX);
            this.EditBox.Controls.Add(this.EAddDATARO);
            this.EditBox.Controls.Add(this.EAddMESTORO);
            this.EditBox.Controls.Add(this.EAddFIO);
            this.EditBox.Controls.Add(this.label7);
            this.EditBox.Controls.Add(this.label8);
            this.EditBox.Controls.Add(this.label9);
            this.EditBox.Controls.Add(this.label10);
            this.EditBox.Controls.Add(this.label12);
            this.EditBox.Controls.Add(this.ESend);
            this.EditBox.Controls.Add(this.label11);
            this.EditBox.Location = new System.Drawing.Point(7, 12);
            this.EditBox.Name = "EditBox";
            this.EditBox.Size = new System.Drawing.Size(602, 383);
            this.EditBox.TabIndex = 13;
            this.EditBox.TabStop = false;
            this.EditBox.Text = "EditBox";
            // 
            // SearchID
            // 
            this.SearchID.Location = new System.Drawing.Point(524, 75);
            this.SearchID.Name = "SearchID";
            this.SearchID.Size = new System.Drawing.Size(62, 20);
            this.SearchID.TabIndex = 14;
            this.SearchID.Text = "SearchID";
            this.SearchID.UseVisualStyleBackColor = true;
            this.SearchID.Click += new System.EventHandler(this.SearchID_Click);
            // 
            // IdEdit
            // 
            this.IdEdit.BackColor = System.Drawing.SystemColors.Menu;
            this.IdEdit.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdEdit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IdEdit.Location = new System.Drawing.Point(447, 30);
            this.IdEdit.Name = "IdEdit";
            this.IdEdit.Size = new System.Drawing.Size(139, 20);
            this.IdEdit.TabIndex = 13;
            this.IdEdit.Tag = "";
            this.IdEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdEdit_KeyPress);
            // 
            // EAddADDRESS
            // 
            this.EAddADDRESS.Location = new System.Drawing.Point(98, 75);
            this.EAddADDRESS.Name = "EAddADDRESS";
            this.EAddADDRESS.Size = new System.Drawing.Size(162, 20);
            this.EAddADDRESS.TabIndex = 12;
            // 
            // EAddNTEL
            // 
            this.EAddNTEL.Location = new System.Drawing.Point(98, 125);
            this.EAddNTEL.Name = "EAddNTEL";
            this.EAddNTEL.Size = new System.Drawing.Size(162, 20);
            this.EAddNTEL.TabIndex = 11;
            // 
            // EAddSEX
            // 
            this.EAddSEX.Location = new System.Drawing.Point(98, 167);
            this.EAddSEX.Name = "EAddSEX";
            this.EAddSEX.Size = new System.Drawing.Size(162, 20);
            this.EAddSEX.TabIndex = 10;
            // 
            // EAddDATARO
            // 
            this.EAddDATARO.Location = new System.Drawing.Point(98, 215);
            this.EAddDATARO.Name = "EAddDATARO";
            this.EAddDATARO.Size = new System.Drawing.Size(162, 20);
            this.EAddDATARO.TabIndex = 9;
            // 
            // EAddMESTORO
            // 
            this.EAddMESTORO.Location = new System.Drawing.Point(98, 270);
            this.EAddMESTORO.Name = "EAddMESTORO";
            this.EAddMESTORO.Size = new System.Drawing.Size(162, 20);
            this.EAddMESTORO.TabIndex = 8;
            // 
            // EAddFIO
            // 
            this.EAddFIO.Location = new System.Drawing.Point(98, 31);
            this.EAddFIO.Name = "EAddFIO";
            this.EAddFIO.Size = new System.Drawing.Size(162, 20);
            this.EAddFIO.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "MESTORO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "DATARO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "SEX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "NTEL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "FIO";
            // 
            // ESend
            // 
            this.ESend.Location = new System.Drawing.Point(505, 336);
            this.ESend.Name = "ESend";
            this.ESend.Size = new System.Drawing.Size(82, 27);
            this.ESend.TabIndex = 0;
            this.ESend.Text = "Send";
            this.ESend.UseVisualStyleBackColor = true;
            this.ESend.Click += new System.EventHandler(this.ESend_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "ADDRESS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 407);
            this.Controls.Add(this.MainBox);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.EditBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TablPeople)).EndInit();
            this.MainBox.ResumeLayout(false);
            this.MainBox.PerformLayout();
            this.AddBox.ResumeLayout(false);
            this.AddBox.PerformLayout();
            this.EditBox.ResumeLayout(false);
            this.EditBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablPeople;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.GroupBox MainBox;
        private System.Windows.Forms.GroupBox AddBox;
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
        private System.Windows.Forms.GroupBox EditBox;
        private System.Windows.Forms.TextBox EAddADDRESS;
        private System.Windows.Forms.TextBox EAddNTEL;
        private System.Windows.Forms.TextBox EAddSEX;
        private System.Windows.Forms.TextBox EAddDATARO;
        private System.Windows.Forms.TextBox EAddMESTORO;
        private System.Windows.Forms.TextBox EAddFIO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ESend;
        private System.Windows.Forms.TextBox IdEdit;
        private System.Windows.Forms.Button SearchID;
        private System.Windows.Forms.TextBox DeleteID;
        private System.Windows.Forms.Label DeleteLabel;

    }
}
