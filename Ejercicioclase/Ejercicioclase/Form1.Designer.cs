
namespace Ejercicioclase
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_deConversores = new System.Windows.Forms.Label();
            this.Cbo_Conversores = new System.Windows.Forms.ComboBox();
            this.cbo_aconversores = new System.Windows.Forms.ComboBox();
            this.lbl_aconversores = new System.Windows.Forms.Label();
            this.btn_convertirconvensores = new System.Windows.Forms.Button();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_deConversores
            // 
            this.lbl_deConversores.AutoSize = true;
            this.lbl_deConversores.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deConversores.Location = new System.Drawing.Point(190, 61);
            this.lbl_deConversores.Name = "lbl_deConversores";
            this.lbl_deConversores.Size = new System.Drawing.Size(37, 22);
            this.lbl_deConversores.TabIndex = 0;
            this.lbl_deConversores.Text = "De:";
            this.lbl_deConversores.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cbo_Conversores
            // 
            this.Cbo_Conversores.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Conversores.FormattingEnabled = true;
            this.Cbo_Conversores.Location = new System.Drawing.Point(265, 53);
            this.Cbo_Conversores.Name = "Cbo_Conversores";
            this.Cbo_Conversores.Size = new System.Drawing.Size(217, 30);
            this.Cbo_Conversores.TabIndex = 2;
            // 
            // cbo_aconversores
            // 
            this.cbo_aconversores.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_aconversores.FormattingEnabled = true;
            this.cbo_aconversores.Location = new System.Drawing.Point(265, 105);
            this.cbo_aconversores.Name = "cbo_aconversores";
            this.cbo_aconversores.Size = new System.Drawing.Size(217, 30);
            this.cbo_aconversores.TabIndex = 4;
            // 
            // lbl_aconversores
            // 
            this.lbl_aconversores.AutoSize = true;
            this.lbl_aconversores.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aconversores.Location = new System.Drawing.Point(190, 108);
            this.lbl_aconversores.Name = "lbl_aconversores";
            this.lbl_aconversores.Size = new System.Drawing.Size(29, 22);
            this.lbl_aconversores.TabIndex = 3;
            this.lbl_aconversores.Text = "A:";
            // 
            // btn_convertirconvensores
            // 
            this.btn_convertirconvensores.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convertirconvensores.Location = new System.Drawing.Point(288, 227);
            this.btn_convertirconvensores.Name = "btn_convertirconvensores";
            this.btn_convertirconvensores.Size = new System.Drawing.Size(149, 67);
            this.btn_convertirconvensores.TabIndex = 5;
            this.btn_convertirconvensores.Text = "Convertir";
            this.btn_convertirconvensores.UseVisualStyleBackColor = true;
            this.btn_convertirconvensores.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(175, 183);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(52, 13);
            this.lbl_cantidad.TabIndex = 6;
            this.lbl_cantidad.Text = "Cantidad:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(265, 183);
            this.txt_cantidad.Multiline = true;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(217, 23);
            this.txt_cantidad.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.btn_convertirconvensores);
            this.Controls.Add(this.cbo_aconversores);
            this.Controls.Add(this.lbl_aconversores);
            this.Controls.Add(this.Cbo_Conversores);
            this.Controls.Add(this.lbl_deConversores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_deConversores;
        private System.Windows.Forms.ComboBox Cbo_Conversores;
        private System.Windows.Forms.ComboBox cbo_aconversores;
        private System.Windows.Forms.Label lbl_aconversores;
        private System.Windows.Forms.Button btn_convertirconvensores;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_cantidad;
    }
}

