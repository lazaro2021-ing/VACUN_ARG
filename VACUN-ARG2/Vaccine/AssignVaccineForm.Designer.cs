
namespace VACUN_ARG2.Vaccine
{
    partial class AssignVaccineForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.vaccine_cbox = new System.Windows.Forms.ComboBox();
            this.add_dosis_btn = new System.Windows.Forms.Button();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.center_cbox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "VACUNA";
            // 
            // vaccine_cbox
            // 
            this.vaccine_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vaccine_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaccine_cbox.FormattingEnabled = true;
            this.vaccine_cbox.Location = new System.Drawing.Point(121, 58);
            this.vaccine_cbox.Name = "vaccine_cbox";
            this.vaccine_cbox.Size = new System.Drawing.Size(306, 28);
            this.vaccine_cbox.TabIndex = 38;
            this.vaccine_cbox.SelectedIndexChanged += new System.EventHandler(this.vaccine_cbox_SelectedIndexChanged);
            // 
            // add_dosis_btn
            // 
            this.add_dosis_btn.Location = new System.Drawing.Point(285, 104);
            this.add_dosis_btn.Name = "add_dosis_btn";
            this.add_dosis_btn.Size = new System.Drawing.Size(142, 26);
            this.add_dosis_btn.TabIndex = 37;
            this.add_dosis_btn.Text = "ASIGNAR DOSIS";
            this.add_dosis_btn.UseVisualStyleBackColor = true;
            this.add_dosis_btn.Click += new System.EventHandler(this.add_dosis_btn_Click);
            // 
            // cantidad
            // 
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(121, 104);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(143, 26);
            this.cantidad.TabIndex = 36;
            this.cantidad.TextChanged += new System.EventHandler(this.cantidad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "CANTIDAD";
            this.label2.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "CENTRO";
            // 
            // center_cbox
            // 
            this.center_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.center_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.center_cbox.FormattingEnabled = true;
            this.center_cbox.Location = new System.Drawing.Point(121, 12);
            this.center_cbox.Name = "center_cbox";
            this.center_cbox.Size = new System.Drawing.Size(306, 28);
            this.center_cbox.TabIndex = 40;
            this.center_cbox.SelectedIndexChanged += new System.EventHandler(this.center_cbox_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // AssignVaccineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.center_cbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vaccine_cbox);
            this.Controls.Add(this.add_dosis_btn);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label2);
            this.Name = "AssignVaccineForm";
            this.Text = "ASIGNAR VACUNA A UN CENTRO";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox vaccine_cbox;
        private System.Windows.Forms.Button add_dosis_btn;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox center_cbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}