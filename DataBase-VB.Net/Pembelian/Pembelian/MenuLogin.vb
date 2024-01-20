Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class MenuLogin
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
    Private Sub MenuLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)Handles MyBase.Load
        tbIDUser.Focus()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        koneksi()
        cmd = New OleDbCommand("select * from tbuser where iduser='" & tbIDUser.Text & "' and passworduser='" & tbPassword.Text & "' and bagian='" & cbBagian.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            MsgBox("Login Sukses")
            If cbBagian.Text = "ADM" Then
                Menu_Utama.USERBARUToolStripMenuItem.Enabled = False
                Menu_Utama.MASTERToolStripMenuItem.Enabled = False
            ElseIf cbBagian.Text = "SPV" Then
                Menu_Utama.USERBARUToolStripMenuItem.Enabled = False
                Menu_Utama.FILEToolStripMenuItem.Enabled = True
                Menu_Utama.MASTERToolStripMenuItem.Enabled = True
                Menu_Utama.TRANSAKSIToolStripMenuItem.Enabled = True
            ElseIf cbBagian.Text = "IT" Then
                Menu_Utama.USERBARUToolStripMenuItem.Enabled = True
                Menu_Utama.FILEToolStripMenuItem.Enabled = True
                Menu_Utama.MASTERToolStripMenuItem.Enabled = True
                Menu_Utama.TRANSAKSIToolStripMenuItem.Enabled = True
            End If
            Menu_Utama.Show()
            Me.Hide()
        Else
            MsgBox("Login Salah, Periksa Kembali ID User dan Password")
            tbIDUser.Focus()
            Me.tbIDUser.Text = ""
            Me.tbPassword.Text = ""
            Me.cbBagian.Text = ""
        End If
    End Sub
End Class