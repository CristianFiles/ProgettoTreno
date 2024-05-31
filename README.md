Progetto Treno
===============
Il programma simula la gestione di un treno, permettendo all' utente di gestire un treno, ma anche di comprare i biglietti per esso.

Abstract iniziale
-----------------
### L'abstract iniziale prevedeva la seguente struttura:

Tipi di vagone(letto,1a 2a 3a classe, silenzio, ristorante);  
Cambio posto, salita, discesa;  
Biglietteria;  
Tabellone arrivi/partenze;  
Carta per caricare biglietti e riscattare punti per viaggi gratis o sconti su viaggi;    
2 form: simulazione del passeggero(salita, discesa, cambio posto), gestione del treno in cui si può vedere lo stato dei vagoni.  

Durante la creazione del progetto ci siamo accorti della presenza di alcune funzioni che avrebbero richiesto troppo lavoro o che non avrebbero contribuito al progetto finale, 
ad esempio la carta per i punti avrebbe richiesto il salvataggio dei dati su un file esterno. In corso d'opera abbiamo aggiunto diverse idee non presenti inizialmente, come ad esempio la gestione dei vagoni e dei suoi passeggeri.

Funzioni principali
-------------------
![](Gestore.png)

## Sezione utente (Parte sinistra)
* #### Crea biglietto:  
![](BigliettoVuoto.png)  
Tipi biglietto:  
* Prima classe: permette di accedere ai vagoni di tipo prima classe, fumatori, ristorante e silenzio.
* Seconda classe: permette di accedere ai vagoni di tipo seconda classe e fumatori.
* Full optional: permette di accedere ai vagoni di tipo cuccette, fumatori, ristorante e silenzio.

**Destinazione**: permette di scegliere una destinazione tra le regioni d'Italia.  
**Nome e cognome**: permette di inserire le generalità del passeggero.  

*Dopo aver creato un biglietto non è più possibile modificare tipo e destinazione fino a quando non verranno eliminati i biglietti precedenti.*  
* Mostra biglietto: visualizza le informazioni sui biglietti acquistati.
* Elimina biglietto: elimina tutti i biglietti precedentemente acquistati.
* Spostati nel vagone: permette di spostarsi nel vagone selezionato nella lista in basso a destra (*In base al tipo di biglietto acquistato*). 
* Collega WiFi: verifica se è possibile collegarsi al WiFi nel vagone corrente. *I vagoni che si posso collegare sono di tipo prima classe, cuccette e silenzio.*
* Attacco presa: verifica se è possibile utilizzare le prese elettriche nel vagone corrente. *I vagoni con le prese sono di tipo prima classe, seconda classe e cuccette.*

## Sezione treno (Parte destra)
### Gestione vagoni
* Aggiunta vagone: permette di scegliere il tipo di vagone da aggiungere inserendo la capienza e la posizione dove si vuole inserire il nuovo vagone.
* Rimuovi vagone: permette di eliminare il vagone selezionato nella lista drop-down.
### Gestione passeggeri
* Sposta in altro vagone: permette di spostare persone dal vagone selezionato nel tabella in basso a destra. nella sezione "Gestione passeggeri" andiamo a selezionare il vagone dove desideriamo spostare le persone e il numero di persone che vogliamo spostare.
* Rimuovi o aggiungi: permette di scegliere un numero di persone che possono scendere o salire dal treno selezionando il vagone su cui si vuole eseguire l'azione nella tabella in basso a destra.

Autori
------
Nello sviluppo non c'è stata una vera e propria suddivisione del lavoro, ognuno lavorava in base alle necessità del momento. Abbiamo lavorato utilizzando GitHub per avere in cloud sempre l'ultima versione del progetto, quando lavoravamo in più persone utilizzavamo l'estensione "Live Share" per Visual Studio 2022
* Carteni Riccardo
* Dal Pont Giona
* Pirozzolo Cristian
* Spinellino Michael
