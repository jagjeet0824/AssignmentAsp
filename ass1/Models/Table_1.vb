Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Table_1
    <StringLength(10)>
    Public Property Basketball As String

    <StringLength(10)>
    Public Property Football As String

    <StringLength(10)>
    Public Property Cricket As String

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Players As Integer

    Public Overridable Property Table_2 As Table_2
End Class
