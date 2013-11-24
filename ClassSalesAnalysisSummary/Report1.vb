Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class Report1
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()

    End Sub

    Private Sub cust_nbrGroupHeaderSection_ItemDataBinding(sender As Object, e As EventArgs) Handles cust_nbrGroupHeaderSection.ItemDataBinding

    End Sub

    Private Sub cust_nbrGroupHeaderSection_ItemDataBound(sender As Object, e As EventArgs) Handles cust_nbrGroupHeaderSection.ItemDataBound

    End Sub
End Class