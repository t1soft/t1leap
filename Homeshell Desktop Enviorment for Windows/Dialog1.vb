﻿Imports System.Windows.Forms

Public Class Dialog1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each form In My.Application.OpenForms
            If (form.name = DocWorks.Name) Then
                DocWorks.Show()
            End If
        Next
        For Each form In My.Application.OpenForms
            If (form.name = SheetWorks.Name) Then
                SheetWorks.Show()

            End If
        Next
        For Each form In My.Application.OpenForms
            If (form.name = WebBrowser.Name) Then
                WebBrowser.Show()
            End If
        Next

        Desktop.Show()
        Me.Close()

    End Sub
End Class
