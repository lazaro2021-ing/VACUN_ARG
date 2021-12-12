
namespace VACUN_ARG2.Vacunar
{
    partial class VacunarForm
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
            this.dni_type_cbox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dni_numero = new System.Windows.Forms.TextBox();
            this.vaccine_cbox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buscar_box = new System.Windows.Forms.PictureBox();
            this.dosis_textbox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.buscar_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dni_type_cbox
            // 
            this.dni_type_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dni_type_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dni_type_cbox.FormattingEnabled = true;
            this.dni_type_cbox.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LE"});
            this.dni_type_cbox.Location = new System.Drawing.Point(177, 14);
            this.dni_type_cbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dni_type_cbox.Name = "dni_type_cbox";
            this.dni_type_cbox.Size = new System.Drawing.Size(304, 28);
            this.dni_type_cbox.TabIndex = 39;
            this.dni_type_cbox.SelectedIndexChanged += new System.EventHandler(this.dni_type_cbox_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(14, 18);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 24);
            this.label18.TabIndex = 36;
            this.label18.Text = "DOCUMENTO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(14, 57);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 24);
            this.label17.TabIndex = 37;
            this.label17.Text = "NÚMERO";
            // 
            // dni_numero
            // 
            this.dni_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dni_numero.Location = new System.Drawing.Point(177, 57);
            this.dni_numero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dni_numero.Name = "dni_numero";
            this.dni_numero.Size = new System.Drawing.Size(249, 26);
            this.dni_numero.TabIndex = 38;
            this.dni_numero.TextChanged += new System.EventHandler(this.dni_numero_TextChanged);
            // 
            // vaccine_cbox
            // 
            this.vaccine_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vaccine_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vaccine_cbox.FormattingEnabled = true;
            this.vaccine_cbox.Location = new System.Drawing.Point(125, 100);
            this.vaccine_cbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.vaccine_cbox.Name = "vaccine_cbox";
            this.vaccine_cbox.Size = new System.Drawing.Size(171, 28);
            this.vaccine_cbox.TabIndex = 42;
            this.vaccine_cbox.SelectedIndexChanged += new System.EventHandler(this.vaccine_cbox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(20, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 24);
            this.label10.TabIndex = 41;
            this.label10.Text = "VACUNA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(317, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "DOSIS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Location = new System.Drawing.Point(20, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(463, 37);
            this.button1.TabIndex = 45;
            this.button1.Text = "VACUNAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.vacunar_Click);
            // 
            // buscar_box
            // 
            this.buscar_box.Image = global::VACUN_ARG2.Properties.Resources.buscar;
            this.buscar_box.Location = new System.Drawing.Point(449, 57);
            this.buscar_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buscar_box.Name = "buscar_box";
            this.buscar_box.Size = new System.Drawing.Size(33, 30);
            this.buscar_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buscar_box.TabIndex = 46;
            this.buscar_box.TabStop = false;
            this.buscar_box.Click += new System.EventHandler(this.buscar_Click);
            // 
            // dosis_textbox
            // 
            this.dosis_textbox.Enabled = false;
            this.dosis_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dosis_textbox.Location = new System.Drawing.Point(401, 100);
            this.dosis_textbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dosis_textbox.Name = "dosis_textbox";
            this.dosis_textbox.Size = new System.Drawing.Size(80, 26);
            this.dosis_textbox.TabIndex = 47;
            this.dosis_textbox.TextChanged += new System.EventHandler(this.dosis_textbox_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // VacunarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 202);
            this.Controls.Add(this.dosis_textbox);
            this.Controls.Add(this.buscar_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vaccine_cbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dni_type_cbox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dni_numero);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "VacunarForm";
            this.Text = "REGISTRAR VACUNACIÓN";
            ((System.ComponentModel.ISupportInitialize)(this.buscar_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox dni_type_cbox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox dni_numero;
        private System.Windows.Forms.ComboBox vaccine_cbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox buscar_box;
        private System.Windows.Forms.TextBox dosis_textbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}