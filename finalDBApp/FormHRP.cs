﻿using System;
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
    public partial class FormHRP : Form
    {
        public FormHRP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PID = textBox1.Text;
            string rank = textBox6.Text;

            try
            {
                string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\dbFinalTarek\finalDB.accdb";
                OleDbConnection conDataBase = new OleDbConnection(constring);
                OleDbCommand cmdSelectParcel = new OleDbCommand("INSERT INTO DoctorHospital VALUES ('" + PID + rank + "')", conDataBase);
                OleDbDataReader myReader;
                MessageBox.Show("HRP Added Successfully!");
                conDataBase.Open();
                myReader = cmdSelectParcel.ExecuteReader();
                while (myReader.Read())
                {
                    string Sssn = "" + myReader.GetValue(0);
                    string Said = "" + myReader.GetValue(1);

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
