
namespace punto_de_venta
{
    partial class Proveedores
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
            this.Añadirbtn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombretb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correotb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefonotb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buscarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Añadirbtn
            // 
            this.Añadirbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Añadirbtn.Location = new System.Drawing.Point(12, 12);
            this.Añadirbtn.Name = "Añadirbtn";
            this.Añadirbtn.Size = new System.Drawing.Size(95, 37);
            this.Añadirbtn.TabIndex = 2;
            this.Añadirbtn.Text = "Añadir";
            this.Añadirbtn.UseVisualStyleBackColor = true;
            this.Añadirbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(12, 138);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(95, 37);
            this.back.TabIndex = 3;
            this.back.Text = "Salir";
            this.back.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombretb,
            this.Correotb,
            this.Telefonotb});
            this.dataGridView1.Location = new System.Drawing.Point(123, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 224);
            this.dataGridView1.TabIndex = 6;
            // 
            // Nombretb
            // 
            this.Nombretb.Frozen = true;
            this.Nombretb.HeaderText = "Nombre";
            this.Nombretb.Name = "Nombretb";
            this.Nombretb.ReadOnly = true;
            // 
            // Correotb
            // 
            this.Correotb.Frozen = true;
            this.Correotb.HeaderText = "Correo";
            this.Correotb.Name = "Correotb";
            this.Correotb.ReadOnly = true;
            // 
            // Telefonotb
            // 
            this.Telefonotb.Frozen = true;
            this.Telefonotb.HeaderText = "Teléfono";
            this.Telefonotb.Name = "Telefonotb";
            this.Telefonotb.ReadOnly = true;
            // 
            // Buscarbtn
            // 
            this.Buscarbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbtn.Location = new System.Drawing.Point(12, 199);
            this.Buscarbtn.Name = "Buscarbtn";
            this.Buscarbtn.Size = new System.Drawing.Size(95, 37);
            this.Buscarbtn.TabIndex = 7;
            this.Buscarbtn.Text = "Buscar";
            this.Buscarbtn.UseVisualStyleBackColor = true;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(483, 257);
            this.Controls.Add(this.Buscarbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Añadirbtn);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Añadirbtn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombretb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correotb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefonotb;
        private System.Windows.Forms.Button Buscarbtn;
    }
}