using Ejemplo.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IDnumericUpDown.Value = 0;
            NombretextBox.Clear();
            TelefonomaskedTextBox.Clear();
            DirecciontextBox.Clear();
            CedulamaskedTextBox.Clear();
            
         
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            
            if(IDnumericUpDown.Value ==0)
            {
                if(BLL.PersonaBLL.Guardar(LlenaClase()))
                {
                    MessageBox.Show("Guardo!!");
                }
                else
                {
                    MessageBox.Show("no guardo!!");
                }
            }
            else
            {
                if(BLL.PersonaBLL.Modificar(LlenaClase()))
                {
                    MessageBox.Show("Modifico");
                }
            }


        }

        private Persona LlenaClase()
        {
            Persona persona = new Persona();
            persona.IdPersona = Convert.ToInt32(IDnumericUpDown.Value);
            persona.Nombre = NombretextBox.Text;
            persona.Cedula = CedulamaskedTextBox.Text;
            persona.Direccion = DirecciontextBox.Text;
            persona.Telefono = TelefonomaskedTextBox.Text;
            return persona;

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDnumericUpDown.Value);
            if (BLL.PersonaBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminar");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDnumericUpDown.Value);
            var persona = BLL.PersonaBLL.Buscar(id);
            if(persona!=null)
            {
                NombretextBox.Text = persona.Nombre;
                DirecciontextBox.Text = persona.Direccion;
                TelefonomaskedTextBox.Text = persona.Telefono;
                CedulamaskedTextBox.Text = persona.Cedula;
            }
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
