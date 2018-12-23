Imports dasData
Imports Newtonsoft.Json
Public Class _default
    Inherits System.Web.UI.Page
    Public _myDas As New das
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim _myDas As New das
        'CHANGE FROM YOUR ACCOUNT
        If Not Page.IsPostBack Then
            Dim _Akey As String = "c746434836d84ea79f39ac96d0cc85"
            Dim _dKey As String = "8c7f94153c004dcda3c70b9cbbd502"
            txtAKey.Text = _Akey
            txtDSKey.Text = _dKey
        End If


        'SEND DATA DELIMITED BY |  DEPENDING ON THE CONFIGURED ELEMENTS 
        ' Response.Write(_myDas.sendDas("34|453|4322", _dKey, _Akey))

        'RECEIVE DATA - JSON / XML
        ' latest 100 values :: "json", 0, 100    
        ' based on interval dfrom / dto :: "json", 23.12.2013, 14.01.2014   
        'Response.Write(_myDas.getDas(_dKey, "json", 0, 100))
        '   Response.Write(_myDas.getDas(_dKey, "jsond", "23.12.2013", "14.01.2014"))
        '  Response.Write(_myDas.getDas(_dKey, "xml", 0, 100))
        ' Response.Write(_myDas.getDas(_dKey, "xmld", "23.12.2013", "14.01.2014"))

    End Sub

    Protected Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        cmdGetData()
    End Sub

    Protected Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim _dasResult As String = _myDas.sendDas(txtLine.Text, txtDSKey.Text, txtAKey.Text)
        cmdGetData()
    End Sub

    Function cmdGetData()
        Try
            Dim _dasResult As String = _myDas.getDas(txtDSKey.Text, "json", 0, 100)
            Dim dataSet As DataSet = JsonConvert.DeserializeObject(Of DataSet)(_dasResult)
            Dim dataTable As DataTable = dataSet.Tables(0)

            GridView1.DataSource = dataSet.Tables(0)
            GridView1.AutoGenerateColumns = True
            GridView1.DataBind()
        Catch ex As Exception
            ' MsgBox(ex.Message.ToString)
        End Try
    End Function

End Class