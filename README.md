[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/KCFUwS9s)
# BD90 - Biblioteksdatasystem 90
## Obligatorisk individuell inlämningsuppgift
## Läs igen hela denna uppdragsbeskrivning noggrant.

- **Deadline för inlämning:** Onsdag den 18:e Oktober kl 09:00
- **Inlämning:** GitHub Classroom.
- **Genomgång:** Enskilt med mig den 18e och 19e oktober.
Länk för tidsbokning kommer på discord.

## Uppgiftsbeskrivning:

Du har blivit kontaktad av Statens Informationsavdelning som har fått i uppdrag att digitalisera Sveriges bibliotek.
De vill att du tar fram ett första förslag på en systemlösning. 

Systemet ska kortfattat kunna:
* registrera utlåningsbar media (böcker, tidskrifter samt ljudböcker).
* registrera låntagare.
* hantera utlåning och återlämning av utlånad media.
* söka efter media i biblioteket.
* visa ett enkelt användargränssnitt i konsolen där funktionaliteten kan testas

Systemet är bara tänkt att användas av bibliotekets personal.

### För G krävs följande i inlämningen:

- [x] Minst 12 funktionskrav måste vara uppfyllda (se lista nedan).
- [x] Du har kryssat i alla checkboxar i denna readmefil som du anser att du har gjort. Kryssa så här-> [x]
- [x] Du har planerat din lösning på ett lämpligt sätt. Bifoga flödesschema eller klassdiagram.
- [x] Du har skapat en körbar konsolapplikation i C# ( lösningen kommer att testas i VS Code. )
- [x] Du har enskilt planerat och skapat en enkel men välstrukturerad applikation med hjälp av språket C#.
- [x] Du använder dig av objektorientering i ditt system.
- [x] Du har besvarat följande två frågor (Svara på dem här i Readme-filen, direkt under frågan): 
* Hur tycker du att du lyckats med uppgiften?
Dåligt. Programmet är längre än midgårdsormen och konstigt upplagt. Jag började tänka som en bibliotekarie (jag är utbildad bibliotekarie), och kategorisera allt enligt medietyper (spel, böcker, e-böcker, gåstavar etc).
Hade jag hunnit göra om det så hade jag ordnat alla medier i en lista för att
på ett smidigt sätt kunna samla alla 4 miljarder metoder som ligger i Catalogue-klassen. Med det sagt så är programmet fungerande och uppfyller, i min mening, kraven för ett G.
* Vad var svårast?
Att klura ut hur jag skulle använda properties och metoder för att sätta de privata objekten (singlebook mm) i de privata listorna (books mm) och skriva ut deras information utan att använda console-klassen i props eller metoder. Tog sex timmar av stacked overflow och felaktiga frågor till ChatGPT (Man får verkligen lusläsa svaren den ger då förvånansvärt många av dem kan vara löjeväckande felaktiga). Och, NEJ!, jag har inte använt någon kod från chatGPT utan enbart rådfrågat om generella scenarion!

### För VG krävs utöver samtliga G-krav också följande:

- [ ] 17 funktionskrav måste vara uppfyllda.
- [ ] Din struktur skapar förutsättningar för effektivt underhåll och möjlighet till vidareutveckling, dvs det är extra viktigt att skilja på gränssnittskod och applikationsbunden logik.
- [ ] Din kod är prydlig, konsekvent samt använder sig av bra namngivning.
- [ ] Svara på dessa två frågor: 
* På vilket sätt underlättar din nuvarande struktur vidareutveckling? Ge gärna exempel om du skulle lägga till någon extra funktion.
* Givet mer tid, vad skulle du kunna gjort bättre i denna uppgift? 

---

## Detaljerade funktionskrav

