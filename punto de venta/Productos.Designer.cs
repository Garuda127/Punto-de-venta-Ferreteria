﻿
namespace punto_de_venta
{
    partial class Productos
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
            this.AgregarBTN = new System.Windows.Forms.Button();
            this.EditarBTN = new System.Windows.Forms.Button();
            this.EliminarBTN = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.DataGridView();
            this.BuscarBTN = new System.Windows.Forms.Button();
            this.TBBus = new System.Windows.Forms.TextBox();
            this.Actual = new System.Windows.Forms.Button();
            this.CBFIL = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarBTN
            // 
            this.AgregarBTN.BackColor = System.Drawing.Color.Gray;
            this.AgregarBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBTN.ForeColor = System.Drawing.SystemColors.Menu;
            this.AgregarBTN.Location = new System.Drawing.Point(12, 88);
            this.AgregarBTN.Name = "AgregarBTN";
            this.AgregarBTN.Size = new System.Drawing.Size(141, 32);
            this.AgregarBTN.TabIndex = 0;
            this.AgregarBTN.Text = "Agregar";
            this.AgregarBTN.UseVisualStyleBackColor = false;
            this.AgregarBTN.Click += new System.EventHandler(this.AgregarBTN_Click);
            // 
            // EditarBTN
            // 
            this.EditarBTN.BackColor = System.Drawing.Color.Gray;
            this.EditarBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarBTN.ForeColor = System.Drawing.SystemColors.Menu;
            this.EditarBTN.Location = new System.Drawing.Point(12, 139);
            this.EditarBTN.Name = "EditarBTN";
            this.EditarBTN.Size = new System.Drawing.Size(141, 32);
            this.EditarBTN.TabIndex = 1;
            this.EditarBTN.Text = "Editar";
            this.EditarBTN.UseVisualStyleBackColor = false;
            this.EditarBTN.Click += new System.EventHandler(this.EditarBTN_Click);
            // 
            // EliminarBTN
            // 
            this.EliminarBTN.BackColor = System.Drawing.Color.Gray;
            this.EliminarBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBTN.ForeColor = System.Drawing.SystemColors.Menu;
            this.EliminarBTN.Location = new System.Drawing.Point(12, 190);
            this.EliminarBTN.Name = "EliminarBTN";
            this.EliminarBTN.Size = new System.Drawing.Size(141, 32);
            this.EliminarBTN.TabIndex = 2;
            this.EliminarBTN.Text = "Eliminar";
            this.EliminarBTN.UseVisualStyleBackColor = false;
            this.EliminarBTN.Click += new System.EventHandler(this.EliminarBTN_Click);
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tab.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tab.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tab.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.tab.Location = new System.Drawing.Point(181, 88);
            this.tab.Name = "tab";
            this.tab.Size = new System.Drawing.Size(376, 346);
            this.tab.TabIndex = 3;
            // 
            // BuscarBTN
            // 
            this.BuscarBTN.BackColor = System.Drawing.Color.Gray;
            this.BuscarBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBTN.ForeColor = System.Drawing.SystemColors.Menu;
            this.BuscarBTN.Location = new System.Drawing.Point(12, 37);
            this.BuscarBTN.Name = "BuscarBTN";
            this.BuscarBTN.Size = new System.Drawing.Size(141, 32);
            this.BuscarBTN.TabIndex = 5;
            this.BuscarBTN.Text = "Filtrar";
            this.BuscarBTN.UseVisualStyleBackColor = false;
            this.BuscarBTN.Click += new System.EventHandler(this.BuscarBTN_Click);
            // 
            // TBBus
            // 
            this.TBBus.Location = new System.Drawing.Point(308, 37);
            this.TBBus.Name = "TBBus";
            this.TBBus.Size = new System.Drawing.Size(249, 20);
            this.TBBus.TabIndex = 6;
            // 
            // Actual
            // 
            this.Actual.BackColor = System.Drawing.Color.Gray;
            this.Actual.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actual.ForeColor = System.Drawing.SystemColors.Menu;
            this.Actual.Location = new System.Drawing.Point(12, 241);
            this.Actual.Name = "Actual";
            this.Actual.Size = new System.Drawing.Size(141, 32);
            this.Actual.TabIndex = 7;
            this.Actual.Text = "Actualizar";
            this.Actual.UseVisualStyleBackColor = false;
            this.Actual.Click += new System.EventHandler(this.Actual_Click);
            // 
            // CBFIL
            // 
            this.CBFIL.FormattingEnabled = true;
            this.CBFIL.Items.AddRange(new object[] {
            "ID_Producto",
            "ID_Categorias",
            "nombre",
            "Marca",
            "Proteccion"});
            this.CBFIL.Location = new System.Drawing.Point(181, 37);
            this.CBFIL.Name = "CBFIL";
            this.CBFIL.Size = new System.Drawing.Size(121, 21);
            this.CBFIL.TabIndex = 8;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(573, 453);
            this.Controls.Add(this.CBFIL);
            this.Controls.Add(this.Actual);
            this.Controls.Add(this.TBBus);
            this.Controls.Add(this.BuscarBTN);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.EliminarBTN);
            this.Controls.Add(this.EditarBTN);
            this.Controls.Add(this.AgregarBTN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarBTN;
        private System.Windows.Forms.Button EditarBTN;
        private System.Windows.Forms.Button EliminarBTN;
        private System.Windows.Forms.DataGridView tab;
        private System.Windows.Forms.Button BuscarBTN;
        private System.Windows.Forms.TextBox TBBus;
        private System.Windows.Forms.Button Actual;
        private System.Windows.Forms.ComboBox CBFIL;
    }
}