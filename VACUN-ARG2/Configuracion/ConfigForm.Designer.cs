
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
            this.SuspendLayout();
            // 
            // comboBox_centros
            // 
            this.comboBox_centros.FormattingEnabled = true;
            this.comboBox_centros.Location = new System.Drawing.Point(12, 44);
            this.comboBox_centros.Name = "comboBox_centros";
            this.comboBox_centros.Size = new System.Drawing.Size(332, 23);
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
            this.mac_address.Location = new System.Drawing.Point(12, 13);
            this.mac_address.Name = "mac_address";
            this.mac_address.Size = new System.Drawing.Size(332, 23);
            this.mac_address.TabIndex = 2;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 125);
            this.Controls.Add(this.mac_address);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.comboBox_centros);
            this.Name = "ConfigForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_centros;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox mac_address;
    }
}