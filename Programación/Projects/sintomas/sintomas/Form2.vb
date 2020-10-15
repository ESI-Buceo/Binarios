Imports System.IO

Public Class Form2

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'dim es para crear variables'

        Dim Fiebre As Boolean, tos_humeda As Boolean, Dolor_garganta As Boolean, Goteo As Boolean, Dolores_musculares As Boolean, Dolores_cabeza As Boolean, fatiga As Boolean, Tos_seca As Boolean

        Fiebre = SintomasText.GetItemChecked(0)
        tos_humeda = SintomasText.GetItemChecked(1)
        Dolor_garganta = SintomasText.GetItemChecked(2)
        Goteo = SintomasText.GetItemChecked(3)
        Dolores_musculares = SintomasText.GetItemChecked(4)
        Dolores_cabeza = SintomasText.GetItemChecked(5)
        fatiga = SintomasText.GetItemChecked(6)
        Tos_seca = SintomasText.GetItemChecked(7)


        If ((Fiebre And tos_humeda And Dolor_garganta And Goteo And Dolores_musculares And Dolores_cabeza And fatiga And Not Tos_seca)) Then

            MessageBox.Show("tienes gripe")

        ElseIf (Fiebre And Tos_seca And fatiga And Not tos_humeda And Not Dolor_garganta And Not Goteo And Not Dolores_musculares And Not Dolores_cabeza) Then
            MessageBox.Show("Posiblemente tienes coronavirus")
        End If


    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SintomasText.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim objLectorList As StreamReader = File.OpenText("C:\Sintomas.txt")
        Do While Not objLectorList.EndOfStream

            Me.SintomasText.Items.Add(objLectorList.ReadLine)
        Loop

        FileClose()
        objLectorList.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class