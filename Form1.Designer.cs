namespace EstructuraLista
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
            this.txtCal1 = new System.Windows.Forms.TextBox();
            this.txtCal2 = new System.Windows.Forms.TextBox();
            this.txtCal3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCal1
            // 
            this.txtCal1.Location = new System.Drawing.Point(190, 39);
            this.txtCal1.Name = "txtCal1";
            this.txtCal1.Size = new System.Drawing.Size(100, 22);
            this.txtCal1.TabIndex = 0;
            // 
            // txtCal2
            // 
            this.txtCal2.Location = new System.Drawing.Point(190, 90);
            this.txtCal2.Name = "txtCal2";
            this.txtCal2.Size = new System.Drawing.Size(100, 22);
            this.txtCal2.TabIndex = 0;
            // 
            // txtCal3
            // 
            this.txtCal3.Location = new System.Drawing.Point(190, 136);
            this.txtCal3.Name = "txtCal3";
            this.txtCal3.Size = new System.Drawing.Size(100, 22);
            this.txtCal3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calificación alu 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calificación alu 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Calificación alu 3";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(141, 187);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(86, 34);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.txtCalcular_Click);
            // 
            // txtpromedio
            // 
            this.txtpromedio.Location = new System.Drawing.Point(190, 255);
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.Size = new System.Drawing.Size(100, 22);
            this.txtpromedio.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "El promedio es =";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 405);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCal3);
            this.Controls.Add(this.txtCal2);
            this.Controls.Add(this.txtpromedio);
            this.Controls.Add(this.txtCal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCal1;
        private System.Windows.Forms.TextBox txtCal2;
        private System.Windows.Forms.TextBox txtCal3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtpromedio;
        private System.Windows.Forms.Label label4;
    }
}

