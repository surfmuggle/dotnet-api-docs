﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System.Runtime.Serialization

<Assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://microsoft.wcf.documentation", ClrNamespace:="microsoft.wcf.documentation")>

Namespace microsoft.wcf.documentation


	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0"), System.Runtime.Serialization.DataContractAttribute()> _
	Partial Public Class SampleFault
		Inherits Object
		Implements System.Runtime.Serialization.IExtensibleDataObject

		Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject

		Private FaultMessageField As String

		Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
			Get
				Return Me.extensionDataField
			End Get
			Set(ByVal value As System.Runtime.Serialization.ExtensionDataObject)
				Me.extensionDataField = value
			End Set
		End Property

		<System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property FaultMessage() As String
			Get
				Return Me.FaultMessageField
			End Get
			Set(ByVal value As String)
				Me.FaultMessageField = value
			End Set
		End Property
	End Class
End Namespace


<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), System.ServiceModel.ServiceContractAttribute(Namespace:="http://microsoft.wcf.documentation", ConfigurationName:="ISampleService")> _
Public Interface ISampleService

	<System.ServiceModel.OperationContractAttribute(Action:="http://microsoft.wcf.documentation/ISampleService/SampleMethod", ReplyAction:="http://microsoft.wcf.documentation/ISampleService/SampleMethodResponse"), System.ServiceModel.FaultContractAttribute(GetType(microsoft.wcf.documentation.SampleFault), Action:="http://microsoft.wcf.documentation/ISampleService/SampleMethodSampleFaultFault", Name:="SampleFault")> _
	Function SampleMethod(ByVal msg As String) As String
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Public Interface ISampleServiceChannel
	Inherits ISampleService, System.ServiceModel.IClientChannel
End Interface

<System.Diagnostics.DebuggerStepThroughAttribute(), System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Partial Public Class SampleServiceClient
	Inherits System.ServiceModel.ClientBase(Of ISampleService)
	Implements ISampleService

	Public Sub New()
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

	Public Function SampleMethod(ByVal msg As String) As String Implements ISampleService.SampleMethod
		Return MyBase.Channel.SampleMethod(msg)
	End Function
End Class
