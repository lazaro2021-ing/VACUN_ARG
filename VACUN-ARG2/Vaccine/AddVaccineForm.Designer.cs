
namespace VACUN_ARG2.Vaccine
{
    partial class AddVaccineForm
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
            this.components = new System.ComponentModel.Container();
            this.add_dosis_btn = new System.Windows.Forms.Button();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vaccine_cbox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_dosis_btn
            // 
            this.add_dosis_btn.Location = new System.Drawing.Point(330, 72);
            this.add_dosis_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add_dosis_btn.Name = "add_dosis_btn";
            this.add_dosis_btn.Size = new System.Drawing.Size(166, 30);
            this.add_dosis_btn.TabIndex = 32;
            this.add_dosis_btn.Text = "AÑADIR DOSIS";
            this.add_dosis_btn.UseVisualStyleBackColor = true;
            this.add_dosis_btn.Click += new System.EventHandler(this.add_dosis_btn_Click);
            // 
            // cantidad
            // 
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cantidad.Location = new System.Drawing.Point(139, 72);
            this.cantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(166, 26);
            this.cantidad.TabIndex = 27;
            this.cantidad.TextChanged += new System.EventHandler(this.cantidad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "CANTIDAD";
            this.label2.UseMnemonic = false;
            // 
            // vaccine_cbox
            // 
            this.vaccine_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vaccine_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vaccine_cbox.FormattingEnabled = true;
            this.vaccine_cbox.Location = new System.Drawing.Point(139, 14);
            this.vaccine_cbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.vaccine_cbox.Name = "vaccine_cbox";
            this.vaccine_cbox.Size = new System.Drawing.Size(356, 28);
            this.vaccine_cbox.TabIndex = 33;
            this.vaccine_cbox.SelectedIndexChanged += new System.EventHandler(this.vaccine_cbox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "NOMBRE";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // AddVaccineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 126);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vaccine_cbox);
            this.Controls.Add(this.add_dosis_btn);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddVaccineForm";
            this.Text = "Añadir Vacuna";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_dosis_btn;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vaccine_cbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}