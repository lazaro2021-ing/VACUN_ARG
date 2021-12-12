
namespace VACUN_ARG2
{
    partial class ConfigForm
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
            this.comboBox_centros = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            this.mac_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_centros
            // 
            this.comboBox_centros.FormattingEnabled = true;
            this.comboBox_centros.Location = new System.Drawing.Point(132, 44);
            this.comboBox_centros.Name = "comboBox_centros";
            this.comboBox_centros.Size = new System.Drawing.Size(212, 23);
            this.comboBox_centros.TabIndex = 0;
            this.comboBox_centros.SelectedIndexChanged += new System.EventHandler(this.comboBox_centros_SelectedIndexChanged);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(12, 89);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(332, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Guardar";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // mac_address
            // 
            this.mac_address.Enabled = false;
            this.mac_address.Location = new System.Drawing.Point(132, 13);
            this.mac_address.Name = "mac_address";
            this.mac_address.Size = new System.Drawing.Size(212, 23);
            this.mac_address.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "MAC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "CENTRO:";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 125);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mac_address);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.comboBox_centros);
            this.Name = "ConfigForm";
            this.Text = "CONFIGURACIÓN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_centros;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox mac_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}