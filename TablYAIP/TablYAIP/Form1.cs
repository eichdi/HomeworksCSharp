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

namespace TablYAIP
{
    public partial class Form1 : Form
    {
        string path = "people.xml";
        int idcounter;
        public int GetID
        {
            get
            {
                idcounter++;
                return idcounter;
            }
        }
        public Form1()
        {
            InitializeComponent();
            EditBox.Visible = false;
            AddBox.Visible = false;
            MainBox.Visible = true;
            //DataTable dt = (DataTable)TablPeople.DataSource;
            TablPeople.DataSource = ReadXml();
        }
        private DataTable CreateTable()
        {
            //создаём таблицу
            DataTable dt = new DataTable("People");

            //создаём колонки
            DataColumn colID = new DataColumn("id", typeof(Int32));
            DataColumn colFIO = new DataColumn("fio", typeof(String));
            DataColumn colADR = new DataColumn("address", typeof(String));
            DataColumn colNTEL = new DataColumn("ntel", typeof(String));
            DataColumn colSEX = new DataColumn("sex", typeof(String));
            DataColumn colDATARO = new DataColumn("dataro", typeof(String));
            DataColumn colMESTORO = new DataColumn("mestoro", typeof(String));

            //добавляем колонки в таблицу
            dt.Columns.Add(colID);
            dt.Columns.Add(colFIO);
            dt.Columns.Add(colADR);
            dt.Columns.Add(colNTEL);
            dt.Columns.Add(colSEX);
            dt.Columns.Add(colDATARO);
            dt.Columns.Add(colMESTORO);

            return dt;
        }

