using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace finalDBApp
{
    public partial class FormCovid : Form
    {
        public FormCovid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TID = textBox1.Text;
            string date = textBox2.Text;
            string price = textBox3.Text;
            string result = textBox4.Text;
            string HID = textBox5.Text;
            string PID = textBox6.Text;
            string type = textBox7.Text;

            try
            {
                string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\dbFinalTarek\finalDB.accdb";
                OleDbConnection conDataBase = new OleDbConnection(constring);
                OleDbCommand cmdSelectParcel = new OleDbCommand("INSERT INTO CovidTest VALUES ('" + TID + "','" + date + "','" + price + "','" + result + "','" + HID + "','" + PID + "','" + type + "')", conDataBase);
                OleDbDataReader myReader;
                MessageBox.Show("Employee Added Successfully!");
                conDataBase.Open();
                myReader = cmdSelectParcel.ExecuteReader();
                while (myReader.Read())
                {
                    string Sssn = "" + myReader.GetValue(0);
                    string Sname = "" + myReader.GetValue(1);
                    string SDOB = "" + myReader.GetValue(2);
                    string Saddress = "" + myReader.GetValue(3);
                    string Stel = "" + myReader.GetValue(4);
                    string Said = "" + myReader.GetValue(5);
                    string Stype = "" + myReader.GetValue(6);

                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
