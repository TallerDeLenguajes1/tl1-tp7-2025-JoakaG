using System;
namespace EspacioEmpeado
{

    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        public string EstadoCivil;
        private DateTime fechaDeingreso;
        public Cargos cargo;

        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaDeIngreso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaDeingreso = fechaDeIngreso;

        }
        public DateTime FechaDeingreso { get => fechaDeingreso; set => fechaDeingreso = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public double Antiguedad()
        {
            TimeSpan antiguedad = System.DateTime.Now - FechaDeingreso;
            return Math.Round(antiguedad.TotalDays / 365);
        }

        public double Edad()
        {
            TimeSpan edad = System.DateTime.Now - FechaNacimiento;
            return Math.Round(edad.TotalDays / 365);
        }

        public double FaltaParaJubilacion()
        {
            double jubilacion = 65 - Edad();
            return jubilacion;
        }

        public double Salario()
        {
            double Adicional = 0;
            if (Antiguedad() > 20)
            {
                Adicional = SueldoBasico() * 0.25;
            }
            else
            {
                Adicional = SueldoBasico() * (Antiguedad() / 100);
            }

            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                Adicional *= 1.5;
            }

            if (EstadoCivil == "Casado")
            {
                Adicional += 150000;
            }

            double salario = SueldoBasico() + Adicional;
            return Math.Round(salario, 2);
        }

        public double SueldoBasico()
        {
            switch (cargo)
            {
                case Cargos.Administrativo:
                    return 650000;
                case Cargos.Auxiliar:
                    return 450000;
                case Cargos.Especialista:
                    return 900000;
                case Cargos.Investigador:
                    return 1200000;
                case Cargos.Ingeniero:
                    return 1200000;
                default:
                    return 0;
            }
        }
    }

    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }


}


