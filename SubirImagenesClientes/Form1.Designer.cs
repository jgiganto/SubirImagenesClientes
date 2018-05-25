namespace SubirImagenesClientes
{
    partial class Form1
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
            this.btncargarclientes = new System.Windows.Forms.Button();
            this.btnactualizarsql = new System.Windows.Forms.Button();
            this.btnsubirficheros = new System.Windows.Forms.Button();
            this.gridclientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btncargarclientes
            // 
            this.btncargarclientes.Location = new System.Drawing.Point(96, 59);
            this.btncargarclientes.Name = "btncargarclientes";
            this.btncargarclientes.Size = new System.Drawing.Size(100, 23);
            this.btncargarclientes.TabIndex = 0;
            this.btncargarclientes.Text = "Cargar clientes";
            this.btncargarclientes.UseVisualStyleBackColor = true;
            // 
            // btnactualizarsql
            // 
            this.btnactualizarsql.Location = new System.Drawing.Point(264, 58);
            this.btnactualizarsql.Name = "btnactualizarsql";
            this.btnactualizarsql.Size = new System.Drawing.Size(115, 23);
            this.btnactualizarsql.TabIndex = 1;
            this.btnactualizarsql.Text = "actualizar";
            this.btnactualizarsql.UseVisualStyleBackColor = true;
            // 
            // btnsubirficheros
            // 
            this.btnsubirficheros.Location = new System.Drawing.Point(455, 58);
            this.btnsubirficheros.Name = "btnsubirficheros";
            this.btnsubirficheros.Size = new System.Drawing.Size(118, 23);
            this.btnsubirficheros.TabIndex = 2;
            this.btnsubirficheros.Text = "Subir ficheros";
            this.btnsubirficheros.UseVisualStyleBackColor = true;
            // 
            // gridclientes
            // 
            this.gridclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridclientes.Location = new System.Drawing.Point(126, 141);
            this.gridclientes.Name = "gridclientes";
            this.gridclientes.Size = new System.Drawing.Size(509, 299);
            this.gridclientes.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 639);
            this.Controls.Add(this.gridclientes);
            this.Controls.Add(this.btnsubirficheros);
            this.Controls.Add(this.btnactualizarsql);
            this.Controls.Add(this.btncargarclientes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridclientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncargarclientes;
        private System.Windows.Forms.Button btnactualizarsql;
        private System.Windows.Forms.Button btnsubirficheros;
        private System.Windows.Forms.DataGridView gridclientes;
    }
}

