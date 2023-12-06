# stampante
Consegna:
Questo progetto implementa un' applicazione WPF che simula una stampante e la stampa di pagine colorate,
la stampante e le pagine sono rappresentate dalle classi "Stampante" e "Pagina".
Il programma consente di visualizzare lo stato dell'inchiostro e della carta ed eseguire operazioni come la sostituzione del colore e la stampa di pagine.

Proprietà dei consumabili:

C, M, Y, B: Queste quattro proprietà rappresentano la quantità di inchiostro nei serbatoi per i colori ciano, magenta, giallo e nero, rispettivamente.
Fogli: Rappresenta la quantità di fogli disponibili nel cassetto di fogli.
Costruttore:

Il costruttore inizializza le quantità di inchiostro per ciascun colore (C, M, Y, B) a 100 e la quantità di fogli (Fogli) a 200.
Metodo Stampa:

Accetta un parametro di tipo Pagina che rappresenta una pagina da stampare, contenente le quantità di inchiostro richieste per ciascun colore (C, M, Y, B).
Verifica se ci sono fogli disponibili (Fogli > 0) e se ci sono sufficienti quantità di inchiostro per ciascun colore.
Se tutte le condizioni sono soddisfatte, diminuisce le quantità di inchiostro nei serbatoi e il numero di fogli disponibili e restituisce true. Altrimenti, restituisce false.
Metodo StatoInchiostro:

Accetta un parametro colore che rappresenta il colore per cui si vuole conoscere la quantità di inchiostro.
La funzione dovrebbe restituire la quantità di inchiostro presente nel serbatoio del colore specificato (colore). Tuttavia, il metodo è incompleto e non implementa questa funzionalità. Potrebbe essere completato restituendo il valore della proprietà corrispondente al colore richiesto.
È importante notare che il metodo StatoInchiostro è incompleto e dovrebbe essere implementato per restituire la quantità di inchiostro per il colore specificato. Ad esempio, se colore è "C", il metodo dovrebbe restituire il valore di C.
