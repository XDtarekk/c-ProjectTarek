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
    public partial class FormPCR : Form
    {
        public FormPCR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TID = textBox1.Text;
            int DNAP = int.Parse(textBox2.Text);
            int TP = int.Parse(textBox3.Text);

            try
            {
                string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\dbFinalTarek\finalDB.accdb";
                OleDbConnection conDataBase = new OleDbConnection(constring);
                OleDbCommand cmdSelectParcel = new OleDbCommand("INSERT INTO Patient VALUES ('" + TID + "','" + DNAP + "','" + TP + "')", conDataBase);
                OleDbDataReader myReader;
                MessageBox.Show("PCR Added Successfully!");
                conDataBase.Open();
                myReader = cmdSelectParcel.ExecuteReader();
                while (myReader.Read())
                {
                    string Sssn = "" + myReader.GetValue(0);
                    string Sname = "" + myReader.GetValue(1);
                    string SDOB = "" + myReader.GetValue(2);

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
