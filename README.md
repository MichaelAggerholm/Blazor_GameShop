[![.NET](https://github.com/MichaelAggerholm/Blazor_GameShop/actions/workflows/dotnet.yml/badge.svg)](https://github.com/MichaelAggerholm/Blazor_GameShop/actions/workflows/dotnet.yml)

# GameShop

Webshom lavet i blazor web assembly som personlig udviklings projekt.

# Projekt noter

## .NET Core 7.0

I projektet har jeg benyttet .NET Core 7.0 da det er den seneste version af .NET Core.
Det er også den version som er anbefalet at benytte i forbindelse med Blazor.

## Blazor WebAssembly App

Det er komponent baseret, komponenter bygges ved hjælp af C# og Razor syntax, som bliver kompileret til Web Assembly syntax som kan køre i browseren.
Hver komponent kan indeholde sin egen logik, markup, styling og kan nemt sammensættes med andre komponenter for at opbygge komplekse brugergrænseflader.

Den komponentbaserede tilgang i Blazor WebAssembly fremmer genanvendelighed, vedligeholdelse og skalerbarhed, da du kan opbygge og genbruge komponenter på tværs af forskellige dele af din applikation. Du kan også udvikle dine egne genanvendelige komponenter, der indeholder specifik funktionalitet, som kan deles let på tværs af din applikation.

Fordelen ved at kompilere komponenter til WebAssembly er, at de kan køre hurtigt og effektivt i browseren uden at kræve en server for at behandle og generere HTML. Dette kan give en mere responsiv og hurtig brugeroplevelse, da komponenterne kan reagere hurtigt på brugerinteraktioner uden at skulle kommunikere med serveren først.

WebAssembly er en binær instruktionsformat, der er designet til at køre i moderne browsere. Det er ikke en erstatning for HTML, CSS eller JavaScript, men snarere en supplerende teknologi til webudvikling.
Når der skrives HTML, CSS og Javascript i Blazor, bliver det oversat til WebAssembly, som så kan køre i browseren.

## Web API

Jeg har benyttet mig af Web API til at håndtere kommunikationen mellem klienten og serveren.

## Separation af client / server

Arkitekturpraksis, der benævnes som "Separation of Concerns".
Separation of Concerns handler om at adskille forskellige ansvarsområder og funktionaliteter i separate enheder for at opnå højere modularitet og løs kobling. Det gør det muligt at ændre, tilføje eller fjerne funktionaliteter uden at påvirke andre dele af applikationen.
Det gør jeg for at frontend og backend kan vedligeholdes og udvikles uafhængigt af hinanden. Dette betyder også, at API'en kan genbruges af flere forskellige klientapplikationer, og at klientapplikationen kan udvikles med forskellige frontend-teknologier, hvis det er ønsket.

Derudover kan denne adskillelse også føre til bedre sikkerhed, da det gør det lettere at styre adgangen til API'en. Med separate projekter kan API'en konfigureres til at køre på en separat server og kun acceptere anmodninger fra godkendte kilder, mens klienten kan køres på en anden server eller i en browser.

Samlet set giver adskillelsen af API og klient i separate projekter i en .NET Core 7 Blazor WebAssembly-app en mere fleksibel og modulær arkitektur med en høj grad af løs kobling og sikkerhed.

## Https

Anvendelse af HTTPS i stedet for HTTP øger sikkerheden ved at kryptere trafikken mellem klienten og serveren.

## HTTPS-only-cookies

Når man bruger cookies til at gemme brugerdata, er det vigtigt at sikre, at cookies kun sendes over HTTPS.
Her i blazor er det let opsat med brug af SameSite- og Secure-cookien attributter.

## InputValidation

InputValidation er en indbygget metode i ASP.NET Core Razor Pages, som er den samme teknologi, der bruges til Blazor WebAssembly.
Hjælpe med at forhindre angreb såsom Cross-Site Scripting (XSS) og SQL Injection.

Hvis en applikation ikke validerer brugerinput, kan en angriber indsætte skadelig kode i inputfelterne, som kan blive gemt i databasen eller vist på websiden. Dette kan føre til problemer som f.eks. at angriberen kan tage kontrol over applikationen, stjæle følsomme data, eller manipulere med indholdet på websiden.

InputValidation kan også hjælpe med at forbedre brugeroplevelsen i applikationen ved at sikre, at brugerne kun kan indtaste gyldige data i inputfelterne. Dette kan mindske risikoen for fejl og forbedre kvaliteten af data, som applikationen gemmer og bruger.

Derudover kan InputValidation også hjælpe med at overholde forskellige sikkerhedsstandarder og regler, som f.eks. GDPR og HIPAA, der kræver, at applikationer beskytter følsomme data og personlige oplysninger.

Sammenfattende kan InputValidation hjælpe med at sikre, at applikationen fungerer som den skal, og at brugerdata er beskyttet mod angreb og manipulation.

## In-memory database (Udviklingsmiljø)

Dette giver udviklere mulighed for at teste og validere applikationens funktionalitet uden at skulle oprette og administrere en ægte database. Dette kan spare tid og ressourcer og gøre det lettere at finde og rette fejl i koden.

En in-memory database fungerer ved at lagre data i hukommelsen i stedet for på en fysisk disk. Dette gør det muligt at simulere en rigtig database, men uden at skulle oprette og vedligeholde en faktisk database. Der er forskellige in-memory database-løsninger, som kan bruges i Blazor WebAssembly-apps, såsom SQLite eller Microsofts Entity Framework Core In-Memory Database Provider.

Når udviklingsprocessen er afsluttet, benyttes EF-core til at oprette og migrere til en sqlite database i stedet, her til skal der installeres en nuget pakke til at benytte sqlite.

## Entity Framework Core

Jeg har benyttet mig af Entity Framework Core til at håndtere kommunikationen mellem databasen og serveren.
Som database har jeg valgt SQLite integreret database i solution "GameShopDb.db", det gøres nemt ved at lave en migration, derefter migrere den.

## Code-first migration

Jeg benytter code-first migration tilgangen til databaseudvikling, det går ud på at jeg først definere min datamodel i koden, og derefter benytter entity framework core til at genere en database ud fra min model. Det giver mig en række fordele under udviklingen, som blandt andet disse punkter:

Hurtig og effektiv udvikling: Med code-first migration kan du hurtigt oprette og ændre din database ved at redigere dine modeller i kode. Dette gør det nemmere at tilføje eller ændre funktionalitet, da du kan opdatere dit datamodel og opdatere din database med et enkelt kommando.

Versionering af databasen: Ved at anvende code-first migration kan du versionere din database og sikre, at alle i dit team har den samme version af databasen. Dette gør det nemmere at samarbejde og sikre, at alle har den samme forståelse af, hvordan databasen er struktureret.

Fleksibilitet: Code-first migration giver dig mulighed for at arbejde med en bred vifte af databaser og understøtter flere forskellige databaseteknologier. Det betyder, at du kan vælge den database, der passer bedst til dit projekt, og at du kan ændre databaseplatformen senere, hvis det er nødvendigt.

Produktivitet: Code-first migration kan hjælpe dig med at øge din produktivitet ved at reducere mængden af ​​kode, du skal skrive, og ved at give dig mulighed for at fokusere på at udvikle applikationen, i stedet for at skrive manuelle SQL-scripts.

## Github versionskontrol

Jeg har benyttet mig af Github til versionskontrol, da det er et gratis værktøj, som er nemt at bruge og giver mulighed for at dele koden med andre.

## Github .Net workflow pipeline

automatiserer bygge- og testprocessen for et .NET-projekt. Ved at automatisere disse processer bliver det muligt at opnå flere fordele:

Reducerer risikoen for fejl: Automatiske testprocesser sikrer, at nye ændringer i koden ikke introducerer nye fejl eller bryder eksisterende funktionalitet. Dette hjælper med at reducere risikoen for, at koden ikke fungerer korrekt, når den er i produktion.

Hurtig feedback: Automatiske testprocesser giver hurtig feedback til udviklerne, når en ændring i koden bryder testene. Dette giver mulighed for hurtigt at identificere og løse problemerne.

Spar tid: Automatisering af bygge- og testprocesser sparer tid og ressourcer i forhold til manuelle processer. Dette kan give mulighed for at fokusere på andre opgaver og øge produktiviteten.

Øget kvalitet: Automatiske testprocesser sikrer, at koden er testet grundigt, hvilket øger kvaliteten af den leverede software.

Samarbejde: Automatiske testprocesser sikrer, at alle i teamet arbejder med samme kodebase og at deres arbejde er testet og valideret. Dette kan give mulighed for øget samarbejde og reducere risikoen for konflikter i koden.

I dette tilfælde kan denne GitHub workflow bidrage til at sikre, at alle kodeændringer bliver grundigt testet og integreret i master-branchen, kun når de består alle tests. Dette hjælper med at sikre, at produktet fungerer korrekt og reducerer risikoen for fejl i produktionen.

## Microsoft.AspNetCore.Cors

Microsoft.AspNetCore.Cors library integreret i web api, for at kunne håndtere CORS (Cross-Origin Resource Sharing) requests.
På den måde kan blazor klienten kommunikere med web api serveren.

## Code-behind separation

Adskiller præsentationslaget fra logikken for komponenten.
Adskillelse hjælper med at forbedre vedligeholdelsen af koden ved at adskille UI-ansvar fra logikken i komponenten. Det hjælper også med at forbedre læsbarheden af koden ved at gøre det nemmere at finde og forstå logikken bag komponentens adfærd.

## CSS-behind separation

(Afventer lige.. benytter ikke p.t code-behind alligevel.)

For at adskille styling fra komponentens logik og struktur. Ved at opdele CSS-koden i en separat fil kan man holde koden mere organiseret og letlæselig.
CSS-separation hjælper også med at forhindre stilinterferens eller -konflikter mellem forskellige komponenter eller dele af applikationen. Det gør det muligt at definere styling specifikt for en bestemt komponent, uden at det påvirker resten af applikationen.
CSS-separation også give mulighed for at genbruge styling på tværs af flere komponenter eller applikationer, da CSS-filen kan importeres og bruges flere steder.

## Brugeridentifikation og godkendelse ??

??

## Dependency Injection (DI) ??

?? mere
Der anvendes blandt andet blazor injection i ProductList.razor, her injectes HttpClient, for at vise data fetched fra http request.

## SOLID-principperne ?

Single Responsibility Principle, Open/Closed Principle, Liskov Substitution Principle, Interface Segregation Principle, Dependency Inversion Principle

?? Bliver de brugt i denne kode, eller bør man ikke nævne det ??

NOTE:

SOLID-principperne er en række designprincipper til objektorienteret programmering, der sigter mod at gøre koden mere modulær, fleksibel og genanvendelig. Disse principper er uafhængige af applikationsarkitekturen, og de kan anvendes i enhver type applikation, inklusive Blazor WebAssembly-projekter.

For at overholde SOLID-principperne kan Blazor-kode opdeles i separate moduler eller komponenter, der har en enkelt ansvar og er nemme at vedligeholde og genbruge.

## REST Api principperne ?

NOTE:

REST-principperne, derimod, er en arkitektonisk stil til udvikling af webapplikationer, der bygger på HTTP-protokollen og består af en række principper for at designe API'er, der er nemme at bruge og vedligeholde. REST-principperne fokuserer på at bruge HTTP-verbene på en standardiseret måde for at skabe en ensartet grænseflade til API'en.

Blazor WebAssembly-projekter kan følge REST-principperne ved at oprette en API, der bruger standardiserede HTTP-verb til at udføre CRUD-operationer (oprette, læse, opdatere og slette) på data.

## Swagger integration

Swagger er et open-source værktøj, der bruges til at designe, dokumentere og teste API'er. Det gør det nemt for udviklere at oprette en interaktiv dokumentation af deres API'er, der beskriver, hvordan API'en fungerer, og hvordan man bruger den.

Når det kommer til Blazor WebAssembly-apps, er Swagger især nyttig, fordi det kan integreres direkte i appen og bruges til at teste API-kald i realtid. Dette betyder, at udviklere kan teste deres API'er og se resultatet øjeblikkeligt, uden at skulle oprette en separat testklient eller deployere appen til en server.

Swagger kan også bruges til at validere API-anmodninger og svar i henhold til API-specifikationerne og hjælpe med at identificere eventuelle fejl eller problemer. Dette kan bidrage til at forbedre kvaliteten og pålideligheden af API'en og reducere tiden, der bruges på at fejlfinde.

Samlet set gør Swagger det nemt for udviklere at designe, dokumentere og teste deres API'er på en standardiseret måde, som kan føre til mere effektiv og pålidelig softwareudvikling.

## Repository Pattern

Repository pattern er en arkitektonisk designmodel, der bruges til at abstrahere adgangen til datakilder fra applikationslogikken. Ved at adskille adgangen til datakilder fra applikationslogikken bliver applikationen mere modulær og lettere at vedligeholde og teste.

I Repository pattern oprettes der en service, der fungerer som en abstraktion af datakilden. Denne service udfører CRUD-operationer på datakilden og gemmer eller henter dataene som objekter. Applikationslogikken kommunikerer med disse services eller klasser i stedet for at interagere direkte med datakilden.

Fordelene ved Repository pattern inkluderer:

Bedre adskillelse af ansvar: Repository pattern adskiller adgangen til datakilden fra applikationslogikken, hvilket gør det lettere at vedligeholde og teste applikationen.
Mere fleksibilitet: Repository pattern gør det muligt at skifte datakilden uden at skulle ændre applikationslogikken.
Lettere at teste: Repository pattern gør det muligt at teste applikationslogikken uden at skulle interagere med den faktiske datakilde.

## Sikkerhed

Grundet projektet størrelse, vil det ikke påvirke ydeevnen at benytte guid frem for normalt id til produkter, dog øger det sikkerheden da det er sværere at forudsige og manipulere dem.
