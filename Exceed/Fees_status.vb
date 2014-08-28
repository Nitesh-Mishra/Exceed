Imports System.Data.Odbc

Public Class Fees_status
    Dim con As New OdbcConnection("DSN=exceed")
    Dim disamount As String

    Private Sub Class_Combo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Class_Combo.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Class_Combo.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from Add_Subject", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Class_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()


    End Sub

    Private Sub Studid_Combo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Studid_Combo.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Studid_Combo.Items.Clear()
            cmd = New OdbcCommand("select Distinct Student_Id from assign_subject where Class_Detail='" + Class_Combo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Studid_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()


    End Sub

    Private Sub paid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paid.Click
        If Class_Combo.Text = "" Or Studid_Combo.Text = "" Or totalamounttextbox.Text = "" Or amountpaidtextbox.Text = "" Or amounttobepaidtextbox.Text = "" Then
            MsgBox("Fields can't left blank", MsgBoxStyle.Critical)
        Else
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Try
                con.Open()

                Dim cmd As OdbcCommand
                Dim vmop As String
                If cashradio.Checked = True Then
                    vmop = "Cash"
                End If
                If checkradio.Checked = True Then
                    vmop = "Check"
                End If
                If ddradio.Checked = True Then
                    vmop = "DD"
                End If
                cmd = New OdbcCommand("insert into Fees_Status values('" + sessionLabel.Text + "','" + Class_Combo.Text + "','" + Studid_Combo.Text + "','" + totalamounttextbox.Text + "','" + amountpaidtextbox.Text + "','" + amountduetextbox.Text + "','" + dateofpayment.Text + "','" + vmop + "','" + checkddno.Text + "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Fees Paid Successfully")

                Class_Combo.Text = ""
                Studid_Combo.Text = ""
                totalamounttextbox.Clear()
                amounttobepaidtextbox.Clear()
                amountpaidtextbox.Clear()
                amountduetextbox.Clear()
                dateofpayment.Value = Now
                checkddno.Clear()
                'cashradio.Checked = True
                noradio.Checked = True
                Class_Combo.Focus()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            con.Close()

        End If
    End Sub



    Private Sub Fees_status_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dateofpayment.Format = DateTimePickerFormat.Custom
        dateofpayment.CustomFormat = "yyyy/MM/dd"

        amounttobepaidtextbox.Enabled = False
        amountduetextbox.Enabled = False
        discountpanel.Visible = False
        'disamtlabel.Visible = False
        'discountamountbox.Visible = False
        percentbox.Visible = False

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Percentlabel.Visible = False
        Try
            con.Open()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("Select Distinct Year from student_Info order by Year ASC", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                sessionLabel.Text = dr(0)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()

    End Sub

    Private Sub cashradio_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cashradio.CheckedChanged
        If cashradio.Checked = True Then
            checkddno.Text = "Not Applicable"
            checkddno.Enabled = False
        End If

    End Sub

    Private Sub checkradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkradio.CheckedChanged
        If checkradio.Checked = True Then
            checkddno.Enabled = True
            checkddno.Clear()
        End If
        
    End Sub

    Private Sub ddradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddradio.CheckedChanged
        If ddradio.Checked = True Then
            checkddno.Enabled = True
            checkddno.Clear()
        End If
    End Sub


    Private Sub amountpaidtextbox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles amountpaidtextbox.LostFocus
        If Val(amountpaidtextbox.Text) > Val(amounttobepaidtextbox.Text) Then
            MsgBox("Enter correct value", MsgBoxStyle.Critical)
        Else
            amountduetextbox.Text = Val(amounttobepaidtextbox.Text) - Val(amountpaidtextbox.Text)
        End If
    End Sub

    Private Sub Class_Combo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Class_Combo.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Class_Combo.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from Add_Subject", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Class_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Class_Combo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Class_Combo.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Class_Combo.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from Add_Subject", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Class_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Private Sub Studid_Combo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Studid_Combo.DropDown
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Studid_Combo.Items.Clear()
            cmd = New OdbcCommand("select Distinct Student_Id from assign_subject where Class_Detail='" + Class_Combo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Studid_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
            con.Close()
    End Sub

    Private Sub Studid_Combo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Studid_Combo.GotFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Studid_Combo.Items.Clear()
            cmd = New OdbcCommand("select Distinct Student_Id from assign_subject where Class_Detail='" + Class_Combo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Studid_Combo.Items.Add(dr.Item(0))
            End While
            totalamounttextbox.Clear()
            totalamounttextbox.Enabled = True
            yesradio.Enabled = True
            noradio.Enabled = True
            amountpaidtextbox.Enabled = True
            dateofpayment.Enabled = True
            paid.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub


    Private Sub viewreciept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewreciept.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            If Class_Combo.Text = "" And Studid_Combo.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Critical)
            End If
            Module1.mstudent_id = Studid_Combo.Text
            Module1.clas = Class_Combo.Text
            Module1.myear = sessionLabel.Text
            Fees_Report.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub yesradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yesradio.CheckedChanged
        If yesradio.Checked = True Then
            discountpanel.Visible = True
        End If
    End Sub

    Private Sub noradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noradio.CheckedChanged
        If noradio.Checked = True Then
            discountpanel.Visible = False
            amounttobepaidtextbox.Text = totalamounttextbox.Text
        End If
    End Sub

    Private Sub okbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okbutton.Click
        If Rupeesradio.Checked = True Then
            amounttobepaidtextbox.Text = totalamounttextbox.Text - discountamountbox.Text
            discountamountbox.Clear()
            discountpanel.Hide()
            amountpaidtextbox.Focus()
        Else
            amounttobepaidtextbox.Text = totalamounttextbox.Text - disamount
            percentbox.Clear()
            discountpanel.Hide()
            amountpaidtextbox.Focus()
            percentbox.Clear()
        End If
    End Sub

    Private Sub Rupeesradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rupeesradio.CheckedChanged
        If Rupeesradio.Checked = True Then
            percentbox.Visible = False
            Percentlabel.Visible = False
            disamtlabel.Visible = True
            discountamountbox.Visible = True
            discountamountbox.Enabled = True
            percentbox.Clear()
            discountamountbox.Focus()

        End If
    End Sub

    Private Sub discountamountbox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles discountamountbox.LostFocus
        Try
            If discountamountbox.Text > totalamounttextbox.Text Then
                MsgBox("Enter correct value", MsgBoxStyle.Critical)
            Else
                vamounttobepaid = totalamounttextbox.Text - discountamountbox.Text
            End If
        Catch ex As Exception
            '  MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub percentageradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles percentageradio.CheckedChanged
        If percentageradio.Checked = True Then
            disamtlabel.Visible = False
            discountamountbox.Visible = False
            percentbox.Focus()
            percentbox.Visible = True
            Percentlabel.Visible = True
            'discountamountbox.Visible = False
            discountamountbox.Clear()
        End If
    End Sub

    Private Sub percentbox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles percentbox.LostFocus
        If percentbox.Text > 100 Then
            MsgBox("Enter correct value", MsgBoxStyle.Critical)
        Else

            disamount = (totalamounttextbox.Text / 100) * percentbox.Text
            ' MsgBox(disamount)
        End If
    End Sub


    
   

    Private Sub Studid_Combo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Studid_Combo.LostFocus
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Total_Amount from fees_status where Student_Id='" + Studid_Combo.Text + "'", con)
            If (cmd.ExecuteNonQuery()) > 0 Then
                'Dim cmd1 As OdbcCommand
                'cmd1 = New OdbcCommand("select Total_Amount from fees_status where Student_Id='" + Studid_Combo.Text + "'", con)
                Dim dr As OdbcDataReader
                dr = cmd.ExecuteReader()
                While dr.Read()
                    totalamounttextbox.Text = dr(0)
                End While
                yesradio.Enabled = False
                noradio.Enabled = False
                totalamounttextbox.Enabled = False
            Else
                totalamounttextbox.Enabled = True
                yesradio.Enabled = True
                noradio.Enabled = True

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()

        Try
            con.Open()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Due_Amount from fees_status where Student_Id='" + Studid_Combo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                amounttobepaidtextbox.Text = dr(0)
            End While
            If amounttobepaidtextbox.Text = 0 Then
                amountpaidtextbox.Enabled = False
                dateofpayment.Enabled = False
                paid.Enabled = False
            Else
                amountpaidtextbox.Enabled = True
                dateofpayment.Enabled = True
                paid.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(e.ToString)
        End Try
        con.Close()
    End Sub

    
End Class