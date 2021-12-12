
namespace VACUN_ARG2.Vaccine
{
    partial class CreateVaccineForm
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pais = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.temperatura = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombre.Location = new System.Drawing.Point(133, 8);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(363, 26);
            this.nombre.TabIndex = 16;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "NOMBRE";
            // 
            // cantidad
            // 
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cantidad.Location = new System.Drawing.Point(133, 107);
            this.cantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(121, 26);
            this.cantidad.TabIndex = 18;
            this.cantidad.TextChanged += new System.EventHandler(this.cantidad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "CANTIDAD";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "PAÍS";
            this.label3.UseMnemonic = false;
            // 
            // pais
            // 
            this.pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pais.Location = new System.Drawing.Point(133, 58);
            this.pais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(363, 26);
            this.pais.TabIndex = 20;
            this.pais.TextChanged += new System.EventHandler(this.pais_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(287, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "TEMP.";
            this.label4.UseMnemonic = false;
            // 
            // temperatura
            // 
            this.temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.temperatura.Location = new System.Drawing.Point(373, 107);
            this.temperatura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(123, 26);
            this.temperatura.TabIndex = 22;
            this.temperatura.TextChanged += new System.EventHandler(this.temperatura_TextChanged);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(19, 156);
            this.create.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(478, 39);
            this.create.TabIndex = 23;
            this.create.Text = "CREAR";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // CreateVaccineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 219);
            this.Controls.Add(this.create);
            this.Controls.Add(this.temperatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CreateVaccineForm";
            this.Text = "CREAR VACUNA DISPONIBLE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox temperatura;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}