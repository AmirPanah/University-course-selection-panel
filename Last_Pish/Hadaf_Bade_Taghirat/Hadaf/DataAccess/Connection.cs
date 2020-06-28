using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class Connection
    {

       public hadafDBEntities GetContext()
        {
            hadafDBEntities DC = new hadafDBEntities();
            return DC;
        }
    }
}
