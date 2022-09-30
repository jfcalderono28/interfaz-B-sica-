using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interfaz
{

    public class Hora
    {

        private int numeroHoras = 0;

        public void pedirHoras()
        {
            Console.WriteLine("Número de horas trabajadas: ");
            

        }

        public int getNumeroHoras()
        {
            return numeroHoras;
        }

        public void setNumeroHoras(int numeroHoras)
        {
            this.numeroHoras = numeroHoras;
        }
    }


    /// <summary>
    /// Clase valor horas
    /// /// ////////////////////////////////////////////////////////////////////////////////////
    /// </summary>




    public class ValorHoras : Hora
    {

        private double total = 0;
        private double valorHora = 0;



        public void calcular(int nHoras)
        {
            if (nHoras < 41)
            {
                this.total = valorHora * nHoras;

            }
            else if (nHoras >= 40 && nHoras <= 48)
            {
                this.total = valorHora * 40;
                nHoras -= 40;
                double temp = valorHora * 1.20;
                this.total += temp * nHoras;
                // 3960

            }
            else if (nHoras > 48)
            {
                this.total = valorHora * 40;
                double temp = valorHora * 1.20;
                this.total += temp * 8;
                nHoras -= 48;

                temp = valorHora * 1.40;
                this.total += temp * nHoras;

            }

        }

        public void valorDeLaHora()
        {
            Console.WriteLine("Valor de la hora trabajada: ");
            this.valorHora = Int32.Parse(Console.ReadLine());
        }

        public double getTotal()
        {
            return total;
        }

        public void setTotal(double total)
        {
            this.total = total;
        }

        public double getValorHora()
        {
            return valorHora;
        }

        public void setValorHora(double valorHora)
        {
            this.valorHora = valorHora;
        }

    }



    /// <summary>
    /// Clase empleado
    /// /// ////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    /// 





    public class Empleado : ValorHoras
    {

        private String nombre;
        private String cedula;
        private String telefono;

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }


        public String getCedula()
        {
            return cedula;
        }

        public void setCedula(String cedula)
        {
            this.cedula = cedula;
        }


        public String getTelefono()
        {
            return telefono;
        }

        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }

        public Empleado()
        {
          

            //pedirHoras();
            //valorDeLaHora();
            

        }

        public void MostrarInformaciónEmpleado()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Cedula: " + cedula);
            Console.WriteLine("Telefono: " + telefono);
            Console.WriteLine("Número de horas trabajadas: " + getNumeroHoras());
            Console.WriteLine("Valor de la hora : " + getValorHora());
            Console.WriteLine("Total: " + getTotal());

        }

    }

}
