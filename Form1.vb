Public Class Form1

    Private Sub btnApproach_Click(sender As Object, e As EventArgs) Handles btnApproach.Click
        Dim strName As String = InputBox("What is your name?", "Name")
        Dim strQuest As String = InputBox("What is your quest?", "Quest")
        Dim strRandomQAnswer As String
        Dim intRandomQuestionNumber As Integer

        Dim strRandomQ1 As String = "What is your favorite color?"
        Dim strRandomQ2 As String = "What is the flight speed of an unladen swallow?"
        Dim strRandomQ3 As String = "What is the capital of Assyria?"
        Dim strRandomQ4 As String = "What is the depth of the polar ice cap?"

        'typical random number sequence
        Randomize()
        intRandomQuestionNumber = Int((4 - 1 + 1) * Rnd() + 1)

        If intRandomQuestionNumber = 1 Then
            strRandomQAnswer = InputBox(strRandomQ1, "Random")
        ElseIf intRandomQuestionNumber = 2 Then
            strRandomQAnswer = InputBox(strRandomQ2, "Random")
        ElseIf intRandomQuestionNumber = 3 Then
            strRandomQAnswer = InputBox(strRandomQ3, "Random")
        ElseIf intRandomQuestionNumber = 4 Then
            strRandomQAnswer = InputBox(strRandomQ4, "Random")
        End If

        If intRandomQuestionNumber = 1 And strRandomQAnswer = "Green" Then
            Me.lblFate.Text = "You Pass"
        ElseIf intRandomQuestionNumber = 1 And strRandomQAnswer <> "Green" Then
            Me.lblFate.Text = "You Die"
        ElseIf intRandomQuestionNumber = 2 And strRandomQAnswer = "24 mph" Then
            Me.lblFate.Text = "You Pass"
        ElseIf intRandomQuestionNumber = 2 And strRandomQAnswer <> "24 mph" Then
            Me.lblFate.Text = "You Die"
        ElseIf intRandomQuestionNumber = 3 And (strRandomQAnswer = "Ashur" Or strRandomQAnswer = "Calah" Or strRandomQAnswer = "Dur Sharrukin" Or strRandomQAnswer = "Nineveh") Then
            Me.lblFate.Text = "You Pass"
        ElseIf intRandomQuestionNumber = 3 And (strRandomQAnswer <> "Ashur" Or strRandomQAnswer <> "Calah" Or strRandomQAnswer <> "Dur Sharrukin" Or strRandomQAnswer <> "Nineveh") Then
            Me.lblFate.Text = "You Die"
        ElseIf intRandomQuestionNumber = 4 And strRandomQAnswer = "100 feet" Then
            Me.lblFate.Text = "You Pass"
        ElseIf intRandomQuestionNumber = 4 And strRandomQAnswer <> "100 feet" Then
            Me.lblFate.Text = "You Die"

        
        End If
    End Sub
End Class
