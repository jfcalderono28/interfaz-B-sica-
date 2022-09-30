using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        Empleado obj = new Empleado();
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            double x;
            if (nombre.Text.Equals("") || cedula.Text.Equals("")  || (telefono.Text.Equals("") ))
                {
            
                MessageBox.Show("Rellene los campos faltantes!");
            }else if(double.TryParse(cedula.Text, out x)==false)
            {
                MessageBox.Show("Cedula no es un número o contiene letras");
            }else if(double.TryParse(telefono.Text, out x)==false)
            {
                MessageBox.Show("Telefono no es un número o contiene letras");
            }
            else
            {
                obj.setNombre(nombre.Text);
                obj.setCedula(cedula.Text);
                obj.setTelefono(telefono.Text);
                try
                {
                    obj.setNumeroHoras(Int32.Parse(horasTrabajadas.Text));

                }
                catch (FormatException)
                {
                    MessageBox.Show("El valor de horas trabajadas no es numerico");

                }
                try
                {
                    obj.setValorHora(Int32.Parse(valorHora.Text));

                }
                catch (FormatException)
                {
                    MessageBox.Show("El valor de la hora no es numerico");

                }


                nombre.Text = "";
                cedula.Text = "";
                telefono.Text = "";
                horasTrabajadas.Text = "";
                valorHora.Text = "";
                total.Text = "";

                try
                {
                    nombre.Text = obj.getNombre();
                    cedula.Text = Convert.ToString(obj.getCedula());
                    telefono.Text = Convert.ToString(obj.getTelefono());
                    horasTrabajadas.Text = Convert.ToString(obj.getNumeroHoras());
                    valorHora.Text = Convert.ToString(obj.getValorHora());
                }
                catch (Exception)
                {
                    MessageBox.Show("Error ");


                }

                try
                {

                    obj.calcular(obj.getNumeroHoras());
                    total.Text = Convert.ToString(obj.getTotal());

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al calcular");

                }
            }
                







        }

        private void mostrar_Click(object sender, EventArgs e)
        {

            if (nombre.Text.Equals("")){

                MessageBox.Show("No existen datos que mostrar!");

            }
            else
            {
                nombre.Text = obj.getNombre();
                cedula.Text = Convert.ToString(obj.getCedula());
                telefono.Text = Convert.ToString(obj.getTelefono());
                horasTrabajadas.Text = Convert.ToString(obj.getNumeroHoras());
                valorHora.Text = Convert.ToString(obj.getValorHora());
                obj.calcular(obj.getNumeroHoras());
                total.Text = Convert.ToString(obj.getTotal());
            }
     

           
          
                
            



        }
        

        private void limpiar_Click(object sender, EventArgs e)
        {
            nombre.Text ="";
            cedula.Text = "";
            telefono.Text = "";
            horasTrabajadas.Text = "";
            valorHora.Text = "";
            total.Text = "";
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
