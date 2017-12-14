Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class Model1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Assignment1")
    End Sub

    Public Overridable Property Table_1 As DbSet(Of Table_1)
    Public Overridable Property Table_2 As DbSet(Of Table_2)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Table_1)() _
            .Property(Function(e) e.Basketball) _
            .IsFixedLength()

        modelBuilder.Entity(Of Table_1)() _
            .Property(Function(e) e.Football) _
            .IsFixedLength()

        modelBuilder.Entity(Of Table_1)() _
            .Property(Function(e) e.Cricket) _
            .IsFixedLength()

        modelBuilder.Entity(Of Table_1)() _
            .HasOptional(Function(e) e.Table_2) _
            .WithRequired(Function(e) e.Table_1)

        modelBuilder.Entity(Of Table_2)() _
            .Property(Function(e) e.Ice_Hockey) _
            .IsFixedLength()

        modelBuilder.Entity(Of Table_2)() _
            .Property(Function(e) e.Rugby) _
            .IsFixedLength()

        modelBuilder.Entity(Of Table_2)() _
            .Property(Function(e) e.Kabbadi) _
            .IsFixedLength()
    End Sub
End Class
