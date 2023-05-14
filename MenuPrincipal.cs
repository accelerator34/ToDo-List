using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToDo_List.Datos;
using ToDo_List.Logica;

namespace ToDo_List
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Tareas.Mostrar_Tareas(this);
        }

        DTareas Tareas = new DTareas();

        //public Tuple<string, DateTime, string> Resultado = Tareas.Mostrar_Tareas();

        public void nuevoTextBox(string Tarea, string Codigo, DateTime Fecha)
        {
            FlowLayoutPanel FLPTareas = new FlowLayoutPanel();
            FLPTareas.Size = new Size(656, 75);
            FLPTareas.BackColor = Color.FromArgb(142, 147, 149);
            FLPTareas.Click += FLPTareas_Click;

            TextBox txtTarea_Copia = new TextBox();
            txtTarea_Copia.Text = Tarea;
            txtTarea_Copia.ForeColor = txtAsignadorTarea.ForeColor;
            txtTarea_Copia.Font = txtAsignadorTarea.Font;
            txtTarea_Copia.BackColor = txtAsignadorTarea.BackColor;
            txtTarea_Copia.Multiline = true;
            txtTarea_Copia.BorderStyle = BorderStyle.None;
            txtTarea_Copia.Size = new Size(584, 42);
            txtTarea_Copia.ReadOnly = true;
            FLPTareas.Controls.Add(txtTarea_Copia);

            Button btnEliminar = new Button();
            btnEliminar.Image = ToDo_List.Properties.Resources.eliminar;
            btnEliminar.Width = 46;
            btnEliminar.Height = 42;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.BackColor = SystemColors.ControlDarkDark;
            btnEliminar.Click += BtnEliminar_Click;
            FLPTareas.Controls.Add(btnEliminar);

            Label LblFterminacion = new Label();
            LblFterminacion.Text = "Fecha de terminacion:";
            LblFterminacion.ForeColor = Color.FromArgb(240, 240, 240);
            LblFterminacion.Font = new Font("Consolas", 12);
            LblFterminacion.Size = new Size(198, 26);
            LblFterminacion.Dock = DockStyle.Fill;
            FLPTareas.Controls.Add(LblFterminacion);

            DateTimePicker DTPFecha = new DateTimePicker();
            DTPFecha.Value = Fecha;
            DTPFecha.Enabled= false;
            DTPFecha.Size = new Size(231, 20);
            FLPTareas.Controls.Add(DTPFecha);

            Label lblCodigo = new Label();
            lblCodigo.Text = Codigo;
            lblCodigo.ForeColor = Color.FromArgb(240, 240, 240);
            lblCodigo.Font = new Font("Consolas", 12);
            lblCodigo.Size = new Size(198, 26);
            lblCodigo.Dock = DockStyle.Fill;
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            FLPTareas.Controls.Add(lblCodigo);

            flowLayoutPanel1.Controls.Add(FLPTareas);
        }
        private void AgregarTareasfrm()
        {
            DTareas cmd = new DTareas();
            Ltareas Tarea = new Ltareas();
            Tarea.Tarea = txtAsignadorTarea.Text;
            Tarea.Fecha = DTPone.Value;
            Tarea.Codigo = txtCodigoAsignador.Text;
            cmd.Agregar_Tareas(Tarea);
        }
        private void EditarTareasfrm()
        {
            DTareas cmd = new DTareas();
            Ltareas InfoTareas = new Ltareas();
            InfoTareas.Tarea = txtAsignadorTarea.Text;
            InfoTareas.Fecha = DTPone.Value;
            InfoTareas.Codigo = txtCodigoAsignador.Text;
            cmd.Editar_Tareas(InfoTareas);
        }
        private void FLPTareas_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = (FlowLayoutPanel)sender;
            TextBox txtTarea = (TextBox)panel.Controls[0];
            txtAsignadorTarea.Text = txtTarea.Text;
            txtAsignadorTarea.Tag = txtTarea.Tag;
            DateTimePicker Fecha = (DateTimePicker)panel.Controls[3];
            Label lblCodigoPasador = (Label)panel.Controls[4];
            txtCodigoAsignador.Text = lblCodigoPasador.Text;
            DTPone.Value = Fecha.Value;
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Button btnEliminar = sender as Button;
            Control PanelPadre = btnEliminar.Parent;
            DTareas cmd = new DTareas();
            Ltareas Tarea = new Ltareas();
            if (PanelPadre is FlowLayoutPanel flowLayoutPanel)
            {
                flowLayoutPanel1.Controls.Remove(PanelPadre);
                Label lblCodigo = (Label)PanelPadre.Controls[4];
                Tarea.Codigo = lblCodigo.Text;
                cmd.Eliminar_Tareas(Tarea);
                //CargaBD();
            }
        }

        //private void CargaBD()
        //{
        //    FlowLayoutPanel FLPTareas = new FlowLayoutPanel();
        //    FLPTareas.Size = new Size(656, 73);
        //    FLPTareas.BackColor = Color.FromArgb(142, 147, 149);
        //    FLPTareas.Click += FLPTareas_Click;

        //    TextBox txtTarea_Copia = new TextBox();
        //    txtTarea_Copia.Text = Tareas.Tarea;
        //    txtTarea_Copia.ForeColor = txtAsignadorTarea.ForeColor;
        //    txtTarea_Copia.Font = txtAsignadorTarea.Font;
        //    txtTarea_Copia.BackColor = txtAsignadorTarea.BackColor;
        //    txtTarea_Copia.Multiline = true;
        //    txtTarea_Copia.BorderStyle = BorderStyle.None;
        //    txtTarea_Copia.Size = new Size(584, 42);
        //    txtTarea_Copia.ReadOnly = true;
        //    FLPTareas.Controls.Add(txtTarea_Copia);

        //    Button btnEliminar = new Button();
        //    btnEliminar.Image = ToDo_List.Properties.Resources.eliminar;
        //    btnEliminar.Width = 46;
        //    btnEliminar.Height = 42;
        //    btnEliminar.FlatStyle = FlatStyle.Flat;
        //    btnEliminar.FlatAppearance.BorderSize = 0;
        //    btnEliminar.BackColor = SystemColors.ControlDarkDark;
        //    btnEliminar.Click += BtnEliminar_Click;
        //    FLPTareas.Controls.Add(btnEliminar);

        //    Label LblFterminacion = new Label();
        //    LblFterminacion.Text = "Fecha de terminacion:";
        //    LblFterminacion.ForeColor = Color.FromArgb(240, 240, 240);
        //    LblFterminacion.Font = new Font("Consolas", 12);
        //    LblFterminacion.Size = new Size(198, 26);
        //    LblFterminacion.Dock = DockStyle.Fill;
        //    FLPTareas.Controls.Add(LblFterminacion);

        //    DateTimePicker DTPFecha = new DateTimePicker();
        //    DTPFecha.Value = Tareas.Fecha;
        //    DTPFecha.Size = new Size(231, 20);
        //    FLPTareas.Controls.Add(DTPFecha);

        //    Label lblCodigo = new Label();
        //    lblCodigo.Text = Tareas.Codigo;
        //    lblCodigo.Dock = DockStyle.Fill;
        //    lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
        //    FLPTareas.Controls.Add(lblCodigo);

        //    Tareas.Mostrar_Tareas();
        //    flowLayoutPanel1.Controls.Add(FLPTareas);
        //    btnEliminar.Click += BtnEliminar_Click;
        //}
        private void Asignando()
        {
            FlowLayoutPanel FLPTareas = new FlowLayoutPanel();
            FLPTareas.Size = new Size(656, 73);
            FLPTareas.BackColor = Color.FromArgb(142, 147, 149);
            FLPTareas.Click += FLPTareas_Click;

            TextBox txtTarea_Copia = new TextBox();
            txtTarea_Copia.Text = txtAsignadorTarea.Text;
            txtTarea_Copia.ForeColor = txtAsignadorTarea.ForeColor;
            txtTarea_Copia.Font = txtAsignadorTarea.Font;
            txtTarea_Copia.BackColor = txtAsignadorTarea.BackColor;
            txtTarea_Copia.Multiline = true;
            txtTarea_Copia.BorderStyle = BorderStyle.None;
            txtTarea_Copia.Size = new Size(584, 42);
            txtTarea_Copia.ReadOnly = true;
            FLPTareas.Controls.Add(txtTarea_Copia);

            Button btnEliminar = new Button();
            btnEliminar.Image = ToDo_List.Properties.Resources.eliminar;
            btnEliminar.Width = 46;
            btnEliminar.Height = 42;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.BackColor = SystemColors.ControlDarkDark;
            btnEliminar.Click += BtnEliminar_Click;
            FLPTareas.Controls.Add(btnEliminar);

            Label LblFterminacion = new Label();
            LblFterminacion.Text = "Fecha de terminacion:";
            LblFterminacion.ForeColor = Color.FromArgb(240, 240, 240);
            LblFterminacion.Font = new Font("Consolas", 12);
            LblFterminacion.Size = new Size(198, 26);
            LblFterminacion.Dock = DockStyle.Fill;
            FLPTareas.Controls.Add(LblFterminacion);

            DateTimePicker DTPFecha = new DateTimePicker();
            DTPFecha.Size = new Size(231, 20);
            DTPFecha.Value = DTPone.Value;
            DTPFecha.Enabled = false;
            FLPTareas.Controls.Add(DTPFecha);

            Label lblCodigo = new Label();
            lblCodigo.Text = txtCodigoAsignador.Text;
            lblCodigo.ForeColor = Color.FromArgb(240, 240, 240);
            lblCodigo.Dock = DockStyle.Fill;
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            FLPTareas.Controls.Add(lblCodigo);

            flowLayoutPanel1.Controls.Add(FLPTareas);
            //btnEliminar.Click += BtnEliminar_Click;
        }
        private void Limpiar()
        {
            txtAsignadorTarea.Text = "";
            RbtnImportante.Checked = false;
            DTPone.Value = DateTime.Now;
        }
        private void Importante()
        {
            if (RbtnImportante.Checked == true)
            {
                RbtnNormal.Checked = false;
                txtAsignadorTarea.BackColor = Color.FromArgb(29, 29, 29);
                txtAsignadorTarea.ForeColor = Color.Yellow;
            }
        }
        private void Normal()
        {
            if (RbtnNormal.Checked == true)
            {
                RbtnImportante.Checked = false;
                txtAsignadorTarea.BackColor = Color.FromArgb(180, 180, 180);
                txtAsignadorTarea.ForeColor = Color.FromArgb(240, 240, 240);
            }
        }

        private void RbtnImportante_Click(object sender, EventArgs e)
        {
            Importante();
        }

        private void RbtnNormal_CheckedChanged(object sender, EventArgs e)
        {
            Normal();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtAsignadorTarea.Text != "")
            {
                Asignando();
                AgregarTareasfrm();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Necesitas describir la tarea");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtAsignadorTarea.Text != "")
            {
                EditarTareasfrm();
            }
            else
            {
                Limpiar();
                MessageBox.Show("Necesitas describir la tarea");
            }
        }

    }
}



/*
falta el proceso de hacer que lea todas las tareas que ya existen y las ingrese al flowlayoutpanel
 */