using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase.Model
{
    public enum Brands{
        Chevrolet, Volkswagen, Renault
    }
    
    public enum CarLine
    {
        Corsa, Gol, Clio        
    }
    public enum VehicleTypes
    {
        Monovolumen, Automóvil, Utilitario, Caminoneta
    }


    public class Vehicle

    {
        public int Id { get; set; }
        public string Enrollment { get; set; }
        public string Brand { get; set; }
        public string VehicleLine { get; set; }
        public string Type { get; set; }
        public int idType { get; set; }
        public string ClassVehicle { get; set; }
        public int idClassVehicle { get; set; }
        public string Colour { get; set; }
        public int Model { get; set; }
        public int NumberOfDoors { get; set; }
        public decimal Price { get; set; }
        public bool Gps { get; set; }
        public string State { get; set; }

        public Vehicle()
        {
            State = "DISPONIBLE";
        }

        public string showGps()
        {
            if (Gps)
            {
                return "SI";
            }
            else
            {
                return "NO";
            }
        }

    }
}
