<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Utama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransaksiPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LapDataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LapDataCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LapDataPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.USERBARUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TambahUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LapDataSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.MASTERToolStripMenuItem, Me.TRANSAKSIToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.USERBARUToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(578, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BantuanToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'BantuanToolStripMenuItem
        '
        Me.BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        Me.BantuanToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.BantuanToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BantuanToolStripMenuItem.Text = "Bantuan"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangToolStripMenuItem, Me.DataCustomerToolStripMenuItem, Me.DataSupplierToolStripMenuItem})
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DataBarangToolStripMenuItem.Text = "Data Barang"
        '
        'DataCustomerToolStripMenuItem
        '
        Me.DataCustomerToolStripMenuItem.Name = "DataCustomerToolStripMenuItem"
        Me.DataCustomerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.DataCustomerToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DataCustomerToolStripMenuItem.Text = "Data Customer"
        '
        'DataSupplierToolStripMenuItem
        '
        Me.DataSupplierToolStripMenuItem.Name = "DataSupplierToolStripMenuItem"
        Me.DataSupplierToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.DataSupplierToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DataSupplierToolStripMenuItem.Text = "Data Supplier"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiPembelianToolStripMenuItem})
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.TRANSAKSIToolStripMenuItem.Text = "TRANSAKSI"
        '
        'TransaksiPembelianToolStripMenuItem
        '
        Me.TransaksiPembelianToolStripMenuItem.Name = "TransaksiPembelianToolStripMenuItem"
        Me.TransaksiPembelianToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.TransaksiPembelianToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.TransaksiPembelianToolStripMenuItem.Text = "Transaksi Pembelian"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LapDataBarangToolStripMenuItem, Me.LapDataCustomerToolStripMenuItem, Me.LapDataPembelianToolStripMenuItem, Me.LapDataSupplierToolStripMenuItem})
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        '
        'LapDataBarangToolStripMenuItem
        '
        Me.LapDataBarangToolStripMenuItem.Name = "LapDataBarangToolStripMenuItem"
        Me.LapDataBarangToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.LapDataBarangToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LapDataBarangToolStripMenuItem.Text = "Lap Data Barang"
        '
        'LapDataCustomerToolStripMenuItem
        '
        Me.LapDataCustomerToolStripMenuItem.Name = "LapDataCustomerToolStripMenuItem"
        Me.LapDataCustomerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.LapDataCustomerToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LapDataCustomerToolStripMenuItem.Text = "Lap Data Customer"
        '
        'LapDataPembelianToolStripMenuItem
        '
        Me.LapDataPembelianToolStripMenuItem.Name = "LapDataPembelianToolStripMenuItem"
        Me.LapDataPembelianToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.LapDataPembelianToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LapDataPembelianToolStripMenuItem.Text = "Lap Data Pembelian"
        '
        'USERBARUToolStripMenuItem
        '
        Me.USERBARUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahUserToolStripMenuItem})
        Me.USERBARUToolStripMenuItem.Name = "USERBARUToolStripMenuItem"
        Me.USERBARUToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.USERBARUToolStripMenuItem.Text = "USER BARU"
        '
        'TambahUserToolStripMenuItem
        '
        Me.TambahUserToolStripMenuItem.Name = "TambahUserToolStripMenuItem"
        Me.TambahUserToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.TambahUserToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.TambahUserToolStripMenuItem.Text = "Tambah User"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SELAMAT DATANG DI MENU UTAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(325, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SISTEM INFORMASI PEMBELIAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(415, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PADA INSAN PEMBANGUNAN INDONESIA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Created by : Adam Kurniawan"
        '
        'LapDataSupplierToolStripMenuItem
        '
        Me.LapDataSupplierToolStripMenuItem.Name = "LapDataSupplierToolStripMenuItem"
        Me.LapDataSupplierToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.LapDataSupplierToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LapDataSupplierToolStripMenuItem.Text = "Lap Data Supplier"
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(578, 382)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_Utama"
        Me.Text = "Menu_Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapDataBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapDataCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapDataPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USERBARUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapDataSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
