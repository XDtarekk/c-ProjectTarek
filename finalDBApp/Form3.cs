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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\dbFinalTarek\finalDB.accdb";
                OleDbConnection conDataBase = new OleDbConnection(constring);
                String x = textBox1.Text;

                OleDbCommand cmdSelectParcel = new OleDbCommand("Select * from Patient where PID ='" + x + "'", conDataBase);

                OleDbDataReader myReader;

                conDataBase.Open();
                myReader = cmdSelectParcel.ExecuteReader();
                while (myReader.Read())
                {

                    string SSN = "" + myReader.GetValue(0);
                    string Name = "" + myReader.GetValue(1);
                    string DOB = "" + myReader.GetValue(2);
                    string Address = "" + myReader.GetValue(3);
                    string tel = "" + myReader.GetValue(4);
                    string AID = "" + myReader.GetValue(5);
                    String X = SSN + "\n" + Name + "\n" + DOB;
                    richTextBox1.Text = X;

                }
                conDataBase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
