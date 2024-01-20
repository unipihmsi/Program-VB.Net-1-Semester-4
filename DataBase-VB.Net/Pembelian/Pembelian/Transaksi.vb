Imports System.Data.OleDb
Public Class Transaksi
    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader
    Dim str As String
    Sub koneksi()
        str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Adam Kurniawan\DBPembelian.mdb"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Private Sub Transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        tbTanggal.Text = Now.Date
        Call TextMati()
        Me.btnTambah.Enabled = True
        Me.btnSimpan.Enabled = False
        Me.btnKeluar.Enabled = True
        Me.btnBatal.Enabled = False
        Me.btnCetak.Enabled = False
        Me.btnHapus.Enabled = False
    End Sub
    Sub TextMati()
        Me.tbKDTransaksi.Enabled = False
        Me.tbTanggal.Enabled = False
        Me.tbKDSupplier.Enabled = False
        Me.tbNamaSupplier.Enabled = False
        Me.tbTelepon.Enabled = False
        Me.tbEmail.Enabled = False
        Me.tbAlamat.Enabled = False
        Me.tbKDbarang.Enabled = False
        Me.tbNamaBarang.Enabled = False
        Me.tbSatuan.Enabled = False
        Me.tbJumlah.Enabled = False
        Me.btnCariSupplier.Enabled = False
        Me.btnCariBarang.Enabled = False
    End Sub
    Sub TextHidup()
        Me.tbKDTransaksi.Enabled = True
        Me.tbTanggal.Enabled = True
        Me.tbKDSupplier.Enabled = True
        Me.tbNamaSupplier.Enabled = True
        Me.tbTelepon.Enabled = True
        Me.tbEmail.Enabled = True
        Me.tbAlamat.Enabled = True
        Me.tbKDbarang.Enabled = True
        Me.tbNamaBarang.Enabled = True
        Me.tbSatuan.Enabled = True
        Me.tbJumlah.Enabled = True
        Me.btnCariSupplier.Enabled = True
        Me.btnCariBarang.Enabled = True
    End Sub
    Sub Kosong()
        tbKDTransaksi.Clear()
        tbTanggal.Clear()
        tbKDSupplier.Clear()
        tbNamaSupplier.Clear()
        tbTelepon.Clear()
        tbEmail.Clear()
        tbAlamat.Clear()
        tbKDbarang.Clear()
        tbNamaBarang.Clear()
        tbSatuan.Clear()
        tbJumlah.Clear()
        tbKDTransaksi.Focus()
    End Sub
    Sub TampilSupplier(ByVal kode As String)
        da = New OleDbDataAdapter("select * from tbsupplier where kodesupplier='" & kode & "'", conn)
        ds = New DataSet
        da.Fill(ds, "tbsupplier")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dsData As DataRow In ds.Tables(0).Rows
                tbNamaSupplier.Text = dsData("namasupplier")
                tbTelepon.Text = dsData("telepon")
                tbEmail.Text = dsData("email")
                tbAlamat.Text = dsData("alamat")
            Next
        End If
    End Sub
    Sub TampilBarang(ByVal kode As String)
        da = New OleDbDataAdapter("select * from tbbarang where kdbarang='" & kode & "'", conn)
        ds = New DataSet
        da.Fill(ds, "tbbarang")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dsData As DataRow In ds.Tables(0).Rows
                tbNamaBarang.Text = dsData("nmbarang")
                tbSatuan.Text = dsData("satuan")
                tbJumlah.Text = dsData("jumlah")
            Next
        End If
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Call TextHidup()
        Me.btnTambah.Enabled = True
        Me.btnSimpan.Enabled = True
        Me.btnKeluar.Enabled = True
        Me.btnBatal.Enabled = True
        Me.btnCetak.Enabled = True
        Me.btnHapus.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariSupplier.Click
        Call TampilSupplier(tbKDSupplier.Text)
    End Sub

    Private Sub btnCariBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariBarang.Click
        Call TampilBarang(tbKDbarang.Text)
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If tbKDTransaksi.Text = "" Then
            MsgBox("Data Belum Lengkap, Pastikan Semua Form Terisi")
            Exit Sub
        Else
            Call koneksi()
            Dim simpan As String = "insert into tbtrx (kdtrx,kodesupplier,kdbarang,jumlah,tgl)" & _
            "Values ('" & tbKDTransaksi.Text & "','" & tbKDSupplier.Text & "','" & tbKDbarang.Text & "','" & tbJumlah.Text & "','" & tbTanggal.Text & "')"
            cmd = New OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil di Input", MsgBoxStyle.Information, "Information")
            Me.OleDbConnection1.Close()
            Call koneksi()
            Call Kosong()
            Call TextMati()
            Me.btnTambah.Enabled = True
            Me.btnSimpan.Enabled = False
            Me.btnCetak.Enabled = False
            Me.btnBatal.Enabled = False
            Me.btnHapus.Enabled = False
            Me.btnKeluar.Enabled = True
        End If
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class