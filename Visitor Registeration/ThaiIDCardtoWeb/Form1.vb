Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Net
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports ThaiNationalIDCard




Public Class frmIDRead

    Dim IDcard As ThaiIDCard
    Dim Personal_info As Personal
    Dim THName As String
    Dim Reader As Array

    Dim RDservice As String = "https://rdws.rd.go.th"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RdVerify.Image = ThaiIDCardtoWeb.My.Resources.Resources._2000px_Red_pog_svg
        IDcard = New ThaiIDCard

        VerifyCard()

        If Not (vIntenet(RDservice)) Then
            MsgBox("ไม่สามารเชื่อมต่อ Webservice ของกรมสรรพากรได้")

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        VerifyCard()

        Personal_info = IDcard.readAllPhoto()


        If Personal_info IsNot Nothing Then


            txtCitizenID.Text = Personal_info.Citizenid
            THName = Personal_info.Th_Prefix & Personal_info.Th_Firstname & " " & Personal_info.Th_Lastname
            txtThaiName.Text = THName
            txtAddress.Text = Personal_info.Address
            IDPhoto.Image = Personal_info.PhotoBitmap




            If vIntenet(RDservice) Then

                'ByPass SSL Certificate Validation Checking
                ServicePointManager.ServerCertificateValidationCallback = Function(se As Object, cert As System.Security.Cryptography.X509Certificates.X509Certificate, chain As System.Security.Cryptography.X509Certificates.X509Chain, sslerror As System.Net.Security.SslPolicyErrors) True

                'Call web application/web service with HTTPS URL
                Dim TaxClient As New TaxID.checktinpinserviceSoapClient
                Dim TaxResp As TaxID.tinpin

                TaxResp = TaxClient.ServiceTIN("anonymous", "anonymous", Personal_info.Citizenid)


                If TaxResp.vIsExist(0).ToString = "Yes" Then
                    RdVerify.Image = ThaiIDCardtoWeb.My.Resources._2000px_Green_pog_svg
                End If

                ServicePointManager.ServerCertificateValidationCallback = Nothing
            End If
        End If


    End Sub

    Public Sub VerifyCard()
        Do Until Reader IsNot Nothing

            Reader = IDcard.GetReaders()

            If Reader Is Nothing Then
                MsgBox("กรุณาเชื่อมต่อเครื่องอ่านบัตร", MsgBoxStyle.Critical)

            End If

        Loop

    End Sub

    Public Shared Function vIntenet(ByVal URL As String) As Boolean
        ServicePointManager.ServerCertificateValidationCallback = Function(se As Object, cert As System.Security.Cryptography.X509Certificates.X509Certificate, chain As System.Security.Cryptography.X509Certificates.X509Chain, sslerror As System.Net.Security.SslPolicyErrors) True
        Try
            Dim request As WebRequest = WebRequest.Create(URL)
            Dim response As WebResponse = request.GetResponse()
        Catch ex As Exception
            Return False
        End Try
        Return True
        ServicePointManager.ServerCertificateValidationCallback = Nothing
    End Function


End Class
