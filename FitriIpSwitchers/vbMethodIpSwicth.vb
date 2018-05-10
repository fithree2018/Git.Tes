Imports System.Management
Namespace FitriKHCode
    Public Class vbMethodIpSwicth
        Public Function IpSwitchTo(ByVal IPAddress As String, ByVal SubnetMask As String, ByVal Gateway As String) As String
            Dim result As String = ""
            Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
            Dim objMOC As ManagementObjectCollection = objMC.GetInstances()

            For Each objMO As ManagementObject In objMOC
                If (Not CBool(objMO("IPEnabled"))) Then
                    Continue For
                End If

                Try
                    Dim objNewIP As ManagementBaseObject = Nothing
                    Dim objSetIP As ManagementBaseObject = Nothing
                    Dim objNewGate As ManagementBaseObject = Nothing

                    objNewIP = objMO.GetMethodParameters("EnableStatic")
                    objNewGate = objMO.GetMethodParameters("SetGateways")

                    'Set DefaultGateway
                    objNewGate("DefaultIPGateway") = New String() {Gateway}
                    objNewGate("GatewayCostMetric") = New Integer() {1}

                    'Set IPAddress and Subnet Mask
                    objNewIP("IPAddress") = New String() {IPAddress}
                    objNewIP("SubnetMask") = New String() {SubnetMask}

                    objSetIP = objMO.InvokeMethod("EnableStatic", objNewIP, Nothing)
                    objSetIP = objMO.InvokeMethod("SetGateways", objNewGate, Nothing)

                    result = "Updated IPAddress, SubnetMask and Default Gateway!"
                    Return result
                Catch ex As Exception
                    result = "Unable to Set IP : " & ex.Message
                End Try
            Next objMO

            Return result
        End Function
    End Class
End Namespace


