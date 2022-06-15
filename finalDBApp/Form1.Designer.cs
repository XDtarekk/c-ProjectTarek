
namespace finalDBApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.covidTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docHospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hRPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lRPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patHospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCRHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCRPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numOfPatientsInHospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numOfPatientsVsHospitalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.searchPatientToolStripMenuItem,
            this.pCRHistoryToolStripMenuItem,
            this.pCRPaymentsToolStripMenuItem,
            this.numOfPatientsInHospitalToolStripMenuItem,
            this.numOfPatientsVsHospitalsToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.projectToolStripMenuItem.Text = "project";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.covidTestToolStripMenuItem,
            this.pCRToolStripMenuItem,
            this.rtestToolStripMenuItem,
            this.docAreaToolStripMenuItem,
            this.docHospitalToolStripMenuItem,
            this.hRPToolStripMenuItem,
            this.lRPToolStripMenuItem,
            this.patDocToolStripMenuItem,
            this.patHospitalToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.addToolStripMenuItem.Text = "add";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.patientToolStripMenuItem.Text = "patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.areaToolStripMenuItem.Text = "Area";
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.doctorToolStripMenuItem.Text = "Doctor";
            this.doctorToolStripMenuItem.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // covidTestToolStripMenuItem
            // 
            this.covidTestToolStripMenuItem.Name = "covidTestToolStripMenuItem";
            this.covidTestToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.covidTestToolStripMenuItem.Text = "CovidTest";
            this.covidTestToolStripMenuItem.Click += new System.EventHandler(this.covidTestToolStripMenuItem_Click);
            // 
            // pCRToolStripMenuItem
            // 
            this.pCRToolStripMenuItem.Name = "pCRToolStripMenuItem";
            this.pCRToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.pCRToolStripMenuItem.Text = "PCR";
            this.pCRToolStripMenuItem.Click += new System.EventHandler(this.pCRToolStripMenuItem_Click);
            // 
            // rtestToolStripMenuItem
            // 
            this.rtestToolStripMenuItem.Name = "rtestToolStripMenuItem";
            this.rtestToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.rtestToolStripMenuItem.Text = "Rtest";
            this.rtestToolStripMenuItem.Click += new System.EventHandler(this.rtestToolStripMenuItem_Click);
            // 
            // docAreaToolStripMenuItem
            // 
            this.docAreaToolStripMenuItem.Name = "docAreaToolStripMenuItem";
            this.docAreaToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.docAreaToolStripMenuItem.Text = "DocArea";
            this.docAreaToolStripMenuItem.Click += new System.EventHandler(this.docAreaToolStripMenuItem_Click);
            // 
            // docHospitalToolStripMenuItem
            // 
            this.docHospitalToolStripMenuItem.Name = "docHospitalToolStripMenuItem";
            this.docHospitalToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.docHospitalToolStripMenuItem.Text = "DocHospital";
            this.docHospitalToolStripMenuItem.Click += new System.EventHandler(this.docHospitalToolStripMenuItem_Click);
            // 
            // hRPToolStripMenuItem
            // 
            this.hRPToolStripMenuItem.Name = "hRPToolStripMenuItem";
            this.hRPToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.hRPToolStripMenuItem.Text = "HRP";
            this.hRPToolStripMenuItem.Click += new System.EventHandler(this.hRPToolStripMenuItem_Click);
            // 
            // lRPToolStripMenuItem
            // 
            this.lRPToolStripMenuItem.Name = "lRPToolStripMenuItem";
            this.lRPToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.lRPToolStripMenuItem.Text = "LRP";
            this.lRPToolStripMenuItem.Click += new System.EventHandler(this.lRPToolStripMenuItem_Click);
            // 
            // patDocToolStripMenuItem
            // 
            this.patDocToolStripMenuItem.Name = "patDocToolStripMenuItem";
            this.patDocToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.patDocToolStripMenuItem.Text = "PatDoc";
            this.patDocToolStripMenuItem.Click += new System.EventHandler(this.patDocToolStripMenuItem_Click);
            // 
            // patHospitalToolStripMenuItem
            // 
            this.patHospitalToolStripMenuItem.Name = "patHospitalToolStripMenuItem";
            this.patHospitalToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.patHospitalToolStripMenuItem.Text = "PatHospital";
            this.patHospitalToolStripMenuItem.Click += new System.EventHandler(this.patHospitalToolStripMenuItem_Click);
            // 
            // searchPatientToolStripMenuItem
            // 
            this.searchPatientToolStripMenuItem.Name = "searchPatientToolStripMenuItem";
            this.searchPatientToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.searchPatientToolStripMenuItem.Text = "search patient";
            this.searchPatientToolStripMenuItem.Click += new System.EventHandler(this.searchPatientToolStripMenuItem_Click);
            // 
            // pCRHistoryToolStripMenuItem
            // 
            this.pCRHistoryToolStripMenuItem.Name = "pCRHistoryToolStripMenuItem";
            this.pCRHistoryToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.pCRHistoryToolStripMenuItem.Text = "PCR history";
            this.pCRHistoryToolStripMenuItem.Click += new System.EventHandler(this.pCRHistoryToolStripMenuItem_Click);
            // 
            // pCRPaymentsToolStripMenuItem
            // 
            this.pCRPaymentsToolStripMenuItem.Name = "pCRPaymentsToolStripMenuItem";
            this.pCRPaymentsToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.pCRPaymentsToolStripMenuItem.Text = "PCR payments";
            this.pCRPaymentsToolStripMenuItem.Click += new System.EventHandler(this.pCRPaymentsToolStripMenuItem_Click);
            // 
            // numOfPatientsInHospitalToolStripMenuItem
            // 
            this.numOfPatientsInHospitalToolStripMenuItem.Name = "numOfPatientsInHospitalToolStripMenuItem";
            this.numOfPatientsInHospitalToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.numOfPatientsInHospitalToolStripMenuItem.Text = "num of patients in hospital";
            this.numOfPatientsInHospitalToolStripMenuItem.Click += new System.EventHandler(this.numOfPatientsInHospitalToolStripMenuItem_Click);
            // 
            // numOfPatientsVsHospitalsToolStripMenuItem
            // 
            this.numOfPatientsVsHospitalsToolStripMenuItem.Name = "numOfPatientsVsHospitalsToolStripMenuItem";
            this.numOfPatientsVsHospitalsToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.numOfPatientsVsHospitalsToolStripMenuItem.Text = "num of patients vs hospitals";
            this.numOfPatientsVsHospitalsToolStripMenuItem.Click += new System.EventHandler(this.numOfPatientsVsHospitalsToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem1});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem1
            // 
            this.patientToolStripMenuItem1.Name = "patientToolStripMenuItem1";
            this.patientToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.patientToolStripMenuItem1.Text = "patient";
            this.patientToolStripMenuItem1.Click += new System.EventHandler(this.patientToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem covidTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rtestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docHospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hRPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lRPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patHospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCRHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCRPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numOfPatientsInHospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numOfPatientsVsHospitalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem1;
    }
}

