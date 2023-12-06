using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace bucci.sebastian._4i.stampante.Models
{
    public class stampante
    {
        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int B { get; set; }

        // - ... e un cassetto di fogli(tutte property int)
        public int Fogli { get; set; }
        public stampante()
        {
            C = M = Y = B = 100;
            Fogli = 200;
        }
        public bool Stampa (Pagina p)
        {
            if (Fogli > 0 
                && C >= p.C
                && M >= p.M
                && Y >= p.Y
                && B >= p.B)
            {
 
                C -= p.C;
                M -= p.M;
                Y -= p.Y;
                B -= p.B;
                Fogli--;

                return true;
                }
            return false;
            }
        // - torna la quantità di inchiostro presente nei 4 serbatoi.
        public int StatoInchiostro(string colore )
        {
            
        }

        }
    }

