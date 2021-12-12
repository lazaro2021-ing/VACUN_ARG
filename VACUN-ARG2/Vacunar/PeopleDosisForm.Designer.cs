
namespace VACUN_ARG2.Vacunar
{
    partial class PeopleDosisForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dosis_grid = new System.Windows.Forms.DataGridView();
            this.dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dosis_label = new System.Windows.Forms.Label();
            this.nacionalidad_label = new System.Windows.Forms.Label();
            this.dni_numero_label = new System.Windows.Forms.Label();
            this.dni_type_label = new System.Windows.Forms.Label();
            this.nombre_label = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dosis_grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datos Personales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dosis Aplicadas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.dosis_grid);
            this.panel2.Location = new System.Drawing.Point(14, 255);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 208);
            this.panel2.TabIndex = 5;
            // 
            // dosis_grid
            // 
            this.dosis_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dosis_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dosis,
            this.nombre,
            this.fecha});
            this.dosis_grid.Location = new System.Drawing.Point(5, 7);
            this.dosis_grid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dosis_grid.Name = "dosis_grid";
            this.dosis_grid.Size = new System.Drawing.Size(373, 201);
            this.dosis_grid.TabIndex = 1;
            // 
            // dosis
            // 
            this.dosis.HeaderText = "Dosis";
            this.dosis.Name = "dosis";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.dosis_label);
            this.panel1.Controls.Add(this.nacionalidad_label);
            this.panel1.Controls.Add(this.dni_numero_label);
            this.panel1.Controls.Add(this.dni_type_label);
            this.panel1.Controls.Add(this.nombre_label);
            this.panel1.Location = new System.Drawing.Point(14, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 179);
            this.panel1.TabIndex = 0;
            // 
            // dosis_label
            // 
            this.dosis_label.AutoSize = true;
            this.dosis_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dosis_label.Location = new System.Drawing.Point(15, 135);
            this.dosis_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dosis_label.Name = "dosis_label";
            this.dosis_label.Size = new System.Drawing.Size(53, 20);
            this.dosis_label.TabIndex = 5;
            this.dosis_label.Text = "Dosis:";
            // 
            // nacionalidad_label
            // 
            this.nacionalidad_label.AutoSize = true;
            this.nacionalidad_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nacionalidad_label.Location = new System.Drawing.Point(15, 104);
            this.nacionalidad_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nacionalidad_label.Name = "nacionalidad_label";
            this.nacionalidad_label.Size = new System.Drawing.Size(104, 20);
            this.nacionalidad_label.TabIndex = 4;
            this.nacionalidad_label.Text = "Nacionalidad:";
            // 
            // dni_numero_label
            // 
            this.dni_numero_label.AutoSize = true;
            this.dni_numero_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dni_numero_label.Location = new System.Drawing.Point(15, 73);
            this.dni_numero_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dni_numero_label.Name = "dni_numero_label";
            this.dni_numero_label.Size = new System.Drawing.Size(156, 20);
            this.dni_numero_label.TabIndex = 3;
            this.dni_numero_label.Text = "Número Documento:";
            // 
            // dni_type_label
            // 
            this.dni_type_label.AutoSize = true;
            this.dni_type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dni_type_label.Location = new System.Drawing.Point(15, 42);
            this.dni_type_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dni_type_label.Name = "dni_type_label";
            this.dni_type_label.Size = new System.Drawing.Size(130, 20);
            this.dni_type_label.TabIndex = 2;
            this.dni_type_label.Text = "Tipo Documento:";
            // 
            // nombre_label
            // 
            this.nombre_label.AutoSize = true;
            this.nombre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombre_label.Location = new System.Drawing.Point(15, 10);
            this.nombre_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(69, 20);
            this.nombre_label.TabIndex = 1;
            this.nombre_label.Text = "Nombre:";
            // 
            // PeopleDosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PeopleDosisForm";
            this.Text = "DATOS";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dosis_grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nacionalidad_label;
        private System.Windows.Forms.Label dni_numero_label;
        private System.Windows.Forms.Label dni_type_label;
        private System.Windows.Forms.Label nombre_label;
        private System.Windows.Forms.DataGridView dosis_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dosis_label;
    }
}