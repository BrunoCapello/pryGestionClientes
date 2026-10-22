namespace pryGestionClientes
{
    partial class frmDeudores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeudores));
            this.btnListar = new System.Windows.Forms.Button();
            this.lblMuestraPromedio = new System.Windows.Forms.Label();
            this.lblMuestraQ = new System.Windows.Forms.Label();
            this.lblMuestraTotal = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblQClientes = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(279, 377);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(276, 28);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblMuestraPromedio
            // 
            this.lblMuestraPromedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMuestraPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMuestraPromedio.Location = new System.Drawing.Point(685, 347);
            this.lblMuestraPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMuestraPromedio.Name = "lblMuestraPromedio";
            this.lblMuestraPromedio.Size = new System.Drawing.Size(95, 18);
            this.lblMuestraPromedio.TabIndex = 14;
            // 
            // lblMuestraQ
            // 
            this.lblMuestraQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMuestraQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMuestraQ.Location = new System.Drawing.Point(421, 346);
            this.lblMuestraQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMuestraQ.Name = "lblMuestraQ";
            this.lblMuestraQ.Size = new System.Drawing.Size(95, 18);
            this.lblMuestraQ.TabIndex = 13;
            // 
            // lblMuestraTotal
            // 
            this.lblMuestraTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMuestraTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMuestraTotal.Location = new System.Drawing.Point(137, 345);
            this.lblMuestraTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMuestraTotal.Name = "lblMuestraTotal";
            this.lblMuestraTotal.Size = new System.Drawing.Size(95, 18);
            this.lblMuestraTotal.TabIndex = 12;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPromedio.Location = new System.Drawing.Point(543, 347);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(120, 18);
            this.lblPromedio.TabIndex = 11;
            this.lblPromedio.Text = "Promedio Deuda";
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblQClientes
            // 
            this.lblQClientes.AutoSize = true;
            this.lblQClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblQClientes.Location = new System.Drawing.Point(227, 331);
            this.lblQClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQClientes.Name = "lblQClientes";
            this.lblQClientes.Size = new System.Drawing.Size(152, 18);
            this.lblQClientes.TabIndex = 10;
            this.lblQClientes.Text = "Cantidad de deudores";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDeuda.Location = new System.Drawing.Point(33, 343);
            this.lblDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(85, 18);
            this.lblDeuda.TabIndex = 9;
            this.lblDeuda.Text = "Total deuda";
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
            this.dgvListadoClientes.Location = new System.Drawing.Point(32, 27);
            this.dgvListadoClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.RowHeadersWidth = 51;
            this.dgvListadoClientes.Size = new System.Drawing.Size(749, 305);
            this.dgvListadoClientes.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lblQClientes);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 401);
            this.panel1.TabIndex = 15;
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
            // frmDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 426);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblMuestraPromedio);
            this.Controls.Add(this.lblMuestraQ);
            this.Controls.Add(this.lblMuestraTotal);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.dgvListadoClientes);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDeudores";
            this.Text = "Deudores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblMuestraPromedio;
        private System.Windows.Forms.Label lblMuestraQ;
        private System.Windows.Forms.Label lblMuestraTotal;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblQClientes;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.DataGridView dgvListadoClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
    }
}