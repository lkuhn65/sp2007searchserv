﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1433
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.1433.
'
Namespace SPSearchWS
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="QueryServiceSoap", [Namespace]:="http://microsoft.com/webservices/SharePoint/QueryService")>  _
    Partial Public Class QueryService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private QueryOperationCompleted As System.Threading.SendOrPostCallback
        
        Private QueryExOperationCompleted As System.Threading.SendOrPostCallback
        
        Private RegistrationOperationCompleted As System.Threading.SendOrPostCallback
        
        Private StatusOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.SharePointSearchServiceTool.My.MySettings.Default.SharePointSearchServiceTool_SPSearchWS_QueryService
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event QueryCompleted As QueryCompletedEventHandler
        
        '''<remarks/>
        Public Event QueryExCompleted As QueryExCompletedEventHandler
        
        '''<remarks/>
        Public Event RegistrationCompleted As RegistrationCompletedEventHandler
        
        '''<remarks/>
        Public Event StatusCompleted As StatusCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:Microsoft.Search/Query", RequestNamespace:="urn:Microsoft.Search", ResponseNamespace:="urn:Microsoft.Search", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Query(ByVal queryXml As String) As String
            Dim results() As Object = Me.Invoke("Query", New Object() {queryXml})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub QueryAsync(ByVal queryXml As String)
            Me.QueryAsync(queryXml, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub QueryAsync(ByVal queryXml As String, ByVal userState As Object)
            If (Me.QueryOperationCompleted Is Nothing) Then
                Me.QueryOperationCompleted = AddressOf Me.OnQueryOperationCompleted
            End If
            Me.InvokeAsync("Query", New Object() {queryXml}, Me.QueryOperationCompleted, userState)
        End Sub
        
        Private Sub OnQueryOperationCompleted(ByVal arg As Object)
            If (Not (Me.QueryCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent QueryCompleted(Me, New QueryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://microsoft.com/webservices/SharePoint/QueryService/QueryEx", RequestNamespace:="http://microsoft.com/webservices/SharePoint/QueryService", ResponseNamespace:="http://microsoft.com/webservices/SharePoint/QueryService", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function QueryEx(ByVal queryXml As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("QueryEx", New Object() {queryXml})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Overloads Sub QueryExAsync(ByVal queryXml As String)
            Me.QueryExAsync(queryXml, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub QueryExAsync(ByVal queryXml As String, ByVal userState As Object)
            If (Me.QueryExOperationCompleted Is Nothing) Then
                Me.QueryExOperationCompleted = AddressOf Me.OnQueryExOperationCompleted
            End If
            Me.InvokeAsync("QueryEx", New Object() {queryXml}, Me.QueryExOperationCompleted, userState)
        End Sub
        
        Private Sub OnQueryExOperationCompleted(ByVal arg As Object)
            If (Not (Me.QueryExCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent QueryExCompleted(Me, New QueryExCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:Microsoft.Search/Registration", RequestNamespace:="urn:Microsoft.Search", ResponseNamespace:="urn:Microsoft.Search", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Registration(ByVal registrationXml As String) As String
            Dim results() As Object = Me.Invoke("Registration", New Object() {registrationXml})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub RegistrationAsync(ByVal registrationXml As String)
            Me.RegistrationAsync(registrationXml, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub RegistrationAsync(ByVal registrationXml As String, ByVal userState As Object)
            If (Me.RegistrationOperationCompleted Is Nothing) Then
                Me.RegistrationOperationCompleted = AddressOf Me.OnRegistrationOperationCompleted
            End If
            Me.InvokeAsync("Registration", New Object() {registrationXml}, Me.RegistrationOperationCompleted, userState)
        End Sub
        
        Private Sub OnRegistrationOperationCompleted(ByVal arg As Object)
            If (Not (Me.RegistrationCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent RegistrationCompleted(Me, New RegistrationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:Microsoft.Search/Status", RequestNamespace:="urn:Microsoft.Search", ResponseNamespace:="urn:Microsoft.Search", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Status() As String
            Dim results() As Object = Me.Invoke("Status", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub StatusAsync()
            Me.StatusAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub StatusAsync(ByVal userState As Object)
            If (Me.StatusOperationCompleted Is Nothing) Then
                Me.StatusOperationCompleted = AddressOf Me.OnStatusOperationCompleted
            End If
            Me.InvokeAsync("Status", New Object(-1) {}, Me.StatusOperationCompleted, userState)
        End Sub
        
        Private Sub OnStatusOperationCompleted(ByVal arg As Object)
            If (Not (Me.StatusCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent StatusCompleted(Me, New StatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")>  _
    Public Delegate Sub QueryCompletedEventHandler(ByVal sender As Object, ByVal e As QueryCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class QueryCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")>  _
    Public Delegate Sub QueryExCompletedEventHandler(ByVal sender As Object, ByVal e As QueryExCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class QueryExCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As System.Data.DataSet
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),System.Data.DataSet)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")>  _
    Public Delegate Sub RegistrationCompletedEventHandler(ByVal sender As Object, ByVal e As RegistrationCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class RegistrationCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")>  _
    Public Delegate Sub StatusCompletedEventHandler(ByVal sender As Object, ByVal e As StatusCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class StatusCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
End Namespace