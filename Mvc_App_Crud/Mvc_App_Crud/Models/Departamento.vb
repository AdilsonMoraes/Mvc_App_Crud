'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Departamento
    Public Property DepartamentoID As Integer
    Public Property DepartamentoNome As String

    Public Overridable Property Alunoes As ICollection(Of Aluno) = New HashSet(Of Aluno)

End Class
