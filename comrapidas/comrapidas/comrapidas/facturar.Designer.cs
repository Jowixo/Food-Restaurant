namespace comrapidas
{
    partial class password
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btncrrar = new System.Windows.Forms.Button();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.lblusu = new System.Windows.Forms.Label();
            this.lblcontra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cnombre,
            this.Cpedido,
            this.Ccantidad,
            this.Ctotal});
            this.dataGridView1.Location = new System.Drawing.Point(103, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Cnombre
            // 
            this.Cnombre.HeaderText = "Nombre";
            this.Cnombre.Name = "Cnombre";
            // 
            // Cpedido
            // 
            this.Cpedido.HeaderText = "Orden";
            this.Cpedido.Name = "Cpedido";
            // 
            // Ccantidad
            // 
            this.Ccantidad.HeaderText = "Cantidad";
            this.Ccantidad.Name = "Ccantidad";
            // 
            // Ctotal
            // 
            this.Ctotal.HeaderText = "Total";
            this.Ctotal.Name = "Ctotal";
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Location = new System.Drawing.Point(148, 248);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnrefrescar.TabIndex = 1;
            this.btnrefrescar.Text = "Refrescar";
            this.btnrefrescar.UseVisualStyleBackColor = true;
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(286, 248);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 2;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            // 
            // btncrrar
            // 
            this.btncrrar.Location = new System.Drawing.Point(210, 199);
            this.btncrrar.Name = "btncrrar";
            this.btncrrar.Size = new System.Drawing.Size(114, 30);
            this.btncrrar.TabIndex = 0;
            this.btncrrar.Text = "Aceptar";
            this.btncrrar.UseVisualStyleBackColor = true;
            this.btncrrar.Click += new System.EventHandler(this.btncrrar_Click);
            // 
            // txtusu
            // 
            this.txtusu.Location = new System.Drawing.Point(210, 90);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(107, 23);
            this.txtusu.TabIndex = 2;
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(210, 130);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(107, 23);
            this.txtcontra.TabIndex = 3;
            // 
            // lblusu
            // 
            this.lblusu.AutoSize = true;
            this.lblusu.Location = new System.Drawing.Point(129, 98);
            this.lblusu.Name = "lblusu";
            this.lblusu.Size = new System.Drawing.Size(47, 15);
            this.lblusu.TabIndex = 4;
            this.lblusu.Text = "Usuario";
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.Location = new System.Drawing.Point(129, 138);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(67, 15);
            this.lblcontra.TabIndex = 5;
            this.lblcontra.Text = "Contraseña";
            // 
            // password
            // 
            this.ClientSize = new System.Drawing.Size(550, 329);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.lblusu);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.btncrrar);
            this.Name = "password";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Cnombre;
        private DataGridViewTextBoxColumn Cpedido;
        private DataGridViewTextBoxColumn Ccantidad;
        private DataGridViewTextBoxColumn Ctotal;
        private Button btnrefrescar;
        private Button btncerrar;
        private Button btncrrar;
        private TextBox txtusu;
        private TextBox txtcontra;
        private Label lblusu;
        private Label lblcontra;
    }
}