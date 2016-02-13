using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;

namespace KursWork
{
    public partial class Form1 : Form
    {
        int numNameDialogs=0;
        string[] nameDialogs = { "START", "TEST", "DOCSYS", "RATE", "END" };
        DialogsClass dialogs;
        DialogClass dialog;
        QuestionClass question;
        //private XDocument _BaseDoc;
        private bool TextOrCombo=true;
        public int _state = -1;// 0 - Start(take file) 1 - Dialog 2 - End dialog
        public DataTable dataTable;

        public string GetText
        {
            get
            {
                if (TextOrCombo)
                {
                    if (AnswerText.Text != "")
                        return AnswerText.Text;
                    else
                        return null;
                }
                else
                {
                    if (AnswerCommbo.Text != "")
                    return AnswerCommbo.Text;
                    else
                        return null;
                }
            }
        }
        public void ChooseCombo()
        {
            this.AnswerText.Visible = false;
            this.AnswerCommbo.Visible = true;
            TextOrCombo = false;
        }
        public void ChooseText()
        {
            this.AnswerText.Visible = true;
            this.AnswerCommbo.Visible = false;
            TextOrCombo = true;

        }
        public void ClearForm()
        {
            questionLable.Text = "";
            AnswerCommbo.ResetText();
            AnswerText.Text = "";
        }
        public void ShowToTable(string question, string answer)
        {



            ClearForm();
        }
        

        //0
        public void ShowOpenJson()
        {
            _state = 0;
            questionLable.Text = "Введите имя файла в котором содержится диалог";
            ChooseText();

        }
        public void OpenJson()
        {
            _state = 1;
            ChooseText();
            StreamReader sr = new StreamReader(GetText);
            string temp = sr.ReadToEnd();
            dialogs = JsonConvert.DeserializeObject<DialogsClass>(temp);
            sr.Close();
        }
        
        //1
        public void GoDialog()
        {
            bool find= false;
            for (int i = 0; i < dialogs.Dialogs.Length; i++)
            {
                if (dialogs.Dialogs[i].Name == nameDialogs[numNameDialogs])
                {
                    find = true;
                    numNameDialogs++;
                }
            }
            if (find)
            {

            }
        }

        public void JumpDialog()
        {
            switch (_state)
            {
                case -1:
                    ShowOpenJson();
                    break;
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
            
        }
        public Form1()
        {
            InitializeComponent();
            dataTable = (DataTable)QueAnsTable.DataSource;
            JumpDialog();
        }

        private void CreateQuestion_Click(object sender, EventArgs e)
        {
            CreateQuestions temp = new CreateQuestions();
            temp.Show();
        }

        private void какСоздаватьВопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpCreateQuesion temp = new HelpCreateQuesion();
            temp.Show();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            switch (_state)
            {
                
                case 0:
                    OpenJson();
                    break;
                case 1:

                    break;
                case 2:
                    break;
            }
            ShowToTable(questionLable.Text, GetText);

        }
    }
}
