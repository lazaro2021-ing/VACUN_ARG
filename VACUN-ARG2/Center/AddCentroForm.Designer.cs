

namespace VACUN_ARG2.Center
{
    partial class AddCenterForm
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
            this.departamentos_cbox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.crear_btn = new System.Windows.Forms.Button();
            this.localidades_cbox = new System.Windows.Forms.ComboBox();
            this.provincias_cbox = new System.Windows.Forms.ComboBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // departamentos_cbox
            // 
            this.departamentos_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departamentos_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departamentos_cbox.FormattingEnabled = true;
            this.departamentos_cbox.Location = new System.Drawing.Point(238, 134);
            this.departamentos_cbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.departamentos_cbox.Name = "departamentos_cbox";
            this.departamentos_cbox.Size = new System.Drawing.Size(352, 28);
            this.departamentos_cbox.TabIndex = 19;
            this.departamentos_cbox.SelectedIndexChanged += new System.EventHandler(this.departamentos_cbox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "DEPARTAMENTO";
            // 
            // crear_btn
            // 
            this.crear_btn.Location = new System.Drawing.Point(15, 252);
            this.crear_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.crear_btn.Name = "crear_btn";
            this.crear_btn.Size = new System.Drawing.Size(575, 38);
            this.crear_btn.TabIndex = 17;
            this.crear_btn.Text = "CREAR";
            this.crear_btn.UseVisualStyleBackColor = true;
            this.crear_btn.Click += new System.EventHandler(this.createCenter_Click);
            // 
            // localidades_cbox
            // 
            this.localidades_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.localidades_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.localidades_cbox.FormattingEnabled = true;
            this.localidades_cbox.Location = new System.Drawing.Point(237, 194);
            this.localidades_cbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.localidades_cbox.Name = "localidades_cbox";
            this.localidades_cbox.Size = new System.Drawing.Size(353, 28);
            this.localidades_cbox.TabIndex = 16;
            this.localidades_cbox.SelectedIndexChanged += new System.EventHandler(this.localidad_cbox_SelectedIndexChanged);
            // 
            // provincias_cbox
            // 
            this.provincias_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provincias_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.provincias_cbox.FormattingEnabled = true;
            this.provincias_cbox.Location = new System.Drawing.Point(237, 74);
            this.provincias_cbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.provincias_cbox.Name = "provincias_cbox";
            this.provincias_cbox.Size = new System.Drawing.Size(353, 28);
            this.provincias_cbox.TabIndex = 15;
            this.provincias_cbox.SelectedIndexChanged += new System.EventHandler(this.provincias_cbox_SelectedIndexChanged);
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombre.Location = new System.Drawing.Point(237, 18);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(352, 26);
            this.nombre.TabIndex = 14;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "PROVINCIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "LOCALIDAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "NOMBRE";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // AddCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 301);
            this.Controls.Add(this.departamentos_cbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.crear_btn);
            this.Controls.Add(this.localidades_cbox);
            this.Controls.Add(this.provincias_cbox);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddCenterForm";
            this.Text = "CREAR CENTRO DE VACUNACIÓN";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox departamentos_cbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button crear_btn;
        private System.Windows.Forms.ComboBox localidades_cbox;
        private System.Windows.Forms.ComboBox provincias_cbox;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}