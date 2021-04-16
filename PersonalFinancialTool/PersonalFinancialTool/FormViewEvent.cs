﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinancialTool
{
    public partial class FormViewEvent : Form
    {
        FinancialToolDataSet myDataSet = new FinancialToolDataSet();
        FinancialToolDataSet UserDataSet { get; set; }
        public FormViewEvent()
        {
            InitializeComponent();
        }

        private void navCreateEvent(object sender, EventArgs e)
        {
            FormCreateEvent formCreateEvent = new FormCreateEvent();
            formCreateEvent.Show();
        }

        private void FormViewEvent_Load(object sender, EventArgs e)
        {
            myDataSet.ReadXml("PersonalFinanceToolDB.xml");
            this.UserDataSet = this.myDataSet;
            this.financialToolDataSet = this.myDataSet;
            this.dataGridView1.DataSource = this.financialToolDataSet;
            this.dataGridView1.DataMember = "Events";
        }
    }
}
