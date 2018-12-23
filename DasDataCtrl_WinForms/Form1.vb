Imports dasData
Imports Newtonsoft.Json

Public Class Form1
    Public _myDas As New das
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAKey.Text = "a09075165g-2f343fe-485a-8276-02574c41c94"
        txtDSKey.Text = "bf082e44-7945-48b5-8016-8b94365ce8d2"
    End Sub
    Private Sub btnTestMe_Click(sender As Object, e As EventArgs) Handles btnTestMe.Click
        Try
            Dim _dasResult As String = _myDas.getDas(txtDSKey.Text, "json", 0, 100)
            Dim dataSet As DataSet = JsonConvert.DeserializeObject(Of DataSet)(_dasResult)
            Dim dataTable As DataTable = dataSet.Tables(0)

            DataGridView1.DataSource = dataSet.Tables(0)
            DataGridView1.AutoGenerateColumns = True
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Try
            Dim _dasResult As String = _myDas.sendDas(txtLine.Text, txtDSKey.Text, txtAKey.Text)
        Catch ex As Exception

        End Try

    End Sub
End Class
