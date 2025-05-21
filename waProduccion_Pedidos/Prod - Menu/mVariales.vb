Module mVariales
    Private mListaPrecios As String
    Private mCodigoArticulo As String
    Private mCodigoArticulo2 As String
    Private mNombreArticulo As String
    Private mBodega As String
    Private mValorProducir As String
    Private mNumSAP As String
    Private mOrigenes As String
    Private mTipoOrden As String
    Private mBoolean As Boolean
    Private mTabla1 As New DataTable

    Public Property vpListaPrecios() As String
        Get
            Return mListaPrecios
        End Get
        Set(ByVal Value As String)
            mListaPrecios = Value
        End Set
    End Property
    Public Property vpCodigoArticulo() As String
        Get
            Return mCodigoArticulo
        End Get
        Set(ByVal Value As String)
            mCodigoArticulo = Value
        End Set
    End Property
    Public Property vpCodigoArticulo2() As String
        Get
            Return mCodigoArticulo2
        End Get
        Set(ByVal Value As String)
            mCodigoArticulo2 = Value
        End Set
    End Property

    Public Property vpBodega() As String
        Get
            Return mBodega
        End Get
        Set(ByVal Value As String)
            mBodega = Value
        End Set
    End Property

    Public Property vpNombreArticulo() As String
        Get
            Return mNombreArticulo
        End Get
        Set(ByVal Value As String)
            mNombreArticulo = Value
        End Set
    End Property

    Public Property vpNumSAP() As String
        Get
            Return mNumSAP
        End Get
        Set(ByVal Value As String)
            mNumSAP = Value
        End Set
    End Property



    Public Property vpValorProducir() As Integer
        Get
            Return mValorProducir
        End Get
        Set(ByVal Value As Integer)
            mValorProducir = Value
        End Set
    End Property

    Public Property vpTabla1() As DataTable
        Get
            Return mTabla1
        End Get
        Set(ByVal Value As DataTable)
            mTabla1 = Value
        End Set
    End Property

    Public Property vpOrigenes() As String
        Get
            Return mOrigenes
        End Get
        Set(ByVal Value As String)
            mOrigenes = Value
        End Set
    End Property
    Public Property vpTipoOrden() As String
        Get
            Return mTipoOrden
        End Get
        Set(ByVal Value As String)
            mTipoOrden = Value
        End Set
    End Property

    Public Property vpBoolean() As Boolean
        Get
            Return mBoolean
        End Get
        Set(ByVal Value As Boolean)
            mBoolean = Value
        End Set
    End Property

End Module
