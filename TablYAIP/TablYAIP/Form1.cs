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
        int thisid = 0;
        string path = "people.xml";
        bool isedit=false;
        bool enterrow = false;


        public bool IsNat(string a)
        {
            if (a.Length != 0)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (!(a[i] >= '0' && a[i] <= '9'))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
                return false;
        }

        public Form1()
        {
            InitializeComponent();
            Box.Visible = false;
            MainBox.Visible = true;
            //DataTable dt = (DataTable)TablPeople.DataSource;
            TablPeople.DataSource = ReadXml();
            enterrow = false;
        }

        private DataTable CreateTable()
        {
            //создаём таблицу
            DataTable dt = new DataTable("People");

            //создаём колонки
            DataColumn colFIO = new DataColumn("fio", typeof(String));
            DataColumn colADR = new DataColumn("address", typeof(String));
            DataColumn colNTEL = new DataColumn("ntel", typeof(String));
            DataColumn colSEX = new DataColumn("sex", typeof(String));
            DataColumn colDATARO = new DataColumn("dataro", typeof(String));
            DataColumn colMESTORO = new DataColumn("mestoro", typeof(String));

            //добавляем колонки в таблицу
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
                Box.Visible = true;
            
            
            }

        private void send_Click(object sender, EventArgs e)
        {
            //get data on xml file
            DataTable dt = (DataTable)TablPeople.DataSource;
            //add new row
            if (isedit)
            {
                dt.Rows.RemoveAt(thisid);
                isedit = false;
            }
            DataRow addRow = dt.NewRow();

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
            Box.Visible = false;
            MainBox.Visible = true;
            enterrow = false;

        }

        private void edit_Click(object sender, EventArgs e)
        {
            
            //Дописать
            if (enterrow)
            {
                DataTable dt = (DataTable)TablPeople.DataSource;
                AddFIO.Text = TablPeople[0, thisid].Value.ToString();
                AddADDRESS.Text = TablPeople[1, thisid].Value.ToString();
                AddNTEL.Text = TablPeople[2, thisid].Value.ToString();
                AddSEX.Text = TablPeople[3, thisid].Value.ToString();
                AddDATARO.Text = TablPeople[4, thisid].Value.ToString();
                AddMESTORO.Text = TablPeople[5, thisid].Value.ToString();
                isedit = true;
                add_Click(sender, e);
            }
            else
                MessageBox.Show("Select row");

            

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (enterrow)
            {
                TablPeople.Refresh();
                DataTable dt = (DataTable)TablPeople.DataSource;
                dt.Rows.RemoveAt(thisid);
                dt.WriteXml(path);
                TablPeople.DataSource = dt;
                TablPeople.Refresh();
                enterrow = false;
            }
            else
                MessageBox.Show("Select row");

        }

        private void DeleteID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((char) Keys.Enter == e.KeyChar)
                delete_Click(sender, e);
        }

        private void TablPeople_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            thisid = e.RowIndex;
            enterrow = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            AddFIO.Text = "";
            AddADDRESS.Text = "";
            AddNTEL.Text = "";
            AddSEX.Text = "";
            AddDATARO.Text = "";
            AddMESTORO.Text = "";
            Box.Visible = false;
            MainBox.Visible = true;
            enterrow = false;
        }

        
    }
}
