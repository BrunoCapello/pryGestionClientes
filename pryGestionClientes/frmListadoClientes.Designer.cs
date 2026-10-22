namespace pryGestionClientes
{
    partial class frmListadoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoClientes));
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblQClientes = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMuestraTotal = new System.Windows.Forms.Label();
            this.lblMuestraQ = new System.Windows.Forms.Label();
            this.lblMuestraPromedio = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoClientes
            // 
            this.dgvListadoClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colDeu,
            this.colLimite});
            this.dgvListadoClientes.Location = new System.Drawing.Point(16, 15);
            this.dgvListadoClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.RowHeadersWidth = 51;
            this.dgvListadoClientes.Size = new System.Drawing.Size(749, 305);
            this.dgvListadoClientes.TabIndex = 0;
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDeuda.Location = new System.Drawing.Point(17, 331);
            this.lblDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(85, 18);
            this.lblDeuda.TabIndex = 1;
            this.lblDeuda.Text = "Total deuda";
            // 
            // lblQClientes
            // 
            this.lblQClientes.AutoSize = true;
            this.lblQClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblQClientes.Location = new System.Drawing.Point(240, 334);
            this.lblQClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQClientes.Name = "lblQClientes";
            this.lblQClientes.Size = new System.Drawing.Size(140, 18);
            this.lblQClientes.TabIndex = 2;
            this.lblQClientes.Text = "Cantidad de clientes";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPromedio.Location = new System.Drawing.Point(527, 335);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(120, 18);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio Deuda";
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMuestraTotal
            // 
            this.lblMuestraTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMuestraTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMuestraTotal.Location = new System.Drawing.Point(121, 332);
            this.lblMuestraTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMuestraTotal.Name = "lblMuestraTotal";
            this.lblMuestraTotal.Size = new System.Drawing.Size(95, 18);
            this.lblMuestraTotal.TabIndex = 4;
            // 
            // lblMuestraQ
            // 
            this.lblMuestraQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMuestraQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMuestraQ.Location = new System.Drawing.Point(405, 334);
            this.lblMuestraQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMuestraQ.Name = "lblMuestraQ";
            this.lblMuestraQ.Size = new System.Drawing.Size(95, 18);
            this.lblMuestraQ.TabIndex = 5;
            // 
            // lblMuestraPromedio
            // 
            this.lblMuestraPromedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMuestraPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMuestraPromedio.Location = new System.Drawing.Point(669, 335);
            this.lblMuestraPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMuestraPromedio.Name = "lblMuestraPromedio";
            this.lblMuestraPromedio.Size = new System.Drawing.Size(95, 18);
            this.lblMuestraPromedio.TabIndex = 6;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(531, 364);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(187, 28);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(84, 364);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(187, 28);
            this.btnReporte.TabIndex = 7;
            this.btnReporte.Text = "Generar reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(303, 364);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(187, 28);
            this.btnOrdenar.TabIndex = 8;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre y Apellido";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            // 
            // colDeu
            // 
            this.colDeu.HeaderText = "Deuda";
            this.colDeu.MinimumWidth = 6;
            this.colDeu.Name = "colDeu";
            // 
            // colLimite
            // 
            this.colLimite.HeaderText = "Límite de Crédito";
            this.colLimite.MinimumWidth = 6;
            this.colLimite.Name = "colLimite";
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 407);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblMuestraPromedio);
            this.Controls.Add(this.lblMuestraQ);
            this.Controls.Add(this.lblMuestraTotal);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblQClientes);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.dgvListadoClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListadoClientes";
            this.Text = "Listado Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoClientes;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblQClientes;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblMuestraTotal;
        private System.Windows.Forms.Label lblMuestraQ;
        private System.Windows.Forms.Label lblMuestraPromedio;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
    }
}