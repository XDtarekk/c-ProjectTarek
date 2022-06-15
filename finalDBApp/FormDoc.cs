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
    public partial class FormDoc : Form
    {
        public FormDoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SSN = textBox1.Text;
            string Name = textBox2.Text;
            string DOB = textBox3.Text;
            string Address = textBox4.Text;
            int tel = int.Parse(textBox5.Text);
            

            try
            {
                string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\dbFinalTarek\finalDB.accdb";
                OleDbConnection conDataBase = new OleDbConnection(constring);
                OleDbCommand cmdSelectParcel = new OleDbCommand("INSERT INTO Doctor VALUES ('" + SSN + "','" + Name + "','" + DOB + "','" + Address + "','" + tel + "')", conDataBase);
                OleDbDataReader myReader;
                MessageBox.Show("Doctor Added Successfully!");
                conDataBase.Open();
                myReader = cmdSelectParcel.ExecuteReader();
                while (myReader.Read())
                {
                    string Sssn = "" + myReader.GetValue(0);
                    string Sname = "" + myReader.GetValue(1);
                    string SDOB = "" + myReader.GetValue(2);
                    string Saddress = "" + myReader.GetValue(3);
                    string Stel = "" + myReader.GetValue(4);
                    

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
