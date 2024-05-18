namespace Arquitecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            lblNombres = new Label();
            txtNombres = new TextBox();
            cmbCondicion = new ComboBox();
            lblCondicion = new Label();
            lblespecialidad = new Label();
            cmbEspecialidad = new ComboBox();
            lblactividad = new Label();
            cmbSupervision = new ComboBox();
            lblafiliacion = new Label();
            cmbAfiliacion = new ComboBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            txtResumen = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.Info;
            txtCodigo.Location = new Point(23, 51);
            txtCodigo.Multiline = true;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(159, 40);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(23, 26);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(60, 22);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            lblCodigo.Click += lblCódigo_Click;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.BorderStyle = BorderStyle.FixedSingle;
            lblNombres.Location = new Point(217, 26);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(72, 22);
            lblNombres.TabIndex = 3;
            lblNombres.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.BackColor = SystemColors.Info;
            txtNombres.Location = new Point(217, 51);
            txtNombres.Multiline = true;
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(159, 40);
            txtNombres.TabIndex = 2;
            // 
            // cmbCondicion
            // 
            cmbCondicion.BackColor = SystemColors.Info;
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Location = new Point(580, 51);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(159, 28);
            cmbCondicion.TabIndex = 4;
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Location = new Point(580, 28);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(159, 20);
            lblCondicion.TabIndex = 5;
            lblCondicion.Text = "Condición de Contrato";
            lblCondicion.Click += label1_Click;
            // 
            // lblespecialidad
            // 
            lblespecialidad.AutoSize = true;
            lblespecialidad.Location = new Point(798, 28);
            lblespecialidad.Name = "lblespecialidad";
            lblespecialidad.Size = new Size(127, 20);
            lblespecialidad.TabIndex = 7;
            lblespecialidad.Text = "Tipo de Actividad";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.BackColor = SystemColors.Info;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(798, 51);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(151, 28);
            cmbEspecialidad.TabIndex = 6;
            // 
            // lblactividad
            // 
            lblactividad.AutoSize = true;
            lblactividad.Location = new Point(578, 94);
            lblactividad.Name = "lblactividad";
            lblactividad.Size = new Size(122, 20);
            lblactividad.TabIndex = 9;
            lblactividad.Text = "Tipo de Contrato";
            // 
            // cmbSupervision
            // 
            cmbSupervision.BackColor = SystemColors.Info;
            cmbSupervision.FormattingEnabled = true;
            cmbSupervision.Location = new Point(578, 117);
            cmbSupervision.Name = "cmbSupervision";
            cmbSupervision.Size = new Size(161, 28);
            cmbSupervision.TabIndex = 8;
            // 
            // lblafiliacion
            // 
            lblafiliacion.AutoSize = true;
            lblafiliacion.Location = new Point(798, 94);
            lblafiliacion.Name = "lblafiliacion";
            lblafiliacion.Size = new Size(127, 20);
            lblafiliacion.TabIndex = 11;
            lblafiliacion.Text = "Tipo de Afiliación";
            // 
            // cmbAfiliacion
            // 
            cmbAfiliacion.BackColor = SystemColors.Info;
            cmbAfiliacion.FormattingEnabled = true;
            cmbAfiliacion.Location = new Point(798, 117);
            cmbAfiliacion.Name = "cmbAfiliacion";
            cmbAfiliacion.Size = new Size(151, 28);
            cmbAfiliacion.TabIndex = 10;
            // 
            // btnCalcular
            // 
            btnCalcular.Image = (Image)resources.GetObject("btnCalcular.Image");
            btnCalcular.Location = new Point(942, 202);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(126, 118);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular";
            btnCalcular.TextAlign = ContentAlignment.BottomCenter;
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.Location = new Point(942, 373);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(126, 123);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button1_Click;
            // 
            // txtResumen
            // 
            txtResumen.Location = new Point(12, 202);
            txtResumen.Multiline = true;
            txtResumen.Name = "txtResumen";
            txtResumen.ReadOnly = true;
            txtResumen.Size = new Size(846, 370);
            txtResumen.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(477, 179);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(12, 177);
            label2.Name = "label2";
            label2.Size = new Size(77, 22);
            label2.TabIndex = 16;
            label2.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1096, 584);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResumen);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(lblafiliacion);
            Controls.Add(cmbAfiliacion);
            Controls.Add(lblactividad);
            Controls.Add(cmbSupervision);
            Controls.Add(lblespecialidad);
            Controls.Add(cmbEspecialidad);
            Controls.Add(lblCondicion);
            Controls.Add(cmbCondicion);
            Controls.Add(lblNombres);
            Controls.Add(txtNombres);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Name = "Form1";
            Text = "Arquitecto";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label lblNombres;
        private TextBox txtNombres;
        private ComboBox cmbCondicion;
        private Label lblCondicion;
        private Label lblespecialidad;
        private ComboBox cmbEspecialidad;
        private Label lblactividad;
        private ComboBox cmbSupervision;
        private Label lblafiliacion;
        private ComboBox cmbAfiliacion;
        private Button btnCalcular;
        private Button btnLimpiar;
        private TextBox txtResumen;
        private Label label1;
        private Label label2;
    }
}
