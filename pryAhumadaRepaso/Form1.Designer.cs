namespace pryAhumadaRepaso
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
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            btnRegistrar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblGrupo = new Label();
            cmbGrupo = new ComboBox();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 44);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(52, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo :";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(75, 41);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(75, 181);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 33);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 89);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre :";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(75, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(15, 132);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(49, 15);
            lblGrupo.TabIndex = 5;
            lblGrupo.Text = "Grupo : ";
            // 
            // cmbGrupo
            // 
            cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Items.AddRange(new object[] { "A", "B", "C" });
            cmbGrupo.Location = new Point(75, 129);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(110, 23);
            cmbGrupo.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 410);
            Controls.Add(cmbGrupo);
            Controls.Add(lblGrupo);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Name = "Form1";
            Text = "Carga Datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private Button btnRegistrar;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblGrupo;
        private ComboBox cmbGrupo;
    }
}
