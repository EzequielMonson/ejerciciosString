using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Cuenta
    {
        private string titular;
        private string cantidad;

        public Cuenta(string titular, string cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string GetTitular()
        {
            return this.titular;
        }
        public string GetCantidad()
        {
            return this.cantidad;
        }
        public string CuentaToString()
        {
            return $"Titular: {titular}, Cantidad: {cantidad:C}";
        }
        public void IngresarDinero(string montoAIngresar)
        {
            int montoDado;
            int montoTotal = 0;
            if (TextOperations.ConvertirStringAEntero(montoAIngresar, out montoDado))
            {
                if (TextOperations.ConvertirStringAEntero(cantidad, out montoTotal))
                {

                    montoTotal = montoTotal + montoDado;
                    cantidad = montoTotal.ToString();
                }
            }
            
            //IngresarDinero: recibirá un monto para acreditar a la cuenta.
            //Si el monto ingresado es negativo, no se hará nada.

        }
    }
}
