﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), _
 System.ServiceModel.ServiceContractAttribute([Namespace]:="http://Microsoft.ServiceModel.Samples", ConfigurationName:="IUpload")> _
Public Interface IUpload

    <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/IUpload/Upload", ReplyAction:="http://Microsoft.ServiceModel.Samples/IUpload/UploadResponse")> _
    Function Upload(ByVal data As System.IO.Stream) As Integer
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Public Interface IUploadChannel
    Inherits IUpload, System.ServiceModel.IClientChannel
End Interface

<System.Diagnostics.DebuggerStepThroughAttribute(), _
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Partial Public Class UploadClient
    Inherits System.ServiceModel.ClientBase(Of IUpload)
    Implements IUpload

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal endpointConfigurationName As String)
        MyBase.New(endpointConfigurationName)
    End Sub

    Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
        MyBase.New(endpointConfigurationName, remoteAddress)
    End Sub

    Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
        MyBase.New(endpointConfigurationName, remoteAddress)
    End Sub

    Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
        MyBase.New(binding, remoteAddress)
    End Sub

    Public Function Upload(ByVal data As System.IO.Stream) As Integer Implements IUpload.Upload
        Return MyBase.Channel.Upload(data)
    End Function
End Class