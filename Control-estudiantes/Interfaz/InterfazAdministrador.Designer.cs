namespace Interfaz
{
    partial class InterfazAdministrador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazAdministrador));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acudienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madreComunitariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jardinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_madre = new System.Windows.Forms.Button();
            this.btn_child = new System.Windows.Forms.Button();
            this.btn_acudiente = new System.Windows.Forms.Button();
            this.btn_jardin = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.displayAdmin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.entidad = new System.Windows.Forms.GroupBox();
            this.txtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listaEstadoJardin = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listaCity = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.listaJardin = new System.Windows.Forms.ComboBox();
            this.listaAcudiente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listaEps = new System.Windows.Forms.ComboBox();
            this.listaSangre = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayAdmin)).BeginInit();
            this.entidad.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Location = new System.Drawing.Point(24, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Enabled = false;
            this.btn_consultar.Location = new System.Drawing.Point(236, 80);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(156, 55);
            this.btn_consultar.TabIndex = 3;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(35, 80);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(156, 55);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Enabled = false;
            this.btn_editar.Location = new System.Drawing.Point(236, 19);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(156, 55);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Location = new System.Drawing.Point(35, 19);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(156, 55);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(103, 26);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(110, 26);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acudienteToolStripMenuItem,
            this.madreComunitariaToolStripMenuItem,
            this.jardinToolStripMenuItem,
            this.niñoToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // acudienteToolStripMenuItem
            // 
            this.acudienteToolStripMenuItem.Name = "acudienteToolStripMenuItem";
            this.acudienteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.acudienteToolStripMenuItem.Text = "Acudiente";
            // 
            // madreComunitariaToolStripMenuItem
            // 
            this.madreComunitariaToolStripMenuItem.Name = "madreComunitariaToolStripMenuItem";
            this.madreComunitariaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.madreComunitariaToolStripMenuItem.Text = "Madre Comunitaria";
            // 
            // jardinToolStripMenuItem
            // 
            this.jardinToolStripMenuItem.Name = "jardinToolStripMenuItem";
            this.jardinToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.jardinToolStripMenuItem.Text = "Jardin";
            // 
            // niñoToolStripMenuItem
            // 
            this.niñoToolStripMenuItem.Name = "niñoToolStripMenuItem";
            this.niñoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.niñoToolStripMenuItem.Text = "Niño";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_madre);
            this.groupBox2.Controls.Add(this.btn_child);
            this.groupBox2.Controls.Add(this.btn_acudiente);
            this.groupBox2.Controls.Add(this.btn_jardin);
            this.groupBox2.Location = new System.Drawing.Point(24, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 66);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entidades";
            // 
            // btn_madre
            // 
            this.btn_madre.Location = new System.Drawing.Point(313, 19);
            this.btn_madre.Name = "btn_madre";
            this.btn_madre.Size = new System.Drawing.Size(94, 35);
            this.btn_madre.TabIndex = 7;
            this.btn_madre.Text = "Madre Comunitaria";
            this.btn_madre.UseVisualStyleBackColor = true;
            this.btn_madre.Click += new System.EventHandler(this.btn_madre_Click);
            // 
            // btn_child
            // 
            this.btn_child.Location = new System.Drawing.Point(213, 19);
            this.btn_child.Name = "btn_child";
            this.btn_child.Size = new System.Drawing.Size(94, 35);
            this.btn_child.TabIndex = 6;
            this.btn_child.Text = "Child";
            this.btn_child.UseVisualStyleBackColor = true;
            this.btn_child.Click += new System.EventHandler(this.btn_child_Click);
            // 
            // btn_acudiente
            // 
            this.btn_acudiente.Location = new System.Drawing.Point(119, 19);
            this.btn_acudiente.Name = "btn_acudiente";
            this.btn_acudiente.Size = new System.Drawing.Size(88, 35);
            this.btn_acudiente.TabIndex = 5;
            this.btn_acudiente.Text = "Acudiente";
            this.btn_acudiente.UseVisualStyleBackColor = true;
            this.btn_acudiente.Click += new System.EventHandler(this.btn_acudiente_Click);
            // 
            // btn_jardin
            // 
            this.btn_jardin.Location = new System.Drawing.Point(22, 19);
            this.btn_jardin.Name = "btn_jardin";
            this.btn_jardin.Size = new System.Drawing.Size(91, 35);
            this.btn_jardin.TabIndex = 4;
            this.btn_jardin.Text = "Jardin";
            this.btn_jardin.UseVisualStyleBackColor = true;
            this.btn_jardin.Click += new System.EventHandler(this.btn_jardin_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.displayAdmin);
            this.groupBox3.Location = new System.Drawing.Point(24, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 211);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vista Previa";
            // 
            // displayAdmin
            // 
            this.displayAdmin.AllowUserToOrderColumns = true;
            this.displayAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayAdmin.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.displayAdmin.Location = new System.Drawing.Point(7, 20);
            this.displayAdmin.Name = "displayAdmin";
            this.displayAdmin.Size = new System.Drawing.Size(419, 185);
            this.displayAdmin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escriba el ID del usuario o jardin: ";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Enabled = false;
            this.txt_buscar.Location = new System.Drawing.Point(662, 27);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(198, 20);
            this.txt_buscar.TabIndex = 8;
            // 
            // entidad
            // 
            this.entidad.Controls.Add(this.txtFechaNacimiento);
            this.entidad.Controls.Add(this.label7);
            this.entidad.Controls.Add(this.txtCorreo);
            this.entidad.Controls.Add(this.groupBox6);
            this.entidad.Controls.Add(this.groupBox5);
            this.entidad.Controls.Add(this.label6);
            this.entidad.Controls.Add(this.label5);
            this.entidad.Controls.Add(this.txtDireccion);
            this.entidad.Controls.Add(this.label4);
            this.entidad.Controls.Add(this.txtTelefono);
            this.entidad.Controls.Add(this.label3);
            this.entidad.Controls.Add(this.txtNombres);
            this.entidad.Controls.Add(this.label2);
            this.entidad.Controls.Add(this.txtId);
            this.entidad.Location = new System.Drawing.Point(484, 60);
            this.entidad.Name = "entidad";
            this.entidad.Size = new System.Drawing.Size(398, 411);
            this.entidad.TabIndex = 9;
            this.entidad.TabStop = false;
            this.entidad.Text = "N.a.N";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(178, 126);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.txtFechaNacimiento.TabIndex = 14;
            this.txtFechaNacimiento.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Correo ->";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(178, 154);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(198, 20);
            this.txtCorreo.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listaEstadoJardin);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(6, 328);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(386, 69);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Datos Jardin";
            // 
            // listaEstadoJardin
            // 
            this.listaEstadoJardin.FormattingEnabled = true;
            this.listaEstadoJardin.Items.AddRange(new object[] {
            "APROBADO",
            "EN TRAMITE",
            "NEGADO"});
            this.listaEstadoJardin.Location = new System.Drawing.Point(172, 26);
            this.listaEstadoJardin.Name = "listaEstadoJardin";
            this.listaEstadoJardin.Size = new System.Drawing.Size(198, 21);
            this.listaEstadoJardin.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Estado Jardin ->";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listaCity);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.listaJardin);
            this.groupBox5.Controls.Add(this.listaAcudiente);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.listaEps);
            this.groupBox5.Controls.Add(this.listaSangre);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(6, 180);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(386, 142);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos Niñ@";
            // 
            // listaCity
            // 
            this.listaCity.FormattingEnabled = true;
            this.listaCity.Items.AddRange(new object[] {
            "BOGOTA D.C",
            "CALI",
            "MEDELLIN",
            "BUCARAMANGA",
            "APARTADO",
            "VALLEDUPAR",
            "IBAGUE",
            "MONTERIA",
            "PASTO",
            "PEREIRA",
            "BOYACA"});
            this.listaCity.Location = new System.Drawing.Point(172, 114);
            this.listaCity.Name = "listaCity";
            this.listaCity.Size = new System.Drawing.Size(198, 21);
            this.listaCity.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Ciudad Nacimiento ->";
            // 
            // listaJardin
            // 
            this.listaJardin.FormattingEnabled = true;
            this.listaJardin.Location = new System.Drawing.Point(172, 88);
            this.listaJardin.Name = "listaJardin";
            this.listaJardin.Size = new System.Drawing.Size(198, 21);
            this.listaJardin.TabIndex = 23;
            // 
            // listaAcudiente
            // 
            this.listaAcudiente.FormattingEnabled = true;
            this.listaAcudiente.Location = new System.Drawing.Point(172, 64);
            this.listaAcudiente.Name = "listaAcudiente";
            this.listaAcudiente.Size = new System.Drawing.Size(198, 21);
            this.listaAcudiente.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "ID Jardin ->";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "ID Acudiente ->";
            // 
            // listaEps
            // 
            this.listaEps.FormattingEnabled = true;
            this.listaEps.Items.AddRange(new object[] {
            "SALUD TOTAL",
            "COMPENSAR",
            "CONVIDA",
            "FAMISANAR",
            "COLSANITAS",
            "SALUCAFE",
            "MEDIMAS"});
            this.listaEps.Location = new System.Drawing.Point(172, 40);
            this.listaEps.Name = "listaEps";
            this.listaEps.Size = new System.Drawing.Size(198, 21);
            this.listaEps.TabIndex = 19;
            // 
            // listaSangre
            // 
            this.listaSangre.FormattingEnabled = true;
            this.listaSangre.Items.AddRange(new object[] {
            "AB+",
            "AB-",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.listaSangre.Location = new System.Drawing.Point(172, 16);
            this.listaSangre.Name = "listaSangre";
            this.listaSangre.Size = new System.Drawing.Size(198, 21);
            this.listaSangre.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "EPS ->";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tipo Sangre ->";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha Nacimiento ->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Direccion ->";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(178, 97);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(198, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefono ->";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(178, 71);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(198, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombres ->";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(178, 45);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(198, 20);
            this.txtNombres.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificacion ->";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(178, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(198, 20);
            this.txtId.TabIndex = 0;
            // 
            // InterfazAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(905, 483);
            this.Controls.Add(this.entidad);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InterfazAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz Administrador";
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayAdmin)).EndInit();
            this.entidad.ResumeLayout(false);
            this.entidad.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acudienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem madreComunitariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jardinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niñoToolStripMenuItem;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView displayAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_madre;
        private System.Windows.Forms.Button btn_child;
        private System.Windows.Forms.Button btn_acudiente;
        private System.Windows.Forms.Button btn_jardin;
        private System.Windows.Forms.GroupBox entidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtFechaNacimiento;
        private System.Windows.Forms.ComboBox listaJardin;
        private System.Windows.Forms.ComboBox listaAcudiente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox listaEps;
        private System.Windows.Forms.ComboBox listaSangre;
        private System.Windows.Forms.ComboBox listaEstadoJardin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox listaCity;
        private System.Windows.Forms.Label label13;
    }
}