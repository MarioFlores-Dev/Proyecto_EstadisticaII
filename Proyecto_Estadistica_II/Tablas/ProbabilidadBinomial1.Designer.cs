
namespace Proyecto_Estadistica_II.Tablas
{
    partial class ProbabilidadBinomial1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProbabilidadBinomial1));
            this.dgv_pb1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbx_parte = new System.Windows.Forms.ComboBox();
            this.dgv_pb2 = new System.Windows.Forms.DataGridView();
            this.dgv_pb3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pb3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pb1
            // 
            this.dgv_pb1.AllowUserToAddRows = false;
            this.dgv_pb1.AllowUserToDeleteRows = false;
            this.dgv_pb1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pb1.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pb1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_pb1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pb1.Location = new System.Drawing.Point(0, 92);
            this.dgv_pb1.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_pb1.Name = "dgv_pb1";
            this.dgv_pb1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pb1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_pb1.Size = new System.Drawing.Size(1146, 627);
            this.dgv_pb1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Probabilidad Binomial  (P)";
            // 
            // cbbx_parte
            // 
            this.cbbx_parte.FormattingEnabled = true;
            this.cbbx_parte.Items.AddRange(new object[] {
            "2 - 7",
            "8 - 10",
            "12 - 20"});
            this.cbbx_parte.Location = new System.Drawing.Point(800, 44);
            this.cbbx_parte.Name = "cbbx_parte";
            this.cbbx_parte.Size = new System.Drawing.Size(121, 24);
            this.cbbx_parte.TabIndex = 3;
            this.cbbx_parte.SelectedIndexChanged += new System.EventHandler(this.cbbx_parte_SelectedIndexChanged);
            // 
            // dgv_pb2
            // 
            this.dgv_pb2.AllowUserToAddRows = false;
            this.dgv_pb2.AllowUserToDeleteRows = false;
            this.dgv_pb2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pb2.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pb2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_pb2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_pb2.Location = new System.Drawing.Point(0, 101);
            this.dgv_pb2.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_pb2.Name = "dgv_pb2";
            this.dgv_pb2.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pb2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_pb2.Size = new System.Drawing.Size(1146, 627);
            this.dgv_pb2.TabIndex = 4;
            // 
            // dgv_pb3
            // 
            this.dgv_pb3.AllowUserToAddRows = false;
            this.dgv_pb3.AllowUserToDeleteRows = false;
            this.dgv_pb3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pb3.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pb3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pb3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_pb3.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_pb3.Location = new System.Drawing.Point(0, 92);
            this.dgv_pb3.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_pb3.Name = "dgv_pb3";
            this.dgv_pb3.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pb3.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_pb3.Size = new System.Drawing.Size(1146, 627);
            this.dgv_pb3.TabIndex = 5;
            // 
            // ProbabilidadBinomial1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 719);
            this.Controls.Add(this.dgv_pb3);
            this.Controls.Add(this.dgv_pb2);
            this.Controls.Add(this.cbbx_parte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_pb1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProbabilidadBinomial1";
            this.Text = "Probabilidad Binomial 1";
            this.Load += new System.EventHandler(this.ProbabilidadBinomial1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pb3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbx_parte;
        private System.Windows.Forms.DataGridView dgv_pb2;
        private System.Windows.Forms.DataGridView dgv_pb3;
    }
}