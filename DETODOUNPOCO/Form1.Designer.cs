namespace DETODOUNPOCO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtnombre = new TextBox();
            txtproducto = new TextBox();
            cbcantproducto = new ComboBox();
            datecompra = new DateTimePicker();
            txttotal = new TextBox();
            dataregistros = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            pro = new DataGridViewTextBoxColumn();
            cabtudad = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            Tota = new DataGridViewTextBoxColumn();
            btagregar = new Button();
            txtprecio = new TextBox();
            label7 = new Label();
            btcalcular = new Button();
            btcambios = new Button();
            ((System.ComponentModel.ISupportInitialize)dataregistros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(252, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 0;
            label1.Text = "FERRETERIA ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 75);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(209, 75);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 2;
            label3.Text = "Producto ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 159);
            label4.Name = "label4";
            label4.Size = new Size(114, 17);
            label4.TabIndex = 3;
            label4.Text = "Fecha de Compra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(385, 75);
            label5.Name = "label5";
            label5.Size = new Size(144, 17);
            label5.TabIndex = 4;
            label5.Text = "Cantidad del Producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(480, 159);
            label6.Name = "label6";
            label6.Size = new Size(41, 17);
            label6.TabIndex = 5;
            label6.Text = "Total ";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(25, 95);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(114, 23);
            txtnombre.TabIndex = 6;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(209, 95);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(114, 23);
            txtproducto.TabIndex = 7;
            // 
            // cbcantproducto
            // 
            cbcantproducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcantproducto.FormattingEnabled = true;
            cbcantproducto.Location = new Point(385, 95);
            cbcantproducto.Name = "cbcantproducto";
            cbcantproducto.Size = new Size(121, 23);
            cbcantproducto.TabIndex = 8;
            cbcantproducto.SelectedIndexChanged += cbcantproducto_SelectedIndexChanged;
            // 
            // datecompra
            // 
            datecompra.Location = new Point(25, 195);
            datecompra.Name = "datecompra";
            datecompra.Size = new Size(225, 23);
            datecompra.TabIndex = 9;
            // 
            // txttotal
            // 
            txttotal.Location = new Point(480, 195);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(85, 23);
            txttotal.TabIndex = 10;
            // 
            // dataregistros
            // 
            dataregistros.AllowUserToAddRows = false;
            dataregistros.AllowUserToDeleteRows = false;
            dataregistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataregistros.Columns.AddRange(new DataGridViewColumn[] { nombre, pro, cabtudad, fecha, Tota });
            dataregistros.Location = new Point(27, 272);
            dataregistros.Name = "dataregistros";
            dataregistros.ReadOnly = true;
            dataregistros.RowTemplate.Height = 25;
            dataregistros.Size = new Size(579, 150);
            dataregistros.TabIndex = 11;
            // 
            // nombre
            // 
            nombre.HeaderText = "NombreCliente";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // pro
            // 
            pro.HeaderText = "Producto ";
            pro.Name = "pro";
            pro.ReadOnly = true;
            // 
            // cabtudad
            // 
            cabtudad.HeaderText = "CantidadProducto";
            cabtudad.Name = "cabtudad";
            cabtudad.ReadOnly = true;
            cabtudad.Width = 130;
            // 
            // fecha
            // 
            fecha.HeaderText = "FechaCompra";
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            // 
            // Tota
            // 
            Tota.HeaderText = "Total";
            Tota.Name = "Tota";
            Tota.ReadOnly = true;
            // 
            // btagregar
            // 
            btagregar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btagregar.Location = new Point(624, 282);
            btagregar.Name = "btagregar";
            btagregar.Size = new Size(91, 41);
            btagregar.TabIndex = 12;
            btagregar.Text = "Agregar";
            btagregar.UseVisualStyleBackColor = true;
            btagregar.Click += btagregar_Click;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(308, 195);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(85, 23);
            txtprecio.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(308, 159);
            label7.Name = "label7";
            label7.Size = new Size(45, 17);
            label7.TabIndex = 13;
            label7.Text = "Precio";
            // 
            // btcalcular
            // 
            btcalcular.Location = new Point(603, 194);
            btcalcular.Name = "btcalcular";
            btcalcular.Size = new Size(96, 33);
            btcalcular.TabIndex = 15;
            btcalcular.Text = "Calcular";
            btcalcular.UseVisualStyleBackColor = true;
            btcalcular.Click += btcalcular_Click;
            // 
            // btcambios
            // 
            btcambios.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btcambios.Location = new Point(624, 352);
            btcambios.Name = "btcambios";
            btcambios.Size = new Size(91, 49);
            btcambios.TabIndex = 16;
            btcambios.Text = "Cambio de Formulario";
            btcambios.UseVisualStyleBackColor = true;
            btcambios.Click += btcambios_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 427);
            Controls.Add(btcambios);
            Controls.Add(btcalcular);
            Controls.Add(txtprecio);
            Controls.Add(label7);
            Controls.Add(btagregar);
            Controls.Add(dataregistros);
            Controls.Add(txttotal);
            Controls.Add(datecompra);
            Controls.Add(cbcantproducto);
            Controls.Add(txtproducto);
            Controls.Add(txtnombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataregistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtnombre;
        private TextBox txtproducto;
        private ComboBox cbcantproducto;
        private DateTimePicker datecompra;
        private TextBox txttotal;
        private DataGridView dataregistros;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn pro;
        private DataGridViewTextBoxColumn cabtudad;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn Tota;
        private Button btagregar;
        private TextBox txtprecio;
        private Label label7;
        private Button btcalcular;
        private Button btcambios;
    }
}