Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Table_2
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Players As Integer

    <StringLength(10)>
    Public Property Ice_Hockey As String

    <StringLength(10)>
    Public Property Rugby As String

    <StringLength(10)>
    Public Property Kabbadi As String

    Public Overridable Property Table_1 As Table_1
End Class
