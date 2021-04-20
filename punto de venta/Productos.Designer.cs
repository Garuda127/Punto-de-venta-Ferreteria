
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.AgregarBTN = new System.Windows.Forms.Button();
            this.EditarBTN = new System.Windows.Forms.Button();
            this.EliminarBTN = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.DataGridView();
            this.Nombretb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marcatb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciotb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcionbt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventariotb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuscarBTN = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarBTN
            // 
            this.AgregarBTN.BackColor = System.Drawing.Color.Gray;
            this.AgregarBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBTN.ForeColor = System.Drawing.SystemColors.Menu;
            this.AgregarBTN.Location = new System.Drawing.Point(14, 12);
            this.AgregarBTN.Name = "AgregarBTN";
            this.AgregarBTN.Size = new System.Drawing.Size(111, 37);
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
            this.EditarBTN.Location = new System.Drawing.Point(132, 12);
            this.EditarBTN.Name = "EditarBTN";
            this.EditarBTN.Size = new System.Drawing.Size(111, 37);
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
            this.EliminarBTN.Location = new System.Drawing.Point(250, 12);
            this.EliminarBTN.Name = "EliminarBTN";
            this.EliminarBTN.Size = new System.Drawing.Size(111, 37);
            this.EliminarBTN.TabIndex = 2;
            this.EliminarBTN.Text = "Eliminar";
            this.EliminarBTN.UseVisualStyleBackColor = false;
            this.EliminarBTN.Click += new System.EventHandler(this.EliminarBTN_Click);
            // 
            // tab
            // 
            this.tab.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tab.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombretb,
            this.Marcatb,
            this.Preciotb,
            this.Descripcionbt,
            this.Inventariotb});
            this.tab.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tab.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.tab.Location = new System.Drawing.Point(14, 55);
            this.tab.Name = "tab";
            this.tab.Size = new System.Drawing.Size(543, 329);
            this.tab.TabIndex = 3;
            // 
            // Nombretb
            // 
            this.Nombretb.HeaderText = "Nombre";
            this.Nombretb.Name = "Nombretb";
            this.Nombretb.ReadOnly = true;
            // 
            // Marcatb
            // 
            this.Marcatb.HeaderText = "Marca";
            this.Marcatb.Name = "Marcatb";
            this.Marcatb.ReadOnly = true;
            // 
            // Preciotb
            // 
            this.Preciotb.HeaderText = "Precio";
            this.Preciotb.Name = "Preciotb";
            this.Preciotb.ReadOnly = true;
            // 
            // Descripcionbt
            // 
            this.Descripcionbt.HeaderText = "Descripcion";
            this.Descripcionbt.Name = "Descripcionbt";
            this.Descripcionbt.ReadOnly = true;
            // 
            // Inventariotb
            // 
            this.Inventariotb.HeaderText = "Stock";
            this.Inventariotb.Name = "Inventariotb";
            this.Inventariotb.ReadOnly = true;
            // 
            // BuscarBTN
            // 
            this.BuscarBTN.BackColor = System.Drawing.Color.Gray;
            this.BuscarBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBTN.ForeColor = System.Drawing.SystemColors.Menu;
            this.BuscarBTN.Location = new System.Drawing.Point(367, 12);
            this.BuscarBTN.Name = "BuscarBTN";
            this.BuscarBTN.Size = new System.Drawing.Size(97, 37);
            this.BuscarBTN.TabIndex = 5;
            this.BuscarBTN.Text = "Buscar";
            this.BuscarBTN.UseVisualStyleBackColor = false;
            this.BuscarBTN.Click += new System.EventHandler(this.BuscarBTN_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Location = new System.Drawing.Point(637, 12);
            this.btnexit.Margin = new System.Windows.Forms.Padding(1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(17, 15);
            this.btnexit.TabIndex = 15;
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(542, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 15);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(573, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexit);
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
            ((System.ComponentModel.ISupportInitialize)(this.tab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AgregarBTN;
        private System.Windows.Forms.Button EditarBTN;
        private System.Windows.Forms.Button EliminarBTN;
        private System.Windows.Forms.DataGridView tab;
        private System.Windows.Forms.Button BuscarBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombretb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marcatb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciotb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcionbt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventariotb;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button button1;
    }
}