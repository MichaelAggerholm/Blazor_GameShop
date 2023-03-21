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


