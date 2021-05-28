
namespace punto_de_venta
{
    partial class EditarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProductos));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBColumn = new System.Windows.Forms.ComboBox();
            this.AgregarBTN = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.TBDato = new System.Windows.Forms.TextBox();
            this.NUDProd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Columna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Editar productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nuevo dato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID del producto";
            // 
            // CBColumn
            // 
            this.CBColumn.FormattingEnabled = true;
            this.CBColumn.Items.AddRange(new object[] {
            "ID_Categorias",
            "",
            "Nombre",
            "",
            "Marca",
            "",
            "Precio",
            "",
            "Descripcion",
            "",
            "InVentario"});
            this.CBColumn.Location = new System.Drawing.Point(188, 67);
            this.CBColumn.Name = "CBColumn";
            this.CBColumn.Size = new System.Drawing.Size(192, 21);
            this.CBColumn.TabIndex = 7;
            // 
            // AgregarBTN
            // 
            this.AgregarBTN.BackColor = System.Drawing.Color.Gray;
            this.AgregarBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBTN.ForeColor = System.Drawing.SystemColors.Menu;
            this.AgregarBTN.Location = new System.Drawing.Point(107, 251);
            this.AgregarBTN.Name = "AgregarBTN";
            this.AgregarBTN.Size = new System.Drawing.Size(180, 44);
            this.AgregarBTN.TabIndex = 12;
            this.AgregarBTN.Text = "Confirmar";
            this.AgregarBTN.UseVisualStyleBackColor = false;
            this.AgregarBTN.Click += new System.EventHandler(this.AgregarBTN_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Location = new System.Drawing.Point(365, 9);
            this.btnexit.Margin = new System.Windows.Forms.Padding(1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(15, 15);
            this.btnexit.TabIndex = 15;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // TBDato
            // 
            this.TBDato.Location = new System.Drawing.Point(188, 121);
            this.TBDato.Name = "TBDato";
            this.TBDato.Size = new System.Drawing.Size(192, 20);
            this.TBDato.TabIndex = 16;
            // 
            // NUDProd
            // 
            this.NUDProd.Location = new System.Drawing.Point(188, 177);
            this.NUDProd.Name = "NUDProd";
            this.NUDProd.Size = new System.Drawing.Size(192, 20);
            this.NUDProd.TabIndex = 17;
            // 
            // EditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(396, 307);
            this.Controls.Add(this.NUDProd);
            this.Controls.Add(this.TBDato);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.AgregarBTN);
            this.Controls.Add(this.CBColumn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "EditarProductos";
            this.Text = "EditarProductos";
            this.Load += new System.EventHandler(this.EditarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBColumn;
        private System.Windows.Forms.Button AgregarBTN;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox TBDato;
        private System.Windows.Forms.NumericUpDown NUDProd;
    }
}