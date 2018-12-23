using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using dasData;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace DasDataCtrl_WinForms_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAKey.Text = "a09075165g-2f343fe-485a-8276-02574c41c94";
            txtDSKey.Text = "bf082e44-7945-48b5-8016-8b94365ce8d2";
        }

        private void btnTestMe_Click(object sender, EventArgs e)
        {
            try
            { 
                das _myDas = new das();
                 object _dasResult = _myDas.getDas(Convert.ToString(txtDSKey.Text), "json", "0", "100");
                //RECEIVE DATA - JSON / XML
                // latest 100 values :: "json", 0, 100    
                // based on interval dfrom / dto :: "jsond", 23.12.2013, 14.01.2014   
                //  _myDas.getDas(_dKey, "jsond", "23.12.2013", "14.01.2014")
                // _myDas.getDas(_dKey, "xml", 0, 100)
                // _myDas.getDas(_dKey, "xmld", "23.12.2013", "14.01.2014")

                //convert json to dataset
                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(Convert.ToString(_dasResult));
                DataTable dataTable = dataSet.Tables[0];
                //fill datagrid
                DataGridView1.DataSource = dataSet.Tables[0];
                DataGridView1.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
              //  MsgBox(ex.Message.ToString());
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                // send (delim data , dataset key , access key)
                das _myDas = new das();
                _myDas.sendDas(Convert.ToString(txtLine.Text), Convert.ToString(txtDSKey.Text), Convert.ToString(txtAKey.Text));

            }
            catch (Exception ex)
            {
            }
        }
    }
}
