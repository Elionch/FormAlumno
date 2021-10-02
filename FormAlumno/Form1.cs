using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAlumno
{
    public partial class Form1 : Form
    {
        private List<Alumno> alumnos = new List<Alumno>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                alumnos.Add(new Alumno(txtNom.Text, txtAp.Text, txtCar.Text, Int32.Parse(txtDni.Text), Int32.Parse(txtLeg.Text), Int32.Parse(txtInsc.Text)));
            
                txtNom.Clear();
                txtAp.Clear();
                txtDni.Clear();
                txtLeg.Clear();
                txtCar.Clear();
                txtInsc.Clear();
                MessageBox.Show("Alumno agregado");

                

            }
            if (alumnos.Count == 0)
            {

            }
            else if (alumnos.Count > 1) {
                lblCont.Text = (alumnos.Count) + " alumnos agregados";
            }else
            {
                lblCont.Text = (alumnos.Count) + " alumno agregado";
            }

        }
        private bool Validar()
        {
            bool datovalido = true;

            if (txtNom.Text.Trim() == "")
            {
                MessageBox.Show("El campo nombre es obligatorio");
                datovalido = false;
                txtNom.Focus();
            }
            if (txtAp.Text.Trim() == "")
            {
                MessageBox.Show("El campo apellido es obligatorio");
                datovalido = false;
                txtAp.Focus();

            }
            try
            {
                Int32.Parse(txtDni.Text.Trim());
            }
            catch (Exception ex) {
                MessageBox.Show("El campo dni es incorrecto o esta vacio");
                datovalido = false;
                txtDni.Focus();
            }
            try
            {
                Int32.Parse(txtLeg.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("El campo legajo es incorrecto o esta vacio");
                datovalido = false;
                txtLeg.Focus();
            }
            if (txtCar.Text.Trim() == "")
            {
                MessageBox.Show("El campo carrera es obligatorio");
                datovalido = false;
                txtCar.Focus();
            }
            try
            {
                Int32.Parse(txtInsc.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("El campo año de inscripcion es incorrecto o esta vacio");
                datovalido = false;
                txtInsc.Focus();
            }
            return datovalido;
        }
    }
}