#### SYSTEMET
- [x] Programmet ska innehålla klassen _Book_ med minst fyra egenskaper: id, titel, författare och utgivningsår. 
- [x] Programmet ska innehålla klassen _Magazine_ med egenskaperna id, titel, nummer och utgivningsår.
- [x] Programmet ska innehålla klassen _AudioBook_ id, titel, författare, längd i minuter.
- [x] Programmet ska innehålla en klass kallad _Catalogue_, som ska innehålla en eller flera listor med alla mediatyper i biblioteket. Listan/listorna ska vara _private_ och andra klasser kan bara integrera med listan med hjälp av metoder i klassen _Catalogue_. 
- **_Catalogue_-klassen ska ha minst fyra publika metoder:**
- [x] Registrera/lägga till ny media i _Catalogue_
- [x] Hämta ut all media från _Catalogue_ 
- [x] Söka bland media utifrån en söksträng (ex titel eller författare) 
- [x] Använd en egen override av ToString()-metoden på dina mediaklasser för att enkelt kunna skriva ut info om dem med Console.WriteLine().
#### ANVÄNDARGRÄNSSNITTET
- [x] Registrera ny media i biblioteket (där titel, författare, utgivningsår osv skall matas in)
- [x] Lista all media i biblioteket 
- [x] Söka efter media. Sökningen ska matcha om det man söker efter finns någonstans i bokens titel, författarens namn eller i utgivningsåret och ska inte vara känsligt för stora eller små bokstäver.
- [x] När programmet startar ska minst 5 media av olika typer finnas i biblioteket, så att det snabbt går att testa.
- [x] Programmet skall hantera felaktig inmatning
#### MER AVANCERAT
- [ ] Programmet skall kunna ladda och spara bok-objekten som exempelvis json-data eller något liknande. Beroende på hur dina klasser är strukturerade kan detta vara allt ifrån lätt till svårt.
- [ ] Låt författare och liknande attribut bestå av en egenskapad klass istället för bara en sträng
- [ ] Låntagare skall gå att registrera i systemet och i menyn (åtminstone namn och födelsedag)
- [ ] Du skall kunna låna ut och lämna tillbaka böcker till en användare med ett specifikt låntagarnummer.
- [ ] Media skall ha en max utlåningstid och ett återlämningsdatum skall skrivas ut när media lånas.
- [ ] Lån skall inte gå att göra om försenad media finns utlånad till en specifik låntagare
- [ ] Lån skall gå att återlämna. Om lånet är försenat skall en bötesavgift skrivas ut (1kr per dag)

---

### Tips och riktlinjer:

* Kör **inte** _git init_! Du har klonat ner projektet från github och har därmed redan ett git repo initialiserat.
* Glöm inte **dotnet new gitignore**!
* Skapa sen projektet med **dotnet new console** som vanligt.
* Inlämning av uppgiften sker via GitHub Classroom, med **git push**. Har du problem med att få det att fungera, se till att få hjälp med det **i god tid**! 
* Programmera i steg! Försök inte lösa allt på en gång. Börja gärna utan ett gränssnitt, tänkt på logiken först.
* Använd kryssrutorna i detta dokument som en att-göra-lista! Du kan kryssa i dom genom att ändra -[ ] till -[x]
* All form av koddelning är otillåten och innebär automatiskt Underkänt i betyg. Använder ni en färdig lösning från exempelvis Stack Overflow eller ChatGPT måste ni dokumentera- samt motivera detta i kodkommmentarer. **Använd ALDRIG kod du själv inte förstår** Du kommer att behöva beskriva vad din kod gör och hur den fungerar.
* Se till att ditt program kan hantera felaktig inmatning och inte kraschar.
* För en bra struktur, tänk på att separera "inmatningen av information" från "katalog- och bok-klasserna". Katalog och bokklasserna ska alltså helst inte använda sig av Console-klassen någonstans, inte ej heller i andrahand via anropade funktioner!
* Deadline kollas mot det senaste comitten, så se till att **pusha** ditt lokala repository innan deadline, inte bara comitta.
* **Kom ihåg, mer kod betyder inte bättre kod! Hellre eleganta lösningar än mycket extra funktionalitet utöver kravspecen!**

Lycka till!
"# bd90-for-eric" 
