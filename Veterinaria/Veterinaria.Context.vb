'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class VeterinariaEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=VeterinariaEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Ciudad() As DbSet(Of Ciudad)
    Public Overridable Property Cliente() As DbSet(Of Cliente)
    Public Overridable Property Especie() As DbSet(Of Especie)
    Public Overridable Property Mascota() As DbSet(Of Mascota)
    Public Overridable Property MascotaVacuna() As DbSet(Of MascotaVacuna)
    Public Overridable Property Raza() As DbSet(Of Raza)
    Public Overridable Property Vacuna() As DbSet(Of Vacuna)

End Class
