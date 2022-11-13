namespace WindowsTripulacion
{
    partial class frmTripulacion
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
            this.btnAgregarAzafata = new System.Windows.Forms.Button();
            this.btnQuitarAzafata = new System.Windows.Forms.Button();
            this.btnCrearJet = new System.Windows.Forms.Button();
            this.btnAgregarHelicoptero = new System.Windows.Forms.Button();
            this.btnMostrarListaAzafatas = new System.Windows.Forms.Button();
            this.gridAzafatas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridAzafatas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarAzafata
            // 
            this.btnAgregarAzafata.Location = new System.Drawing.Point(41, 53);
            this.btnAgregarAzafata.Name = "btnAgregarAzafata";
            this.btnAgregarAzafata.Size = new System.Drawing.Size(190, 47);
            this.btnAgregarAzafata.TabIndex = 0;
            this.btnAgregarAzafata.Text = "Agregar Azafata";
            this.btnAgregarAzafata.UseVisualStyleBackColor = true;
            // 
            // btnQuitarAzafata
            // 
            this.btnQuitarAzafata.Location = new System.Drawing.Point(237, 53);
            this.btnQuitarAzafata.Name = "btnQuitarAzafata";
            this.btnQuitarAzafata.Size = new System.Drawing.Size(190, 47);
            this.btnQuitarAzafata.TabIndex = 1;
            this.btnQuitarAzafata.Text = "Quitar Azafata";
            this.btnQuitarAzafata.UseVisualStyleBackColor = true;
            // 
            // btnCrearJet
            // 
            this.btnCrearJet.Location = new System.Drawing.Point(433, 369);
            this.btnCrearJet.Name = "btnCrearJet";
            this.btnCrearJet.Size = new System.Drawing.Size(190, 47);
            this.btnCrearJet.TabIndex = 2;
            this.btnCrearJet.Text = "Crear Jet";
            this.btnCrearJet.UseVisualStyleBackColor = true;
            // 
            // btnAgregarHelicoptero
            // 
            this.btnAgregarHelicoptero.Location = new System.Drawing.Point(41, 369);
            this.btnAgregarHelicoptero.Name = "btnAgregarHelicoptero";
            this.btnAgregarHelicoptero.Size = new System.Drawing.Size(190, 47);
            this.btnAgregarHelicoptero.TabIndex = 3;
            this.btnAgregarHelicoptero.Text = "Agregar Helicoptero";
            this.btnAgregarHelicoptero.UseVisualStyleBackColor = true;
            // 
            // btnMostrarListaAzafatas
            // 
            this.btnMostrarListaAzafatas.Location = new System.Drawing.Point(433, 53);
            this.btnMostrarListaAzafatas.Name = "btnMostrarListaAzafatas";
            this.btnMostrarListaAzafatas.Size = new System.Drawing.Size(190, 47);
            this.btnMostrarListaAzafatas.TabIndex = 4;
            this.btnMostrarListaAzafatas.Text = "Mostrar Azafatas";
            this.btnMostrarListaAzafatas.UseVisualStyleBackColor = true;
            // 
            // gridAzafatas
            // 
            this.gridAzafatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAzafatas.Location = new System.Drawing.Point(41, 106);
            this.gridAzafatas.Name = "gridAzafatas";
            this.gridAzafatas.RowHeadersWidth = 51;
            this.gridAzafatas.RowTemplate.Height = 24;
            this.gridAzafatas.Size = new System.Drawing.Size(582, 229);
            this.gridAzafatas.TabIndex = 5;
            // 
            // FrmTripulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.gridAzafatas);
            this.Controls.Add(this.btnMostrarListaAzafatas);
            this.Controls.Add(this.btnAgregarHelicoptero);
            this.Controls.Add(this.btnCrearJet);
            this.Controls.Add(this.btnQuitarAzafata);
            this.Controls.Add(this.btnAgregarAzafata);
            this.Name = "FrmTripulacion";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridAzafatas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarAzafata;
        private System.Windows.Forms.Button btnQuitarAzafata;
        private System.Windows.Forms.Button btnCrearJet;
        private System.Windows.Forms.Button btnAgregarHelicoptero;
        private System.Windows.Forms.Button btnMostrarListaAzafatas;
        private System.Windows.Forms.DataGridView gridAzafatas;
    }
}

