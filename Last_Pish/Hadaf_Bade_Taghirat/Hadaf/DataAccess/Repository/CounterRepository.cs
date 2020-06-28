using Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace DataAccess.Repository
{
  public  class CounterRepository
    {
        private Connection conn;
       
       public CounterRepository()
        {
            conn = new Connection();
        }
       public DataTable GetLinkUrl(string StdID)
       {
           List<Counter> result = new List<Counter>();

           using (hadafDBEntities pb = conn.GetContext())
           {
               IEnumerable<Counter> pl =
                   from r in pb.Counters
                   where
                   r.stdid==StdID

                   select r;

               result = pl.ToList();
           }


           return HadafTools.ToDataTable(result);
       }

       public Counter FindBystdid(string username)
       {
           Counter result = null;

           using (hadafDBEntities DC = conn.GetContext())
           {
               //--  SELECT * FROM vPhoneList WHERE PhobeID = phoneID

               result = (from r in DC.Counters
                         where r.stdid == username
                         select r).FirstOrDefault();
           }

           return result;
       }

       //public DataTable GetTopSoftware(string reshte)
       //{
       //    List<Counter> result = new List<Counter>();

       //    using (hadafDBEntities pb = conn.GetContext())
       //    {
       //        IEnumerable<Counter> pl =
       //            from r in pb.Counters
       //             where
       //             r.Reshte == reshte

       //             se

       //        result = pl.ToList();
       //    }

       //    return DownloadCenterTools.ToDataTable(result);
       //}


    }
}
