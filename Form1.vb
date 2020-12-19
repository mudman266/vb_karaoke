Public Class frmMain
    ' Constants to hold the price per song or per hour
    Private Const decPricePerSong As Decimal = 2.99
    Private Const decPricePerHour As Decimal = 8.99
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show the splash screen for ~3 seconds
        Threading.Thread.Sleep(3000)
    End Sub

    Private Sub cmbSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelection.SelectedIndexChanged
        ' When the user selects a way to pay, update the label to reflect their choice and make the label and input box visible
        lblNumber.Visible = True
        txtNumber.Visible = True
        If cmbSelection.SelectedIndex = 0 Then
            lblNumber.Text = "Number of songs:"
        Else
            lblNumber.Text = "Number of hours:"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear button
        cmbSelection.SelectedIndex = -1
        lblNumber.Visible = False
        txtNumber.Clear()
        txtNumber.Visible = False
        lblTotalCost.Text = "Total Cost: "
    End Sub

    Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click
        ' Total Cost button
        Dim decTotalCost As Decimal
        decTotalCost = If(cmbSelection.SelectedIndex = 0, ComputeSongs(), ComputeHours())
        lblTotalCost.Text = "Total cost: " & decTotalCost.ToString("C2")
    End Sub

    Private Function ComputeSongs()
        ' Compute the total for number of songs
        Dim decCost As Decimal
        Dim intRequest As Integer
        Try
            intRequest = Convert.ToInt32(txtNumber.Text)
        Catch ex As Exception
            MsgBox("Number of songs must be a positive integer. Try again.")
        End Try
        If intRequest < 1 Then
            MsgBox("Number of songs must be a positive integer. Try again.")
            Exit Function
        End If
        decCost = intRequest * decPricePerSong
        Return decCost
    End Function

    Private Function ComputeHours()
        ' Compute the total for the number of hours
        Dim decCost As Decimal
        Dim intRequest As Integer
        Try
            intRequest = Convert.ToInt32(txtNumber.Text)
        Catch ex As Exception
            MsgBox("Number of hours must be a positive integer. Try again.")
        End Try
        If intRequest < 1 Then
            MsgBox("Number of hours must be a positive integer. Try again.")
            Exit Function
        End If
        decCost = intRequest * decPricePerHour
        Return decCost
    End Function
End Class
