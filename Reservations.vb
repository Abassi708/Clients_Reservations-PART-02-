Public Class Reservations
    Private NameAirline As String
    Private PointDeparature As String
    Private PointArrival As String
    Private costTravel As String
    Private town As String



    Public Property NAirline() As String
        Set(value As String)
            NAirline = value
        End Set
        Get
            Return NAirline

        End Get
    End Property


    Public Property PDeparature() As String
        Set(value As String)
            PDeparature = value
        End Set
        Get
            Return PDeparature

        End Get
    End Property

    Public Property PArrival() As String
        Set(value As String)
            PArrival = value
        End Set
        Get
            Return PArrival

        End Get
    End Property

    Public Property CTravel() As String
        Set(value As String)
            CTravel = value
        End Set
        Get
            Return CTravel

        End Get
    End Property

End Class




Public Class cCustomer
    Private CustomerID As String
    Private FirstName As String
    Private surname As String
    Private Adress As String
    Private Postcode As String
    Private town As String
    Private Number As Integer
    Private proveofID As String



    Public Property cCustomerID() As String
        Set(value As String)
            cCustomerID = value
        End Set
        Get
            Return cCustomerID

        End Get
    End Property

    Public Property cFirtname() As String
        Set(value As String)
            cFirtname = value
        End Set
        Get
            Return cFirtname

        End Get
    End Property

    Public Property cPostcode() As String
        Set(value As String)
            cPostcode = value
        End Set
        Get
            Return cPostcode

        End Get
    End Property

    Public Property cSurname() As String
        Set(value As String)
            cSurname = value
        End Set
        Get
            Return cSurname

        End Get
    End Property

    Public Property cTown() As String
        Set(value As String)
            cTown = value
        End Set
        Get
            Return cTown

        End Get
    End Property

    Public Property cNumber() As String
        Set(value As String)
            cNumber = value
        End Set
        Get
            Return cNumber

        End Get
    End Property

    Public Property cProveofID() As String
        Set(value As String)
            cProveofID = value
        End Set
        Get
            Return cProveofID

        End Get
    End Property
End Class
