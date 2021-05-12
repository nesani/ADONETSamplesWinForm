using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETSamplesWinForm.ClassProperties
{
   public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public DateTime StartingDate { get; set; }

        public string URL { get; set; }

        public Decimal Price { get; set; }

        public DateTime? RetireDate { get; set; }
    }
}
