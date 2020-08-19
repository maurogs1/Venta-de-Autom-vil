using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase.Model
{
    public enum Descriptions
    {
        Administrador, Vendedor, Auditor
    }
    

    }
   public class Role
    {
        public int Code {get;set; }
        public string Description { get;set; }
        public Role()
        {

        }

    public Role(int code, string description)
    {
        this.Code = code;
        this.Description= description;
    }

   
}

