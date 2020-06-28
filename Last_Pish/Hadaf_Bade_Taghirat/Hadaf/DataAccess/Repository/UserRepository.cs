using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using Common;

namespace DataAccess.Repository
{
   public class UserRepository
    {
       private Connection conn;
       
       public UserRepository()
        {
            conn = new Connection();
        }
       public enter FindByUserName(string username)
       {
          enter result = null;

          using (hadafDBEntities DC = conn.GetContext())
           {
               //--  SELECT * FROM vPhoneList WHERE PhobeID = phoneID

               result = (from r in DC.enters
                         where r.Username == username 
                         select r).FirstOrDefault();
           }

           return result;
       }

       public DataTable Getstatus()
       {
           List<enter> result = new List<enter>();

           using (hadafDBEntities DC = conn.GetContext())
           {
               IEnumerable<enter> pl =
                   from r in DC.enters
                   where r.Status==0
                   orderby r.id
                   select r;

               result = pl.ToList();
           }

           return HadafTools.ToDataTable(result);
       }
       public void Savestatus(enter user)
       {
           using (hadafDBEntities DC = conn.GetContext())
           {
              
                   //==== UPDATE ====
                  
                  
                   DC.enters.Attach(user);
                   DC.Entry(user).State = EntityState.Modified;

               DC.SaveChanges();
           }
       }


       //public void SaveAdmin(enter user)
       //{
         
       //    using (hadafDBEntities DC = conn.GetContext())
       //    {
               
               
       //            //==== UPDATE ====
       //            DC.enters.Attach(user);
       //            DC.Entry(user).State = EntityState.Modified;
               
       //        DC.SaveChanges();
       //    }
       //}




       public void Saveuser(enter user)
       {
           using (hadafDBEntities DC = conn.GetContext())
           {

               //if (enter. > 0)
               //{
               //    //==== UPDATE ====
               //    DC.enters.Attach(enter);

               //    DC.Entry(enter).State = EntityState.Modified;
               //}
               //else
               //{
                   //==== INSERT ====
                   DC.enters.Add(user);
              // }

               DC.SaveChanges();
           }
       }
    }
}
