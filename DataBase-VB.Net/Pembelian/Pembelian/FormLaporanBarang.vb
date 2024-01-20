Public Class FormLaporanBarang

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub btnTampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampilkan.Click
        CrystalReportViewer1.SelectionFormula = "{tbbarang.kdbarang}='" & tbCari.Text & "'"
        CrystalReportViewer1.ReportSource = "C:\Adam Kurniawan\Pembelian\Pembelian\Laporan_Barang.rpt"
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Menu_Utama.Show()
        Me.Hide()
    End Sub
End Class