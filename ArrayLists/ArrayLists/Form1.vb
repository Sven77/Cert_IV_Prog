﻿Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer

        Dim ItemList As New ArrayList()

        ItemList.Add("Item4")
        ItemList.Add("Item5")
        ItemList.Add("Item2")
        ItemList.Add("Item1")
        ItemList.Add("Item3")

        MsgBox("Shows Added Items")
        For i = 0 To ItemList.Count - 1
            lbCollections.Items.Add(ItemList.Item(i))
            'MsgBox(ItemList.Item(i))
        Next

        'insert an item
        ItemList.Insert(3, "Item6")
        'sort itemms in an arraylist
        ItemList.Sort()
        'remove an item
        ItemList.Remove("Item1")
        'remove item from a specified index
        ItemList.RemoveAt(3)
        MsgBox("Shows final Items the ArrayList")
        For i = 0 To ItemList.Count - 1
            lbCollections.Items.Add(ItemList.Item(i))
            'MsgBox(ItemList.Item(i))
        Next

    End Sub
End Class
