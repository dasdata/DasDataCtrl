Imports dasData.das
Imports Newtonsoft.Json

Public Class _default
    Inherits System.Web.UI.Page
    'CHANGE API KEYS FROM _das.vb file
    Private _dasX As New _das
    Private dasData As New dasData.das

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Page.IsPostBack Then
                txtDateDue.Text = Date.Now.AddDays(2)
                cmdGetData()
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnSendTask_Click(sender As Object, e As EventArgs) Handles btnSendTask.Click
        Try
            If txtTask.Text <> "" Then
                Dim _taskChannel As String = txtTask.Text & "|" & txtTaskDetail.Text & "|" & ddlTaskStatus.SelectedValue & "|" & txtDateDue.Text
                lblTaskResult.Text = dasData.sendDas(_taskChannel, _dasX.DSKey, _dasX.AKey)

                'FILL THE DATASET
                cmdGetData()

                'CLEAR INPUT BOXES
                txtTask.Text = ""
                txtDateDue.Text = ""

            Else
                lblTaskResult.Text = "Fill task title"

            End If



        Catch ex As Exception

        End Try

    End Sub


    Private Sub cmdGetData()
        'READ FROM DATA SOURCE
        Dim _dasResult As String = dasData.getDas(_dasX.DSKey, "json", 0, 100)
        Dim dataSet As DataSet = JsonConvert.DeserializeObject(Of DataSet)(_dasResult)
        Dim dataTable As DataTable = dataSet.Tables(0)

        'FILL GRIDVIEW
        GridView1.DataSource = dataTable
        GridView1.AutoGenerateColumns = True
        GridView1.DataBind()

    End Sub
End Class