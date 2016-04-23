Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lbDirections_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbDirections.SelectedIndexChanged

    End Sub

    Private Sub btnEditHospitalList_Click(sender As Object, e As EventArgs) Handles btnEditHospitalList.Click
        Dim FormNewME As New Form2
        FormNewME.Show()
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub tbLettersList_TextChanged(sender As Object, e As EventArgs) Handles tbLettersList.TextChanged

    End Sub

    Private Sub tbComplList_TextChanged(sender As Object, e As EventArgs) Handles tbComplList.TextChanged

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ORDERS_DataSet.Staff_List' table. You can move, or remove it, as needed.
        Me.Staff_ListTableAdapter.Fill(Me.ORDERS_DataSet.Staff_List)
        'TODO: This line of code loads data into the 'ORDERS_DataSet.MedEst_By_Towns' table. You can move, or remove it, as needed.
        Me.MedEst_By_TownsTableAdapter.Fill(Me.ORDERS_DataSet.MedEst_By_Towns)
        'TODO: This line of code loads data into the 'ORDERS_DataSet.MedEst_Towns_List' table. You can move, or remove it, as needed.
        Me.MedEst_Towns_ListTableAdapter.Fill(Me.ORDERS_DataSet.MedEst_Towns_List)

    End Sub

    Private Sub cbTeamHead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTeamHead.SelectedIndexChanged
        'Debug.Print(cbTeamHead.SelectedValue)
    End Sub
End Class
