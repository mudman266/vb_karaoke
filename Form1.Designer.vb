<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbSelection = New System.Windows.Forms.ComboBox()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnTotalCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(355, 426)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(391, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(397, 41)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Karaoke Music Night"
        '
        'cmbSelection
        '
        Me.cmbSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelection.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelection.FormattingEnabled = True
        Me.cmbSelection.Items.AddRange(New Object() {"By Song ($2.99)", "By Hour ($8.99)"})
        Me.cmbSelection.Location = New System.Drawing.Point(670, 89)
        Me.cmbSelection.Name = "cmbSelection"
        Me.cmbSelection.Size = New System.Drawing.Size(220, 32)
        Me.cmbSelection.TabIndex = 2
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelection.Location = New System.Drawing.Point(373, 92)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(291, 24)
        Me.lblSelection.TabIndex = 3
        Me.lblSelection.Text = "How would you like to pay?"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(417, 158)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(191, 24)
        Me.lblNumber.TabIndex = 4
        Me.lblNumber.Text = "Number of songs:"
        Me.lblNumber.Visible = False
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(670, 155)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(56, 32)
        Me.txtNumber.TabIndex = 5
        Me.txtNumber.Visible = False
        '
        'btnTotalCost
        '
        Me.btnTotalCost.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalCost.Location = New System.Drawing.Point(442, 234)
        Me.btnTotalCost.Name = "btnTotalCost"
        Me.btnTotalCost.Size = New System.Drawing.Size(142, 43)
        Me.btnTotalCost.TabIndex = 6
        Me.btnTotalCost.Text = "Total Cost"
        Me.btnTotalCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(720, 234)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(142, 43)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(377, 359)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(540, 24)
        Me.lblTotalCost.TabIndex = 8
        Me.lblTotalCost.Text = "Total Cost: "
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 450)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTotalCost)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.cmbSelection)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMain"
        Me.Text = "Karaoke Music Night"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents cmbSelection As ComboBox
    Friend WithEvents lblSelection As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnTotalCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotalCost As Label
End Class
