using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitecto
{
    public class Arquitecto
    {
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string CondicionContrato { get; set; }
        public string Especialidad { get; set; }
        public string TipoActividad { get; set; }
        public string TipoAfiliacion { get; set; }
        public double SueldoBase { get; private set; }
        public double Bonificacion { get; private set; }
        public double SueldoBruto { get; private set; }
        public double SueldoNeto { get; private set; }

        public Arquitecto(string codigo, string nombres, string condicionContrato, string especialidad, string tipoActividad, string tipoAfiliacion)
        {
            Codigo = codigo;
            Nombres = nombres;
            CondicionContrato = condicionContrato;
            Especialidad = especialidad;
            TipoActividad = tipoActividad;
            TipoAfiliacion = tipoAfiliacion;

            CalcularSueldoBase();
            CalcularBonificacion();
            CalcularSueldoBruto();
            CalcularSueldoNeto();
        }

        private void CalcularSueldoBase()
        {
            if (CondicionContrato == "Estable")
            {
                if (TipoActividad == "Obras")
                {
                    SueldoBase = 4000;
                }
                else if (TipoActividad == "Vías")
                {
                    SueldoBase = 6000;
                }
            }
            else if (CondicionContrato == "Contratado")
            {
                if (TipoActividad == "Obras")
                {
                    SueldoBase = 2000;
                }
                else if (TipoActividad == "Vías")
                {
                    SueldoBase = 4500;
                }
            }
        }

        private void CalcularBonificacion()
        {
            if (Especialidad == "Estructuras")
            {
                Bonificacion = SueldoBase * 0.16;
            }
            else if (Especialidad == "Recursos Hídricos")
            {
                Bonificacion = SueldoBase * 0.18;
            }
        }

        private void CalcularSueldoBruto()
        {
            SueldoBruto = SueldoBase + Bonificacion;
        }

        private void CalcularSueldoNeto()
        {
            double descuento = 0;

            if (TipoAfiliacion == "AFP")
            {
                descuento = SueldoBruto * 0.15;
            }
            else if (TipoAfiliacion == "SNP")
            {
                descuento = SueldoBruto * 0.08;
            }

            SueldoNeto = SueldoBruto - descuento;
        }

        public string ObtenerResumen()
        {
            return $"Código: {Codigo}\n         " +
                   $"Nombres: {Nombres}\n       " +
                   $"Condición de Contrato: {CondicionContrato}\n          " +
                   $"Especialidad: {Especialidad}\n           " +
                   $"Tipo de Actividad: {TipoActividad}\n        " +
                   $"Tipo de Afiliación: {TipoAfiliacion}\n        " +
                   $"Sueldo Base: {SueldoBase:C}\n         " +
                   $"Bonificación: {Bonificacion:C}\n                   " +
                   $"Sueldo Bruto: {SueldoBruto:C}\n           " +
                   $"Sueldo Neto: {SueldoNeto:C}\n            ";
            
           
        }
    }

}
