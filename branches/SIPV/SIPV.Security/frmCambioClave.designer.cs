namespace SIPV.Security
{
    partial class frmCambioClave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambioClave));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.CmdSalir = new System.Windows.Forms.Button();
            this.cmdIngresar = new System.Windows.Forms.Button();
            this.TbUsuarioActual = new System.Windows.Forms.TextBox();
            this.TbClaveActual = new System.Windows.Forms.TextBox();
            this.TbNuevaClave = new System.Windows.Forms.TextBox();
            this.TbConfirmarNuevaClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(21, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(21, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nueva clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(21, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirmar nueva clave";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Salir.ico");
            this.imageList2.Images.SetKeyName(1, "Aceptar.ico");
            // 
            // CmdSalir
            // 
            this.CmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSalir.Location = new System.Drawing.Point(160, 130);
            this.CmdSalir.Name = "CmdSalir";
            this.CmdSalir.Size = new System.Drawing.Size(129, 28);
            this.CmdSalir.TabIndex = 4;
            this.CmdSalir.Text = "Salir";
            this.CmdSalir.Click += new System.EventHandler(this.CmdSalir_Click);
            // 
            // cmdIngresar
            // 
            this.cmdIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIngresar.Location = new System.Drawing.Point(24, 130);
            this.cmdIngresar.Name = "cmdIngresar";
            this.cmdIngresar.Size = new System.Drawing.Size(129, 28);
            this.cmdIngresar.TabIndex = 3;
            this.cmdIngresar.Text = "Aceptar";
            this.cmdIngresar.Click += new System.EventHandler(this.cmdIngresar_Click);
            // 
            // TbUsuarioActual
            // 
            this.TbUsuarioActual.Location = new System.Drawing.Point(159, 14);
            this.TbUsuarioActual.Name = "TbUsuarioActual";
            this.TbUsuarioActual.Size = new System.Drawing.Size(129, 20);
            this.TbUsuarioActual.TabIndex = 10;
            // 
            // TbClaveActual
            // 
            this.TbClaveActual.Location = new System.Drawing.Point(159, 42);
            this.TbClaveActual.Name = "TbClaveActual";
            this.TbClaveActual.Size = new System.Drawing.Size(130, 20);
            this.TbClaveActual.TabIndex = 0;
            // 
            // TbNuevaClave
            // 
            this.TbNuevaClave.Location = new System.Drawing.Point(159, 70);
            this.TbNuevaClave.Name = "TbNuevaClave";
            this.TbNuevaClave.Size = new System.Drawing.Size(130, 20);
            this.TbNuevaClave.TabIndex = 1;
            // 
            // TbConfirmarNuevaClave
            // 
            this.TbConfirmarNuevaClave.Location = new System.Drawing.Point(159, 98);
            this.TbConfirmarNuevaClave.Name = "TbConfirmarNuevaClave";
            this.TbConfirmarNuevaClave.Size = new System.Drawing.Size(130, 20);
            this.TbConfirmarNuevaClave.TabIndex = 2;
            // 
            // frmCambioClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(310, 170);
            this.ControlBox = false;
            this.Controls.Add(this.TbConfirmarNuevaClave);
            this.Controls.Add(this.TbNuevaClave);
            this.Controls.Add(this.TbClaveActual);
            this.Controls.Add(this.TbUsuarioActual);
            this.Controls.Add(this.CmdSalir);
            this.Controls.Add(this.cmdIngresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCambioClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de clave";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.frmCambioClave_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCambioClave_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList2;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Button CmdSalir;
        private System.Windows.Forms.Button cmdIngresar;
        private System.Windows.Forms.TextBox  TbUsuarioActual;
        private System.Windows.Forms.TextBox  TbClaveActual;
        private System.Windows.Forms.TextBox  TbNuevaClave;
        private System.Windows.Forms.TextBox TbConfirmarNuevaClave;
    }
}