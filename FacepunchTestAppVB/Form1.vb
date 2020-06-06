Imports Steamworks.Ugc

Public Class Form1

    Dim publishReasult As PublishResult
    Dim theRandom As Random = New Random
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Steamworks.SteamClient.Init(714030, True) '252490 test ID    714030 StudyX    'Yargis 369040

        Catch f As System.Exception
            MsgBox(f.Message)

            Me.Close()
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Steamworks.SteamClient.Shutdown()
    End Sub

    Private Async Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        'Process.Start("TestUpload\icon-1719737_640.png") 'verify the path exists
        'Process.Start("TestUpload\") 'verify the path exists
        Dim previewLocation = "\TestUpload\icon-1719737_640.png"
        publishReasult = Await Steamworks.Ugc.Editor.NewCommunityFile.WithTitle(
            "My New Item" & theRandom.Next).
            WithDescription("test").
            WithTag("StudyFile").
            WithContent("TestUpload\").
        SubmitAsync()
        '                WithPreviewFile(previewLocation).      
        MemoEdit1.Text = publishReasult.Result.ToString & vbCrLf
    End Sub

    Private Sub MemoEdit1_TextChanged(sender As Object, e As EventArgs) Handles MemoEdit1.TextChanged

    End Sub
End Class
