Imports System.Data.OleDb

Public Class Form1
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
        Da = New OleDbDataAdapter("select * from tbbarang", conn)
        ds = New DataSet
        Da.Fill(ds, "tbbarang")
        DataGridView1.DataSource = ds.Tables("tbbarang")
    End Sub
    Sub Tampilan()
        TextBox2.Text = rd.Item(1)
        ComboBox1.Text = rd.Item(2)
        TextBox3.Text = rd.Item(3)
        TextBox4.Text = rd.Item(4)
    End Sub
    Sub TextMati()
        Me.TextBox1.Enabled = False
        Me.TextBox2.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.TextBox3.Enabled = False
        Me.TextBox4.Enabled = False
    End Sub
    Sub TextHidup()
        Me.TextBox1.Enabled = True
        Me.TextBox2.Enabled = True
        Me.ComboBox1.Enabled = True
        Me.TextBox3.Enabled = True
        Me.TextBox4.Enabled = True
    End Sub
    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Focus()
    End Sub
    Private Sub Pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If TextBox1.Text = "" Or TextBox1.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data Belum Lengkap, Pastikan Semua Form Terisi")
            Exit Sub
        Else
            Call koneksi()
            Dim simpan As String = "insert into tbbarang (kdbarang,nmbarang,satuan,jumlah,harga)" & _
            "Values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
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
        TextBox1.Enabled = False
        Me.btnTambah.Enabled = False
        Me.btnSimpan.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnUpdate.Enabled = True
        Me.btnBatal.Enabled = True
        Me.btnHapus.Enabled = True
        Me.btnKeluar.Enabled = True
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 5
        If e.KeyChar = Chr(13) Then TextBox2.Focus()
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        str = "SELECT * FROM tbbarang Where kdbarang = '" & TextBox1.Text & "'"
        cmd = New OleDbCommand(str, conn)
        rd = cmd.ExecuteReader
        Try
            While rd.Read
                TextBox2.Text = rd.GetString(1)
                ComboBox1.Text = rd.GetString(2)
                TextBox3.Text = rd.GetValue(3)
                TextBox4.Text = rd.GetValue(4)
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
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim Sql As String
        If MsgBox("Do You Want save again ?", MsgBoxStyle.YesNo, "Message") = vbYes Then
            Sql = "update tbbarang set nmbarang='" & TextBox2.Text & "' ,Satuan='" & ComboBox1.Text & "' ,jumlah='" & TextBox3.Text & "' ,harga='" & TextBox4.Text & "' where kdbarang='" & TextBox1.Text & "'"
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
        If TextBox1.Text = "" Then
            MsgBox("Kode belum diisi")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan dihapus...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String = "Delete * from tbbarang where kdbarang='" & TextBox1.Text & "'"
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

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        TextBox2.MaxLength = 25
        If e.KeyChar = Chr(13) Then ComboBox1.Focus()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        ComboBox1.MaxLength = 10
        If e.KeyChar = Chr(13) Then TextBox3.Focus()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        TextBox3.MaxLength = 10
        If e.KeyChar = Chr(13) Then TextBox4.Focus()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        TextBox3.MaxLength = 10
        If e.KeyChar = Chr(13) Then btnSimpan.Focus()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
