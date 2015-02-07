﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.0.30319.1.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="checkVatBinding", Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat")]
public class checkVatService : System.Web.Services.Protocols.SoapHttpClientProtocol {
	
	private System.Threading.SendOrPostCallback checkVatOperationCompleted;
	
	private System.Threading.SendOrPostCallback checkVatApproxOperationCompleted;
	
	/// <remarks/>
	public checkVatService() {
		this.Url = "http://ec.europa.eu/taxation_customs/vies/services/checkVatService";
	}
	
	/// <remarks/>
	public event checkVatCompletedEventHandler checkVatCompleted;
	
	/// <remarks/>
	public event checkVatApproxCompletedEventHandler checkVatApproxCompleted;
	
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", ResponseNamespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	[return: System.Xml.Serialization.XmlElementAttribute("requestDate", DataType="date")]
	public System.DateTime checkVat(ref string countryCode, ref string vatNumber, out bool valid, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] out string name, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] out string address) {
		object[] results = this.Invoke("checkVat", new object[] {
					countryCode,
					vatNumber});
		countryCode = ((string)(results[1]));
		vatNumber = ((string)(results[2]));
		valid = ((bool)(results[3]));
		name = ((string)(results[4]));
		address = ((string)(results[5]));
		return ((System.DateTime)(results[0]));
	}
	
	/// <remarks/>
	public System.IAsyncResult BegincheckVat(string countryCode, string vatNumber, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("checkVat", new object[] {
					countryCode,
					vatNumber}, callback, asyncState);
	}
	
	/// <remarks/>
	public System.DateTime EndcheckVat(System.IAsyncResult asyncResult, out string countryCode, out string vatNumber, out bool valid, out string name, out string address) {
		object[] results = this.EndInvoke(asyncResult);
		countryCode = ((string)(results[1]));
		vatNumber = ((string)(results[2]));
		valid = ((bool)(results[3]));
		name = ((string)(results[4]));
		address = ((string)(results[5]));
		return ((System.DateTime)(results[0]));
	}
	
	/// <remarks/>
	public void checkVatAsync(string countryCode, string vatNumber) {
		this.checkVatAsync(countryCode, vatNumber, null);
	}
	
	/// <remarks/>
	public void checkVatAsync(string countryCode, string vatNumber, object userState) {
		if ((this.checkVatOperationCompleted == null)) {
			this.checkVatOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckVatOperationCompleted);
		}
		this.InvokeAsync("checkVat", new object[] {
					countryCode,
					vatNumber}, this.checkVatOperationCompleted, userState);
	}
	
	private void OncheckVatOperationCompleted(object arg) {
		if ((this.checkVatCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
			this.checkVatCompleted(this, new checkVatCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
	
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", ResponseNamespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	[return: System.Xml.Serialization.XmlElementAttribute("requestDate", DataType="date")]
	public System.DateTime checkVatApprox(
				ref string countryCode, 
				ref string vatNumber, 
				ref string traderName, 
				ref string traderCompanyType, 
				ref string traderStreet, 
				ref string traderPostcode, 
				ref string traderCity, 
				string requesterCountryCode, 
				string requesterVatNumber, 
				out bool valid, 
				[System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] out string traderAddress, 
				out matchCode traderNameMatch, 
				[System.Xml.Serialization.XmlIgnoreAttribute()] out bool traderNameMatchSpecified, 
				out matchCode traderCompanyTypeMatch, 
				[System.Xml.Serialization.XmlIgnoreAttribute()] out bool traderCompanyTypeMatchSpecified, 
				out matchCode traderStreetMatch, 
				[System.Xml.Serialization.XmlIgnoreAttribute()] out bool traderStreetMatchSpecified, 
				out matchCode traderPostcodeMatch, 
				[System.Xml.Serialization.XmlIgnoreAttribute()] out bool traderPostcodeMatchSpecified, 
				out matchCode traderCityMatch, 
				[System.Xml.Serialization.XmlIgnoreAttribute()] out bool traderCityMatchSpecified, 
				out string requestIdentifier) {
		object[] results = this.Invoke("checkVatApprox", new object[] {
					countryCode,
					vatNumber,
					traderName,
					traderCompanyType,
					traderStreet,
					traderPostcode,
					traderCity,
					requesterCountryCode,
					requesterVatNumber});
		countryCode = ((string)(results[1]));
		vatNumber = ((string)(results[2]));
		traderName = ((string)(results[3]));
		traderCompanyType = ((string)(results[4]));
		traderStreet = ((string)(results[5]));
		traderPostcode = ((string)(results[6]));
		traderCity = ((string)(results[7]));
		valid = ((bool)(results[8]));
		traderAddress = ((string)(results[9]));
		traderNameMatch = ((matchCode)(results[10]));
		traderNameMatchSpecified = ((bool)(results[11]));
		traderCompanyTypeMatch = ((matchCode)(results[12]));
		traderCompanyTypeMatchSpecified = ((bool)(results[13]));
		traderStreetMatch = ((matchCode)(results[14]));
		traderStreetMatchSpecified = ((bool)(results[15]));
		traderPostcodeMatch = ((matchCode)(results[16]));
		traderPostcodeMatchSpecified = ((bool)(results[17]));
		traderCityMatch = ((matchCode)(results[18]));
		traderCityMatchSpecified = ((bool)(results[19]));
		requestIdentifier = ((string)(results[20]));
		return ((System.DateTime)(results[0]));
	}
	
	/// <remarks/>
	public System.IAsyncResult BegincheckVatApprox(string countryCode, string vatNumber, string traderName, string traderCompanyType, string traderStreet, string traderPostcode, string traderCity, string requesterCountryCode, string requesterVatNumber, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("checkVatApprox", new object[] {
					countryCode,
					vatNumber,
					traderName,
					traderCompanyType,
					traderStreet,
					traderPostcode,
					traderCity,
					requesterCountryCode,
					requesterVatNumber}, callback, asyncState);
	}
	
	/// <remarks/>
	public System.DateTime EndcheckVatApprox(
				System.IAsyncResult asyncResult, 
				out string countryCode, 
				out string vatNumber, 
				out string traderName, 
				out string traderCompanyType, 
				out string traderStreet, 
				out string traderPostcode, 
				out string traderCity, 
				out bool valid, 
				out string traderAddress, 
				out matchCode traderNameMatch, 
				out bool traderNameMatchSpecified, 
				out matchCode traderCompanyTypeMatch, 
				out bool traderCompanyTypeMatchSpecified, 
				out matchCode traderStreetMatch, 
				out bool traderStreetMatchSpecified, 
				out matchCode traderPostcodeMatch, 
				out bool traderPostcodeMatchSpecified, 
				out matchCode traderCityMatch, 
				out bool traderCityMatchSpecified, 
				out string requestIdentifier) {
		object[] results = this.EndInvoke(asyncResult);
		countryCode = ((string)(results[1]));
		vatNumber = ((string)(results[2]));
		traderName = ((string)(results[3]));
		traderCompanyType = ((string)(results[4]));
		traderStreet = ((string)(results[5]));
		traderPostcode = ((string)(results[6]));
		traderCity = ((string)(results[7]));
		valid = ((bool)(results[8]));
		traderAddress = ((string)(results[9]));
		traderNameMatch = ((matchCode)(results[10]));
		traderNameMatchSpecified = ((bool)(results[11]));
		traderCompanyTypeMatch = ((matchCode)(results[12]));
		traderCompanyTypeMatchSpecified = ((bool)(results[13]));
		traderStreetMatch = ((matchCode)(results[14]));
		traderStreetMatchSpecified = ((bool)(results[15]));
		traderPostcodeMatch = ((matchCode)(results[16]));
		traderPostcodeMatchSpecified = ((bool)(results[17]));
		traderCityMatch = ((matchCode)(results[18]));
		traderCityMatchSpecified = ((bool)(results[19]));
		requestIdentifier = ((string)(results[20]));
		return ((System.DateTime)(results[0]));
	}
	
	/// <remarks/>
	public void checkVatApproxAsync(string countryCode, string vatNumber, string traderName, string traderCompanyType, string traderStreet, string traderPostcode, string traderCity, string requesterCountryCode, string requesterVatNumber) {
		this.checkVatApproxAsync(countryCode, vatNumber, traderName, traderCompanyType, traderStreet, traderPostcode, traderCity, requesterCountryCode, requesterVatNumber, null);
	}
	
	/// <remarks/>
	public void checkVatApproxAsync(string countryCode, string vatNumber, string traderName, string traderCompanyType, string traderStreet, string traderPostcode, string traderCity, string requesterCountryCode, string requesterVatNumber, object userState) {
		if ((this.checkVatApproxOperationCompleted == null)) {
			this.checkVatApproxOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckVatApproxOperationCompleted);
		}
		this.InvokeAsync("checkVatApprox", new object[] {
					countryCode,
					vatNumber,
					traderName,
					traderCompanyType,
					traderStreet,
					traderPostcode,
					traderCity,
					requesterCountryCode,
					requesterVatNumber}, this.checkVatApproxOperationCompleted, userState);
	}
	
	private void OncheckVatApproxOperationCompleted(object arg) {
		if ((this.checkVatApproxCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
			this.checkVatApproxCompleted(this, new checkVatApproxCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
	
	/// <remarks/>
	public new void CancelAsync(object userState) {
		base.CancelAsync(userState);
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types")]
public enum matchCode {
	
	/// <remarks/>
	[System.Xml.Serialization.XmlEnumAttribute("1")]
	Item1,
	
	/// <remarks/>
	[System.Xml.Serialization.XmlEnumAttribute("2")]
	Item2,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
public delegate void checkVatCompletedEventHandler(object sender, checkVatCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class checkVatCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
	
	private object[] results;
	
	internal checkVatCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
			base(exception, cancelled, userState) {
		this.results = results;
	}
	
	/// <remarks/>
	public System.DateTime Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((System.DateTime)(this.results[0]));
		}
	}
	
	/// <remarks/>
	public string countryCode {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string)(this.results[1]));
		}
	}
	
	/// <remarks/>
	public string vatNumber {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string)(this.results[2]));
		}
	}
	
	/// <remarks/>
	public bool valid {
		get {
			this.RaiseExceptionIfNecessary();
			return ((bool)(this.results[3]));
		}
	}
	
	/// <remarks/>
	public string name {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string)(this.results[4]));
		}
	}
	
	/// <remarks/>
	public string address {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string)(this.results[5]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
public delegate void checkVatApproxCompletedEventHandler(object sender, checkVatApproxCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class checkVatApproxCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
	
	private object[] results;
	
	internal checkVatApproxCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
			base(exception, cancelled, userState) {
		this.results = results;
	}
	
	/// <remarks/>
	public System.DateTime Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((System.DateTime)(this.results[0]));
		}
	}
	
	/// <remarks/>
	public string countryCode {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string)(this.results[1]));
		}
	}
	
	/// <remarks/>
	public string vatNumber {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string)(this.results[2]));
		}
	}
	
	/// <remarks/>
	public string traderName {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string)(this.results[3]));
		}
	}
	
	/// <remarks/>
	public string traderCompanyType {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string)(this.results[4]));
		}
	}
	
	/// <remarks/>
	public string traderStreet {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string)(this.results[5]));
		}
	}
	
	/// <remarks/>
	public string traderPostcode {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string)(this.results[6]));
		}
	}
	
	/// <remarks/>
	public string traderCity {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string)(this.results[7]));
		}
	}
	
	/// <remarks/>
	public bool valid {
		get {
			this.RaiseExceptionIfNecessary();
			return ((bool)(this.results[8]));
		}
	}
	
	/// <remarks/>
	public string traderAddress {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string)(this.results[9]));
		}
	}
	
	/// <remarks/>
	public matchCode traderNameMatch {
		get {
			this.RaiseExceptionIfNecessary();
			return ((matchCode)(this.results[10]));
		}
	}
	
	/// <remarks/>
	public bool traderNameMatchSpecified {
		get {
			this.RaiseExceptionIfNecessary();
			return ((bool)(this.results[11]));
		}
	}
	
	/// <remarks/>
	public matchCode traderCompanyTypeMatch {
		get {
			this.RaiseExceptionIfNecessary();
			return ((matchCode)(this.results[12]));
		}
	}
	
	/// <remarks/>
	public bool traderCompanyTypeMatchSpecified {
		get {
			this.RaiseExceptionIfNecessary();
			return ((bool)(this.results[13]));
		}
	}
	
	/// <remarks/>
	public matchCode traderStreetMatch {
		get {
			this.RaiseExceptionIfNecessary();
			return ((matchCode)(this.results[14]));
		}
	}
	
	/// <remarks/>
	public bool traderStreetMatchSpecified {
		get {
			this.RaiseExceptionIfNecessary();
			return ((bool)(this.results[15]));
		}
	}
	
	/// <remarks/>
	public matchCode traderPostcodeMatch {
		get {
			this.RaiseExceptionIfNecessary();
			return ((matchCode)(this.results[16]));
		}
	}
	
	/// <remarks/>
	public bool traderPostcodeMatchSpecified {
		get {
			this.RaiseExceptionIfNecessary();
			return ((bool)(this.results[17]));
		}
	}
	
	/// <remarks/>
	public matchCode traderCityMatch {
		get {
			this.RaiseExceptionIfNecessary();
			return ((matchCode)(this.results[18]));
		}
	}
	
	/// <remarks/>
	public bool traderCityMatchSpecified {
		get {
			this.RaiseExceptionIfNecessary();
			return ((bool)(this.results[19]));
		}
	}
	
	/// <remarks/>
	public string requestIdentifier {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string)(this.results[20]));
		}
	}
}
