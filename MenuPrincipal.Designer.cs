
namespace ToDo_List
{
    partial class MenuPrincipal
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAsignadorTarea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RbtnImportante = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbtnNormal = new System.Windows.Forms.RadioButton();
            this.DTPone = new System.Windows.Forms.DateTimePicker();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoAsignador = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(868, 269);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(147)))), ((int)(((byte)(149)))));
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.dateTimePicker2);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(648, 73);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(3, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(584, 41);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Esto es una plantilla, osea de como se veria al final";
            this.textBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button2.Image = global::ToDo_List.Properties.Resources.mas;
            this.button2.Location = new System.Drawing.Point(593, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 42);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de terminacion:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(207, 49);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(444, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "1234567890";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAsignadorTarea
            // 
            this.txtAsignadorTarea.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtAsignadorTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAsignadorTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtAsignadorTarea.ForeColor = System.Drawing.SystemColors.Control;
            this.txtAsignadorTarea.Location = new System.Drawing.Point(87, 285);
            this.txtAsignadorTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAsignadorTarea.Multiline = true;
            this.txtAsignadorTarea.Name = "txtAsignadorTarea";
            this.txtAsignadorTarea.Size = new System.Drawing.Size(584, 41);
            this.txtAsignadorTarea.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 17F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(4, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarea";
            // 
            // RbtnImportante
            // 
            this.RbtnImportante.AutoSize = true;
            this.RbtnImportante.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RbtnImportante.ForeColor = System.Drawing.SystemColors.Control;
            this.RbtnImportante.Location = new System.Drawing.Point(6, 18);
            this.RbtnImportante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbtnImportante.Name = "RbtnImportante";
            this.RbtnImportante.Size = new System.Drawing.Size(106, 21);
            this.RbtnImportante.TabIndex = 4;
            this.RbtnImportante.TabStop = true;
            this.RbtnImportante.Text = "IMPORTANTE";
            this.RbtnImportante.UseVisualStyleBackColor = true;
            this.RbtnImportante.Click += new System.EventHandler(this.RbtnImportante_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbtnNormal);
            this.groupBox1.Controls.Add(this.RbtnImportante);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(87, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clasificacion";
            // 
            // RbtnNormal
            // 
            this.RbtnNormal.AutoSize = true;
            this.RbtnNormal.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RbtnNormal.ForeColor = System.Drawing.SystemColors.Control;
            this.RbtnNormal.Location = new System.Drawing.Point(6, 43);
            this.RbtnNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbtnNormal.Name = "RbtnNormal";
            this.RbtnNormal.Size = new System.Drawing.Size(74, 21);
            this.RbtnNormal.TabIndex = 5;
            this.RbtnNormal.TabStop = true;
            this.RbtnNormal.Text = "NORMAL";
            this.RbtnNormal.UseVisualStyleBackColor = true;
            this.RbtnNormal.CheckedChanged += new System.EventHandler(this.RbtnNormal_CheckedChanged);
            // 
            // DTPone
            // 
            this.DTPone.Location = new System.Drawing.Point(222, 348);
            this.DTPone.Name = "DTPone";
            this.DTPone.Size = new System.Drawing.Size(231, 20);
            this.DTPone.TabIndex = 6;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Consolas", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnActualizar.Image = global::ToDo_List.Properties.Resources.sincronizar;
            this.btnActualizar.Location = new System.Drawing.Point(688, 285);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(47, 42);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Consolas", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnAgregar.Image = global::ToDo_List.Properties.Resources.mas;
            this.btnAgregar.Location = new System.Drawing.Point(741, 285);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(47, 42);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(459, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Codigo que representa la tarea:";
            // 
            // txtCodigoAsignador
            // 
            this.txtCodigoAsignador.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtCodigoAsignador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoAsignador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtCodigoAsignador.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCodigoAsignador.Location = new System.Drawing.Point(658, 347);
            this.txtCodigoAsignador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoAsignador.Multiline = true;
            this.txtCodigoAsignador.Name = "txtCodigoAsignador";
            this.txtCodigoAsignador.Size = new System.Drawing.Size(119, 31);
            this.txtCodigoAsignador.TabIndex = 9;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(910, 414);
            this.Controls.Add(this.txtCodigoAsignador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.DTPone);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtAsignadorTarea);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuPrincipal";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtAsignadorTarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton RbtnImportante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbtnNormal;
        private System.Windows.Forms.DateTimePicker DTPone;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoAsignador;
        private System.Windows.Forms.Label label4;
    }
}

