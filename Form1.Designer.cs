namespace Decodificador_de_urls
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXT_PreDecode = new System.Windows.Forms.TextBox();
            this.TXT_Decode = new System.Windows.Forms.TextBox();
            this.Btn_Decode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_PreDecode
            // 
            this.TXT_PreDecode.Location = new System.Drawing.Point(13, 13);
            this.TXT_PreDecode.Multiline = true;
            this.TXT_PreDecode.Name = "TXT_PreDecode";
            this.TXT_PreDecode.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TXT_PreDecode.Size = new System.Drawing.Size(550, 110);
            this.TXT_PreDecode.TabIndex = 0;
            // 
            // TXT_Decode
            // 
            this.TXT_Decode.Location = new System.Drawing.Point(12, 129);
            this.TXT_Decode.Multiline = true;
            this.TXT_Decode.Name = "TXT_Decode";
            this.TXT_Decode.ReadOnly = true;
            this.TXT_Decode.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TXT_Decode.Size = new System.Drawing.Size(550, 110);
            this.TXT_Decode.TabIndex = 1;
            // 
            // Btn_Decode
            // 
            this.Btn_Decode.Location = new System.Drawing.Point(487, 245);
            this.Btn_Decode.Name = "Btn_Decode";
            this.Btn_Decode.Size = new System.Drawing.Size(75, 23);
            this.Btn_Decode.TabIndex = 2;
            this.Btn_Decode.Text = "Decode";
            this.Btn_Decode.UseVisualStyleBackColor = true;
            this.Btn_Decode.Click += new System.EventHandler(this.Btn_Decode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 279);
            this.Controls.Add(this.Btn_Decode);
            this.Controls.Add(this.TXT_Decode);
            this.Controls.Add(this.TXT_PreDecode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_PreDecode;
        private System.Windows.Forms.TextBox TXT_Decode;
        private System.Windows.Forms.Button Btn_Decode;
    }
}

