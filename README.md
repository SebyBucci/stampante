# stampante
Consegna:
Questo progetto implementa un' applicazione WPF che simula una stampante e la stampa di pagine colorate,
la stampante e le pagine sono rappresentate dalle classi "Stampante" e "Pagina".
Il programma consente di visualizzare lo stato dell'inchiostro e della carta ed eseguire operazioni come la sostituzione del colore e la stampa di pagine.


#Codice e spiegazione:
```C#
        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int B { get; set; }
```C#

C, M, Y, B: Queste quattro proprietà rappresentano la quantità di inchiostro nei serbatoi per i colori ciano, magenta, giallo e nero, rispettivamente.
Fogli: Rappresenta la quantità di fogli disponibili nel cassetto di fogli.

Costruttore:
```C#
        public stampante()
        {
            C = M = Y = B = 100;
            Fogli = 200;
        }
```

Il costruttore inizializza le quantità di inchiostro per ciascun colore (C, M, Y, B) a 100 e la quantità di fogli (Fogli) a 200.

Metodo Stampa:

```C#
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
```

Accetta un parametro di tipo Pagina che rappresenta una pagina da stampare, contenente le quantità di inchiostro richieste per ciascun colore (C, M, Y, B).
Verifica se ci sono fogli disponibili (Fogli > 0) e se ci sono sufficienti quantità di inchiostro per ciascun colore.
Se tutte le condizioni sono soddisfatte, diminuisce le quantità di inchiostro nei serbatoi e il numero di fogli disponibili e restituisce true. Altrimenti, restituisce false.
Metodo StatoInchiostro:

Accetta un parametro colore che rappresenta il colore per cui si vuole conoscere la quantità di inchiostro.
La funzione dovrebbe restituire la quantità di inchiostro presente nel serbatoio del colore specificato (colore). Tuttavia, il metodo è incompleto e non implementa questa funzionalità. Potrebbe essere completato restituendo il valore della proprietà corrispondente al colore richiesto.
È importante notare che il metodo StatoInchiostro è incompleto e dovrebbe essere implementato per restituire la quantità di inchiostro per il colore specificato. Ad esempio, se colore è "C", il metodo dovrebbe restituire il valore di C.