        private DataTable ReadXml()
        {
            DataTable dt = null;
            idcounter = -1;
            try
            {
                //загружаем xml файл
                XDocument xDoc = XDocument.Load(path);

                //создаём таблицу
                dt = CreateTable();

                DataRow newRow = null;

                //получаем все узлы в xml файле
                foreach (XElement elm in xDoc.Descendants("People"))
                {
                    //создаём новую запись
                    newRow = dt.NewRow();
               
                    //получаем значение атрибута
                    newRow["id"] = GetID;
                    
                    //проверяем наличие xml элемента name
                    if (elm.Element("fio") != null)
                    {
                        //получаем значения элемента name
                        newRow["fio"] = elm.Element("fio").Value;
                    }

                    if (elm.Element("address") != null)
                    {
                        newRow["address"] = elm.Element("address").Value;
                    }

                    if (elm.Element("ntel") != null)
                    {
                        newRow["ntel"] = elm.Element("ntel").Value;
                    }
                    if (elm.Element("sex") != null)
                    {
                        newRow["sex"] = elm.Element("sex").Value;
                    }
                    if (elm.Element("dataro") != null)
                    {
                        newRow["dataro"] = elm.Element("dataro").Value;
                    }
                    if (elm.Element("mestoro") != null)
                    {
                        newRow["mestoro"] = elm.Element("mestoro").Value;
                    }

                    //добавляем новую запись в таблицу
                    dt.Rows.Add(newRow);
                }
            }

            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

        private void add_Click(object sender, EventArgs e)
        {
            MainBox.Visible = false;
            AddBox.Visible = true;
        }

        private void send_Click(object sender, EventArgs e)
        {
            //get data on xml file
            DataTable dt = ReadXml();
            //add new row
            DataRow addRow = dt.NewRow();

            addRow["id"] = GetID;
            addRow["fio"] = AddFIO.Text;
            addRow["address"] = AddADDRESS.Text;
            addRow["ntel"] = AddNTEL.Text;
            addRow["sex"] = AddSEX.Text;
            addRow["dataro"] = AddDATARO.Text;
            addRow["mestoro"] = AddMESTORO.Text;

            dt.Rows.Add(addRow);

            dt.WriteXml(path);

            TablPeople.DataSource = dt;
            AddFIO.Text = "";
            AddADDRESS.Text="";
            AddNTEL.Text = "";
            AddSEX.Text = "";
            AddDATARO.Text = "";
            AddMESTORO.Text = "";
            EditBox.Visible = false;
            AddBox.Visible = false;
            MainBox.Visible = true;

        }

        

        private void edit_Click(object sender, EventArgs e)
        {
            MainBox.Visible = false;
            EditBox.Visible = true;

        }


        private void delete_Click(object sender, EventArgs e)
        {
            if (DeleteLabel.Visible == false && DeleteID.Visible == false)
            {
                DeleteLabel.Visible=true;
                DeleteID.Visible = true;
                add.Visible = false;
                edit.Visible = false;
            }
            else
            {
                int i;
                bool idnotfound = true;
                int id = int.Parse(DeleteID.Text.ToString());
                DataTable dt = ReadXml();
                DataRow[] rows = dt.Select();
                for (i = 0; i < rows.Length; i++)
                {
                    if (id == int.Parse(rows[i][0].ToString()))
                    {
                        idnotfound = false;
                        rows[i].Delete();
                    }
                }
                dt.WriteXml(path);
                TablPeople.DataSource = ReadXml();
                if (idnotfound)
                {
                    MessageBox.Show("Строки с таким id не существует");
                }
                else
                {
                    DeleteLabel.Visible = false;
                    DeleteID.Visible = false;
                    add.Visible = true;
                    edit.Visible = true;
                }
            }
            
        }
        
        private void SearchID_Click(object sender, EventArgs e)
        {

            int i;
            bool idnotfound = true;
            int id = int.Parse(IdEdit.Text.ToString());
            DataTable dt = ReadXml();
            DataRow[] rows = dt.Select();
            for (i = 0; i < rows.Length; i++)
            {
                if (id == int.Parse(rows[i][0].ToString()))
                {
                    idnotfound = false;
                    EAddFIO.Text = rows[i]["fio"].ToString();
                    EAddADDRESS.Text = rows[i]["address"].ToString();
                    EAddNTEL.Text = rows[i]["ntel"].ToString();
                    EAddSEX.Text = rows[i]["sex"].ToString();
                    EAddDATARO.Text = rows[i]["dataro"].ToString();
                    EAddMESTORO.Text = rows[i]["mestoro"].ToString();
                }
            }
            if (idnotfound)
            {
                MessageBox.Show("Строки с таким id не существует");
            }
            //rows[i].Delete();
        }

        private void ESend_Click(object sender, EventArgs e)
        {
            int i;
            bool idnotfound = true;
            int id = int.Parse(IdEdit.Text.ToString());
            DataTable dt = ReadXml();
            DataRow[] rows = dt.Select();
            for (i = 0; i < rows.Length; i++)
            {
                if (id == int.Parse(rows[i][0].ToString()))
                {
                    idnotfound = false;
                    rows[i].Delete();
                    break;
                }
            }
            if (idnotfound)
            {
                MessageBox.Show("Строки с таким id не существует");
            }
            else
            {
                TablPeople.DataSource = dt;
                dt.WriteXml(path);
                dt = ReadXml();
                DataRow EaddRow = dt.NewRow();

                EaddRow["id"] = GetID;
                EaddRow["fio"] = EAddFIO.Text;
                EaddRow["address"] = EAddADDRESS.Text;
                EaddRow["ntel"] = EAddNTEL.Text;
                EaddRow["sex"] = EAddSEX.Text;
                EaddRow["dataro"] = EAddDATARO.Text;
                EaddRow["mestoro"] = EAddMESTORO.Text;

                dt.Rows.Add(EaddRow);

                dt.WriteXml("people.xml");

                TablPeople.DataSource = dt;
                EAddFIO.Text = "";
                EAddADDRESS.Text = "";
                EAddNTEL.Text = "";
                EAddSEX.Text = "";
                EAddDATARO.Text = "";
                EAddMESTORO.Text = "";

                EditBox.Visible = false;
                AddBox.Visible = false;
                MainBox.Visible = true;
            }
        }
    }
}
