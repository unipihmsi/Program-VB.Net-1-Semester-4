<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tbTanggal = New System.Windows.Forms.TextBox
        Me.tbKDTransaksi = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnCariSupplier = New System.Windows.Forms.Button
        Me.tbAlamat = New System.Windows.Forms.TextBox
        Me.tbEmail = New System.Windows.Forms.TextBox
        Me.tbNamaSupplier = New System.Windows.Forms.TextBox
        Me.tbTelepon = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.tbKDSupplier = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.tbSatuan = New System.Windows.Forms.TextBox
        Me.btnCariBarang = New System.Windows.Forms.Button
        Me.tbJumlah = New System.Windows.Forms.TextBox
        Me.tbNamaBarang = New System.Windows.Forms.TextBox
        Me.tbKDbarang = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnHapus = New System.Windows.Forms.Button
        Me.btnCetak = New System.Windows.Forms.Button
        Me.btnBatal = New System.Windows.Forms.Button
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.btnTambah = New System.Windows.Forms.Button
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(134, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(335, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Jl.Raya Serang KM 10 Bitung-Tangerang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "PT. SISFO 4A PAGI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "TRANSAKSI PEMBELIAN"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox1.Controls.Add(Me.tbTanggal)
        Me.GroupBox1.Controls.Add(Me.tbKDTransaksi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 60)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Transaksi"
        '
        'tbTanggal
        '
        Me.tbTanggal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbTanggal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTanggal.Location = New System.Drawing.Point(376, 25)
        Me.tbTanggal.Name = "tbTanggal"
        Me.tbTanggal.Size = New System.Drawing.Size(150, 20)
        Me.tbTanggal.TabIndex = 31
        '
        'tbKDTransaksi
        '
        Me.tbKDTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbKDTransaksi.Location = New System.Drawing.Point(140, 25)
        Me.tbKDTransaksi.Name = "tbKDTransaksi"
        Me.tbKDTransaksi.Size = New System.Drawing.Size(139, 20)
        Me.tbKDTransaksi.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(304, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Kode Transaksi"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox2.Controls.Add(Me.btnCariSupplier)
        Me.GroupBox2.Controls.Add(Me.tbAlamat)
        Me.GroupBox2.Controls.Add(Me.tbEmail)
        Me.GroupBox2.Controls.Add(Me.tbNamaSupplier)
        Me.GroupBox2.Controls.Add(Me.tbTelepon)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tbKDSupplier)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(541, 118)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Supplier"
        '
        'btnCariSupplier
        '
        Me.btnCariSupplier.BackColor = System.Drawing.Color.Orange
        Me.btnCariSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCariSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCariSupplier.Location = New System.Drawing.Point(236, 26)
        Me.btnCariSupplier.Name = "btnCariSupplier"
        Me.btnCariSupplier.Size = New System.Drawing.Size(54, 23)
        Me.btnCariSupplier.TabIndex = 32
        Me.btnCariSupplier.Text = "Cari"
        Me.btnCariSupplier.UseVisualStyleBackColor = False
        '
        'tbAlamat
        '
        Me.tbAlamat.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbAlamat.Location = New System.Drawing.Point(139, 87)
        Me.tbAlamat.Name = "tbAlamat"
        Me.tbAlamat.Size = New System.Drawing.Size(386, 20)
        Me.tbAlamat.TabIndex = 33
        '
        'tbEmail
        '
        Me.tbEmail.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbEmail.Location = New System.Drawing.Point(375, 55)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(150, 20)
        Me.tbEmail.TabIndex = 33
        '
        'tbNamaSupplier
        '
        Me.tbNamaSupplier.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbNamaSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNamaSupplier.Location = New System.Drawing.Point(139, 58)
        Me.tbNamaSupplier.Name = "tbNamaSupplier"
        Me.tbNamaSupplier.Size = New System.Drawing.Size(139, 20)
        Me.tbNamaSupplier.TabIndex = 31
        '
        'tbTelepon
        '
        Me.tbTelepon.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbTelepon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbTelepon.Location = New System.Drawing.Point(375, 26)
        Me.tbTelepon.Name = "tbTelepon"
        Me.tbTelepon.Size = New System.Drawing.Size(150, 20)
        Me.tbTelepon.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(303, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 20)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Email"
        '
        'tbKDSupplier
        '
        Me.tbKDSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbKDSupplier.Location = New System.Drawing.Point(139, 26)
        Me.tbKDSupplier.Name = "tbKDSupplier"
        Me.tbKDSupplier.Size = New System.Drawing.Size(91, 20)
        Me.tbKDSupplier.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(303, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 20)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Telepon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Nama Supplier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Kode Supplier"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox3.Controls.Add(Me.tbSatuan)
        Me.GroupBox3.Controls.Add(Me.btnCariBarang)
        Me.GroupBox3.Controls.Add(Me.tbJumlah)
        Me.GroupBox3.Controls.Add(Me.tbNamaBarang)
        Me.GroupBox3.Controls.Add(Me.tbKDbarang)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 305)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(541, 85)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Barang"
        '
        'tbSatuan
        '
        Me.tbSatuan.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSatuan.Location = New System.Drawing.Point(375, 50)
        Me.tbSatuan.Name = "tbSatuan"
        Me.tbSatuan.Size = New System.Drawing.Size(70, 20)
        Me.tbSatuan.TabIndex = 32
        '
        'btnCariBarang
        '
        Me.btnCariBarang.BackColor = System.Drawing.Color.Orange
        Me.btnCariBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCariBarang.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCariBarang.Location = New System.Drawing.Point(129, 47)
        Me.btnCariBarang.Name = "btnCariBarang"
        Me.btnCariBarang.Size = New System.Drawing.Size(54, 23)
        Me.btnCariBarang.TabIndex = 31
        Me.btnCariBarang.Text = "Cari"
        Me.btnCariBarang.UseVisualStyleBackColor = False
        '
        'tbJumlah
        '
        Me.tbJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbJumlah.Location = New System.Drawing.Point(469, 50)
        Me.tbJumlah.Name = "tbJumlah"
        Me.tbJumlah.Size = New System.Drawing.Size(56, 20)
        Me.tbJumlah.TabIndex = 30
        '
        'tbNamaBarang
        '
        Me.tbNamaBarang.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNamaBarang.Location = New System.Drawing.Point(200, 49)
        Me.tbNamaBarang.Name = "tbNamaBarang"
        Me.tbNamaBarang.Size = New System.Drawing.Size(151, 20)
        Me.tbNamaBarang.TabIndex = 30
        '
        'tbKDbarang
        '
        Me.tbKDbarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbKDbarang.Location = New System.Drawing.Point(10, 49)
        Me.tbKDbarang.Name = "tbKDbarang"
        Me.tbKDbarang.Size = New System.Drawing.Size(113, 20)
        Me.tbKDbarang.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(465, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 20)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Jumlah"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(371, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 20)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Satuan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(196, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 20)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Nama Barang"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Kode Barang"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox4.Controls.Add(Me.btnHapus)
        Me.GroupBox4.Controls.Add(Me.btnCetak)
        Me.GroupBox4.Controls.Add(Me.btnBatal)
        Me.GroupBox4.Controls.Add(Me.btnKeluar)
        Me.GroupBox4.Controls.Add(Me.btnSimpan)
        Me.GroupBox4.Controls.Add(Me.btnTambah)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 400)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(541, 73)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Button"
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Orange
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHapus.Location = New System.Drawing.Point(273, 19)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(81, 41)
        Me.btnHapus.TabIndex = 47
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.Orange
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCetak.Location = New System.Drawing.Point(447, 19)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(81, 41)
        Me.btnCetak.TabIndex = 46
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Orange
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBatal.Location = New System.Drawing.Point(186, 19)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(81, 41)
        Me.btnBatal.TabIndex = 45
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Orange
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKeluar.Location = New System.Drawing.Point(360, 19)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(81, 41)
        Me.btnKeluar.TabIndex = 44
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Orange
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSimpan.Location = New System.Drawing.Point(99, 19)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(81, 41)
        Me.btnSimpan.TabIndex = 43
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.Orange
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTambah.Location = New System.Drawing.Point(9, 19)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(81, 41)
        Me.btnTambah.TabIndex = 42
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Adam Kurniawan\DBPembelian.mdb"""
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(565, 480)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbNamaSupplier As System.Windows.Forms.TextBox
    Friend WithEvents tbKDSupplier As System.Windows.Forms.TextBox
    Friend WithEvents tbEmail As System.Windows.Forms.TextBox
    Friend WithEvents tbTelepon As System.Windows.Forms.TextBox
    Friend WithEvents tbAlamat As System.Windows.Forms.TextBox
    Friend WithEvents tbKDbarang As System.Windows.Forms.TextBox
    Friend WithEvents tbNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents tbJumlah As System.Windows.Forms.TextBox
    Friend WithEvents tbTanggal As System.Windows.Forms.TextBox
    Friend WithEvents tbKDTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents btnCariBarang As System.Windows.Forms.Button
    Friend WithEvents btnCariSupplier As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents tbSatuan As System.Windows.Forms.TextBox
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
End Class
