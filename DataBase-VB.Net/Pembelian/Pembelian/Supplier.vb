Imports System.Data.OleDb

Public Class Supplier
    Dim conn As OleDbConnection
    Dim Da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader
    Dim str As String
    Sub koneksi()
        str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Adam Kurniawan\DBPembelian.mdb"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
    Sub Tampilgrid()
        Da = New OleDbDataAdapter("select * from tbsupplier", conn)
        ds = New DataSet
        Da.Fill(ds, "tbsupplier")
        DataGridView1.DataSource = ds.Tables("tbsupplier")
    End Sub
    Sub Tampilan()
        tbNamaSupplier.Text = rd.Item(1)
        tbTelepon.Text = rd.Item(2)
        tbEmail.Text = rd.Item(3)
        tbAlamat.Text = rd.Item(4)
    End Sub
    Sub TextMati()
        Me.tbKDSupplier.Enabled = False
        Me.tbNamaSupplier.Enabled = False
        Me.tbTelepon.Enabled = False
        Me.tbEmail.Enabled = False
        Me.tbAlamat.Enabled = False
    End Sub
    Sub TextHidup()
        Me.tbKDSupplier.Enabled = True
        Me.tbNamaSupplier.Enabled = True
        Me.tbTelepon.Enabled = True
        Me.tbEmail.Enabled = True
        Me.tbAlamat.Enabled = True
    End Sub
    Sub kosong()
        tbKDSupplier.Clear()
        tbNamaSupplier.Clear()
        tbTelepon.Clear()
        tbEmail.Clear()
        tbAlamat.Clear()
        tbKDSupplier.Focus()
    End Sub
    Private Sub Supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Tampilgrid()
        Call kosong()
        Call TextMati()
        DataGridView1.ReadOnly = True
        DataGridView1.Enabled = True
        Me.btnTambah.Enabled = True
        Me.btnSimpan.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnBatal.Enabled = False
        Me.btnUpdate.Enabled = False
        Me.btnHapus.Enabled = False
        Me.btnKeluar.Enabled = True
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Call kosong()
        Call TextHidup()
        Me.btnTambah.Enabled = False
        Me.btnSimpan.Enabled = True
        Me.btnEdit.Enabled = True
        Me.btnBatal.Enabled = False
        Me.btnUpdate.Enabled = False
        Me.btnHapus.Enabled = False
        Me.btnKeluar.Enabled = True
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Menu_Utama.Show()
        Me.Hide()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If tbKDSupplier.Text = "" Or tbKDSupplier.Text = "" Or tbNamaSupplier.Text = "" Then
            MsgBox("Data Belum Lengkap, Pastikan Semua Form Terisi")
            Exit Sub
        Else
            Call koneksi()
            Dim simpan As String = "insert into tbsupplier (kodesupplier,namasupplier,telepon,email,alamat)" & _
            "Values ('" & tbKDSupplier.Text & "','" & tbNamaSupplier.Text & "','" & tbTelepon.Text & "','" & tbEmail.Text & "','" & tbAlamat.Text & "')"
            cmd = New OleDbCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil di Input", MsgBoxStyle.Information, "Information")
            Me.OleDbConnection1.Close()
            Call Tampilgrid()
            DataGridView1.Refresh()
            Call koneksi()
            Call kosong()
            Call TextMati()
            Me.btnTambah.Enabled = True
            Me.btnSimpan.Enabled = False
            Me.btnEdit.Enabled = False
            Me.btnUpdate.Enabled = False
            Me.btnBatal.Enabled = False
            Me.btnHapus.Enabled = False
            Me.btnKeluar.Enabled = True
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Call TextHidup()
        tbKDSupplier.Enabled = False
        Me.btnTambah.Enabled = False
        Me.btnSimpan.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnUpdate.Enabled = True
        Me.btnBatal.Enabled = True
        Me.btnHapus.Enabled = True
        Me.btnKeluar.Enabled = True
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbKDSupplier.KeyPress
        tbKDSupplier.MaxLength = 5
        If e.KeyChar = Chr(13) Then tbNamaSupplier.Focus()
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbKDSupplier.LostFocus
        str = "SELECT * FROM tbsupplier Where kodesupplier = '" & tbKDSupplier.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            Call Tampilgrid()
        Else
            tbNamaSupplier.Text = rd.Item("namasupplier")
            tbTelepon.Text = rd.Item("telepon")
            tbEmail.Text = rd.Item("email")
            tbAlamat.Text = rd.Item("alamat")
            TextMati()
            Me.btnTambah.Enabled = True
            Me.btnSimpan.Enabled = False
            Me.btnEdit.Enabled = True
            Me.btnUpdate.Enabled = True
            Me.btnBatal.Enabled = True
            Me.btnHapus.Enabled = True
            Me.btnKeluar.Enabled = True
        End If
        rd.Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim Sql As String
        If MsgBox("Do You Want save again ?", MsgBoxStyle.YesNo, "Message") = vbYes Then
            Sql = "update tbsupplier set namasupplier='" & tbNamaSupplier.Text & "' ,telepon='" & tbTelepon.Text & "' ,email='" & tbEmail.Text & "' ,alamat='" & tbAlamat.Text & "' where kodesupplier='" & tbKDSupplier.Text & "'"
            cmd = New OleDbCommand(Sql, conn)
            cmd.ExecuteNonQuery()
            DataGridView1.Refresh()
            Me.OleDbConnection1.Close()
            Call TextMati()
            Call kosong()
            Me.btnTambah.Enabled = True
            Me.btnSimpan.Enabled = False
            Me.btnEdit.Enabled = False
            Me.btnUpdate.Enabled = False
            Me.btnBatal.Enabled = False
            Me.btnHapus.Enabled = False
            Me.btnKeluar.Enabled = True
            DataGridView1.Refresh()
            Call Tampilgrid()
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call kosong()
        Call TextMati()
        Me.btnTambah.Enabled = True
        Me.btnSimpan.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnUpdate.Enabled = False
        Me.btnBatal.Enabled = False
        Me.btnHapus.Enabled = False
        Me.btnKeluar.Enabled = True
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If tbKDSupplier.Text = "" Then
            MsgBox("Kode belum diisi")
            tbKDSupplier.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "Delete * from tbsupplier where kodesupplier='" & tbKDSupplier.Text & "'"
                cmd = New OleDbCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                Call Tampilgrid()
                Call kosong()
                Me.btnTambah.Enabled = True
                Me.btnSimpan.Enabled = False
                Me.btnEdit.Enabled = False
                Me.btnUpdate.Enabled = False
                Me.btnBatal.Enabled = False
                Me.btnHapus.Enabled = False
                Me.btnKeluar.Enabled = True
            Else
                Call TextMati()
            End If
        End If
    End Sub
End Class