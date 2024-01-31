namespace Interfaz
{
    partial class Interfaz_Acudiente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz_Acudiente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.displayAcudiente = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fechaFiltro = new System.Windows.Forms.DateTimePicker();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_acudiente = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayAcudiente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.displayAcudiente);
            this.groupBox1.Location = new System.Drawing.Point(20, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avances academicos del Niñ@";
            // 
            // displayAcudiente
            // 
            this.displayAcudiente.AllowUserToOrderColumns = true;
            this.displayAcudiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayAcudiente.Location = new System.Drawing.Point(7, 19);
            this.displayAcudiente.Name = "displayAcudiente";
            this.displayAcudiente.Size = new System.Drawing.Size(755, 310);
            this.displayAcudiente.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fechaFiltro);
            this.groupBox2.Controls.Add(this.btn_buscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_Id);
            this.groupBox2.Controls.Add(this.txt_acudiente);
            this.groupBox2.Location = new System.Drawing.Point(20, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Acudiente";
            // 
            // fechaFiltro
            // 
            this.fechaFiltro.Location = new System.Drawing.Point(501, 20);
            this.fechaFiltro.Name = "fechaFiltro";
            this.fechaFiltro.Size = new System.Drawing.Size(163, 20);
            this.fechaFiltro.TabIndex = 4;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(670, 19);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(77, 21);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Niño";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(338, 20);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(156, 20);
            this.txt_Id.TabIndex = 1;
            // 
            // txt_acudiente
            // 
            this.txt_acudiente.Enabled = false;
            this.txt_acudiente.Location = new System.Drawing.Point(7, 20);
            this.txt_acudiente.Name = "txt_acudiente";
            this.txt_acudiente.Size = new System.Drawing.Size(232, 20);
            this.txt_acudiente.TabIndex = 0;
            // 
            // Interfaz_Acudiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(812, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interfaz_Acudiente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz Acudiente";
            this.Load += new System.EventHandler(this.Interfaz_Acudiente_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayAcudiente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView displayAcudiente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_acudiente;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.DateTimePicker fechaFiltro;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label1;
    }
}