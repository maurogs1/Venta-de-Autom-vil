using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase.Model
{
    public enum PaymentMethods
    {
        Efectivo, Cheque, Transferencia
    }
    public class Sale
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }//dni del cliente
        public int VehicleID { get; set; }
        public int UserId { get; set; }
        public string PaymentMethod { get; set; } //forma de pago
        public int idPaymentMethod { get; set; }
        public decimal FinalPrice { get; set; }
        public DateTime Date { get; set; }
        public string State { get; set; }

        public Sale()
        {

        }

    }
}
