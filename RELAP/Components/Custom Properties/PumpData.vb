﻿<System.Serializable()> Public Class PumpData
    Private _tripnumberTab5 As String
    Public Property TripNumberTab5() As String
        Get
            Return _tripnumberTab5
        End Get
        Set(ByVal value As String)
            _tripnumberTab5 = value
        End Set
    End Property
    Private _AlphanumericTab5 As String
    Public Property AlphanumericTab5() As String
        Get
            Return _AlphanumericTab5
        End Get
        Set(ByVal value As String)
            _AlphanumericTab5 = value
        End Set
    End Property
    Private _NumericTab5 As String
    Public Property NumericTab5() As String
        Get
            Return _NumericTab5
        End Get
        Set(ByVal value As String)
            _NumericTab5 = value
        End Set
    End Property

    Private _cmbboxindex1 As String
    Public Property cmbboxindex1() As String
        Get
            Return _cmbboxindex1
        End Get
        Set(ByVal value As String)
            _cmbboxindex1 = value
        End Set
    End Property
    Private _cmbboxindex2 As String
    Public Property cmbboxindex2() As String
        Get
            Return _cmbboxindex2
        End Get
        Set(ByVal value As String)
            _cmbboxindex2 = value
        End Set
    End Property
    Private _cmbboxindex3 As String
    Public Property cmbboxindex3() As String
        Get
            Return _cmbboxindex3
        End Get
        Set(ByVal value As String)
            _cmbboxindex3 = value
        End Set
    End Property
    Private _cmbboxindex4 As String
    Public Property cmbboxindex4() As String
        Get
            Return _cmbboxindex4
        End Get
        Set(ByVal value As String)
            _cmbboxindex4 = value
        End Set
    End Property
    Private _cmbboxindex5 As String
    Public Property cmbboxindex5() As String
        Get
            Return _cmbboxindex5
        End Get
        Set(ByVal value As String)
            _cmbboxindex5 = value
        End Set
    End Property


    Protected m_collection As Generic.SortedDictionary(Of Integer, pumpdata201)
    ' Protected m_status As PipeEditorStatus = PipeEditorStatus.Definir

    Public Property Propumpdata201() As Generic.SortedDictionary(Of Integer, pumpdata201)
        Get
            Return m_collection
        End Get
        Set(ByVal value As Generic.SortedDictionary(Of Integer, pumpdata201))
            m_collection = value
        End Set
    End Property

    Protected m_collection1 As Generic.SortedDictionary(Of Integer, pumpdata202)
    ' Protected m_status As PipeEditorStatus = PipeEditorStatus.Definir

    Public Property Propumpdata202() As Generic.SortedDictionary(Of Integer, pumpdata202)
        Get
            Return m_collection1
        End Get
        Set(ByVal value As Generic.SortedDictionary(Of Integer, pumpdata202))
            m_collection1 = value
        End Set
    End Property

    Protected m_collection2 As Generic.SortedDictionary(Of Integer, pumpdata501)
    ' Protected m_status As PipeEditorStatus = PipeEditorStatus.Definir

    Public Property Propumpdata501() As Generic.SortedDictionary(Of Integer, pumpdata501)
        Get
            Return m_collection2
        End Get
        Set(ByVal value As Generic.SortedDictionary(Of Integer, pumpdata501))
            m_collection2 = value
        End Set
    End Property

    Public Sub New()
        m_collection = New Generic.SortedDictionary(Of Integer, pumpdata201)
        m_collection1 = New Generic.SortedDictionary(Of Integer, pumpdata202)
        m_collection2 = New Generic.SortedDictionary(Of Integer, pumpdata501)
    End Sub

    Public Overrides Function ToString() As String
        Return "Click to Edit..."
    End Function
End Class

<System.Serializable()> Public Class pumpdata201
    Private _Voidfraction1 As Double
    Public Property Voidfraction1() As Double
        Get
            Return _Voidfraction1
        End Get
        Set(ByVal value As Double)
            _Voidfraction1 = value
        End Set
    End Property

    Private _head As Double
    Public Property head() As Double
        Get
            Return _head
        End Get
        Set(ByVal value As Double)
            _head = value
        End Set
    End Property

    Public Sub New(ByVal Voidfraction1 As Double, ByVal head As Double)
        Me._Voidfraction1 = Voidfraction1
        Me._head = head
    End Sub
End Class
<System.Serializable()> Public Class pumpdata202
    Private _Voidfraction2 As Double
    Public Property Voidfraction2() As Double
        Get
            Return _Voidfraction2
        End Get
        Set(ByVal value As Double)
            _Voidfraction2 = value
        End Set
    End Property

    Private _Torque As Double
    Public Property Torque() As Double
        Get
            Return _Torque
        End Get
        Set(ByVal value As Double)
            _Torque = value
        End Set
    End Property

    Public Sub New(ByVal Voidfraction2 As Double, ByVal Torque As Double)
        Me._Voidfraction2 = Voidfraction2
        Me._Torque = Torque
    End Sub
End Class

<System.Serializable()> Public Class pumpdata501
    Private _SearchVariable As Double
    Public Property SearchVariable() As Double
        Get
            Return _SearchVariable
        End Get
        Set(ByVal value As Double)
            _SearchVariable = value
        End Set
    End Property

    Private _PumpVelocity As Double
    Public Property PumpVelocity() As Double
        Get
            Return _PumpVelocity
        End Get
        Set(ByVal value As Double)
            _PumpVelocity = value
        End Set
    End Property

    Public Sub New(ByVal SearchVariable As Double, ByVal PumpVelocity As Double)
        Me._SearchVariable = SearchVariable
        Me._PumpVelocity = PumpVelocity
    End Sub
End Class