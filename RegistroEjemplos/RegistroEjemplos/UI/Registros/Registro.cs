using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroEjemplos.Entidades;
using RegistroEjemplos.BILL;

namespace RegistroEjemplos.UI.Registros
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        
        
        public void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            DateTime1.Value = DateTime.Now;
            MyErrorProvider.Clear();
        }
        private Persona LlenarClase()
        {
           Persona persona = new Persona();

            persona.PersonaId = Convert.ToInt32(IDNumericUpDown.Value);
            persona.Nombre = txtNombre.Text;
            persona.Telefono = txtTelefono.Text;
            persona.Cedula = txtCedula.Text;
            persona.Direccion = txtDireccion.Text;
            persona.FechaNacimiento = DateTime1.Value;

            return persona;
        }
        private void LlenaCampo(Persona persona)
        {
            IDNumericUpDown.Value = persona.PersonaId;
            txtNombre.Text = persona.Nombre;
            txtCedula.Text = persona.Cedula;
            txtDireccion.Text = persona.Direccion;
            DateTime1.Value = persona.FechaNacimiento;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona;
            bool paso = false;

            if (!Validar())
                return;

            persona = LlenarClase();
            Limpiar();

            //Determinar si es guardar o modificar
            if (IDNumericUpDown.Value == 0)
                paso = PersonaBILL.Guardar(persona);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = PersonaBILL.Modificar(persona);
            }

            //Informar el resultado
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (txtNombre.Text == string.Empty)
            {
                MyErrorProvider.SetError(txtNombre, "El campo Nombre no puede estar vacio");
                txtNombre.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MyErrorProvider.SetError(txtDireccion, "El campo Direccion no puede estar vacio");
                txtDireccion.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(txtCedula.Text.Replace("-", "")))
            {
                MyErrorProvider.SetError(txtCedula, "El campo Cedula no puede estar vacio");
                txtCedula.Focus();
                paso = false;
            }

           /* if (this.Detalle.Count == 0)
            {
                MyErrorProvider.SetError(detalleDataGridView, "Debe agregar algun telefono");
                TelefonomaskedTextBox.Focus();
                paso = false;
            }*/

            return paso;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Persona persona = PersonaBILL.Buscar((int)IDNumericUpDown.Value);

            return (persona != null);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int id;
            Persona persona = new Persona();
            int.TryParse(IDNumericUpDown.Text, out id);

            Limpiar();

            persona = PersonaBILL.Buscar(id);

            if (persona != null)
            {
                MessageBox.Show("Persona Encontrada");
                LlenaCampo(persona);
            }
            else
            {
                MessageBox.Show("Persona no Encontada");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }
        /*
private bool ExisteEnLaBaseDeDatos()
{
Persona persona = PersonaBILL.Buscar((string)IDdomainUpDown1.Text);
return (persona != null);
bool paso = true;
return paso;
}

private bool Validar()
{
bool paso = true;
return paso;

}*/
    }
}
