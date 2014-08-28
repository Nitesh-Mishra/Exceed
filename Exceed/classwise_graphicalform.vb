Public Class classwise_graphicalform

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Try
            ' Dim rd As New ReportDocument
            Dim p1fs1, p1fs2 As New CrystalDecisions.Shared.ParameterFields
            Dim p1f1, p1f2 As New CrystalDecisions.Shared.ParameterField
            Dim p1r1, p1r2 As New CrystalDecisions.Shared.ParameterDiscreteValue
            p1f1.ParameterFieldName = "class"
            p1f2.ParameterFieldName = "test_id"
            'MsgBox(muid)
            p1r1.Value = clas
            p1r2.Value = mtid

            p1f1.CurrentValues.Add(p1r1)
            p1f2.CurrentValues.Add(p1r2)
            p1fs1.Add(p1f1)
            p1fs1.Add(p1f2)
            CrystalReportViewer1.ParameterFieldInfo = p1fs1 'to pass parameter inf.to CRV
            'CrystalReportViewer1.ParameterFieldInfo = p1fs2
            ' Dim pfs1 As ParameterFields = Me.CrystalReportViewer1.ParameterFieldInfo
            'Dim pf1, pf2 As New ParameterField
            'pf1.Name = "muid"
            'pf2.Name = "myear"
            ' Dim pf1_value, pf2_value As New ParameterDiscreteValue
            'pf1_value.Value = muid
            'pf2_value.Value = myear
            'pf1.CurrentValues.Add(pf1_value)
            ' pf2.CurrentValues.Add(pf2_value)
            'pfs1.Add(pf1)
            ' pfs1.Add(pf2)
            Dim cr As New Class_Wise
            ' rd.Load("C:\Users\Ajeet K\Desktop\6-2-13\pbas\pbas\CrystalReport1.rpt")
            'rd.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = cr
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

End Class