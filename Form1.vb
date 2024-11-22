Imports MySql.Data.MySqlClient
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class Form1





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Async Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As New Class1
        Dim usersWithStatus1 As Dictionary(Of String, User) = Await i.FetchUsersWithStatus1()
        If usersWithStatus1 IsNot Nothing AndAlso usersWithStatus1.Count > 0 Then
            My.Computer.Audio.Play("sound.wav")
            Dim p As New KeyValuePair(Of String, User)
            p = usersWithStatus1.ElementAt(0)
            lblName.Text = p.Value.name
            lblphone.Text = p.Value.phno
            lblUid.Text = p.Value.uid
            lblLoc.Text = p.Value.latitude & "," & p.Value.longitude '
            Label2.Text = p.Value.timestamp
            Button1.Enabled = True
            lblName.Visible = True
            lblphone.Visible = True
            lblUid.Visible = True
            lblLoc.Visible = True
            Label2.Visible = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        lblName.Visible = False
        Label2.Visible = False
        lblphone.Visible = False
        lblUid.Visible = False
        lblLoc.Visible = False
        Timer1.Enabled = True
        Dim i As New Class1
        Await i.UpdateStatusToZero(lblUid.Text)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblLoc_Click(sender As Object, e As EventArgs) Handles lblLoc.Click
        Dim googleMapsUrl As String = $"https://www.google.com/maps?q={lblLoc.Text}"
        Process.Start(New ProcessStartInfo("cmd", $"/c start {googleMapsUrl}") With {.CreateNoWindow = True})
    End Sub
End Class
