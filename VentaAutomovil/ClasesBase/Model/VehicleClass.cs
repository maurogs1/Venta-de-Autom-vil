using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase.Model
{
    public class VehicleClass
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public VehicleClass() { }

        public VehicleClass(int id, string description)
        {
            this.Id = id;
            this.Description = description;

        }
    }
}
