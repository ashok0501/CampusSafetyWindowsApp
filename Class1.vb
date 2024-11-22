Imports Newtonsoft.Json
Imports System.Net.Http

Public Module common
    Public fireurl As String = "https://campussafetyapp1-default-rtdb.firebaseio.com"
End Module

Public Class User
    Public Property timestamp As String
    Public Property uid As String
    Public Property name As String
    Public Property latitude As Double
    Public Property longitude As Double
    Public Property phno As String
    Public Property status As Integer
End Class


Public Class Class1

    Private ReadOnly firebaseUrl As String = fireurl & "/users.json"

    ' Fetch all users with status = 1
    Public Async Function FetchUsersWithStatus1() As Task(Of Dictionary(Of String, User))
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(firebaseUrl)
                response.EnsureSuccessStatusCode()

                ' Parse response JSON
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Dim allUsers As Dictionary(Of String, User) = JsonConvert.DeserializeObject(Of Dictionary(Of String, User))(jsonResponse)

                ' Filter users with status = 1
                Dim filteredUsers = allUsers.Where(Function(kv) kv.Value.status = 0).
                                             ToDictionary(Function(kv) kv.Key, Function(kv) kv.Value)
                Return filteredUsers
            Catch ex As Exception
                ' MessageBox.Show("Error fetching data: " & ex.Message)
                Return Nothing
            End Try
        End Using
    End Function

    ' Save data to a local file
    Public Sub SaveToFile(users As Dictionary(Of String, User), filePath As String)

    End Sub

    ' Update status of users to 0
    Public Async Function UpdateStatusToZero(users As Dictionary(Of String, User)) As Task
        Using client As New HttpClient()
            Try
                For Each userId In users.Keys
                    Dim updateUrl As String = fireurl & $"/users/{userId}/status.json"
                    Dim payload As String = "1"
                    Dim content As New StringContent(payload, Text.Encoding.UTF8, "application/json")

                    ' Send PATCH request to update status
                    Dim response As HttpResponseMessage = Await client.PutAsync(updateUrl, content)
                    If response.IsSuccessStatusCode Then
                        Console.WriteLine($"Updated status of user {userId} to 0.")
                    Else
                        Console.WriteLine($"Failed to update status for user {userId}: {response.ReasonPhrase}")
                    End If
                    Return
                Next
            Catch ex As Exception
                ' MessageBox.Show("Error updating status: " & ex.Message)
            End Try
        End Using
    End Function

    Public Async Function UpdateStatusToZero(uid As String) As Task
        Using client As New HttpClient()
            Try

                Dim updateUrl As String = fireurl & $"/users/{uid}/status.json"
                Dim payload As String = "1"
                    Dim content As New StringContent(payload, Text.Encoding.UTF8, "application/json")

                    ' Send PATCH request to update status
                    Dim response As HttpResponseMessage = Await client.PutAsync(updateUrl, content)
                    If response.IsSuccessStatusCode Then
                    'Console.WriteLine($"Updated status of user {userId} to 0.")
                Else
                    ' Console.WriteLine($"Failed to update status for user {userId}: {response.ReasonPhrase}")
                End If
                Return

            Catch ex As Exception
                ' MessageBox.Show("Error updating status: " & ex.Message)
            End Try
        End Using
    End Function

End Class

