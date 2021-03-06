﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountingApp.Console.ConsoleWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConsoleWebService.IConsoleWebService")]
    public interface IConsoleWebService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsoleWebService/SaveConfig", ReplyAction="http://tempuri.org/IConsoleWebService/SaveConfigResponse")]
        void SaveConfig(AccountingApp.Model.config config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsoleWebService/SaveConfig", ReplyAction="http://tempuri.org/IConsoleWebService/SaveConfigResponse")]
        System.Threading.Tasks.Task SaveConfigAsync(AccountingApp.Model.config config);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsoleWebService/GetConfig", ReplyAction="http://tempuri.org/IConsoleWebService/GetConfigResponse")]
        AccountingApp.Model.config GetConfig();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsoleWebService/GetConfig", ReplyAction="http://tempuri.org/IConsoleWebService/GetConfigResponse")]
        System.Threading.Tasks.Task<AccountingApp.Model.config> GetConfigAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsoleWebService/SaveInvoice", ReplyAction="http://tempuri.org/IConsoleWebService/SaveInvoiceResponse")]
        void SaveInvoice(AccountingApp.Model.invoice invoice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsoleWebService/SaveInvoice", ReplyAction="http://tempuri.org/IConsoleWebService/SaveInvoiceResponse")]
        System.Threading.Tasks.Task SaveInvoiceAsync(AccountingApp.Model.invoice invoice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsoleWebService/DeleteInvoice", ReplyAction="http://tempuri.org/IConsoleWebService/DeleteInvoiceResponse")]
        void DeleteInvoice(AccountingApp.Model.invoice invoice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsoleWebService/DeleteInvoice", ReplyAction="http://tempuri.org/IConsoleWebService/DeleteInvoiceResponse")]
        System.Threading.Tasks.Task DeleteInvoiceAsync(AccountingApp.Model.invoice invoice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsoleWebService/GetInvoiceData", ReplyAction="http://tempuri.org/IConsoleWebService/GetInvoiceDataResponse")]
        AccountingApp.Model.invoice[] GetInvoiceData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsoleWebService/GetInvoiceData", ReplyAction="http://tempuri.org/IConsoleWebService/GetInvoiceDataResponse")]
        System.Threading.Tasks.Task<AccountingApp.Model.invoice[]> GetInvoiceDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsoleWebService/FetchListForJpk", ReplyAction="http://tempuri.org/IConsoleWebService/FetchListForJpkResponse")]
        AccountingApp.Model.invoice[] FetchListForJpk(System.DateTime dateFrom, System.DateTime dateTo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsoleWebService/FetchListForJpk", ReplyAction="http://tempuri.org/IConsoleWebService/FetchListForJpkResponse")]
        System.Threading.Tasks.Task<AccountingApp.Model.invoice[]> FetchListForJpkAsync(System.DateTime dateFrom, System.DateTime dateTo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IConsoleWebServiceChannel : AccountingApp.Console.ConsoleWebService.IConsoleWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConsoleWebServiceClient : System.ServiceModel.ClientBase<AccountingApp.Console.ConsoleWebService.IConsoleWebService>, AccountingApp.Console.ConsoleWebService.IConsoleWebService {
        
        public ConsoleWebServiceClient() {
        }
        
        public ConsoleWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConsoleWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConsoleWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConsoleWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SaveConfig(AccountingApp.Model.config config) {
            base.Channel.SaveConfig(config);
        }
        
        public System.Threading.Tasks.Task SaveConfigAsync(AccountingApp.Model.config config) {
            return base.Channel.SaveConfigAsync(config);
        }
        
        public AccountingApp.Model.config GetConfig() {
            return base.Channel.GetConfig();
        }
        
        public System.Threading.Tasks.Task<AccountingApp.Model.config> GetConfigAsync() {
            return base.Channel.GetConfigAsync();
        }
        
        public void SaveInvoice(AccountingApp.Model.invoice invoice) {
            base.Channel.SaveInvoice(invoice);
        }
        
        public System.Threading.Tasks.Task SaveInvoiceAsync(AccountingApp.Model.invoice invoice) {
            return base.Channel.SaveInvoiceAsync(invoice);
        }
        
        public void DeleteInvoice(AccountingApp.Model.invoice invoice) {
            base.Channel.DeleteInvoice(invoice);
        }
        
        public System.Threading.Tasks.Task DeleteInvoiceAsync(AccountingApp.Model.invoice invoice) {
            return base.Channel.DeleteInvoiceAsync(invoice);
        }
        
        public AccountingApp.Model.invoice[] GetInvoiceData() {
            return base.Channel.GetInvoiceData();
        }
        
        public System.Threading.Tasks.Task<AccountingApp.Model.invoice[]> GetInvoiceDataAsync() {
            return base.Channel.GetInvoiceDataAsync();
        }
        
        public AccountingApp.Model.invoice[] FetchListForJpk(System.DateTime dateFrom, System.DateTime dateTo) {
            return base.Channel.FetchListForJpk(dateFrom, dateTo);
        }
        
        public System.Threading.Tasks.Task<AccountingApp.Model.invoice[]> FetchListForJpkAsync(System.DateTime dateFrom, System.DateTime dateTo) {
            return base.Channel.FetchListForJpkAsync(dateFrom, dateTo);
        }
    }
}
