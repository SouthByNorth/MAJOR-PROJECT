Imports System.IO

Public Class ClozeText
    'holds the 2 parts of our data structure 

    Public Const SEPERATOR As String = "}"

    Public MainText As String

    Public Selections As List(Of String) = New List(Of String)

    Public Shared Function ReadClozeText(fileName As String) As ClozeText
        'populate the data structure for clozetext
        Dim clozeText As ClozeText = New ClozeText()

        Dim myStreamReader = New StreamReader(fileName)
        If (myStreamReader IsNot Nothing) Then
            'Read the file content to a holding string
            Dim fileContents As String = myStreamReader.ReadToEnd
            'Split the file by our special seperator to break the CLOZE test from the selections
            Dim splits() As String = fileContents.Split(SEPERATOR.ToCharArray)
            clozeText.MainText = splits(0)
            'clean up formatting on the maintext
            clozeText.MainText = clozeText.MainText.Trim(vbLf)
            clozeText.MainText = clozeText.MainText.Trim(vbCrLf)
            clozeText.MainText = clozeText.MainText.Trim(vbLf)
            clozeText.MainText = clozeText.MainText.Trim(vbCrLf)
            clozeText.MainText = clozeText.MainText.Trim(vbLf)



            Dim selections As String = splits(1)

            'convert the selection string to a list of items
            Dim items As String() = selections.Split(vbCrLf)

            For Each item As String In items
                'item = item.TrimStart(vbLf.ToCharArray)
                item = Strings.Mid(item, 2)
                If item.Length > 0 Then
                    clozeText.Selections.Add(item)
                End If
                ' arrange sleection in alphabetical order 
                clozeText.Selections.Sort()
            Next
        End If


        Return clozeText
    End Function

End Class
