﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3625
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.3625.
// 
#pragma warning disable 1591

namespace SIPV.Datos.ws_SIPV_incop {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="UI_WS_CARGA_DATOSSoap", Namespace="http://tempuri.org/")]
    public partial class UI_WS_CARGA_DATOS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback Actualizar_MaestroOperationCompleted;
        
        private System.Threading.SendOrPostCallback Cargar_TransaccionesOperationCompleted;
        
        private System.Threading.SendOrPostCallback Consultar_PeriodosOperationCompleted;
        
        private System.Threading.SendOrPostCallback Consultar_TransmisionOperationCompleted;
        
        private System.Threading.SendOrPostCallback Registrar_Cifra_ControlOperationCompleted;
        
        private System.Threading.SendOrPostCallback Actualizar_EquivalenciaOperationCompleted;
        
        private System.Threading.SendOrPostCallback Consultar_EquivalenciaOperationCompleted;
        
        private System.Threading.SendOrPostCallback Listar_MaestroOperationCompleted;
        
        private System.Threading.SendOrPostCallback Consultar_Registro_MaestroOperationCompleted;
        
        private System.Threading.SendOrPostCallback Iniciar_TransmisionOperationCompleted;
        
        private System.Threading.SendOrPostCallback Finalizar_TransmisionOperationCompleted;
        
        private System.Threading.SendOrPostCallback Cancelar_TransmisionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public UI_WS_CARGA_DATOS() {
            this.Url = global::SIPV.Datos.Properties.Settings.Default.Estadisticas_Datos_ws_estadisticas_incop_UI_WS_CARGA_DATOS;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event Actualizar_MaestroCompletedEventHandler Actualizar_MaestroCompleted;
        
        /// <remarks/>
        public event Cargar_TransaccionesCompletedEventHandler Cargar_TransaccionesCompleted;
        
        /// <remarks/>
        public event Consultar_PeriodosCompletedEventHandler Consultar_PeriodosCompleted;
        
        /// <remarks/>
        public event Consultar_TransmisionCompletedEventHandler Consultar_TransmisionCompleted;
        
        /// <remarks/>
        public event Registrar_Cifra_ControlCompletedEventHandler Registrar_Cifra_ControlCompleted;
        
        /// <remarks/>
        public event Actualizar_EquivalenciaCompletedEventHandler Actualizar_EquivalenciaCompleted;
        
        /// <remarks/>
        public event Consultar_EquivalenciaCompletedEventHandler Consultar_EquivalenciaCompleted;
        
        /// <remarks/>
        public event Listar_MaestroCompletedEventHandler Listar_MaestroCompleted;
        
        /// <remarks/>
        public event Consultar_Registro_MaestroCompletedEventHandler Consultar_Registro_MaestroCompleted;
        
        /// <remarks/>
        public event Iniciar_TransmisionCompletedEventHandler Iniciar_TransmisionCompleted;
        
        /// <remarks/>
        public event Finalizar_TransmisionCompletedEventHandler Finalizar_TransmisionCompleted;
        
        /// <remarks/>
        public event Cancelar_TransmisionCompletedEventHandler Cancelar_TransmisionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Actualizar_Maestro", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Actualizar_Maestro(System.Data.DataTable mTable, string Tabla, string Muelle) {
            this.Invoke("Actualizar_Maestro", new object[] {
                        mTable,
                        Tabla,
                        Muelle});
        }
        
        /// <remarks/>
        public void Actualizar_MaestroAsync(System.Data.DataTable mTable, string Tabla, string Muelle) {
            this.Actualizar_MaestroAsync(mTable, Tabla, Muelle, null);
        }
        
        /// <remarks/>
        public void Actualizar_MaestroAsync(System.Data.DataTable mTable, string Tabla, string Muelle, object userState) {
            if ((this.Actualizar_MaestroOperationCompleted == null)) {
                this.Actualizar_MaestroOperationCompleted = new System.Threading.SendOrPostCallback(this.OnActualizar_MaestroOperationCompleted);
            }
            this.InvokeAsync("Actualizar_Maestro", new object[] {
                        mTable,
                        Tabla,
                        Muelle}, this.Actualizar_MaestroOperationCompleted, userState);
        }
        
        private void OnActualizar_MaestroOperationCompleted(object arg) {
            if ((this.Actualizar_MaestroCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Actualizar_MaestroCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Cargar_Transacciones", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Cargar_Transacciones(System.Data.DataTable mTable, string Tabla, string Muelle, int Periodo) {
            this.Invoke("Cargar_Transacciones", new object[] {
                        mTable,
                        Tabla,
                        Muelle,
                        Periodo});
        }
        
        /// <remarks/>
        public void Cargar_TransaccionesAsync(System.Data.DataTable mTable, string Tabla, string Muelle, int Periodo) {
            this.Cargar_TransaccionesAsync(mTable, Tabla, Muelle, Periodo, null);
        }
        
        /// <remarks/>
        public void Cargar_TransaccionesAsync(System.Data.DataTable mTable, string Tabla, string Muelle, int Periodo, object userState) {
            if ((this.Cargar_TransaccionesOperationCompleted == null)) {
                this.Cargar_TransaccionesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCargar_TransaccionesOperationCompleted);
            }
            this.InvokeAsync("Cargar_Transacciones", new object[] {
                        mTable,
                        Tabla,
                        Muelle,
                        Periodo}, this.Cargar_TransaccionesOperationCompleted, userState);
        }
        
        private void OnCargar_TransaccionesOperationCompleted(object arg) {
            if ((this.Cargar_TransaccionesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Cargar_TransaccionesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Consultar_Periodos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable Consultar_Periodos(string muelle) {
            object[] results = this.Invoke("Consultar_Periodos", new object[] {
                        muelle});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void Consultar_PeriodosAsync(string muelle) {
            this.Consultar_PeriodosAsync(muelle, null);
        }
        
        /// <remarks/>
        public void Consultar_PeriodosAsync(string muelle, object userState) {
            if ((this.Consultar_PeriodosOperationCompleted == null)) {
                this.Consultar_PeriodosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsultar_PeriodosOperationCompleted);
            }
            this.InvokeAsync("Consultar_Periodos", new object[] {
                        muelle}, this.Consultar_PeriodosOperationCompleted, userState);
        }
        
        private void OnConsultar_PeriodosOperationCompleted(object arg) {
            if ((this.Consultar_PeriodosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Consultar_PeriodosCompleted(this, new Consultar_PeriodosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Consultar_Transmision", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable Consultar_Transmision(string muelle, int periodo) {
            object[] results = this.Invoke("Consultar_Transmision", new object[] {
                        muelle,
                        periodo});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void Consultar_TransmisionAsync(string muelle, int periodo) {
            this.Consultar_TransmisionAsync(muelle, periodo, null);
        }
        
        /// <remarks/>
        public void Consultar_TransmisionAsync(string muelle, int periodo, object userState) {
            if ((this.Consultar_TransmisionOperationCompleted == null)) {
                this.Consultar_TransmisionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsultar_TransmisionOperationCompleted);
            }
            this.InvokeAsync("Consultar_Transmision", new object[] {
                        muelle,
                        periodo}, this.Consultar_TransmisionOperationCompleted, userState);
        }
        
        private void OnConsultar_TransmisionOperationCompleted(object arg) {
            if ((this.Consultar_TransmisionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Consultar_TransmisionCompleted(this, new Consultar_TransmisionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Registrar_Cifra_Control", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Registrar_Cifra_Control(string Catalogo, string Muelle, int periodo, int Registros) {
            this.Invoke("Registrar_Cifra_Control", new object[] {
                        Catalogo,
                        Muelle,
                        periodo,
                        Registros});
        }
        
        /// <remarks/>
        public void Registrar_Cifra_ControlAsync(string Catalogo, string Muelle, int periodo, int Registros) {
            this.Registrar_Cifra_ControlAsync(Catalogo, Muelle, periodo, Registros, null);
        }
        
        /// <remarks/>
        public void Registrar_Cifra_ControlAsync(string Catalogo, string Muelle, int periodo, int Registros, object userState) {
            if ((this.Registrar_Cifra_ControlOperationCompleted == null)) {
                this.Registrar_Cifra_ControlOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegistrar_Cifra_ControlOperationCompleted);
            }
            this.InvokeAsync("Registrar_Cifra_Control", new object[] {
                        Catalogo,
                        Muelle,
                        periodo,
                        Registros}, this.Registrar_Cifra_ControlOperationCompleted, userState);
        }
        
        private void OnRegistrar_Cifra_ControlOperationCompleted(object arg) {
            if ((this.Registrar_Cifra_ControlCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Registrar_Cifra_ControlCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Actualizar_Equivalencia", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Actualizar_Equivalencia(string Catalogo, string Muelle, string Id_unificado, string Id_Muelle) {
            this.Invoke("Actualizar_Equivalencia", new object[] {
                        Catalogo,
                        Muelle,
                        Id_unificado,
                        Id_Muelle});
        }
        
        /// <remarks/>
        public void Actualizar_EquivalenciaAsync(string Catalogo, string Muelle, string Id_unificado, string Id_Muelle) {
            this.Actualizar_EquivalenciaAsync(Catalogo, Muelle, Id_unificado, Id_Muelle, null);
        }
        
        /// <remarks/>
        public void Actualizar_EquivalenciaAsync(string Catalogo, string Muelle, string Id_unificado, string Id_Muelle, object userState) {
            if ((this.Actualizar_EquivalenciaOperationCompleted == null)) {
                this.Actualizar_EquivalenciaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnActualizar_EquivalenciaOperationCompleted);
            }
            this.InvokeAsync("Actualizar_Equivalencia", new object[] {
                        Catalogo,
                        Muelle,
                        Id_unificado,
                        Id_Muelle}, this.Actualizar_EquivalenciaOperationCompleted, userState);
        }
        
        private void OnActualizar_EquivalenciaOperationCompleted(object arg) {
            if ((this.Actualizar_EquivalenciaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Actualizar_EquivalenciaCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Consultar_Equivalencia", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Consultar_Equivalencia(string Maestro, string Muelle, string Codigo) {
            object[] results = this.Invoke("Consultar_Equivalencia", new object[] {
                        Maestro,
                        Muelle,
                        Codigo});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void Consultar_EquivalenciaAsync(string Maestro, string Muelle, string Codigo) {
            this.Consultar_EquivalenciaAsync(Maestro, Muelle, Codigo, null);
        }
        
        /// <remarks/>
        public void Consultar_EquivalenciaAsync(string Maestro, string Muelle, string Codigo, object userState) {
            if ((this.Consultar_EquivalenciaOperationCompleted == null)) {
                this.Consultar_EquivalenciaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsultar_EquivalenciaOperationCompleted);
            }
            this.InvokeAsync("Consultar_Equivalencia", new object[] {
                        Maestro,
                        Muelle,
                        Codigo}, this.Consultar_EquivalenciaOperationCompleted, userState);
        }
        
        private void OnConsultar_EquivalenciaOperationCompleted(object arg) {
            if ((this.Consultar_EquivalenciaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Consultar_EquivalenciaCompleted(this, new Consultar_EquivalenciaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Listar_Maestro", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable Listar_Maestro(string Maestro, string Codigo, string Descripcion) {
            object[] results = this.Invoke("Listar_Maestro", new object[] {
                        Maestro,
                        Codigo,
                        Descripcion});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void Listar_MaestroAsync(string Maestro, string Codigo, string Descripcion) {
            this.Listar_MaestroAsync(Maestro, Codigo, Descripcion, null);
        }
        
        /// <remarks/>
        public void Listar_MaestroAsync(string Maestro, string Codigo, string Descripcion, object userState) {
            if ((this.Listar_MaestroOperationCompleted == null)) {
                this.Listar_MaestroOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListar_MaestroOperationCompleted);
            }
            this.InvokeAsync("Listar_Maestro", new object[] {
                        Maestro,
                        Codigo,
                        Descripcion}, this.Listar_MaestroOperationCompleted, userState);
        }
        
        private void OnListar_MaestroOperationCompleted(object arg) {
            if ((this.Listar_MaestroCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Listar_MaestroCompleted(this, new Listar_MaestroCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Consultar_Registro_Maestro", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable Consultar_Registro_Maestro(string Maestro, string Codigo, string Descripcion, string Filtrar) {
            object[] results = this.Invoke("Consultar_Registro_Maestro", new object[] {
                        Maestro,
                        Codigo,
                        Descripcion,
                        Filtrar});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void Consultar_Registro_MaestroAsync(string Maestro, string Codigo, string Descripcion, string Filtrar) {
            this.Consultar_Registro_MaestroAsync(Maestro, Codigo, Descripcion, Filtrar, null);
        }
        
        /// <remarks/>
        public void Consultar_Registro_MaestroAsync(string Maestro, string Codigo, string Descripcion, string Filtrar, object userState) {
            if ((this.Consultar_Registro_MaestroOperationCompleted == null)) {
                this.Consultar_Registro_MaestroOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsultar_Registro_MaestroOperationCompleted);
            }
            this.InvokeAsync("Consultar_Registro_Maestro", new object[] {
                        Maestro,
                        Codigo,
                        Descripcion,
                        Filtrar}, this.Consultar_Registro_MaestroOperationCompleted, userState);
        }
        
        private void OnConsultar_Registro_MaestroOperationCompleted(object arg) {
            if ((this.Consultar_Registro_MaestroCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Consultar_Registro_MaestroCompleted(this, new Consultar_Registro_MaestroCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Iniciar_Transmision", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Iniciar_Transmision(string muelle, int periodo) {
            this.Invoke("Iniciar_Transmision", new object[] {
                        muelle,
                        periodo});
        }
        
        /// <remarks/>
        public void Iniciar_TransmisionAsync(string muelle, int periodo) {
            this.Iniciar_TransmisionAsync(muelle, periodo, null);
        }
        
        /// <remarks/>
        public void Iniciar_TransmisionAsync(string muelle, int periodo, object userState) {
            if ((this.Iniciar_TransmisionOperationCompleted == null)) {
                this.Iniciar_TransmisionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIniciar_TransmisionOperationCompleted);
            }
            this.InvokeAsync("Iniciar_Transmision", new object[] {
                        muelle,
                        periodo}, this.Iniciar_TransmisionOperationCompleted, userState);
        }
        
        private void OnIniciar_TransmisionOperationCompleted(object arg) {
            if ((this.Iniciar_TransmisionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Iniciar_TransmisionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Finalizar_Transmision", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Finalizar_Transmision(string muelle, int periodo, string usuario) {
            this.Invoke("Finalizar_Transmision", new object[] {
                        muelle,
                        periodo,
                        usuario});
        }
        
        /// <remarks/>
        public void Finalizar_TransmisionAsync(string muelle, int periodo, string usuario) {
            this.Finalizar_TransmisionAsync(muelle, periodo, usuario, null);
        }
        
        /// <remarks/>
        public void Finalizar_TransmisionAsync(string muelle, int periodo, string usuario, object userState) {
            if ((this.Finalizar_TransmisionOperationCompleted == null)) {
                this.Finalizar_TransmisionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFinalizar_TransmisionOperationCompleted);
            }
            this.InvokeAsync("Finalizar_Transmision", new object[] {
                        muelle,
                        periodo,
                        usuario}, this.Finalizar_TransmisionOperationCompleted, userState);
        }
        
        private void OnFinalizar_TransmisionOperationCompleted(object arg) {
            if ((this.Finalizar_TransmisionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Finalizar_TransmisionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Cancelar_Transmision", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Cancelar_Transmision(string muelle, int periodo, string usuario) {
            this.Invoke("Cancelar_Transmision", new object[] {
                        muelle,
                        periodo,
                        usuario});
        }
        
        /// <remarks/>
        public void Cancelar_TransmisionAsync(string muelle, int periodo, string usuario) {
            this.Cancelar_TransmisionAsync(muelle, periodo, usuario, null);
        }
        
        /// <remarks/>
        public void Cancelar_TransmisionAsync(string muelle, int periodo, string usuario, object userState) {
            if ((this.Cancelar_TransmisionOperationCompleted == null)) {
                this.Cancelar_TransmisionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCancelar_TransmisionOperationCompleted);
            }
            this.InvokeAsync("Cancelar_Transmision", new object[] {
                        muelle,
                        periodo,
                        usuario}, this.Cancelar_TransmisionOperationCompleted, userState);
        }
        
        private void OnCancelar_TransmisionOperationCompleted(object arg) {
            if ((this.Cancelar_TransmisionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Cancelar_TransmisionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void Actualizar_MaestroCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void Cargar_TransaccionesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void Consultar_PeriodosCompletedEventHandler(object sender, Consultar_PeriodosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Consultar_PeriodosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Consultar_PeriodosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void Consultar_TransmisionCompletedEventHandler(object sender, Consultar_TransmisionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Consultar_TransmisionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Consultar_TransmisionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void Registrar_Cifra_ControlCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void Actualizar_EquivalenciaCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void Consultar_EquivalenciaCompletedEventHandler(object sender, Consultar_EquivalenciaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Consultar_EquivalenciaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Consultar_EquivalenciaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void Listar_MaestroCompletedEventHandler(object sender, Listar_MaestroCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Listar_MaestroCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Listar_MaestroCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void Consultar_Registro_MaestroCompletedEventHandler(object sender, Consultar_Registro_MaestroCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Consultar_Registro_MaestroCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Consultar_Registro_MaestroCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void Iniciar_TransmisionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void Finalizar_TransmisionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void Cancelar_TransmisionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591