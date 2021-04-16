
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombretb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marcatb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciotb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcionbt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventariotb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BuscarBTN = new System.Windows.Forms.Button();
            this.BackBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarBTN
            // 
            this.AgregarBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBTN.Location = new System.Drawing.Point(12, 12);
            this.AgregarBTN.Name = "AgregarBTN";
            this.AgregarBTN.Size = new System.Drawing.Size(95, 37);
            this.AgregarBTN.TabIndex = 0;
            this.AgregarBTN.Text = "Agregar";
            this.AgregarBTN.UseVisualStyleBackColor = true;
            // 
            // EditarBTN
            // 
            this.EditarBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarBTN.Location = new System.Drawing.Point(113, 12);
            this.EditarBTN.Name = "EditarBTN";
            this.EditarBTN.Size = new System.Drawing.Size(95, 37);
            this.EditarBTN.TabIndex = 1;
            this.EditarBTN.Text = "Editar";
            this.EditarBTN.UseVisualStyleBackColor = true;
            // 
            // EliminarBTN
            // 
            this.EliminarBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBTN.Location = new System.Drawing.Point(214, 12);
            this.EliminarBTN.Name = "EliminarBTN";
            this.EliminarBTN.Size = new System.Drawing.Size(95, 37);
            this.EliminarBTN.TabIndex = 2;
            this.EliminarBTN.Text = "Eliminar";
            this.EliminarBTN.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombretb,
            this.Marcatb,
            this.Preciotb,
            this.Descripcionbt,
            this.Inventariotb});
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 329);
            this.dataGridView1.TabIndex = 3;
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
            this.Inventariotb.HeaderText = "Inventario";
            this.Inventariotb.Name = "Inventariotb";
            this.Inventariotb.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 4;
            // 
            // BuscarBTN
            // 
            this.BuscarBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBTN.Location = new System.Drawing.Point(487, 12);
            this.BuscarBTN.Name = "BuscarBTN";
            this.BuscarBTN.Size = new System.Drawing.Size(83, 37);
            this.BuscarBTN.TabIndex = 5;
            this.BuscarBTN.Text = "Buscar";
            this.BuscarBTN.UseVisualStyleBackColor = true;
            // 
            // BackBTN
            // 
            this.BackBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBTN.Location = new System.Drawing.Point(204, 390);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(175, 37);
            this.BackBTN.TabIndex = 6;
            this.BackBTN.Text = "Volver al menu";
            this.BackBTN.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.BuscarBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EliminarBTN);
            this.Controls.Add(this.EditarBTN);
            this.Controls.Add(this.AgregarBTN);
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarBTN;
        private System.Windows.Forms.Button EditarBTN;
        private System.Windows.Forms.Button EliminarBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombretb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marcatb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciotb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcionbt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventariotb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BuscarBTN;
        private System.Windows.Forms.Button BackBTN;
    }
}