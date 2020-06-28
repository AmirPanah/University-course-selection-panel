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
    public class studentcountRepository
    {
        private Connection conn;

        public studentcountRepository()
        {
            conn = new Connection();
        }
        public void Save(Student user)
        {
            using (hadafDBEntities DC = conn.GetContext())
            {

                
                    //   ==== INSERT ====
                    DC.Students.Add(user);
              

                DC.SaveChanges();
            }
        }

        public DataTable GetStdList(string reshte)
        {
            List<Student> result = new List<Student>();

            using (hadafDBEntities pb = conn.GetContext())
            {
                IEnumerable<Student> pl =
                    from r in pb.Students
                    where
                    r.Reshte == reshte

                    select r;

                result = pl.ToList();
            }

            return HadafTools.ToDataTable(result);
        }





    }
}
