﻿namespace FullProgram
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LegajosDeAfiliados = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.CajaAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LegajoDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LegajosDeAfiliados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LegajosDeAfiliados
            // 
            this.LegajosDeAfiliados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LegajosDeAfiliados.BackColor = System.Drawing.Color.Cornsilk;
            this.LegajosDeAfiliados.Controls.Add(this.label1);
            this.LegajosDeAfiliados.Controls.Add(this.cboEstado);
            this.LegajosDeAfiliados.Controls.Add(this.txtDni);
            this.LegajosDeAfiliados.Controls.Add(this.label11);
            this.LegajosDeAfiliados.Controls.Add(this.txtNombre);
            this.LegajosDeAfiliados.Controls.Add(this.label12);
            this.LegajosDeAfiliados.Controls.Add(this.txtCaja);
            this.LegajosDeAfiliados.Controls.Add(this.label13);
            this.LegajosDeAfiliados.Controls.Add(this.txtLegajo);
            this.LegajosDeAfiliados.Controls.Add(this.label15);
            this.LegajosDeAfiliados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LegajosDeAfiliados.Location = new System.Drawing.Point(12, 19);
            this.LegajosDeAfiliados.Name = "LegajosDeAfiliados";
            this.LegajosDeAfiliados.Size = new System.Drawing.Size(514, 434);
            this.LegajosDeAfiliados.TabIndex = 0;
            this.LegajosDeAfiliados.TabStop = false;
            this.LegajosDeAfiliados.Text = "Datos Legajos";

            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Estado:";
 
            // 
            // cboEstado
            // 
            this.cboEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(201, 259);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(227, 33);
            this.cboEstado.TabIndex = 4;
           
            this.cboEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // txtDni
            // 
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(201, 222);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(227, 31);
            this.txtDni.TabIndex = 3;
   
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(81, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Dni:";
          
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(201, 185);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 31);
            this.txtNombre.TabIndex = 2;

            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(81, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "Nombre:";
       
            // 
            // txtCaja
            // 
            this.txtCaja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja.Location = new System.Drawing.Point(201, 111);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(227, 31);
            this.txtCaja.TabIndex = 0;

            this.txtCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(81, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 25);
            this.label13.TabIndex = 6;
            this.label13.Text = "Caja:";
           
            // 
            // txtLegajo
            // 
            this.txtLegajo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegajo.Location = new System.Drawing.Point(201, 148);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(227, 31);
            this.txtLegajo.TabIndex = 1;

            this.txtLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            this.txtLegajo.Leave += new System.EventHandler(this.CallLegajo);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(81, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Legajo:";
         // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CajaAD,
            this.LegajoDgv,
            this.NombreDgv,
            this.DniDgv,
            this.EstadoDgv});
            this.dgv.Location = new System.Drawing.Point(541, 19);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(568, 506);
            this.dgv.TabIndex = 11;
            // 
            // CajaAD
            // 
            this.CajaAD.HeaderText = "Caja";
            this.CajaAD.Name = "CajaAD";
            this.CajaAD.ReadOnly = true;
            // 
            // LegajoDgv
            // 
            this.LegajoDgv.HeaderText = "Legajo";
            this.LegajoDgv.Name = "LegajoDgv";
            // 
            // NombreDgv
            // 
            this.NombreDgv.HeaderText = "Nombre";
            this.NombreDgv.Name = "NombreDgv";
            // 
            // DniDgv
            // 
            this.DniDgv.HeaderText = "Dni";
            this.DniDgv.Name = "DniDgv";
            // 
            // EstadoDgv
            // 
            this.EstadoDgv.HeaderText = "Estado";
            this.EstadoDgv.Name = "EstadoDgv";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.BtnAdd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 459);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(283, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ClearAll);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(24, 16);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(211, 35);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Cargar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.AddData);
            this.BtnAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // Add
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1121, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.LegajosDeAfiliados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add";
            this.Load += new System.EventHandler(this.StartProgram);
            this.LegajosDeAfiliados.ResumeLayout(false);
            this.LegajosDeAfiliados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox LegajosDeAfiliados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CajaAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegajoDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDgv;
    }
}