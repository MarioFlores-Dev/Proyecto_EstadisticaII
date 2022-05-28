
namespace Proyecto_Estadistica_II
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.btn_muestreo = new System.Windows.Forms.Button();
            this.btn_estimaciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Hipotesis = new System.Windows.Forms.Button();
            this.btn_Tablas = new System.Windows.Forms.Button();
            this.btn_Documentación = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_distribuciones = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_muestreo
            // 
            this.btn_muestreo.BackColor = System.Drawing.Color.White;
            this.btn_muestreo.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_muestreo, "btn_muestreo");
            this.btn_muestreo.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_muestreo.Image = global::Proyecto_Estadistica_II.Properties.Resources.muestreo;
            this.btn_muestreo.Name = "btn_muestreo";
            this.btn_muestreo.UseVisualStyleBackColor = false;
            this.btn_muestreo.Click += new System.EventHandler(this.btn_muestreo_Click);
            // 
            // btn_estimaciones
            // 
            this.btn_estimaciones.BackColor = System.Drawing.Color.White;
            this.btn_estimaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_estimaciones, "btn_estimaciones");
            this.btn_estimaciones.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_estimaciones.Image = global::Proyecto_Estadistica_II.Properties.Resources.Estimaciones;
            this.btn_estimaciones.Name = "btn_estimaciones";
            this.btn_estimaciones.UseVisualStyleBackColor = false;
            this.btn_estimaciones.Click += new System.EventHandler(this.btn_estimaciones_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Name = "label1";
            // 
            // btn_Hipotesis
            // 
            this.btn_Hipotesis.BackColor = System.Drawing.Color.White;
            this.btn_Hipotesis.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Hipotesis, "btn_Hipotesis");
            this.btn_Hipotesis.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_Hipotesis.Image = global::Proyecto_Estadistica_II.Properties.Resources.Hipotesis;
            this.btn_Hipotesis.Name = "btn_Hipotesis";
            this.btn_Hipotesis.UseVisualStyleBackColor = false;
            this.btn_Hipotesis.Click += new System.EventHandler(this.btn_Hipotesis_Click);
            // 
            // btn_Tablas
            // 
            this.btn_Tablas.BackColor = System.Drawing.Color.White;
            this.btn_Tablas.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Tablas, "btn_Tablas");
            this.btn_Tablas.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_Tablas.Image = global::Proyecto_Estadistica_II.Properties.Resources.Tablas;
            this.btn_Tablas.Name = "btn_Tablas";
            this.btn_Tablas.UseVisualStyleBackColor = false;
            this.btn_Tablas.Click += new System.EventHandler(this.btn_Tablas_Click);
            // 
            // btn_Documentación
            // 
            this.btn_Documentación.BackColor = System.Drawing.Color.White;
            this.btn_Documentación.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Documentación, "btn_Documentación");
            this.btn_Documentación.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_Documentación.Image = global::Proyecto_Estadistica_II.Properties.Resources.Docuementacion;
            this.btn_Documentación.Name = "btn_Documentación";
            this.btn_Documentación.UseVisualStyleBackColor = false;
            this.btn_Documentación.Click += new System.EventHandler(this.btn_Documentación_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.White;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Salir, "btn_Salir");
            this.btn_Salir.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_Salir.Image = global::Proyecto_Estadistica_II.Properties.Resources.salir;
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Image = global::Proyecto_Estadistica_II.Properties.Resources.estadistica_descriptiva;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.btn_Documentación);
            this.panel1.Controls.Add(this.btn_Tablas);
            this.panel1.Controls.Add(this.btn_Hipotesis);
            this.panel1.Controls.Add(this.btn_distribuciones);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_estimaciones);
            this.panel1.Controls.Add(this.btn_muestreo);
            this.panel1.Name = "panel1";
            // 
            // btn_distribuciones
            // 
            this.btn_distribuciones.BackColor = System.Drawing.Color.White;
            this.btn_distribuciones.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_distribuciones, "btn_distribuciones");
            this.btn_distribuciones.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_distribuciones.Image = global::Proyecto_Estadistica_II.Properties.Resources.Distribución_de_probabilidades;
            this.btn_distribuciones.Name = "btn_distribuciones";
            this.btn_distribuciones.UseVisualStyleBackColor = false;
            this.btn_distribuciones.Click += new System.EventHandler(this.btn_distribuciones_Click);
            // 
            // frm_menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frm_menu";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_muestreo;
        private System.Windows.Forms.Button btn_estimaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_distribuciones;
        private System.Windows.Forms.Button btn_Hipotesis;
        private System.Windows.Forms.Button btn_Tablas;
        private System.Windows.Forms.Button btn_Documentación;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}