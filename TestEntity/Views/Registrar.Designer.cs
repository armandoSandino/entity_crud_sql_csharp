namespace TestEntity.Views
{
    partial class Registrar
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
            this.bt_registrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ct_correo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ct_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_registrar
            // 
            this.bt_registrar.BackColor = System.Drawing.Color.Black;
            this.bt_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_registrar.ForeColor = System.Drawing.Color.White;
            this.bt_registrar.Location = new System.Drawing.Point(188, 249);
            this.bt_registrar.Name = "bt_registrar";
            this.bt_registrar.Size = new System.Drawing.Size(95, 37);
            this.bt_registrar.TabIndex = 1;
            this.bt_registrar.Text = "Registrar";
            this.bt_registrar.UseVisualStyleBackColor = false;
            this.bt_registrar.Click += new System.EventHandler(this.bt_registrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_titulo);
            this.panel1.Controls.Add(this.dtp_fecha);
            this.panel1.Controls.Add(this.bt_registrar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ct_correo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ct_nombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(38, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 324);
            this.panel1.TabIndex = 2;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(129, 193);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // ct_correo
            // 
            this.ct_correo.Location = new System.Drawing.Point(129, 113);
            this.ct_correo.Name = "ct_correo";
            this.ct_correo.Size = new System.Drawing.Size(200, 20);
            this.ct_correo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Correo";
            // 
            // ct_nombre
            // 
            this.ct_nombre.Location = new System.Drawing.Point(129, 67);
            this.ct_nombre.Name = "ct_nombre";
            this.ct_nombre.Size = new System.Drawing.Size(200, 20);
            this.ct_nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nombre";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(53, 17);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(74, 20);
            this.lb_titulo.TabIndex = 48;
            this.lb_titulo.Text = "Registrar";
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(480, 372);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Registrar";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones Registro";
            this.Load += new System.EventHandler(this.Registrar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_registrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ct_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ct_correo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_titulo;
    }
}