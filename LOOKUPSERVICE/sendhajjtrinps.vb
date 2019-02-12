Namespace sendHajjTrip1
    <DataContract>
    Public Class SendHajjTrip
        <DataMember(IsRequired:=False)>
        Public Property SHT_TAFWEEJ_ID As String
        <DataMember(IsRequired:=False)>
        Public Property SHT_NAQABA_CONFIRM_NO As String
        <DataMember(IsRequired:=False)>
        Public Property SHT_EST_ID As String
        <DataMember(IsRequired:=False)>
        Public Property SHT_HEB_ID As String
        <DataMember(IsRequired:=False)>
        Public Property SHT_TRIP_ID As String
        <DataMember(IsRequired:=False)>
        Public Property SHT_LTC_ID As String
        <DataMember(IsRequired:=False)>
        Public Property SHT_BUS_ID As String
        <DataMember(IsRequired:=False)>
        Public Property SHT_DRIVER_ID As String
        <DataMember(IsRequired:=False)>
        Public Property SHT_STATE As String
        <DataMember(IsRequired:=False)>
        Public Property SHT_TYPE As String
        <DataMember(IsRequired:=False)>
        Public Property SHT_TRIP_DATE As DateTime
        <DataMember>
        Public Property Details As Details
        <DataMember>
        Public Property DRIVER_NAME As String
        <DataMember>
        Public Property DRIVER_IDENTIFICATION_NO As String
        <DataMember>
        Public Property PLATE_NO As String
        <DataMember>
        Public Property VEHICLE_TYPE_ID As String
        <DataMember>
        Public Property SHT_PATH_ID As String
        <DataMember(IsRequired:=False)>
        Public Property SHT_PATH_TYPE_ID As String
        <DataMember(IsRequired:=False)>
        Public Property SHT_TO_EST_ID As String
    End Class

    <DataContract>
    Public Class Details
        <DataMember>
        Public Property Flights As Flight()
        <DataMember>
        Public Property Houses As House()
    End Class

    <DataContract>
    Public Class Flight
        <DataMember>
        Public Property SHT_FD_ID As Long
        <DataMember>
        Public Property HAJJS As HAJJS()
    End Class

    <DataContract>
    Public Class HAJJS
        <DataMember>
        Public Property SHT_HD_ID As String
        <DataMember>
        Public Property SHT_NT_ID As String
        <DataMember(IsRequired:=False)>
        Public Property SHT_TAFWEEJ_ID As String
        <DataMember>
        Public Property SHT_HEB_ID As String
    End Class

    <DataContract>
    Public Class House
        <DataMember>
        Public Property HT_HC_ID As Long
        <DataMember>
        Public Property HAJJS As HAJJS()
    End Class
End Namespace