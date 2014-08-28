Public Class facultyreport

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Try
            Me.BackColor = Color.Azure
            Dim p1fs1 As New CrystalDecisions.Shared.ParameterFields
            Dim p1f1, p1f2, p1f3, p1f4 As New CrystalDecisions.Shared.ParameterField
            Dim p1r1, p1r2, p1r3, p1r4 As New CrystalDecisions.Shared.ParameterDiscreteValue
            p1f1.ParameterFieldName = "myear"
            p1f2.ParameterFieldName = "mclass"
            p1f3.ParameterFieldName = "msubid"
            p1f4.ParameterFieldName = "mfname"
            p1r1.Value = myear
            p1r2.Value = mclass
            p1r3.Value = msubid
            p1r4.Value = mfname

            p1f1.CurrentValues.Add(p1r1)
            p1f2.CurrentValues.Add(p1r2)
            p1f3.CurrentValues.Add(p1r3)
            p1f4.CurrentValues.Add(p1r4)
            p1fs1.Add(p1f1)
            p1fs1.Add(p1f2)
            p1fs1.Add(p1f3)
            p1fs1.Add(p1f4)
            CrystalReportViewer1.ParameterFieldInfo = p1fs1 'to pass parameter inf.to CRV
            Dim cr As New Faculty_Report
            CrystalReportViewer1.ReportSource = cr
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub
End Class