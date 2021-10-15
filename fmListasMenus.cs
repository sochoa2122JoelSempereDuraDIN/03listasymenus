using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listasymenus
{
    public partial class fmListasMenus : Form
    {
        fmAcercaDe ventanaAcercaDe;
        public fmListasMenus()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void laAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCursos.SelectedIndex = 0;
            btnAbrir.PerformClick();
        }

        private void btnMostrarMas_Click(object sender, EventArgs e)
        {
            //recorrer la coleccion y obtener la posicion, contemplar la seleccion vacia
            if (lbAlumnos.SelectedIndex < 0) // indica el indice del elemento seleccionado, sleectedindex tiene en cuenta en tiempo de exec
            {
                MessageBox.Show("Selecciona un alumno");
            }
            else
            {
                MessageBox.Show("El primer de la lista es: " + lbAlumnos.Items[0]);
                MessageBox.Show("El Seleccionado es: " + lbAlumnos.Items[lbAlumnos.SelectedIndex].ToString()
                    + " Ocupa la posicion " + Convert.ToString(lbAlumnos.SelectedIndex + 1));
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            string mostrarTodos = "Numero\tNombre\n";
            for (int i = 0; i <= lbAlumnos.Items.Count - 1; i++)
            {
                mostrarTodos = mostrarTodos + (i + 1).ToString() + "\t" + lbAlumnos.Items[i] + "\n";
            }
            MessageBox.Show(mostrarTodos);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lbAlumnos.Sorted = true;
            lbAlumnos.Sorted = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            laNuevo.Enabled = !laNuevo.Enabled; //cambio de estado del booleano al clic 
            tbNuevo.Enabled = !tbNuevo.Enabled;

            pnActualiza.Visible = !pnActualiza.Visible;

            if (pnActualiza.Visible)
            {
                btnActualizar.BackColor = Color.Green;
            }
            else
            {
                btnActualizar.BackColor = Color.Red;
            }
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            //controlar si no hay entrada
            if (tbNuevo.Text == "")
            {
                MessageBox.Show("Introduce nombre");
            }
            else
            {
                if (lbAlumnos.Items.IndexOf(tbNuevo.Text) > -1) //-1 es que index of no ha encontrado el elemento
                {
                    MessageBox.Show("El nombre ya existe");
                }
                else
                {
                    lbAlumnos.Items.Add(tbNuevo.Text);
                }
                tbNuevo.SelectAll();
                tbNuevo.Focus();
            }
        }

        private void tbNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //introducciones masivas, convierto el enter en un clic
            if (e.KeyChar == (char)13)//si la tecla pulsa es un intro
            {
                btnAnyadir.PerformClick(); //invoca por codigo el evento clic del boton añadir
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lbAlumnos.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un alumno");
            }
            else
            {
                //lbAlumnos.Items.Remove(lbAlumnos.Items[lbAlumnos.SelectedIndex]); // hace lo mismo que la linea de abajo
                lbAlumnos.Items.RemoveAt(lbAlumnos.SelectedIndex);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            tbNuevo.SelectAll(); //es su tbAlumno
            if (tbNuevo.Text == "")//comprueba que hay algo que insertar
            {
                MessageBox.Show("Introduce Nombre");
                tbNuevo.Focus();
            }
            else
            {
                if (lbAlumnos.SelectedIndex < 0 )//seleciona lugar en la lista
                {
                    MessageBox.Show("Elige la posicion en la lista");
                }
                else
                {
                    if (lbAlumnos.Items.IndexOf(tbNuevo.Text) == -1 ) //que no exista
                    {
                        lbAlumnos.Items.Insert(lbAlumnos.SelectedIndex, tbNuevo.Text);
                    }
                    else //hay que capitalizar para que no distinga entre mayus y minus
                    {
                        MessageBox.Show("El alumno ya existe");
                        tbNuevo.Focus();
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tbNuevo.Text == "")
            {
                MessageBox.Show("Introduce Nombre");
            }
            else
            {
                if (lbAlumnos.Items.IndexOf(tbNuevo.Text) == -1)
                {
                    MessageBox.Show("No existe");
                }
                else
                {
                    lbAlumnos.SelectedIndex = lbAlumnos.Items.IndexOf(tbNuevo.Text);
                }
            }
            tbNuevo.Focus();
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {

            int miIndex = lbAlumnos.SelectedIndex; //posicion inicial del alumno
            if (lbAlumnos.SelectedIndex > 0)
            {
                lbAlumnos.Items.Insert(lbAlumnos.SelectedIndex - 1, lbAlumnos.SelectedItem.ToString()); //insertamos una mas arriba
                lbAlumnos.Items.RemoveAt(lbAlumnos.SelectedIndex); //borramos la original
                lbAlumnos.SelectedIndex = miIndex - 1; //posicion arriba del alumno al inicio
            }
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            if (lbAlumnos.SelectedIndex == -1) return;
            int miIndex = lbAlumnos.SelectedIndex; //posicion inicial del alumno
            if (lbAlumnos.SelectedIndex < lbAlumnos.Items.Count - 1)
            {
                lbAlumnos.Items.Insert(lbAlumnos.SelectedIndex + 2, lbAlumnos.SelectedItem.ToString()); //insertamos una mas arriba
                lbAlumnos.Items.RemoveAt(lbAlumnos.SelectedIndex); //borramos la original
                lbAlumnos.SelectedIndex = miIndex + 1; //posicion arriba del alumno al inicio
            }
        }

        private void itGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter miArchivo = new StreamWriter(@".\cursos\" + cbCursos.Text + ".txt");

                foreach(object lista in lbAlumnos.Items)
                {
                    miArchivo.WriteLine(lista.ToString());
                }
                miArchivo.Close();
            }
            catch(Exception miError)
            {
                MessageBox.Show(miError.Message);
                throw;
            }
        }

        private void itSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void itNuevo_Click(object sender, EventArgs e)
        {
            lbAlumnos.Items.Clear();
        }

        private void itAbrir_Click(object sender, EventArgs e)
        {
            //asignar a btAbrir
            lbAlumnos.Items.Clear();
            try
            {
                //@(dice que es un path) actua como prefijo de un elemento de codigo que el compilador interpreta como identifica
                StreamReader miArchivo = new StreamReader(@".\cursos\" + cbCursos.Text + ".txt");
                while(miArchivo.Peek() >= 0)
                {
                    lbAlumnos.Items.Add(Convert.ToString(miArchivo.ReadLine()));
                }
                miArchivo.Close();
            }
            catch(Exception miError)
            {
                MessageBox.Show(miError.Message);
                throw;
            }
        }

        private void itAcercaDe_Click(object sender, EventArgs e)
        {
            ventanaAcercaDe = new fmAcercaDe();
            ventanaAcercaDe.ShowDialog();
            ventanaAcercaDe.Dispose();
        }
    }
}
