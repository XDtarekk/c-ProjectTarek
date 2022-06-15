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
    public partial class FormPatVShos : Form
    {
        public FormPatVShos()
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

                OleDbCommand cmdSelectParcel = new OleDbCommand("SELECT count(*) FROM Patient AS p, Area AS a WHERE p.AID = a.AID AND a.AID  ='" + x + "'", conDataBase);

                OleDbDataReader myReader;

                conDataBase.Open();
                myReader = cmdSelectParcel.ExecuteReader();
                while (myReader.Read())
                {

                    string SSN = "" + myReader.GetValue(0);
                    String X = SSN + "\n";
                    richTextBox1.Text = X;

                }

                OleDbCommand cmdSelectParcel2 = new OleDbCommand("SELECT count(*) FROM Hostpital AS h, Area AS a WHERE h.AID = a.AID AND a.AID  ='" + x + "'", conDataBase);

                OleDbDataReader myReader2;

                //conDataBase.Open();
                myReader2 = cmdSelectParcel2.ExecuteReader();
                while (myReader2.Read())
                {

                    string SSN = "" + myReader2.GetValue(0);
                    String X = SSN + "\n";
                    richTextBox2.Text = X;

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
