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
    public partial class FormArea : Form
    {
        public FormArea()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AID = textBox1.Text;
            string Name = textBox2.Text;
            string state = textBox3.Text;
            int pop = int.Parse(textBox4.Text);
           

            try
            {
                string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\dbFinalTarek\finalDB.accdb";
                OleDbConnection conDataBase = new OleDbConnection(constring);
                OleDbCommand cmdSelectParcel = new OleDbCommand("INSERT INTO Area VALUES ('" + AID + "','" + Name + "','" + state + "','" + pop + "')", conDataBase);
                OleDbDataReader myReader;
                MessageBox.Show("Area Added Successfully!");
                conDataBase.Open();
                myReader = cmdSelectParcel.ExecuteReader();
                while (myReader.Read())
                {
                    string Said = "" + myReader.GetValue(0);
                    string Sname = "" + myReader.GetValue(1);
                    string Sstate = "" + myReader.GetValue(2);
                    string Spop = "" + myReader.GetValue(3);

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
