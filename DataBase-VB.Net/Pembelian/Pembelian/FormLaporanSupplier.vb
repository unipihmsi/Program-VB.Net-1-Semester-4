Public Class FormLaporanSupplier

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnTampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampilkan.Click
        CrystalReportViewer1.SelectionFormula = "{tbsupplier.kodesupplier}='" & tbCariSupplier.Text & "'"
        CrystalReportViewer1.ReportSource = "C:\Adam Kurniawan\Pembelian\Pembelian\LaporanSupplier.rpt"
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Menu_Utama.Show()
        Me.Hide()
    End Sub
End Class