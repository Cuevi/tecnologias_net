using System;

namespace PrincipiosPOO
{
    // ===============================
    // HERENCIA
    // ===============================
    // EmpleadoPorHoras ES un Empleado, y por eso "hereda" de Empleado.
    // Reutiliza Nombre y el constructor base.
    public class EmpleadoPorHoras : Empleado
    {
        public decimal SalarioMensual { get; set; }

        public EmpleadoPorHoras(string nombre, int salarioPorHora, decimal horasTrabajadas) : base(nombre)
        {
            //salarioPorHora < 0m ? throw new ArgumentException($"Salario por hora invalido: {salarioPorHora}");
            //horasTrabajadas < 0 ? throw new ArgumentException($"Horas trabajadas inválidas: {horasTrabajadas}");
            SalarioMensual = salarioPorHora * horasTrabajadas;
        }

        // ===============================
        // POLIMORFISMO (implementación)
        // ===============================
        public override decimal CalcularSalario() => SalarioMensual;
    }
}
