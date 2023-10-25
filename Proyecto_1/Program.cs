namespace Proyecto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Leonel Monier";
            string saldo = "-120";
            string saldoIngresado = "300";
            Cuenta mercado = new Cuenta(nombre,saldo);
            Console.WriteLine("{0}", mercado.GetCantidad());
            mercado.IngresarDinero(saldoIngresado);
            Console.WriteLine("{0}", mercado.GetCantidad());

        }
           
    }

}