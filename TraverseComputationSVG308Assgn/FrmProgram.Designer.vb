<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProgram
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSec = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDeg = New System.Windows.Forms.TextBox()
        Me.lblBearingRange = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblLenRange = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lstTo = New System.Windows.Forms.ListView()
        Me.lblSin = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lstEasting = New System.Windows.Forms.ListView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lstNorthing = New System.Windows.Forms.ListView()
        Me.lstDE = New System.Windows.Forms.ListView()
        Me.lblCos = New System.Windows.Forms.Label()
        Me.lstDN = New System.Windows.Forms.ListView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lstLength = New System.Windows.Forms.ListView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lstBearing = New System.Windows.Forms.ListView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lstFrom = New System.Windows.Forms.ListView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pnlOrigin = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEasting = New System.Windows.Forms.TextBox()
        Me.txtNorthing = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtNumPoints = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlInput.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlOrigin.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlInput
        '
        Me.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInput.Controls.Add(Me.Label13)
        Me.pnlInput.Controls.Add(Me.txtSec)
        Me.pnlInput.Controls.Add(Me.Label5)
        Me.pnlInput.Controls.Add(Me.txtmin)
        Me.pnlInput.Controls.Add(Me.Label4)
        Me.pnlInput.Controls.Add(Me.btnClear)
        Me.pnlInput.Controls.Add(Me.btnNext)
        Me.pnlInput.Controls.Add(Me.Label9)
        Me.pnlInput.Controls.Add(Me.Label8)
        Me.pnlInput.Controls.Add(Me.txtDeg)
        Me.pnlInput.Controls.Add(Me.lblBearingRange)
        Me.pnlInput.Controls.Add(Me.txtLength)
        Me.pnlInput.Controls.Add(Me.lblLenRange)
        Me.pnlInput.Location = New System.Drawing.Point(23, 158)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(313, 192)
        Me.pnlInput.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(220, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "sec."
        '
        'txtSec
        '
        Me.txtSec.Location = New System.Drawing.Point(220, 75)
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(25, 20)
        Me.txtSec.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(170, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "min."
        '
        'txtmin
        '
        Me.txtmin.Location = New System.Drawing.Point(170, 75)
        Me.txtmin.Name = "txtmin"
        Me.txtmin.Size = New System.Drawing.Size(30, 20)
        Me.txtmin.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "deg."
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(151, 118)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(123, 33)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(26, 118)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(104, 34)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "Next Input"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(253, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "degrees"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(253, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "meters"
        '
        'txtDeg
        '
        Me.txtDeg.Location = New System.Drawing.Point(112, 75)
        Me.txtDeg.Name = "txtDeg"
        Me.txtDeg.Size = New System.Drawing.Size(40, 20)
        Me.txtDeg.TabIndex = 7
        '
        'lblBearingRange
        '
        Me.lblBearingRange.AutoSize = True
        Me.lblBearingRange.Location = New System.Drawing.Point(12, 78)
        Me.lblBearingRange.Name = "lblBearingRange"
        Me.lblBearingRange.Size = New System.Drawing.Size(93, 13)
        Me.lblBearingRange.TabIndex = 6
        Me.lblBearingRange.Text = "Bearing (P0 to P1)"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(112, 14)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(135, 20)
        Me.txtLength.TabIndex = 5
        '
        'lblLenRange
        '
        Me.lblLenRange.AutoSize = True
        Me.lblLenRange.Location = New System.Drawing.Point(12, 17)
        Me.lblLenRange.Name = "lblLenRange"
        Me.lblLenRange.Size = New System.Drawing.Size(90, 13)
        Me.lblLenRange.TabIndex = 4
        Me.lblLenRange.Text = "Length (P0 to P1)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lstTo)
        Me.GroupBox1.Controls.Add(Me.lblSin)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lstEasting)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.lstNorthing)
        Me.GroupBox1.Controls.Add(Me.lstDE)
        Me.GroupBox1.Controls.Add(Me.lblCos)
        Me.GroupBox1.Controls.Add(Me.lstDN)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lstLength)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lstBearing)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lstFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(355, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 338)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OUTPUT"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(506, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "To Point"
        '
        'lstTo
        '
        Me.lstTo.LabelWrap = False
        Me.lstTo.Location = New System.Drawing.Point(509, 56)
        Me.lstTo.Name = "lstTo"
        Me.lstTo.Size = New System.Drawing.Size(39, 273)
        Me.lstTo.TabIndex = 15
        Me.lstTo.UseCompatibleStateImageBehavior = False
        '
        'lblSin
        '
        Me.lblSin.AllowDrop = True
        Me.lblSin.Location = New System.Drawing.Point(270, 23)
        Me.lblSin.Name = "lblSin"
        Me.lblSin.Size = New System.Drawing.Size(44, 26)
        Me.lblSin.TabIndex = 14
        Me.lblSin.Text = "(Lsin#) DE"
        Me.lblSin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(434, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Easting"
        '
        'lstEasting
        '
        Me.lstEasting.ForeColor = System.Drawing.Color.Red
        Me.lstEasting.LabelWrap = False
        Me.lstEasting.Location = New System.Drawing.Point(427, 55)
        Me.lstEasting.Name = "lstEasting"
        Me.lstEasting.Size = New System.Drawing.Size(78, 273)
        Me.lstEasting.TabIndex = 12
        Me.lstEasting.UseCompatibleStateImageBehavior = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(359, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Northing"
        '
        'lstNorthing
        '
        Me.lstNorthing.ForeColor = System.Drawing.Color.Red
        Me.lstNorthing.LabelWrap = False
        Me.lstNorthing.Location = New System.Drawing.Point(347, 55)
        Me.lstNorthing.Name = "lstNorthing"
        Me.lstNorthing.Size = New System.Drawing.Size(76, 273)
        Me.lstNorthing.TabIndex = 10
        Me.lstNorthing.UseCompatibleStateImageBehavior = False
        '
        'lstDE
        '
        Me.lstDE.LabelWrap = False
        Me.lstDE.Location = New System.Drawing.Point(267, 55)
        Me.lstDE.Name = "lstDE"
        Me.lstDE.Size = New System.Drawing.Size(74, 273)
        Me.lstDE.TabIndex = 8
        Me.lstDE.UseCompatibleStateImageBehavior = False
        '
        'lblCos
        '
        Me.lblCos.AllowDrop = True
        Me.lblCos.Location = New System.Drawing.Point(203, 23)
        Me.lblCos.Name = "lblCos"
        Me.lblCos.Size = New System.Drawing.Size(44, 26)
        Me.lblCos.TabIndex = 7
        Me.lblCos.Text = "(Lcos#) DN"
        Me.lblCos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstDN
        '
        Me.lstDN.LabelWrap = False
        Me.lstDN.Location = New System.Drawing.Point(191, 55)
        Me.lstDN.Name = "lstDN"
        Me.lstDN.Size = New System.Drawing.Size(70, 273)
        Me.lstDN.TabIndex = 6
        Me.lstDN.UseCompatibleStateImageBehavior = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(132, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Length"
        '
        'lstLength
        '
        Me.lstLength.LabelWrap = False
        Me.lstLength.Location = New System.Drawing.Point(120, 55)
        Me.lstLength.Name = "lstLength"
        Me.lstLength.Size = New System.Drawing.Size(65, 273)
        Me.lstLength.TabIndex = 4
        Me.lstLength.UseCompatibleStateImageBehavior = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(61, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Bearing"
        '
        'lstBearing
        '
        Me.lstBearing.LabelWrap = False
        Me.lstBearing.Location = New System.Drawing.Point(49, 55)
        Me.lstBearing.Name = "lstBearing"
        Me.lstBearing.Size = New System.Drawing.Size(65, 273)
        Me.lstBearing.TabIndex = 2
        Me.lstBearing.UseCompatibleStateImageBehavior = False
        '
        'Label10
        '
        Me.Label10.AllowDrop = True
        Me.Label10.Location = New System.Drawing.Point(6, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 31)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "From Points"
        '
        'lstFrom
        '
        Me.lstFrom.LabelWrap = False
        Me.lstFrom.Location = New System.Drawing.Point(6, 55)
        Me.lstFrom.Name = "lstFrom"
        Me.lstFrom.Size = New System.Drawing.Size(39, 273)
        Me.lstFrom.TabIndex = 0
        Me.lstFrom.UseCompatibleStateImageBehavior = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(132, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 20)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "INPUTS"
        '
        'pnlOrigin
        '
        Me.pnlOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOrigin.Controls.Add(Me.Label7)
        Me.pnlOrigin.Controls.Add(Me.Label6)
        Me.pnlOrigin.Controls.Add(Me.txtEasting)
        Me.pnlOrigin.Controls.Add(Me.txtNorthing)
        Me.pnlOrigin.Controls.Add(Me.Label3)
        Me.pnlOrigin.Controls.Add(Me.Label2)
        Me.pnlOrigin.Controls.Add(Me.btnOk)
        Me.pnlOrigin.Controls.Add(Me.txtNumPoints)
        Me.pnlOrigin.Controls.Add(Me.Label1)
        Me.pnlOrigin.Location = New System.Drawing.Point(22, 42)
        Me.pnlOrigin.Name = "pnlOrigin"
        Me.pnlOrigin.Size = New System.Drawing.Size(314, 108)
        Me.pnlOrigin.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(261, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "meters"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(261, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "meters"
        '
        'txtEasting
        '
        Me.txtEasting.Location = New System.Drawing.Point(120, 45)
        Me.txtEasting.Name = "txtEasting"
        Me.txtEasting.Size = New System.Drawing.Size(135, 20)
        Me.txtEasting.TabIndex = 22
        '
        'txtNorthing
        '
        Me.txtNorthing.Location = New System.Drawing.Point(120, 12)
        Me.txtNorthing.Name = "txtNorthing"
        Me.txtNorthing.Size = New System.Drawing.Size(135, 20)
        Me.txtNorthing.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Easting (P0)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Northing (P0) "
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(216, 78)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(45, 19)
        Me.btnOk.TabIndex = 18
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtNumPoints
        '
        Me.txtNumPoints.Location = New System.Drawing.Point(157, 77)
        Me.txtNumPoints.Name = "txtNumPoints"
        Me.txtNumPoints.Size = New System.Drawing.Size(42, 20)
        Me.txtNumPoints.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Supply Number of Points"
        '
        'FrmProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(923, 364)
        Me.Controls.Add(Me.pnlOrigin)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlInput)
        Me.Name = "FrmProgram"
        Me.Text = "Form1"
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlOrigin.ResumeLayout(False)
        Me.pnlOrigin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlInput As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblBearingRange As System.Windows.Forms.Label
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents lblLenRange As System.Windows.Forms.Label
    Friend WithEvents lstFrom As System.Windows.Forms.ListView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lstBearing As System.Windows.Forms.ListView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lstLength As System.Windows.Forms.ListView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lstTo As System.Windows.Forms.ListView
    Friend WithEvents lblSin As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lstEasting As System.Windows.Forms.ListView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lstNorthing As System.Windows.Forms.ListView
    Friend WithEvents lstDE As System.Windows.Forms.ListView
    Friend WithEvents lblCos As System.Windows.Forms.Label
    Friend WithEvents lstDN As System.Windows.Forms.ListView
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents pnlOrigin As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEasting As System.Windows.Forms.TextBox
    Friend WithEvents txtNorthing As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents txtNumPoints As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSec As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtmin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDeg As System.Windows.Forms.TextBox

End Class
