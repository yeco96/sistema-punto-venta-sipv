﻿using System;
using System.Collections.Generic;
using System.Text;
using BaseCode;
using System.ComponentModel;
using System.Reflection;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SIPV.Windows.Catalogos
{
    



    public partial class IU_FORMA_PAGO : BaseCode.frmBaseMant_Grid_DataObj
    {
        #region Constructores

        public IU_FORMA_PAGO(BaseCode.DB vDB, Form Parent)
            :
            base(vDB, Parent, new SIPV.Datos.FORMA_PAGO(vDB))
        {
            InitializeComponent();
            Campos.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.Campos_PropertyValueChanged);
            TextCampoLlave = TbCodigo;
            Cargar_Forma(Parent);
        }

        #endregion

        public override void Cargar_Combos() { }
        public override void EnlazarPropiedades() { }

        public override void ConfigurarConsulta()
        {
            this.SqlQueryMant = "SELECT FORMA_PAGO ,DESCRIPCION FROM FORMA_PAGO";
            this.Enc = new string[] { "ID", "DESCRIPCION" };
            this.Anch = new int[] { 100, 300 };
            this.ConfigurarConsulta(SqlQueryMant, Enc, Anch);
        }

        private void Campos_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            TextCampoLlave.Text = ((SIPV.Datos.FORMA_PAGO)TablaBase).Forma_pago;
        }
        public override void CargarObjsDeDatosDesdeObjsDeInterfaces()
        {

            ((SIPV.Datos.FORMA_PAGO)TablaBase).Forma_pago = TextCampoLlave.Text;
        }
        private void IU_FORMA_PAGO_AntesDatoEnviado(object sender, EventArgs e)
        {
            ((SIPV.Datos.FORMA_PAGO)TablaBase).Forma_pago = DataGrid.DataGrid.Rows[DataGrid.DataGrid.CurrentCell.RowIndex].Cells[0].Value.ToString(); ;
        }
    }
}
