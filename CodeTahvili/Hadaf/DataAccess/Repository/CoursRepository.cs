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
  public  class CoursRepository
    {
       private Connection conn;

       public CoursRepository()
        {
            conn = new Connection();
        }
      public DataTable GetAllCOMNPList()
      {
          List<COMNP> result = new List<COMNP>();

          using (hadafDBEntities DC = conn.GetContext())
          {
              IEnumerable<COMNP> pl =
                  from r in DC.COMNPs
                  orderby r.id
                  select r;

              result = pl.ToList();
          }

          return HadafTools.ToDataTable(result);
      }

      public DataTable GetAllCOMPList()
      {
          List<COMP> result = new List<COMP>();

          using (hadafDBEntities DC = conn.GetContext())
          {
              IEnumerable<COMP> pl =
                  from r in DC.COMPs
                  orderby r.id
                  select r;

              result = pl.ToList();
          }

          return HadafTools.ToDataTable(result);
      }


      public DataTable GetAllKarBList()
      {
          List<KarB> result = new List<KarB>();

          using (hadafDBEntities DC = conn.GetContext())
          {
              IEnumerable<KarB> pl =
                  from r in DC.KarBs
                  orderby r.id
                  select r;

              result = pl.ToList();
          }

          return HadafTools.ToDataTable(result);
      }



      public DataTable GetAllKardaninarmList()
      {
          List<kardaninarm> result = new List<kardaninarm>();

          using (hadafDBEntities DC = conn.GetContext())
          {
              IEnumerable<kardaninarm> pl =
                  from r in DC.kardaninarms
                  orderby r.id
                  select r;

              result = pl.ToList();
          }

          return HadafTools.ToDataTable(result);
      }


      public DataTable GetAllKarGList()
      {
          List<KarG> result = new List<KarG>();

          using (hadafDBEntities DC = conn.GetContext())
          {
              IEnumerable<KarG> pl =
                  from r in DC.KarGs
                  orderby r.id
                  select r;

              result = pl.ToList();
          }

          return HadafTools.ToDataTable(result);
      }


      public DataTable GetAllKarNCList()
      {
          List<KarNC> result = new List<KarNC>();

          using (hadafDBEntities DC = conn.GetContext())
          {
              IEnumerable<KarNC> pl =
                  from r in DC.KarNCs
                  orderby r.id
                  select r;

              result = pl.ToList();
          }

          return HadafTools.ToDataTable(result);
      }

      
      public DataTable GetAllKarNEList()
      {
          List<KarNE> result = new List<KarNE>();

          using (hadafDBEntities DC = conn.GetContext())
          {
              IEnumerable<KarNE> pl =
                  from r in DC.KarNEs
                  orderby r.id
                  select r;

              result = pl.ToList();
          }

          return HadafTools.ToDataTable(result);
      }

      public DataTable GetAllKarTList()
      {
          List<KarT> result = new List<KarT>();

          using (hadafDBEntities DC = conn.GetContext())
          {
              IEnumerable<KarT> pl =
                  from r in DC.KarTs
                  orderby r.id
                  select r;

              result = pl.ToList();
          }

          return HadafTools.ToDataTable(result);
      }


      public DataTable GetAllKNCList()
      {
          List<KNC> result = new List<KNC>();

          using (hadafDBEntities DC = conn.GetContext())
          {
              IEnumerable<KNC> pl =
                  from r in DC.KNCs
                  orderby r.id
                  select r;

              result = pl.ToList();
          }

          return HadafTools.ToDataTable(result);
      }

      public DataTable GetAllKNEList()
      {
          List<KNE> result = new List<KNE>();

          using (hadafDBEntities DC = conn.GetContext())
          {
              IEnumerable<KNE> pl =
                  from r in DC.KNEs
                  orderby r.id
                  select r;

              result = pl.ToList();
          }

          return HadafTools.ToDataTable(result);
      }

      public DataTable GetAllKNGList()
      {
          List<KNG> result = new List<KNG>();

          using (hadafDBEntities DC = conn.GetContext())
          {
              IEnumerable<KNG> pl =
                  from r in DC.KNGs
                  orderby r.id
                  select r;

              result = pl.ToList();
          }

          return HadafTools.ToDataTable(result);
      }

      public DataTable GetAllKNTList()
      {
          List<KNT> result = new List<KNT>();

          using (hadafDBEntities DC = conn.GetContext())
          {
              IEnumerable<KNT> pl =
                  from r in DC.KNTs
                  orderby r.id
                  select r;

              result = pl.ToList();
          }

          return HadafTools.ToDataTable(result);
      }

      public DataTable GetAllKPEList()
      {
          List<KPE> result = new List<KPE>();

          using (hadafDBEntities DC = conn.GetContext())
          {
              IEnumerable<KPE> pl =
                  from r in DC.KPEs
                  orderby r.id
                  select r;

              result = pl.ToList();
          }

          return HadafTools.ToDataTable(result);
      }

      public DataTable GetAllKPGList()
      {
          List<KPG> result = new List<KPG>();

          using (hadafDBEntities DC = conn.GetContext())
          {
              IEnumerable<KPG> pl =
                  from r in DC.KPGs
                  orderby r.id
                  select r;

              result = pl.ToList();
          }
          
          return HadafTools.ToDataTable(result);
      }


      public DataTable GetAllITList()
      {
          List<ReshteInT> result = new List<ReshteInT>();

          using (hadafDBEntities DC = conn.GetContext())
          {
              IEnumerable<ReshteInT> pl =
                  from r in DC.ReshteInTs
                  orderby r.id
                  select r;

              result = pl.ToList();
          }

          return HadafTools.ToDataTable(result);
      }
      public void Savecourse(Counter counter) 
      {
          using (hadafDBEntities DC = conn.GetContext())
          {
             
              if ( counter.id > 0)
              {
                  //==== UPDATE ====
                  DC.Counters.Attach(counter);
                 
                  DC.Entry(counter).State = EntityState.Modified;
              }
              else
              {
                  //==== INSERT ====
                  DC.Counters.Add(counter);
              }

              DC.SaveChanges();
          }
      }

    }
}
