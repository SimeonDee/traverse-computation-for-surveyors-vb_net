Public Class Form1

    Dim number As Integer = 0, counter As Integer = 0
    Dim northing, DN, DE, easting As Double
    Dim bearing, length As Single

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If IsNothing(txtNorthing.Text) Then
            MessageBox.Show("Please supply the Northing of the Origin")
            txtNorthing.Focus()
            Exit Sub
        End If

        If IsNothing(txtEasting.Text) Then
            MessageBox.Show("Please supply the Easting of the Origin")
            txtEasting.Focus()
            Exit Sub
        End If

        If IsNothing(txtNumPoints.Text) Then
            MessageBox.Show("Please supply the Number of Points to Compute for")
            txtNumPoints.Focus()
            Exit Sub
        End If

        If Not (IsNumeric(txtNorthing.Text)) Then
            MessageBox.Show("Only Numberic input is allowed")
            txtNorthing.SelectAll()
            txtNorthing.Focus()
            Exit Sub
        End If

        If Not (IsNumeric(txtEasting.Text)) Then
            MessageBox.Show("Only Numberic input is allowed")
            txtEasting.SelectAll()
            txtEasting.Focus()
            Exit Sub
        End If

        If Not (IsNumeric(txtNumPoints.Text)) Then
            MessageBox.Show("Only Numberic input is allowed")
            txtNumPoints.SelectAll()
            txtNumPoints.Focus()
            Exit Sub
        End If

        number = CInt(txtNumPoints.Text)
        northing = CDbl(txtNorthing.Text)
        easting = CDbl(txtEasting.Text)
        pnlInput.Enabled = True
        pnlOrigin.Enabled = False



        lstFrom.Items.Add("")
        lstBearing.Items.Add("")
        lstLength.Items.Add("")
        lstDN.Items.Add("")
        lstDE.Items.Add("")
        lstNorthing.Items.Add(CStr(northing))
        lstEasting.Items.Add(CStr(easting))
        lstTo.Items.Add(CStr(counter))

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCos.Text = "(Lcos" & Chr(216) & ")" & vbCrLf & "DN"
        lblSin.Text = "(Lsin" & Chr(216) & ")" & vbCrLf & "DE"
        pnlInput.Enabled = False
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If counter >= number Then
            MessageBox.Show("There is no more point to compute for")
            Exit Sub
        End If

        If IsNothing(txtDeg.Text) Then
            MessageBox.Show("Please supply the Bearing value")
            txtDeg.Focus()
            Exit Sub
        End If

        If IsNothing(txtLength.Text) Then
            MessageBox.Show("Please supply the distance from Point" & number & " to Point" & number + 1)
            txtLength.Focus()
            Exit Sub
        End If

        If Not (IsNumeric(txtDeg.Text)) Then
            MessageBox.Show("Only a numeric value is allowed")
            txtDeg.SelectAll()
            txtDeg.Focus()
            Exit Sub
        End If

        If Not (IsNumeric(txtLength.Text)) Then
            MessageBox.Show("Only a numeric value is allowed")
            txtLength.SelectAll()
            txtLength.Focus()
            Exit Sub
        End If

        bearing = CInt(txtDeg.Text) + (CSng(txtmin.Text) / 60) + (CSng(txtSec.Text) / 3600)
        length = CSng(txtLength.Text)

        DN = length * Math.Cos(bearing)
        DE = length * Math.Sin(bearing)
        northing = northing + DN
        easting = easting + DE

        lstFrom.Items.Add(counter)
        lstBearing.Items.Add(Format(bearing, "###.###"))
        lstLength.Items.Add(length)
        lstDN.Items.Add(Format(DN, "###.###"))
        lstDE.Items.Add(Format(DE, "###.###"))
        lstNorthing.Items.Add(Format(northing, "######.###"))
        lstEasting.Items.Add(Format(easting, "######.###"))
        lstTo.Items.Add(CStr(counter + 1))

        txtDeg.Clear()
        txtLength.Clear()
        txtLength.Focus()

        counter = counter + 1

        If counter >= number Then
            MessageBox.Show("Points Inputs Completed")
            txtDeg.Enabled = False
            txtLength.Enabled = False
        End If
        lblLenRange.Text = "Length (P" & counter & " to P" & counter + 1 & ")"
        lblBearingRange.Text = "Bearing (P" & counter & " to P" & counter + 1 & ")"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNorthing.Clear()
        txtEasting.Clear()
        txtNumPoints.Clear()
        txtLength.Clear()
        txtDeg.Clear()
        txtmin.Clear()
        txtSec.Clear()
        lstFrom.Items.Clear()
        lstBearing.Items.Clear()
        lstLength.Items.Clear()
        lstDE.Items.Clear()
        lstDN.Items.Clear()
        lstNorthing.Items.Clear()
        lstEasting.Items.Clear()
        lstTo.Items.Clear()

        pnlOrigin.Enabled = True
        txtNorthing.Focus()
        pnlInput.Enabled = False

    End Sub
End Class
