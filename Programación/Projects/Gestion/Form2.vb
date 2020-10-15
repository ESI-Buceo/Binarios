Imports System.IO

Public Class Form2

    Private Property archivo As IO.FileStream



    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SintomasText.SelectedIndexChanged

        

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Enfermedad As String

        Enfermedad = Enfermedadtxt.Text

        ' Dim textoANT As String = My.Computer.FileSystem.ReadAllText("C:\" + Enfermedad + ".txt")



        'Dim obj As Object
        'Dim archivo As Object
        ' obj = CreateObject("Scripting.FileSystemObject")
        'archivo = obj.CreateTextFile("C:\" + Enfermedad + ".txt")



        Dim i As Integer
        For i = 0 To SintomasText.Items.Count - 1
            If (SintomasText.GetItemChecked(i)) Then
                MessageBox.Show(SintomasText.Items(i))
            End If
        Next












    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End


    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'Dim ruta As String = My.Application.Info.DirectoryPath
        Dim textoANT As String = My.Computer.FileSystem.ReadAllText("C:\Sintomas.txt")
        Dim textoNUE As String = SintomasTxt.Text



        Dim obj As Object
        Dim archivo As Object
        obj = CreateObject("Scripting.FileSystemObject")
        archivo = obj.CreateTextFile("C:\Sintomas.txt")
        archivo.WriteLine(textoANT)
        archivo.WriteLine(textoNUE)
        archivo.Close()

        SintomasText.Items.Clear()



        Dim objLectorList As StreamReader = File.OpenText("C:\Sintomas.txt")
        Do While Not objLectorList.EndOfStream

            Me.SintomasText.Items.Add(objLectorList.ReadLine)
        Loop
        FileClose()
        objLectorList.Close()



    End Sub











    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles SintomasTxt.MaskInputRejected

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim indice As Integer = SintomasText.Items.Count - 2

        Dim i As Integer

        For i = 0 To indice
            If (SintomasText.GetItemChecked(i)) Then
                SintomasText.Items.RemoveAt(i)
                indice = indice - 1
            End If
        Next

        Dim obj As Object
        Dim archivo As Object
        obj = CreateObject("Scripting.FileSystemObject")
        archivo = obj.CreateTextFile("C:\Sintomas.txt")
        archivo.WriteLine(textoANT)
        archivo.WriteLine(textoNUE)
        archivo.Close()

        SintomasText.Items.Clear()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim objLectorList As StreamReader = File.OpenText("C:\Sintomas.txt")
        Do While Not objLectorList.EndOfStream
            Me.SintomasText.Items.Add(objLectorList.ReadLine)
        Loop
        FileClose()
        objLectorList.Close()

    End Sub

    Private Function pepe() As String
        Throw New NotImplementedException
    End Function

    Private Sub CheckedListBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SintomasText.SelectedIndexChanged

    End Sub

    Private Sub SintomasTxt_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles SintomasTxt.MaskInputRejected

    End Sub

    Private Sub Sintomas_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles Enfermedadtxt.MaskInputRejected

    End Sub

    Private Function EliminarSaltosLinea(ByVal texto As String, ByVal caracterReemplazar As String) As String
        EliminarSaltosLinea = Replace(Replace(texto, Chr(10), caracterReemplazar), Chr(13), caracterReemplazar)
    End Function

End Class