using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DaStarerKit_Tasks_CSharp
{
    public partial class _default : System.Web.UI.Page
    {
        //CHANGE API KEYS FROM _das.cs file
        private new _das _dasX;
        private new  dasData.das dasdata;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtDateDue.Text = DateTime.Now.AddDays(2).ToString();
            cmdGetData();
        }

        private void cmdGetData() {

            try
            { 
                object _dasResult;
                _dasResult = dasdata.getDas(_dasX._dKey, "json", "0", "100");
                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(Convert.ToString(_dasResult));
                DataTable dataTable = dataSet.Tables[0]; 
                GridView1.DataSource = dataTable; //dataSet.Tables[0];
                GridView1.AutoGenerateColumns = true;
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                // MsgBox(ex.Message.ToString)
            }

        }// end void get data

        protected void btnSendTask_Click(object sender, EventArgs e)
        {
            try
            { 
                string dasChannel;
                dasChannel = txtTask.Text.ToString() + "|" + txtTaskDetail.Text.ToString() + "|" + ddlTaskStatus.SelectedValue.ToString() + "|" + txtDateDue.Text.ToString();
                dasdata.sendDas(dasChannel, _dasX._dKey, _dasX._Akey);
                cmdGetData();
            }
            catch (Exception ex)
            {
                lblTaskResult.Text = ex.Message.ToString();
            }
        }  //END OF SEND VOID 



    }
}