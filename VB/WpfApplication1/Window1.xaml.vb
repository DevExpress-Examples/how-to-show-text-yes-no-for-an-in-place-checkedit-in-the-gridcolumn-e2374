' Developer Express Code Central Example:
' How to show text (Yes/No) for an in-place CheckEdit in the GridColumn
' 
' Implement two templates, one for editing and the other one for display mode.
' Assign these templates to the GridColumn.EditTemplate and
' GridColumn.DisplayTemplate properties.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2374

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Xpf.Grid
Imports System.Windows.Threading
Imports DevExpress.Xpf.Editors.Settings
Imports System.Threading
Imports DevExpress.Data
Imports System.Windows.Markup

Namespace WpfApplication1
    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Partial Public Class Window1
        Inherits Window

        Private coll As BindingList(Of ContactItem)
        Public Sub New()
            InitializeComponent()
            coll = New BindingList(Of ContactItem)()
            Dim f1 As New ContactItem()
            f1.Name = "Abcd bla bl1111a  333 32dfsdf 32423dsfs 32423dfsdf 32423dfsdf 444 dsfsdf 2342 fdsdf abcdsdf dfsd dsfdsfdfdfsdf sdfsdf sdfsdf sdfsdf sdfsdfsd   3434 3434 3434 222 1111 343 1111 444 kjdf kkh kdf dfkjdf dlfkj a222 dlfjsd 222 ldfksldfkj 334234 dslfjsd 34343 ldsfjsldjf 34234"
            f1.Salary = 13R
            f1.Date = Date.Today
            f1.IsFired=False
            coll.Add(f1)
            Dim f2 As New ContactItem()
            f2.Name = "bla1"
            f2.Date = Date.Today
            f2.Salary = 13

            coll.Add(f2)

            Dim f3 As New ContactItem()
            f3.Name = "la"
            f3.Salary = 13
            f3.IsFired=True
            f3.Date = Date.Today
            coll.Add(f3)

            Dim f4 As New ContactItem()
            f4.Name = " bla"
            f4.IsFired=True
            f4.Salary = 13

            coll.Add(f4)

            gridControl1.ItemsSource = coll


        End Sub


    End Class

    Public Class checkBoxConverter
        Inherits MarkupExtension
        Implements IValueConverter

        #Region "IValueConverter Members"

        Public Function Convert(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            If value Is Nothing Then
                Return "bb"
            End If
            If DirectCast(value, Boolean) Then
                Return "Yes"
            Else
                Return "No"
            End If
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New System.NotImplementedException()
        End Function

        #End Region

        Public Overrides Function ProvideValue(ByVal serviceProvider As System.IServiceProvider) As Object
            Return Me
        End Function
    End Class

End Namespace
