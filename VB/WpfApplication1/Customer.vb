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
Imports DevExpress.Xpo
Imports System.Windows
Imports System.ComponentModel
Imports System.Windows.Controls

Namespace WpfApplication1
    Public Class ContactItem
        Implements INotifyPropertyChanged



        Protected _Name As String

        Public Property Name() As String
            Get
                Return Me._Name
            End Get

            Set(ByVal value As String)
                If Me._Name <> value Then
                    Me._Name = value
                    Me.OnPropertyChanged("Name")
                End If
            End Set
        End Property

        Protected _Salary As Double

        Public Property Salary() As Double
            Get
                Return Me._Salary
            End Get

            Set(ByVal value As Double)
                If Me._Salary <> value Then
                    Me._Salary = value
                    Me.OnPropertyChanged("Salary")
                End If
            End Set
        End Property
        Protected _Date As Date

        Public Property [Date]() As Date
            Get
                Return Me._Date
            End Get

            Set(ByVal value As Date)
                If Me._Date <> value Then
                    Me._Date = value
                    Me.OnPropertyChanged("Date")
                End If
            End Set
        End Property


        Protected _IsFired As Boolean

        Public Property IsFired() As Boolean
            Get
                Return Me._IsFired
            End Get

            Set(ByVal value As Boolean)
                If Me._IsFired <> value Then
                    Me._IsFired = value
                    Me.OnPropertyChanged("IsFired")
                End If
            End Set
        End Property


        Public Sub OnPropertyChanged(ByVal info As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    End Class

End Namespace
