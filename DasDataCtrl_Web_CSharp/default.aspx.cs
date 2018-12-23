using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using dasData;
using Newtonsoft.Json;

namespace DasDataCtrl_Web_CSharp
{
 
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            das _myDas = new das();
            //CHANGE FROM YOUR ACCOUNT
            string _Akey = "a09075165g-2f343fe-485a-8276-02574c41c94";
            string _dKey = "bf082e44-7945-48b5-8016-8b94365ce8d2";

            txtAKey.Text = _Akey;
            txtDSKey.Text = _dKey;

            //SEND DATA DELIMITED BY |  DEPENDING ON THE CONFIGURED ELEMENTS 
            // Response.Write(_myDas.sendDas("34|453|4322", _dKey, _Akey));

            //RECEIVE DATA - JSON / XML
            // latest 100 values :: "json", 0, 100    
            // based on interval dfrom / dto :: "jsond", 23.12.2013, 14.01.2014   
            //Response.Write(_myDas.getDas(_dKey, "json", 0, 100));
            //   Response.Write(_myDas.getDas(_dKey, "jsond", "23.12.2013", "14.01.2014"));
            //  Response.Write(_myDas.getDas(_dKey, "xml", 0, 100));
            // Response.Write(_myDas.getDas(_dKey, "xmld", "23.12.2013", "14.01.2014"));
        }

        protected void btnTest_Click(object sender, EventArgs e)
        {
            cmdGetData();
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            das _myDas = new das();
            _myDas.sendDas(Convert.ToString(txtLine.Text), Convert.ToString(txtDSKey.Text), Convert.ToString(txtAKey.Text));
            cmdGetData();
        }

        public void cmdGetData()
        {
            try
            {
                das _myDas = new das();
                object _dasResult;
                    _dasResult = _myDas.getDas(Convert.ToString(txtDSKey.Text), "json", "0", "100");
                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(Convert.ToString(_dasResult));
                DataTable dataTable = dataSet.Tables[0];

                GridView1.DataSource = dataSet; //dataSet.Tables[0];
              //  GridView1.AutoGenerateColumns = true;
                GridView1.DataBind();
                 
            }
            catch (Exception ex)
            {
                // MsgBox(ex.Message.ToString)
            }
             
        }
        
    }
}