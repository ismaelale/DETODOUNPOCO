namespace DETODOUNPOCO
{
    partial class PROMEDIO
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
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cbgrado = new ComboBox();
            cbseccion = new ComboBox();
            cbdepa = new ComboBox();
            groupBox1 = new GroupBox();
            btcalcular = new Button();
            txtp3 = new TextBox();
            txtp1 = new TextBox();
            txtp2 = new TextBox();
            txtp4 = new TextBox();
            txtprom = new TextBox();
            dataregistros = new DataGridView();
            depa = new DataGridViewTextBoxColumn();
            nomb = new DataGridViewTextBoxColumn();
            apel = new DataGridViewTextBoxColumn();
            Grado = new DataGridViewTextBoxColumn();
            Seccion = new DataGridViewTextBoxColumn();
            Prom = new DataGridViewTextBoxColumn();
            label11 = new Label();
            btagregar = new Button();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataregistros).BeginInit();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(185, 91);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 0;
            txtnombre.KeyPress += txtnombre_KeyPress;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(338, 91);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(100, 23);
            txtapellido.TabIndex = 1;
            txtapellido.KeyPress += txtapellido_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 64);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 2;
            label1.Text = "Departamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(338, 64);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(482, 64);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 4;
            label3.Text = "Grado ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(625, 64);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 5;
            label4.Text = "Sección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(38, 33);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 6;
            label5.Text = "Parcial 1 ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(308, 33);
            label6.Name = "label6";
            label6.Size = new Size(62, 17);
            label6.TabIndex = 7;
            label6.Text = "Parcial 3 ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(172, 33);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 8;
            label7.Text = "Parcial 2 ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(570, 33);
            label8.Name = "label8";
            label8.Size = new Size(71, 17);
            label8.TabIndex = 9;
            label8.Text = "Promedio ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(430, 33);
            label9.Name = "label9";
            label9.Size = new Size(62, 17);
            label9.TabIndex = 10;
            label9.Text = "Parcial 4 ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(185, 64);
            label10.Name = "label10";
            label10.Size = new Size(58, 17);
            label10.TabIndex = 11;
            label10.Text = "Nombre";
            // 
            // cbgrado
            // 
            cbgrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbgrado.FormattingEnabled = true;
            cbgrado.Location = new Point(482, 91);
            cbgrado.Name = "cbgrado";
            cbgrado.Size = new Size(80, 23);
            cbgrado.TabIndex = 12;
            // 
            // cbseccion
            // 
            cbseccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbseccion.FormattingEnabled = true;
            cbseccion.Location = new Point(625, 91);
            cbseccion.Name = "cbseccion";
            cbseccion.Size = new Size(80, 23);
            cbseccion.TabIndex = 13;
            // 
            // cbdepa
            // 
            cbdepa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbdepa.FormattingEnabled = true;
            cbdepa.Location = new Point(32, 91);
            cbdepa.Name = "cbdepa";
            cbdepa.Size = new Size(119, 23);
            cbdepa.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btcalcular);
            groupBox1.Controls.Add(txtp3);
            groupBox1.Controls.Add(txtp1);
            groupBox1.Controls.Add(txtp2);
            groupBox1.Controls.Add(txtp4);
            groupBox1.Controls.Add(txtprom);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(32, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(782, 119);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Notas del Parcial";
            // 
            // btcalcular
            // 
            btcalcular.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btcalcular.Location = new Point(682, 55);
            btcalcular.Name = "btcalcular";
            btcalcular.Size = new Size(94, 40);
            btcalcular.TabIndex = 19;
            btcalcular.Text = "Calcular";
            btcalcular.UseVisualStyleBackColor = true;
            btcalcular.Click += btcalcular_Click;
            // 
            // txtp3
            // 
            txtp3.Location = new Point(308, 61);
            txtp3.Name = "txtp3";
            txtp3.Size = new Size(71, 29);
            txtp3.TabIndex = 16;
            // 
            // txtp1
            // 
            txtp1.Location = new Point(38, 61);
            txtp1.Name = "txtp1";
            txtp1.Size = new Size(71, 29);
            txtp1.TabIndex = 17;
            // 
            // txtp2
            // 
            txtp2.Location = new Point(172, 61);
            txtp2.Name = "txtp2";
            txtp2.Size = new Size(71, 29);
            txtp2.TabIndex = 18;
            // 
            // txtp4
            // 
            txtp4.Location = new Point(430, 61);
            txtp4.Name = "txtp4";
            txtp4.Size = new Size(71, 29);
            txtp4.TabIndex = 19;
            // 
            // txtprom
            // 
            txtprom.Location = new Point(570, 61);
            txtprom.Name = "txtprom";
            txtprom.Size = new Size(78, 29);
            txtprom.TabIndex = 20;
            // 
            // dataregistros
            // 
            dataregistros.AllowUserToAddRows = false;
            dataregistros.AllowUserToDeleteRows = false;
            dataregistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataregistros.Columns.AddRange(new DataGridViewColumn[] { depa, nomb, apel, Grado, Seccion, Prom });
            dataregistros.Location = new Point(35, 314);
            dataregistros.Name = "dataregistros";
            dataregistros.ReadOnly = true;
            dataregistros.RowTemplate.Height = 25;
            dataregistros.Size = new Size(652, 150);
            dataregistros.TabIndex = 16;
            // 
            // depa
            // 
            depa.HeaderText = "Departamento";
            depa.Name = "depa";
            depa.ReadOnly = true;
            // 
            // nomb
            // 
            nomb.HeaderText = "Nombre";
            nomb.Name = "nomb";
            nomb.ReadOnly = true;
            // 
            // apel
            // 
            apel.HeaderText = "Apellido";
            apel.Name = "apel";
            apel.ReadOnly = true;
            // 
            // Grado
            // 
            Grado.HeaderText = "Grado";
            Grado.Name = "Grado";
            Grado.ReadOnly = true;
            // 
            // Seccion
            // 
            Seccion.HeaderText = "Sección";
            Seccion.Name = "Seccion";
            Seccion.ReadOnly = true;
            // 
            // Prom
            // 
            Prom.HeaderText = "Promedio";
            Prom.Name = "Prom";
            Prom.ReadOnly = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(259, 9);
            label11.Name = "label11";
            label11.Size = new Size(303, 32);
            label11.TabIndex = 17;
            label11.Text = "ENTREGA DE PROMEDIOS ";
            // 
            // btagregar
            // 
            btagregar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btagregar.Location = new Point(720, 314);
            btagregar.Name = "btagregar";
            btagregar.Size = new Size(94, 40);
            btagregar.TabIndex = 18;
            btagregar.Text = "Agregar";
            btagregar.UseVisualStyleBackColor = true;
            btagregar.Click += btagregar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(720, 360);
            button1.Name = "button1";
            button1.Size = new Size(94, 50);
            button1.TabIndex = 19;
            button1.Text = "Siguiente Form";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(720, 416);
            button2.Name = "button2";
            button2.Size = new Size(94, 40);
            button2.TabIndex = 20;
            button2.Text = "Exit ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PROMEDIO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 468);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btagregar);
            Controls.Add(label11);
            Controls.Add(dataregistros);
            Controls.Add(groupBox1);
            Controls.Add(cbdepa);
            Controls.Add(cbseccion);
            Controls.Add(cbgrado);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Name = "PROMEDIO";
            Text = "PROMEDIO";
            Load += PROMEDIO_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataregistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnombre;
        private TextBox txtapellido;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cbgrado;
        private ComboBox cbseccion;
        private ComboBox cbdepa;
        private GroupBox groupBox1;
        private Button btcalcular;
        private TextBox txtp3;
        private TextBox txtp1;
        private TextBox txtp2;
        private TextBox txtp4;
        private TextBox txtprom;
        private DataGridView dataregistros;
        private DataGridViewTextBoxColumn depa;
        private DataGridViewTextBoxColumn nomb;
        private DataGridViewTextBoxColumn apel;
        private DataGridViewTextBoxColumn Grado;
        private DataGridViewTextBoxColumn Seccion;
        private DataGridViewTextBoxColumn Prom;
        private Label label11;
        private Button btagregar;
        private Button button1;
        private Button button2;
    }
}