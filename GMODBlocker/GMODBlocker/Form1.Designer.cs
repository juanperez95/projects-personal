namespace GMODBlocker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clave = new System.Windows.Forms.TextBox();
            this.barraProgreso = new System.Windows.Forms.ProgressBar();
            this.fileLabel = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.txtTiempo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRegresivo = new System.Windows.Forms.Label();
            this.lbPorcentaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.procesoslb = new System.Windows.Forms.Label();
            this.ctrTiempo = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.lbApagado = new System.Windows.Forms.Label();
            this.tiempoApagado = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Oswald", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(713, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "GMOD Blocker";
            // 
            // clave
            // 
            this.clave.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.clave.Enabled = false;
            this.clave.Font = new System.Drawing.Font("Oswald Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave.ForeColor = System.Drawing.SystemColors.Window;
            this.clave.Location = new System.Drawing.Point(360, 83);
            this.clave.Name = "clave";
            this.clave.PasswordChar = '*';
            this.clave.Size = new System.Drawing.Size(344, 24);
            this.clave.TabIndex = 2;
            // 
            // barraProgreso
            // 
            this.barraProgreso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.barraProgreso.Location = new System.Drawing.Point(360, 153);
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barraProgreso.Size = new System.Drawing.Size(283, 28);
            this.barraProgreso.Step = 0;
            this.barraProgreso.TabIndex = 3;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Font = new System.Drawing.Font("Oswald", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileLabel.Location = new System.Drawing.Point(662, 160);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(30, 21);
            this.fileLabel.TabIndex = 4;
            this.fileLabel.Text = "NaN";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Oswald SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerificar.Location = new System.Drawing.Point(31, 205);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(240, 53);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Enabled = false;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Oswald SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(277, 205);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(240, 53);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetener.Enabled = false;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Font = new System.Drawing.Font("Oswald SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDetener.Location = new System.Drawing.Point(523, 205);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(240, 53);
            this.btnDetener.TabIndex = 7;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // txtTiempo
            // 
            this.txtTiempo.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTiempo.CustomFormat = "";
            this.txtTiempo.Enabled = false;
            this.txtTiempo.Font = new System.Drawing.Font("Oswald Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtTiempo.Location = new System.Drawing.Point(360, 113);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(344, 24);
            this.txtTiempo.TabIndex = 8;
            this.txtTiempo.Value = new System.DateTime(2024, 2, 7, 12, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(227, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Oswald", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(227, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Temporizador:";
            // 
            // lbRegresivo
            // 
            this.lbRegresivo.AutoSize = true;
            this.lbRegresivo.Font = new System.Drawing.Font("Oswald", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegresivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRegresivo.Location = new System.Drawing.Point(31, 116);
            this.lbRegresivo.Name = "lbRegresivo";
            this.lbRegresivo.Size = new System.Drawing.Size(140, 59);
            this.lbRegresivo.TabIndex = 11;
            this.lbRegresivo.Text = "0:00:00";
            // 
            // lbPorcentaje
            // 
            this.lbPorcentaje.AutoSize = true;
            this.lbPorcentaje.Font = new System.Drawing.Font("Oswald", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorcentaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPorcentaje.Location = new System.Drawing.Point(227, 160);
            this.lbPorcentaje.Name = "lbPorcentaje";
            this.lbPorcentaje.Size = new System.Drawing.Size(59, 21);
            this.lbPorcentaje.TabIndex = 12;
            this.lbPorcentaje.Text = "0 / 100%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(37, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Procesos encontrados :";
            // 
            // procesoslb
            // 
            this.procesoslb.AutoSize = true;
            this.procesoslb.Font = new System.Drawing.Font("Oswald", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procesoslb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.procesoslb.Location = new System.Drawing.Point(157, 67);
            this.procesoslb.Name = "procesoslb";
            this.procesoslb.Size = new System.Drawing.Size(26, 19);
            this.procesoslb.TabIndex = 14;
            this.procesoslb.Text = "NaN";
            // 
            // ctrTiempo
            // 
            this.ctrTiempo.Tick += new System.EventHandler(this.ctrTiempo_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Oswald", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(227, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Minutos de apagado:";
            // 
            // txtMinutos
            // 
            this.txtMinutos.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMinutos.Enabled = false;
            this.txtMinutos.Font = new System.Drawing.Font("Oswald Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutos.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMinutos.Location = new System.Drawing.Point(360, 54);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(344, 24);
            this.txtMinutos.TabIndex = 17;
            // 
            // lbApagado
            // 
            this.lbApagado.AutoSize = true;
            this.lbApagado.Font = new System.Drawing.Font("Oswald", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApagado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbApagado.Location = new System.Drawing.Point(37, 97);
            this.lbApagado.Name = "lbApagado";
            this.lbApagado.Size = new System.Drawing.Size(0, 19);
            this.lbApagado.TabIndex = 18;
            // 
            // tiempoApagado
            // 
            this.tiempoApagado.Tick += new System.EventHandler(this.tiempoApagado_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(795, 305);
            this.Controls.Add(this.lbApagado);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.procesoslb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPorcentaje);
            this.Controls.Add(this.lbRegresivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.barraProgreso);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GMOD Blocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clave;
        private System.Windows.Forms.ProgressBar barraProgreso;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.DateTimePicker txtTiempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbRegresivo;
        private System.Windows.Forms.Label lbPorcentaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label procesoslb;
        private System.Windows.Forms.Timer ctrTiempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.Label lbApagado;
        private System.Windows.Forms.Timer tiempoApagado;
    }
}

