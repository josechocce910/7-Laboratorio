namespace jefe
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
            lblResultado = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtDNI = new TextBox();
            label3 = new Label();
            txtAniosAntiguedad = new TextBox();
            lblCargo = new Label();
            cboCargo = new ComboBox();
            lblArea = new Label();
            cboArea = new ComboBox();
            btnCrearObjeto = new Button();
            txtResultado = new TextBox();
            bntMostrarInformacion = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(29, 238);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 15;
            lblResultado.Text = "Resultado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 45);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 34);
            txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Location = new Point(186, 22);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 3;
            label2.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(186, 45);
            txtDNI.Multiline = true;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(125, 27);
            txtDNI.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Location = new Point(406, 22);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 5;
            label3.Text = "Años de Antiguedad";
            // 
            // txtAniosAntiguedad
            // 
            txtAniosAntiguedad.Location = new Point(406, 45);
            txtAniosAntiguedad.Multiline = true;
            txtAniosAntiguedad.Name = "txtAniosAntiguedad";
            txtAniosAntiguedad.Size = new Size(145, 27);
            txtAniosAntiguedad.TabIndex = 4;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(26, 111);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(49, 20);
            lblCargo.TabIndex = 12;
            lblCargo.Text = "Cargo";
            lblCargo.Click += label4_Click;
            // 
            // cboCargo
            // 
            cboCargo.AutoCompleteCustomSource.AddRange(new string[] { "Gerente", "Subgerente" });
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Gerente", "Subgerente" });
            cboCargo.Location = new Point(29, 134);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(151, 28);
            cboCargo.TabIndex = 11;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(186, 111);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(40, 20);
            lblArea.TabIndex = 13;
            lblArea.Text = "Área";
            // 
            // cboArea
            // 
            cboArea.AutoCompleteCustomSource.AddRange(new string[] { "Contabilidad", "Planificación" });
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "Contabilidad", "Planificación" });
            cboArea.Location = new Point(186, 134);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(151, 28);
            cboArea.TabIndex = 10;
            // 
            // btnCrearObjeto
            // 
            btnCrearObjeto.Location = new Point(766, 90);
            btnCrearObjeto.Name = "btnCrearObjeto";
            btnCrearObjeto.Size = new Size(140, 144);
            btnCrearObjeto.TabIndex = 8;
            btnCrearObjeto.Text = "Crear Objeto";
            btnCrearObjeto.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(26, 255);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(758, 280);
            txtResultado.TabIndex = 14;
            // 
            // bntMostrarInformacion
            // 
            bntMostrarInformacion.Location = new Point(929, 75);
            bntMostrarInformacion.Name = "bntMostrarInformacion";
            bntMostrarInformacion.Size = new Size(140, 144);
            bntMostrarInformacion.TabIndex = 6;
            bntMostrarInformacion.Text = "Mostar Información";
            bntMostrarInformacion.UseVisualStyleBackColor = true;
            bntMostrarInformacion.Click += bntMostrarInformacion_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(929, 238);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 144);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 563);
            Controls.Add(lblResultado);
            Controls.Add(txtResultado);
            Controls.Add(lblArea);
            Controls.Add(lblCargo);
            Controls.Add(cboCargo);
            Controls.Add(cboArea);
            Controls.Add(btnCrearObjeto);
            Controls.Add(btnLimpiar);
            Controls.Add(bntMostrarInformacion);
            Controls.Add(label3);
            Controls.Add(txtAniosAntiguedad);
            Controls.Add(label2);
            Controls.Add(txtDNI);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Gestion de Gefes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblResultado;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtDNI;
        private Label label3;
        private TextBox txtAniosAntiguedad;
        private Label lblCargo;
        private ComboBox cboCargo;
        private Label lblArea;
        private ComboBox cboArea;
        private Button btnCrearObjeto;
        private TextBox txtResultado;
        private Button bntMostrarInformacion;
        private Button btnLimpiar;
    }
}
