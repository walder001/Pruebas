using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploRegistroFecha_27_05_2019
{
    public partial class rEstudiante : Form
    {
        public class Estudiante
        {
            [Key]
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }

        public class Contexto : DbContext
        {
            public DbSet<Estudiante> Estudiantes { get; set; }
            public Contexto(): base(@"Data Source =.\SQLEXPRESS; Initial Catalog = DataBase; Integrated Security = True")
            {


            }
        }

        public rEstudiante()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            NombretextBox1.Text = estudiante.Nombre;
            EdadnumericUpDown1.Value = estudiante.Edad;

            Contexto contexto = new Contexto();

            contexto.Estudiantes.Add(estudiante);

            contexto.Dispose();
        }

        private void REstudiante_Load(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            Estudiante estudiante = new Estudiante();

            var est = contexto.Estudiantes.Find((int)(IdnumericUpDown2.Value));
            estudiante.Nombre = NombretextBox1.Text;
            estudiante.Edad = (int)EdadnumericUpDown1.Value;

            contexto.Dispose();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            Estudiante estudiante = new Estudiante();

            var est = contexto.Estudiantes.Find(Convert.ToInt32(IdnumericUpDown2.Value));
            contexto.Entry(estudiante).State = EntityState.Modified;

            contexto.Dispose();
        }
    }
}
