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
using System.Runtime.Serialization.Json;
using System.IO;
using Newtonsoft.Json;
namespace KursWork
{
    

    //


    public partial class CreateQuestions : Form
    {
        private string _path;
        //
        private int numDialog;
        private int numQuestion;
        //
        //xml
        private XDocument _BaseDoc;
        private XElement _dialogs = new XElement("dialogs");
        private XElement _dialog;
        private XElement _question= new XElement( "question");
        //
        private string answers;
        private int _state = 0;
        //
        //json
        List<DialogClass> dialogsListJSON = new List<DialogClass>();
        DialogClass dialogJSON;
        List<QuestionClass> questionsListJSON = new List<QuestionClass>();
        QuestionClass questionJSON;
        public CreateQuestions()
        {
            InitializeComponent();
            JumpState();
        }

        //NOT WORK
        public void OpenFile()
        {
            _path = answer.Text;
            _BaseDoc = new XDocument();
            _BaseDoc.Add(new XElement("dialogs"));
            numDialog = 0;
            numQuestion = 0;
        }
        public void CreateDialog()
        {
            //xml
            numDialog++;
            _dialog = new XElement("dialog");
            _dialog.Add(new XAttribute("name", answer.Text));

            //json
            dialogJSON = new DialogClass();
            dialogJSON.Name = answer.Text;
            dialogsListJSON.Add(dialogJSON);

        }
        public void CreateQuestion()
        {
            //xml
            _question.Add(answer.Text);
            //json
            questionJSON = new QuestionClass();
            questionJSON.Question = answer.Text;
            questionsListJSON.Add(questionJSON);
        }
        public void HowAnswer(bool yes)
        {
            if (yes)
            {
                //SaveQuestion();
                _state = 6;
            }
        }
        public void Answer()
        {
            //xml
            answers += answer.Text;
            _state = 6;
            _question.Add(new XAttribute("answers", answers));

            //json
            if(answers!="")
                //questionJSON.Answers = answers.Split('#');
            answers = "";

        }
        public void SaveQuestion()
        {
            //xml
            _dialog.Add(_question);
            _question = new XElement("question");
            //_question.RemoveAll();

            //json
            dialogJSON.Questions = questionsListJSON.ToArray();
        }
        public void SaveDialog()
        {
            //xml
            _dialogs.Add(_dialog);
            //_dialog.RemoveAll();

            //json
            //dialogsJSON.Dialogs = dialogsListJSON.ToArray();
        }
        public void SaveFile()
        {
            _dialogs.Save(_path);
            //string json = JsonConvert.SerializeObject(dialogsJSON);
            StreamWriter wr = new StreamWriter(_path + ".json");
            wr.Write(json);
            wr.Flush();
            wr.Close();

        }
        public void EndTask()
        {
           // _BaseDoc.Add(_dialogs);
            SaveFile();
            this.Close();
            
            //Application.Exit();

            //TODO Доделать!

           // _BaseDoc.Save(_path);
           /* dialogsJSON.Dialogs = dialogsListJSON.ToArray();
            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(DialogsClass));
            ser.WriteObject(stream1, dialogsJSON);
            stream1.Position = 0;
            StreamWriter wr = new StreamWriter("file.json");
            
            JsonReaderWriterFactory.CreateJsonWriter(stream1);*/
        }



        /*Stages*/
        //1
        public void State_OpenFile()
        {
            answer.Visible = true;
            OkAndYes.Visible = true;
            NextAndNo.Visible = false;
            OkAndYes.Text = "Да";
            questionLable.Text = "Введите путь к файлу где вы хотите создать диалоговые вопросы";

        }
        //2
        public void State_CreateDialog()
        {
            answer.Visible = true;
            NextAndNo.Visible = false;
            //NextAndNo.Text = string;
            OkAndYes.Visible = true;
            OkAndYes.Text = "OK";
            questionLable.Text = "Введите название диалога";
        }
        //3
        public void State_CreateQuestion()
        {

            answer.Visible = true;

            NextAndNo.Visible = false;
            OkAndYes.Visible = true;
            OkAndYes.Text = "OK";
            questionLable.Text = "Введите название вопроса";
        }
        //4
        public void State_HowAnswer()
        {
            answer.Visible = false;
            OkAndYes.Visible = true;
            NextAndNo.Visible = true;
            questionLable.Text = "Свободный ввод ответа или Выбор варианта  ответа";
            OkAndYes.Text = "Свободный";
            NextAndNo.Text = "Выбор ответа";
        }
        //5
        public void State_Answer()
        {

            answer.Visible = true;
            OkAndYes.Visible = true;
            NextAndNo.Visible = true;
            questionLable.Text = "Введите вариант ответа";
            OkAndYes.Text = "ОK";
            NextAndNo.Text = "Следущий варинт ответа";
        }
        //6
        public void State_AddQuestion()
        {
            answer.Visible = false;
            OkAndYes.Visible = true;
            NextAndNo.Visible = true;
            questionLable.Text = "Ввести еще вопрос?";
            OkAndYes.Text = "Да";
            NextAndNo.Text = "Нет";
        }
        //7
        public void State_AddDialog()
        {
            answer.Visible = false;
            OkAndYes.Visible = true;
            NextAndNo.Visible = true;
            questionLable.Text = "Создать еще диалог?";
            OkAndYes.Text = "Да";
            NextAndNo.Text = "Нет";
        }
        //8
        public void State_End()
        {
            answer.Visible = false;
            OkAndYes.Visible = true;
            NextAndNo.Visible = true;
            SaveFile();
            questionLable.Text = "Диалог сохранен\nЗавершить работу программы?";
            OkAndYes.Text = "Да";
            NextAndNo.Text = "Нет";
        }
        //\NOT WORK
        /*/Stages*/


        public void JumpState(bool next = false)
        {
            switch (_state)
            {
                case 0:
                    _state = 1;
                    State_OpenFile();
                    break;
                case 1:
                    _state = 2;
                    State_CreateDialog();
                    break;
                case 2:
                    _state = 3;
                    State_CreateQuestion();
                    break;
                case 3:
                    _state = 4;
                    State_HowAnswer();
                    break;
                case 4:
                    State_Answer();
                    break;
                case 5:
                    State_Answer();
                    break;
                case 6:

                    State_AddQuestion();
                    break;
                case 7:
                    State_AddDialog();
                    break;
                case 8:
                    State_End();
                    break;

            }
            answer.Text = "";
        }


        private void OkAndYes_Click(object sender, EventArgs e)
        {
            switch (_state)
            {
                case 1:
                    OpenFile();
                    break;
                case 2:
                    CreateDialog();
                    break;
                case 3:
                    CreateQuestion();
                    break;
                case 4:
                    HowAnswer(true);
                    break;
                case 5:
                    Answer();
                    break;
                case 6:
                    SaveQuestion();
                    _state = 2;
                    break;
                case 7:
                    _state = 1;
                    SaveDialog();
                    break;
                case 8:
                    EndTask();
                    break;

            }
            JumpState();

        }


        private void NextAndNo_Click(object sender, EventArgs e)
        {
            switch (_state)
            {
                case 4:
                    HowAnswer(false);
                    _state = 5;
                    break;
                case 5:
                    answers += answer.Text + "#";
                    break;
                case 6:
                    _state = 7;
                    SaveQuestion();
                    break;
                case 7:
                    _state = 8;
                    SaveDialog();
                    break;

                case 8:
                    _state = 0;
                    break;

            }
            JumpState();

        }

        private void какСоздаватьДиалогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpCreateQuesion temp = new HelpCreateQuesion();
            temp.Show();
        }

    }
}
