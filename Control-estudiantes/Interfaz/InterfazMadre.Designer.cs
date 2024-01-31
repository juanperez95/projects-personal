namespace Interfaz
{
    partial class InterfazMadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazMadre));
            this.datagrid = new System.Windows.Forms.GroupBox();
            this.displayVistaMadre = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_consultarAsistencias = new System.Windows.Forms.Button();
            this.btn_consultarAvances = new System.Windows.Forms.Button();
            this.fechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.listaNotas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listaNivel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listaYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_filtroAvances = new System.Windows.Forms.Button();
            this.btn_filtroAsistencia = new System.Windows.Forms.Button();
            this.fechaFiltro = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_asistencia = new System.Windows.Forms.Button();
            this.listaEstadoAsistencia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listaAsistenciaId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.datagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayVistaMadre)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.Controls.Add(this.displayVistaMadre);
            this.datagrid.Location = new System.Drawing.Point(12, 12);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(776, 181);
            this.datagrid.TabIndex = 0;
            this.datagrid.TabStop = false;
            this.datagrid.Text = "Vista Asistencia";
            // 
            // displayVistaMadre
            // 
            this.displayVistaMadre.AllowUserToOrderColumns = true;
            this.displayVistaMadre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayVistaMadre.Location = new System.Drawing.Point(7, 20);
            this.displayVistaMadre.Name = "displayVistaMadre";
            this.displayVistaMadre.Size = new System.Drawing.Size(763, 150);
            this.displayVistaMadre.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 199);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(769, 239);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_consultarAsistencias);
            this.groupBox2.Controls.Add(this.btn_consultarAvances);
            this.groupBox2.Controls.Add(this.fechaEntrega);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.listaNotas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listaNivel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listaYear);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(387, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Validar avance academico";
            // 
            // btn_consultarAsistencias
            // 
            this.btn_consultarAsistencias.Location = new System.Drawing.Point(197, 169);
            this.btn_consultarAsistencias.Name = "btn_consultarAsistencias";
            this.btn_consultarAsistencias.Size = new System.Drawing.Size(157, 39);
            this.btn_consultarAsistencias.TabIndex = 19;
            this.btn_consultarAsistencias.Text = "Consultar Asistencias";
            this.btn_consultarAsistencias.UseVisualStyleBackColor = true;
            this.btn_consultarAsistencias.Click += new System.EventHandler(this.btn_consultarAsistencias_Click);
            // 
            // btn_consultarAvances
            // 
            this.btn_consultarAvances.Location = new System.Drawing.Point(27, 169);
            this.btn_consultarAvances.Name = "btn_consultarAvances";
            this.btn_consultarAvances.Size = new System.Drawing.Size(152, 39);
            this.btn_consultarAvances.TabIndex = 8;
            this.btn_consultarAvances.Text = "Consultar Avances";
            this.btn_consultarAvances.UseVisualStyleBackColor = true;
            this.btn_consultarAvances.Click += new System.EventHandler(this.button2_Click);
            // 
            // fechaEntrega
            // 
            this.fechaEntrega.Location = new System.Drawing.Point(133, 130);
            this.fechaEntrega.Name = "fechaEntrega";
            this.fechaEntrega.Size = new System.Drawing.Size(221, 20);
            this.fechaEntrega.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha Entrega: ";
            // 
            // listaNotas
            // 
            this.listaNotas.FormattingEnabled = true;
            this.listaNotas.Items.AddRange(new object[] {
            "S",
            "A",
            "B"});
            this.listaNotas.Location = new System.Drawing.Point(133, 95);
            this.listaNotas.Name = "listaNotas";
            this.listaNotas.Size = new System.Drawing.Size(221, 21);
            this.listaNotas.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Notas: ";
            // 
            // listaNivel
            // 
            this.listaNivel.FormattingEnabled = true;
            this.listaNivel.Items.AddRange(new object[] {
            "NATAL",
            "PRENATAL",
            "PARVULO",
            "JARDIN",
            "PREJARDIN"});
            this.listaNivel.Location = new System.Drawing.Point(133, 60);
            this.listaNivel.Name = "listaNivel";
            this.listaNivel.Size = new System.Drawing.Size(221, 21);
            this.listaNivel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nivel: ";
            // 
            // listaYear
            // 
            this.listaYear.FormattingEnabled = true;
            this.listaYear.Items.AddRange(new object[] {
            "1°",
            "2°",
            "3°"});
            this.listaYear.Location = new System.Drawing.Point(133, 28);
            this.listaYear.Name = "listaYear";
            this.listaYear.Size = new System.Drawing.Size(221, 21);
            this.listaYear.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Año Escolar: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_filtroAvances);
            this.groupBox1.Controls.Add(this.btn_filtroAsistencia);
            this.groupBox1.Controls.Add(this.fechaFiltro);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_asistencia);
            this.groupBox1.Controls.Add(this.listaEstadoAsistencia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listaAsistenciaId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validar Asistencia";
            // 
            // btn_filtroAvances
            // 
            this.btn_filtroAvances.Location = new System.Drawing.Point(198, 130);
            this.btn_filtroAvances.Name = "btn_filtroAvances";
            this.btn_filtroAvances.Size = new System.Drawing.Size(157, 32);
            this.btn_filtroAvances.TabIndex = 20;
            this.btn_filtroAvances.Text = "Filtrar Avances";
            this.btn_filtroAvances.UseVisualStyleBackColor = true;
            this.btn_filtroAvances.Click += new System.EventHandler(this.btn_filtroAvances_Click);
            // 
            // btn_filtroAsistencia
            // 
            this.btn_filtroAsistencia.Location = new System.Drawing.Point(28, 130);
            this.btn_filtroAsistencia.Name = "btn_filtroAsistencia";
            this.btn_filtroAsistencia.Size = new System.Drawing.Size(152, 32);
            this.btn_filtroAsistencia.TabIndex = 20;
            this.btn_filtroAsistencia.Text = "Filtrar Asistencias";
            this.btn_filtroAsistencia.UseVisualStyleBackColor = true;
            this.btn_filtroAsistencia.Click += new System.EventHandler(this.btn_filtroAsistencia_Click);
            // 
            // fechaFiltro
            // 
            this.fechaFiltro.Location = new System.Drawing.Point(134, 98);
            this.fechaFiltro.Name = "fechaFiltro";
            this.fechaFiltro.Size = new System.Drawing.Size(221, 20);
            this.fechaFiltro.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 21);
            this.button1.TabIndex = 7;
            this.button1.Text = "Registrar Avance Academico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha Filtro: ";
            // 
            // btn_asistencia
            // 
            this.btn_asistencia.Location = new System.Drawing.Point(28, 196);
            this.btn_asistencia.Name = "btn_asistencia";
            this.btn_asistencia.Size = new System.Drawing.Size(327, 22);
            this.btn_asistencia.TabIndex = 6;
            this.btn_asistencia.Text = "Registrar Asistencias";
            this.btn_asistencia.UseVisualStyleBackColor = true;
            this.btn_asistencia.Click += new System.EventHandler(this.btn_asistencia_Click);
            // 
            // listaEstadoAsistencia
            // 
            this.listaEstadoAsistencia.FormattingEnabled = true;
            this.listaEstadoAsistencia.Items.AddRange(new object[] {
            "ENFERMO",
            "SANO",
            "DECAIDO"});
            this.listaEstadoAsistencia.Location = new System.Drawing.Point(134, 66);
            this.listaEstadoAsistencia.Name = "listaEstadoAsistencia";
            this.listaEstadoAsistencia.Size = new System.Drawing.Size(221, 21);
            this.listaEstadoAsistencia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado Niñ@: ";
            // 
            // listaAsistenciaId
            // 
            this.listaAsistenciaId.FormattingEnabled = true;
            this.listaAsistenciaId.Location = new System.Drawing.Point(134, 31);
            this.listaAsistenciaId.Name = "listaAsistenciaId";
            this.listaAsistenciaId.Size = new System.Drawing.Size(221, 21);
            this.listaAsistenciaId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Niño@: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_descripcion);
            this.groupBox3.Location = new System.Drawing.Point(12, 454);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 135);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Descripcion del avance academico";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(7, 20);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(757, 109);
            this.txt_descripcion.TabIndex = 0;
            // 
            // InterfazMadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.datagrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InterfazMadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz Madre";
            this.Load += new System.EventHandler(this.InterfazMadre_Load);
            this.datagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayVistaMadre)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox datagrid;
        private System.Windows.Forms.DataGridView displayVistaMadre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox listaAsistenciaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listaNotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listaNivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox listaYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_asistencia;
        private System.Windows.Forms.ComboBox listaEstadoAsistencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.DateTimePicker fechaEntrega;
        private System.Windows.Forms.Button btn_consultarAsistencias;
        private System.Windows.Forms.Button btn_consultarAvances;
        private System.Windows.Forms.Button btn_filtroAvances;
        private System.Windows.Forms.Button btn_filtroAsistencia;
        private System.Windows.Forms.DateTimePicker fechaFiltro;
        private System.Windows.Forms.Label label4;
    }
}