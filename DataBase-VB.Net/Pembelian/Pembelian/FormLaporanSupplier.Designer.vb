<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanSupplier
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbCariSupplier = New System.Windows.Forms.TextBox
        Me.btnTampilkan = New System.Windows.Forms.Button
        Me.btnTutup = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.LaporanSupplier1 = New Pembelian.LaporanSupplier
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cari Kode Supplier"
        '
        'tbCariSupplier
        '
        Me.tbCariSupplier.Location = New System.Drawing.Point(393, 30)
        Me.tbCariSupplier.Name = "tbCariSupplier"
        Me.tbCariSupplier.Size = New System.Drawing.Size(146, 20)
        Me.tbCariSupplier.TabIndex = 3
        '
        'btnTampilkan
        '
        Me.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTampilkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTampilkan.Location = New System.Drawing.Point(556, 30)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(89, 23)
        Me.btnTampilkan.TabIndex = 4
        Me.btnTampilkan.Text = "Tampilkan"
        Me.btnTampilkan.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTutup.Location = New System.Drawing.Point(660, 31)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(89, 23)
        Me.btnTutup.TabIndex = 5
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = "C:\Adam Kurniawan\Pembelian\Pembelian\LaporanSupplier.rpt"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(861, 418)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'FormLaporanSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 418)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnTampilkan)
        Me.Controls.Add(Me.tbCariSupplier)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FormLaporanSupplier"
        Me.Text = "FormLaporanSupplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents LaporanSupplier1 As Pembelian.LaporanSupplier
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbCariSupplier As System.Windows.Forms.TextBox
    Friend WithEvents btnTampilkan As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
End Class
