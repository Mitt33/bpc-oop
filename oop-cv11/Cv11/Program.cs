using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var dc = new DataContextDataContext())
            {
                fillData(dc);
                Console.WriteLine("---------Pocet studentu----------");
                foreach (var sp in dc.StudentCountViews)
                    Console.WriteLine("Predmet: {0}, pocet studentu: {1}", sp.Nazev, sp.StudentCount ?? 0);
                Console.WriteLine("----------Prumerne hdnoceni----------");
                foreach (var rv in dc.ResultViews)
                    Console.WriteLine("Predmet: {0}, prumerna znamka: {1}", rv.Nazev, rv.PrumernaZnamka ?? 0);


                Console.WriteLine("---------studenti predmetu podle zkratky---------");
                var Students = StudentiPredmet(dc, "BOOP");
                foreach (var stud in Students)
                {
                   Console.WriteLine("Student predmetu OOP {0}:", stud.Id);
                }

                Console.WriteLine("--------predmety studenta podle Id--------");
                var Subjects = PredmetyStudenta(dc, 1000);
                foreach (var sub in Subjects)
                {
                    Console.WriteLine(sub.Zkratka);
                }
            }
   
            Console.ReadLine();
            
        }

        private static void fillData(DataContextDataContext dc)
        {
            if(!dc.Students.Any(s => s.Prijmeni == "Svoboda"))
            {
                dc.Students.InsertOnSubmit(new Student()
                {
                    Id = 35,
                    Jmeno = "Radovan",
                    Prijmeni = "Nevim",
                    DatumNarozeni = DateTime.Today
                }) ;
            }
            dc.SubmitChanges();
        }

        public static IEnumerable<Student> StudentiPredmet(DataContextDataContext dc, String Shortcut)
        {
            if (dc.Predmets.Any(s => s.Zkratka == Shortcut))
            {
                return dc.Predmets.Where(s => s.Zkratka == Shortcut).SelectMany(p => p.StudentPredmets.Select(se => se.Student));
            }
            else
            {
                throw new Exception("takova zkratka neni");
            }
        }

        public static IEnumerable<Predmet> PredmetyStudenta(DataContextDataContext dc,int StudId)
        {
            if (dc.Students.Any(s => s.Id == StudId))
            {
                return dc.StudentPredmets.Where(s => s.IdStudent == StudId).Select(se => se.Predmet);
            }
            else
            {
                throw new Exception("takove id neni");
            }
        }
    }
}

