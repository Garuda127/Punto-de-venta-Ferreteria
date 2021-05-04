
namespace punto_de_venta
{
    partial class AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.texnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.texMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AgregarBTN = new System.Windows.Forms.Button();
            this.Numst = new System.Windows.Forms.NumericUpDown();
            this.Texarea = new System.Windows.Forms.RichTextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.texprecio = new System.Windows.Forms.TextBox();
            this.CBCatego = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Numst)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar productos";
            // 
            // texnombre
            // 
            this.texnombre.Location = new System.Drawing.Point(163, 50);
            this.texnombre.Name = "texnombre";
            this.texnombre.Size = new System.Drawing.Size(337, 20);
            this.texnombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca";
            // 
            // texMarca
            // 
            this.texMarca.Location = new System.Drawing.Point(163, 91);
            this.texMarca.Name = "texMarca";
            this.texMarca.Size = new System.Drawing.Size(337, 20);
            this.texMarca.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Stock";
            // 
            // AgregarBTN
            // 
            this.AgregarBTN.BackColor = System.Drawing.Color.Gray;
            this.AgregarBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBTN.ForeColor = System.Drawing.SystemColors.Menu;
            this.AgregarBTN.Location = new System.Drawing.Point(177, 376);
            this.AgregarBTN.Name = "AgregarBTN";
            this.AgregarBTN.Size = new System.Drawing.Size(158, 44);
            this.AgregarBTN.TabIndex = 11;
            this.AgregarBTN.Text = "Agregar";
            this.AgregarBTN.UseVisualStyleBackColor = false;
            this.AgregarBTN.Click += new System.EventHandler(this.AgregarBTN_Click);
            // 
            // Numst
            // 
            this.Numst.Location = new System.Drawing.Point(163, 331);
            this.Numst.Name = "Numst";
            this.Numst.Size = new System.Drawing.Size(339, 20);
            this.Numst.TabIndex = 12;
            // 
            // Texarea
            // 
            this.Texarea.Location = new System.Drawing.Point(163, 214);
            this.Texarea.Name = "Texarea";
            this.Texarea.Size = new System.Drawing.Size(337, 96);
            this.Texarea.TabIndex = 13;
            this.Texarea.Text = "";
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Location = new System.Drawing.Point(487, 9);
            this.btnexit.Margin = new System.Windows.Forms.Padding(1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(15, 15);
            this.btnexit.TabIndex = 14;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Categoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Precio";
            // 
            // texprecio
            // 
            this.texprecio.Location = new System.Drawing.Point(163, 132);
            this.texprecio.Name = "texprecio";
            this.texprecio.Size = new System.Drawing.Size(337, 20);
            this.texprecio.TabIndex = 15;
            // 
            // CBCatego
            // 
            this.CBCatego.FormattingEnabled = true;
            this.CBCatego.Items.AddRange(new object[] {
            "Herramientas",
            "Material electrico",
            "Material para plomeria",
            "Hogar",
            "Jardin"});
            this.CBCatego.Location = new System.Drawing.Point(163, 173);
            this.CBCatego.Name = "CBCatego";
            this.CBCatego.Size = new System.Drawing.Size(337, 21);
            this.CBCatego.TabIndex = 19;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(512, 432);
            this.Controls.Add(this.CBCatego);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.texprecio);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.Texarea);
            this.Controls.Add(this.Numst);
            this.Controls.Add(this.AgregarBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texnombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarProducto";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar producto";
            ((System.ComponentModel.ISupportInitialize)(this.Numst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AgregarBTN;
        private System.Windows.Forms.NumericUpDown Numst;
        private System.Windows.Forms.RichTextBox Texarea;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox texprecio;
        private System.Windows.Forms.ComboBox CBCatego;
    }
}