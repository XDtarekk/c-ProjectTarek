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
    public partial class FormPCRpayments : Form
    {
        public FormPCRpayments()
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

                OleDbCommand cmdSelectParcel = new OleDbCommand("SELECT ct.Price FROM CovidTest AS ct, PCR AS p WHERE p.TID = ct.TID AND ct.PID ='" + x + "'", conDataBase);

                OleDbDataReader myReader;

                conDataBase.Open();
                myReader = cmdSelectParcel.ExecuteReader();
                while (myReader.Read())
                {

                    string SSN = "" + myReader.GetValue(0);
                    String X = SSN + "\n";
                    richTextBox1.Text = X;

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
