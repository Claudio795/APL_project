# APL_project
Progetto per l'esame di Advanced Programming Languages, corso di studi di Ingegneria Informatica Magistrale, UniCT

# Guida all'installazione
## Prerequisiti
* Visual Studio con incluso il pacchetto .NET per sviluppo di applicazioni desktop
* Golang 1.8+
* Python 3.8+
* Microsoft SQL Server

## Installazione dei package
* Package per Go
  * Gorilla/Mux ```$ go get github.com/gorilla/mux```
* Package per Python
  * requests ```$pip install requests```
  * telegram.ext ```$pip install python-telegram-bot ```
* Package per C# (se si decide di avviare il client desktop tramite Visual Studio)
  * Newtonsoft.Json 13.0.1: una volta aperta la soluzione C# tramite Visual Studio, cliccare col tasto destro del mouse sul progetto ```Client``` e cliccare su ```Gestisci pacchetti NuGet...```, da lì cercare il pacchetto e installarlo per il progetto
  
 ## Avvio del progetto
 ### Passi preliminari
 Il progetto è stato sviluppato utilizzando un database locale, se si ha intenzione di sfruttare questo progetto per uso personale seguire i seguenti passi:
 * Tramite MS-SQL, creare e popolare un database con le seguenti tabelle strutturate in questa maniera:
    * Users:
      * Id (int con autoincremento, chiave primaria)
      * Name (varchar(50))
      * Username (varchar(50))
      * Password (varchar(50))
      * IsAdmin (bit)
    * Grocery:
      * Id (int con autoincremento, chiave primaria)
      * Name (varchar(50))
      * Category (varchar(50))
      * Quantity (int)
      * IsUrgent (bit)
    * Rooms:
      * Id (int con autoincremento, chiave primaria)
      * Name (varchar(50))
      * UserList (varchar(50)
    * Cleaning:
      * Id (int con autoincremento, chiave primaria)
      * RoomId (int)
      * UserId (int)
      CleanDate (date)
  * all'interno della directory src/Bot_Telegram, se assente, creare un file ```config.py``` al cui interno andranno definite le variabili:
    * ```TOKEN```: token del proprio bot Telegram,
    * ```CHAT_ID```: identificativo della propria chat di gruppo,
    * ```PathPrefix```: indirizzo ip del server REST
    
   ### Avvio
   * Avvio del server REST:
      * aprire dal terminale la directory src/REST_Server e digitare il comando ```$go run main.go```
   * Avvio del bot telegram: 
      * aprire dal terminale la directory src/Bot_Telegram e digitare il comando ```$python3 main.py```
      * Aggiungere il bot alla chat di gruppo della casa e assegnagli il ruolo di amministratore
   * Avvio del client desktop: 
      * all'interno della directory src/Client_Desktop fare doppio click sull'eseguibile ```Client.exe```; in alternativa, da Visual Studio aprire la soluzione ```Client.sln``` presente all'interno della directory src/Client_Desktop_src
      * Effettuare il login utilizzando le credenziali precedentemente inserite nel database
