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

## Entity Framework Core
Jeg har benyttet mig af Entity Framework Core til at håndtere kommunikationen mellem databasen og serveren.

## Github versionskontrol
Jeg har benyttet mig af Github til versionskontrol, da det er et gratis værktøj, som er nemt at bruge og giver mulighed for at dele koden med andre.

## Microsoft.AspNetCore.Cors
Microsoft.AspNetCore.Cors library integreret i web api, for at kunne håndtere CORS (Cross-Origin Resource Sharing) requests.
På den måde kan blazor klienten kommunikere med web api serveren.

## Code-behind separation
Adskiller præsentationslaget fra logikken for komponenten.
Adskillelse hjælper med at forbedre vedligeholdelsen af koden ved at adskille UI-ansvar fra logikken i komponenten. Det hjælper også med at forbedre læsbarheden af koden ved at gøre det nemmere at finde og forstå logikken bag komponentens adfærd.

## CSS-behind separation
For at adskille styling fra komponentens logik og struktur. Ved at opdele CSS-koden i en separat fil kan man holde koden mere organiseret og letlæselig.
CSS-separation hjælper også med at forhindre stilinterferens eller -konflikter mellem forskellige komponenter eller dele af applikationen. Det gør det muligt at definere styling specifikt for en bestemt komponent, uden at det påvirker resten af applikationen.
CSS-separation også give mulighed for at genbruge styling på tværs af flere komponenter eller applikationer, da CSS-filen kan importeres og bruges flere steder.