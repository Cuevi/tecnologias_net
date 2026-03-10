namespace Ejercicio2_SOLID_OCP_TarifasEnvio.Modelos
{
    public class EnvioRecogidaTienda : TarifaEnvio
    {
        public override decimal CalcularCoste(decimal importePedido)
        {
            return 0m;
        }
    }

}
