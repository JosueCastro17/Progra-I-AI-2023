
namespace ejercicios
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
            this.LblDeArea = new System.Windows.Forms.Label();
            this.Btn_ConvertirArea = new System.Windows.Forms.Button();
            this.CboDeArea = new System.Windows.Forms.ComboBox();
            this.CboAarea = new System.Windows.Forms.ComboBox();
            this.LblAarea = new System.Windows.Forms.Label();
            this.LblRespuestaArea = new System.Windows.Forms.Label();
            this.TxtCantidadArea = new System.Windows.Forms.TextBox();
            this.LblCantidadArea = new System.Windows.Forms.Label();
            this.CboTipoArea = new System.Windows.Forms.ComboBox();
            this.lblTipoArea = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDeArea
            // 
            this.LblDeArea.AutoSize = true;
            this.LblDeArea.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeArea.Location = new System.Drawing.Point(99, 146);
            this.LblDeArea.Name = "LblDeArea";
            this.LblDeArea.Size = new System.Drawing.Size(37, 22);
            this.LblDeArea.TabIndex = 0;
            this.LblDeArea.Text = "De:";
            // 
            // Btn_ConvertirArea
            // 
            this.Btn_ConvertirArea.Location = new System.Drawing.Point(197, 394);
            this.Btn_ConvertirArea.Name = "Btn_ConvertirArea";
            this.Btn_ConvertirArea.Size = new System.Drawing.Size(132, 45);
            this.Btn_ConvertirArea.TabIndex = 1;
            this.Btn_ConvertirArea.Text = "Convertir";
            this.Btn_ConvertirArea.UseVisualStyleBackColor = true;
            this.Btn_ConvertirArea.Click += new System.EventHandler(this.Btn_ConvertirConversores_Click);
            // 
            // CboDeArea
            // 
            this.CboDeArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDeArea.FormattingEnabled = true;
            this.CboDeArea.Location = new System.Drawing.Point(164, 143);
            this.CboDeArea.Name = "CboDeArea";
            this.CboDeArea.Size = new System.Drawing.Size(206, 27);
            this.CboDeArea.TabIndex = 2;
            this.CboDeArea.SelectedIndexChanged += new System.EventHandler(this.CboDeArea_SelectedIndexChanged);
            // 
            // CboAarea
            // 
            this.CboAarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAarea.FormattingEnabled = true;
            this.CboAarea.Location = new System.Drawing.Point(164, 220);
            this.CboAarea.Name = "CboAarea";
            this.CboAarea.Size = new System.Drawing.Size(206, 27);
            this.CboAarea.TabIndex = 4;
            // 
            // LblAarea
            // 
            this.LblAarea.AutoSize = true;
            this.LblAarea.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAarea.Location = new System.Drawing.Point(99, 228);
            this.LblAarea.Name = "LblAarea";
            this.LblAarea.Size = new System.Drawing.Size(29, 22);
            this.LblAarea.TabIndex = 3;
            this.LblAarea.Text = "A:";
            // 
            // LblRespuestaArea
            // 
            this.LblRespuestaArea.AutoSize = true;
            this.LblRespuestaArea.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRespuestaArea.Location = new System.Drawing.Point(206, 344);
            this.LblRespuestaArea.Name = "LblRespuestaArea";
            this.LblRespuestaArea.Size = new System.Drawing.Size(110, 22);
            this.LblRespuestaArea.TabIndex = 5;
            this.LblRespuestaArea.Text = "Respuesta: ?";
            // 
            // TxtCantidadArea
            // 
            this.TxtCantidadArea.Location = new System.Drawing.Point(164, 296);
            this.TxtCantidadArea.Name = "TxtCantidadArea";
            this.TxtCantidadArea.Size = new System.Drawing.Size(206, 26);
            this.TxtCantidadArea.TabIndex = 6;
            // 
            // LblCantidadArea
            // 
            this.LblCantidadArea.AutoSize = true;
            this.LblCantidadArea.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadArea.Location = new System.Drawing.Point(60, 300);
            this.LblCantidadArea.Name = "LblCantidadArea";
            this.LblCantidadArea.Size = new System.Drawing.Size(91, 22);
            this.LblCantidadArea.TabIndex = 7;
            this.LblCantidadArea.Text = "Cantidad:";
            // 
            // CboTipoArea
            // 
            this.CboTipoArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoArea.FormattingEnabled = true;
            this.CboTipoArea.Items.AddRange(new object[] {
            "Area"});
            this.CboTipoArea.Location = new System.Drawing.Point(164, 83);
            this.CboTipoArea.Name = "CboTipoArea";
            this.CboTipoArea.Size = new System.Drawing.Size(206, 27);
            this.CboTipoArea.TabIndex = 8;
            this.CboTipoArea.SelectedIndexChanged += new System.EventHandler(this.CboTipoArea_SelectedIndexChanged);
            this.CboTipoArea.TextChanged += new System.EventHandler(this.CboTipoConversor_TextChanged);
            // 
            // lblTipoArea
            // 
            this.lblTipoArea.AutoSize = true;
            this.lblTipoArea.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoArea.Location = new System.Drawing.Point(99, 87);
            this.lblTipoArea.Name = "lblTipoArea";
            this.lblTipoArea.Size = new System.Drawing.Size(52, 22);
            this.lblTipoArea.TabIndex = 9;
            this.lblTipoArea.Text = "Tipo:";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.ForeColor = System.Drawing.Color.Coral;
            this.btn_Cerrar.Location = new System.Drawing.Point(482, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(84, 35);
            this.btn_Cerrar.TabIndex = 10;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 614);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.lblTipoArea);
            this.Controls.Add(this.CboTipoArea);
            this.Controls.Add(this.LblCantidadArea);
            this.Controls.Add(this.TxtCantidadArea);
            this.Controls.Add(this.LblRespuestaArea);
            this.Controls.Add(this.CboAarea);
            this.Controls.Add(this.LblAarea);
            this.Controls.Add(this.CboDeArea);
            this.Controls.Add(this.Btn_ConvertirArea);
            this.Controls.Add(this.LblDeArea);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDeArea;
        private System.Windows.Forms.Button Btn_ConvertirArea;
        private System.Windows.Forms.ComboBox CboDeArea;
        private System.Windows.Forms.ComboBox CboAarea;
        private System.Windows.Forms.Label LblAarea;
        private System.Windows.Forms.Label LblRespuestaArea;
        private System.Windows.Forms.TextBox TxtCantidadArea;
        private System.Windows.Forms.Label LblCantidadArea;
        private System.Windows.Forms.ComboBox CboTipoArea;
        private System.Windows.Forms.Label lblTipoArea;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}

