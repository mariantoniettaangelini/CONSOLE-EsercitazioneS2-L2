using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CV x = new CV();

            //INFO PERSONALI
            Console.WriteLine("---- INFORMAZIONI PERSONALI ----");
            x.InfoPersonali = new InfoPersonali();
            Console.WriteLine("NOME:");
            x.InfoPersonali.Nome = Console.ReadLine();

            Console.WriteLine("COGNOME:");
            x.InfoPersonali.Cognome = Console.ReadLine();

            Console.WriteLine("TELEFONO:");
            x.InfoPersonali.Tel = Console.ReadLine();

            Console.WriteLine("EMAIL:");
            x.InfoPersonali.Email = Console.ReadLine();

            //STUDI 
            x.StudiEffettuati = new List<Studi>();
            Console.WriteLine("---- INSERIRE TITOLI DI STUDIO ----");
            
                Studi studies = new Studi();
                Console.WriteLine("TITOLO DI STUDIO:");
                studies.Qualifica = Console.ReadLine();

                Console.WriteLine("ISTITUTO:");
                studies.Istituto = Console.ReadLine();

                Console.WriteLine("TIPOLOGIA:");
                studies.Tipo = Console.ReadLine();

                Console.Write("Inserisci la data di inizio: ");
                studies.Dal = DateTime.Parse(Console.ReadLine());
                Console.Write("Inserisci la data di fine: ");
                studies.Al = DateTime.Parse(Console.ReadLine());

                x.StudiEffettuati.Add(studies);


            //IMPIEGHI
            x.Impieghi = new List<Impiego>();
            Console.WriteLine("---- INSERIRE IMPIEGHI PRECEDENTI ----");
            
                Impiego work = new Impiego();
                work.Esperienza = new Esperienza();
                Console.WriteLine("AZIENDA:");
                work.Esperienza.Azienda = Console.ReadLine();

                Console.WriteLine("JOB TITLE:");
                work.Esperienza.jobTiTle = Console.ReadLine();

                Console.WriteLine("DESCRIZIONE IMPIEGO:");
                work.Esperienza.Descrizione = Console.ReadLine();

                Console.WriteLine("COMPITI:");
                work.Esperienza.Compiti = Console.ReadLine();

                Console.Write("Inserisci la data di inizio: ");
                work.Esperienza.Dal = DateTime.Parse(Console.ReadLine());
                Console.Write("Inserisci la data di fine: ");
                work.Esperienza.Al = DateTime.Parse(Console.ReadLine());

                x.Impieghi.Add(work);


            //STAMPA CV
            StampaCVSuSchermo(x);
            }
        
        static void StampaCVSuSchermo(CV x)
        {
            Console.WriteLine("---- CURRICULUM VITAE ----");
            Console.WriteLine($"Nome:{x.InfoPersonali.Nome}");
            Console.WriteLine($"Cognome:{x.InfoPersonali.Cognome}");
            Console.WriteLine($"Telefono:{x.InfoPersonali.Tel}");
            Console.WriteLine($"Email:{x.InfoPersonali.Email}");
            Console.WriteLine("\n---- STUDI EFFETTUATI ----");
            foreach(var studi in x.StudiEffettuati)
            {
                Console.WriteLine($"{studi.Qualifica} presso {studi.Istituto}");
                Console.WriteLine($"Tipologia: {studi.Tipo} - Dal {studi.Dal} Al {studi.Al}");
            }
            Console.WriteLine("\n---- IMPIEGHI PRECEDENTI ----");
            foreach (var work in x.Impieghi)
            {
                Console.WriteLine($"Azienda: {work.Esperienza.Azienda}");
                Console.WriteLine($"Job Title: {work.Esperienza.jobTiTle}");
                Console.WriteLine($"Descrizione: {work.Esperienza.Descrizione}");
                Console.WriteLine($"Compiti: {work.Esperienza.Compiti}");
                Console.WriteLine($"Dal {work.Esperienza.Dal} Al {work.Esperienza.Al}");

                Console.WriteLine("Premi un tasto per uscire...");
                Console.ReadKey(); 
            }
        }

        }
    }

