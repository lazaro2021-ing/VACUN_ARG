
namespace VACUN_ARG2.Center
{
    partial class ViewAvailableVaccineForm
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
            this.vaccineGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vaccineGridView
            // 
            this.vaccineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vaccineGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.dosis,
            this.disponibles,
            this.aplicadas});
            this.vaccineGridView.Location = new System.Drawing.Point(0, 0);
            this.vaccineGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.vaccineGridView.Name = "vaccineGridView";
            this.vaccineGridView.Size = new System.Drawing.Size(638, 400);
            this.vaccineGridView.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            // 
            // dosis
            // 
            this.dosis.HeaderText = "Dosis";
            this.dosis.Name = "dosis";
            // 
            // disponibles
            // 
            this.disponibles.HeaderText = "Disponibles";
            this.disponibles.Name = "disponibles";
            // 
            // aplicadas
            // 
            this.aplicadas.HeaderText = "Aplicadas";
            this.aplicadas.Name = "aplicadas";
            // 
            // ViewAvailableVaccineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 400);
            this.Controls.Add(this.vaccineGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ViewAvailableVaccineForm";
            this.Text = "VACUNAS DISPONIBLES";
            ((System.ComponentModel.ISupportInitialize)(this.vaccineGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vaccineGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicadas;
    }
}