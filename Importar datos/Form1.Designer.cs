namespace Importar_datos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataDetalles = new System.Windows.Forms.DataGridView();
            this.BtnImportarDatos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcadena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // DataDetalles
            // 
            this.DataDetalles.AllowUserToAddRows = false;
            this.DataDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDetalles.Location = new System.Drawing.Point(12, 43);
            this.DataDetalles.Name = "DataDetalles";
            this.DataDetalles.Size = new System.Drawing.Size(620, 395);
            this.DataDetalles.TabIndex = 0;
            // 
            // BtnImportarDatos
            // 
            this.BtnImportarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImportarDatos.BackColor = System.Drawing.Color.DeepPink;
            this.BtnImportarDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnImportarDatos.Location = new System.Drawing.Point(638, 12);
            this.BtnImportarDatos.Name = "BtnImportarDatos";
            this.BtnImportarDatos.Size = new System.Drawing.Size(150, 50);
            this.BtnImportarDatos.TabIndex = 1;
            this.BtnImportarDatos.Text = "Importar Datos";
            this.BtnImportarDatos.UseVisualStyleBackColor = false;
            this.BtnImportarDatos.Click += new System.EventHandler(this.BtnImportarDatos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepPink;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(638, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Registrar Datos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcadena
            // 
            this.txtcadena.Location = new System.Drawing.Point(188, 15);
            this.txtcadena.Name = "txtcadena";
            this.txtcadena.Size = new System.Drawing.Size(408, 20);
            this.txtcadena.TabIndex = 3;
            this.txtcadena.Text = "Data Source=cpiprodesign;Initial Catalog=CM_FARMA;Integrated Security=True";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadena de conexion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcadena);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnImportarDatos);
            this.Controls.Add(this.DataDetalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMPORTAR DATOS DE EXCEL AL SISTEMA";
            ((System.ComponentModel.ISupportInitialize)(this.DataDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataDetalles;
        private System.Windows.Forms.Button BtnImportarDatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcadena;
        private System.Windows.Forms.Label label1;
    }
}

