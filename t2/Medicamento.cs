using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    public class Medicamento
    {
        // Atributos de medicamentos
        private string nombre, codigo;
        private int cantidad;
        private double precio, monto;

        public Medicamento()
        {

        }

        //Método constructor
        public Medicamento(string nombre, string codigo, int cantidad, double precio, double monto)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.cantidad = cantidad;
            this.precio = precio;
            this.monto = monto;
        }

        public double calcularMonto()
        {
            return cantidad * precio;
        }

        //Getters and Setters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Monto { get => monto; set => monto = value; }
    }
}