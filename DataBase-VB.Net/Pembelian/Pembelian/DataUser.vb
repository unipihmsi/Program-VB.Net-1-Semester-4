Imports System.Data.OleDb

Public Class DataUser
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
        Da = New OleDbDataAdapter("select * from tbuser", conn)
        ds = New DataSet
        Da.Fill(ds, "tbuser")
        DataGridView1.DataSource = ds.Tables("tbuser")
    End Sub
    Sub Tampilan()
        tbPassword.Text = rd.Item(1)
        cbBagian.Text = rd.Item(2)
    End Sub
    Sub TextMati()
        Me.tbIDUser.Enabled = False
        Me.tbPassword.Enabled = False
        Me.cbBagian.Enabled = False
    End Sub
    Sub TextHidup()
        Me.tbIDUser.Enabled = True
        Me.tbPassword.Enabled = True
        Me.cbBagian.Enabled = True
    End Sub
    Sub kosong()
        tbIDUser.Clear()
        tbPassword.Clear()
        tbIDUser.Focus()
    End Sub
    Private Sub DataUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
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
        If tbIDUser.Text = "" Or tbPassword.Text = "" Or cbBagian.Text = "" Then
            MsgBox("Data Belum Lengkap, Pastikan Semua Form Terisi")
            Exit Sub
        Else
            Call koneksi()
            Dim simpan As String = "insert into tbuser (iduser, passworduser, bagian)" & "values ('" & tbIDUser.Text & "','" & tbPassword.Text & "','" & cbBagian.Text & "')"
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
        tbIDUser.Enabled = False
        Me.btnTambah.Enabled = False
        Me.btnSimpan.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnUpdate.Enabled = True
        Me.btnBatal.Enabled = True
        Me.btnHapus.Enabled = True
        Me.btnKeluar.Enabled = True
    End Sub

    Private Sub tbIDUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbIDUser.KeyPress
        tbIDUser.MaxLength = 5
        If e.KeyChar = Chr(13) Then tbPassword.Focus()
    End Sub

    Private Sub tbIDUser_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbIDUser.LostFocus
        str = "SELECT * FROM tbuser Where iduser = '" & tbIDUser.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        Try
            While rd.Read
                tbPassword.Text = rd.GetString(1)
                cbBagian.Text = rd.GetString(2)
                TextMati()
                Me.btnTambah.Enabled = True
                Me.btnSimpan.Enabled = False
                Me.btnEdit.Enabled = True
                Me.btnUpdate.Enabled = True
                Me.btnBatal.Enabled = True
                Me.btnHapus.Enabled = True
                Me.btnKeluar.Enabled = True
            End While
        Finally
            rd.Close()
        End Try
    End Sub
    Private Sub tbIDUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIDUser.TextChanged
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim Sql As String
        If MsgBox("Do You Want save again ?", MsgBoxStyle.YesNo, "Message") = vbYes Then
            Sql = "update tbuser set passworduser='" & tbPassword.Text & "' ,bagian='" & cbBagian.Text & "' where iduser='" & tbIDUser.Text & "'"
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
        If tbIDUser.Text = "" Then
            MsgBox("Kode belum diisi")
            tbIDUser.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "Delete * from tbuser where iduser='" & tbIDUser.Text & "'"
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

    Private Sub tbPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbPassword.KeyPress
        tbPassword.MaxLength = 25
        If e.KeyChar = Chr(13) Then cbBagian.Focus()
    End Sub

    Private Sub tbPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPassword.TextChanged

    End Sub

    Private Sub cbBagian_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbBagian.KeyPress
        cbBagian.MaxLength = 10
        If e.KeyChar = Chr(13) Then btnSimpan.Focus()
    End Sub
End Class