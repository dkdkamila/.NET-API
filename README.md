# .NET-API
API skapat med .NET

Detta projekt är ett ASP.NET Core API för att hantera en låtlista med musik. API:et tillåter CRUD-operationer (Create, Read, Update, Delete) för låtar och presenterar data i JSON-format.

## Funktioner
Skapa låt: Skapa en ny låt med artist, låt-titel, spel-längd och kategorier.
Hämta alla låtar: Hämta en lista med alla tillgängliga låtar.
Hämta en låt: Hämta en specifik låt baserat på dess ID.
Uppdatera låt: Uppdatera informationen för en befintlig låt.
Radera låt: Ta bort en låt från låtlistan.

## Tekniker
ASP.NET Core: API:et är byggt med ASP.NET Core. 
Entity Framework Core: Används för att kommunicera med databasen och hantera dataåtkomst.
JSON: API:et presenterar och accepterar data i JSON-format. 

## Användning
För att använda API:et, starta projektet och navigera till API-routerna med hjälp av en HTTP-klient, till exempel Postman eller använd det i en klientapplikation.

### Endpoints
GET /api/Song: Hämta alla låtar.
GET /api/Song/{id}: Hämta en specifik låt baserat på ID.
POST /api/Song: Skapa en ny låt.
PUT /api/Song/{id}: Uppdatera en befintlig låt.
DELETE /api/Song/{id}: Ta bort en låt.


