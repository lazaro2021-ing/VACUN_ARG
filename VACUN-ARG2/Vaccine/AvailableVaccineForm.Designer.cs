
namespace VACUN_ARG2.Vaccine
{
    partial class AvailableVaccineForm
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
            this.data_vaccine = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_vaccine)).BeginInit();
            this.SuspendLayout();
            // 
            // data_vaccine
            // 
            this.data_vaccine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_vaccine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.pais,
            this.temp,
            this.dosis,
            this.aplicadas,
            this.disponibles});
            this.data_vaccine.Location = new System.Drawing.Point(0, 0);
            this.data_vaccine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.data_vaccine.Name = "data_vaccine";
            this.data_vaccine.Size = new System.Drawing.Size(886, 449);
            this.data_vaccine.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // pais
            // 
            this.pais.HeaderText = "País";
            this.pais.Name = "pais";
            this.pais.ReadOnly = true;
            // 
            // temp
            // 
            this.temp.HeaderText = "Temp.(°C)";
            this.temp.Name = "temp";
            // 
            // dosis
            // 
            this.dosis.HeaderText = "Dosis";
            this.dosis.Name = "dosis";
            // 
            // aplicadas
            // 
            this.aplicadas.HeaderText = "Aplicadas";
            this.aplicadas.Name = "aplicadas";
            // 
            // disponibles
            // 
            this.disponibles.HeaderText = "Disponibles";
            this.disponibles.Name = "disponibles";
            // 
            // AvailableVaccineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.data_vaccine);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AvailableVaccineForm";
            this.Text = "DISPONIBILIDAD DE VACUNAS";
            ((System.ComponentModel.ISupportInitialize)(this.data_vaccine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_vaccine;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibles;
    }
}