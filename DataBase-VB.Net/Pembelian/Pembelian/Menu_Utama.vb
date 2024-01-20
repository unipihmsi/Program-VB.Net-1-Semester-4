Public Class Menu_Utama

    Private Sub DataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBarangToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MenuLogin.Show()
        Me.Hide()
    End Sub

    Private Sub TambahUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahUserToolStripMenuItem.Click
        DataUser.Show()
        Me.Hide()
    End Sub

    Private Sub LapDataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LapDataBarangToolStripMenuItem.Click
        FormLaporanBarang.Show()
        Me.Hide()
    End Sub

    Private Sub DataSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSupplierToolStripMenuItem.Click
        Supplier.Show()
        Me.Hide()
    End Sub

    Private Sub LapDataSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LapDataSupplierToolStripMenuItem.Click
        FormLaporanSupplier.Show()
        Me.Hide()
    End Sub
End Class