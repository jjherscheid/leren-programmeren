
# Snake werkbeschrijving

![Snake](Resources/Snake/SnakeFinal.PNG)

Deze snake werkbeschrijving komt heb ik niet helemaal zelf bedacht maar via een ander site op internet gevonden. Daar is hij alleen in het engels dus ik heb geprobeerd hem te vertalen.

Snake is een op zich een simpel spelletje, maar het is nog best ingewikkeld om te maken. Naast als je programmeer ervaring van de vorige opdrachten zal je hier ook met een nieuw programma aan de slag gaan, namelijk Unity. Unity is een programma waarmee spelletjes gemaakt kunnen worden voor de Computer, maar ook voor de PS4, Switch, Telefoon, Tablet etc. Het is dus een heel uitgebreid programma waar heel veel dingen ingesteld kunnen worden.

## Project openen in Unity

_Omdat het best lastig is om een Unity project aan te maken, heb ik alvast een basis project aangemaakt voor een 2D spel. Ook zijn alle plaatjes die je nodig hebt ook al toegevoegd._

Laten we beginnen met het project te openen. Zoek in het Startmenu van Windows naar 'Unity Hub'.  
![00](Resources/Snake/00-UnityHub.PNG)

Klik in het venster wat nu in beeld staat op 'Add' (toevoegen).  
![01](Resources/Snake/01-OpenProject.PNG)

Zoek de map _C\\Leren-Programmeren\\Snake\\_ en kies voor 'Select Folder'.  
![02](Resources/Snake/02-SelectFolder.PNG)

Klik in het projecten scherm nu op het zojuist toegevoegde project 'Snake'.  
![03](Resources/Snake/03-OpenLoadedProject.PNG)

Als het goed is opent nu het volgende scherm van Unity:  
![04](Resources/Snake/04-Unity.PNG)

In het Unity scherm zijn een aantal dingen belangrijk:

1. Is de 'scene' selectie. Daarin hebben we op dit moment 'SampleScene' met daarin alleen een 'Main Camera'.
2. Hier kan je mapjes vinden met extra items. Handigste is om deze met de selectie op 'Assets' te laten staan.
3. Dit een een gedetailleerde weergave van een mapje wat in '2' in aangeklikt. Door in 2 op 'Assets' te laten staan zie je hier als het goed is de onderdelen die je nodig hebt voor het spel.
4. Dit is een eigenschappen venster. Wanneer je wat aanklikt in Unity kan je hier allemaal dingen aanpassen.
5. Is het venster waar je het spel echt gaat 'maken'.
6. Zijn de knopjes om het spel te testen.

## Toevoegen van de randen van het spel

Als eerste gaan we de randen van het spel maken. Daarvoor zijn er twee 'assets' (die plaatjes in vakje 3).
- border_horizontal.png
- border_vertical.png

Selecteer eerst de horizontale lijn in het 'Assets' venster (3).  
![02-01](Resources/Snake/02-01-SelectBorderHorizontal.png)

Als het goed is zie je nu in het eigenschappen venster (4) dat je een heleboel kan instellen.
Zorg ervoor dat de instelling hetzelfde zijn als op onderstaand plaatje en druk dan op 'Apply':  
![02-02](Resources/Snake/02-02-SettingsBorderHorizontal.png)

_Belangrijkste wijziging is de 'Pixel Per Unit'. Omdat de snake ook 1x1 pixel gaat zijn willen we dat elke afstand in het spel ook per 1 pixel gaat. We zullen daarom bij **alle** assets dit op **1** willen zetten._

Selecteer nu de verticale lijn in het 'Assets' venster.  
![02-03](Resources/Snake/02-03-SelectBorderVertical.png)

Ook hiervoor zetten we de eigenschappen hetzelfde als bij de horizontale lijn en klik weer op 'Apply':  
![02-04](Resources/Snake/02-04-SettingsBorderVertical.png)

Nu kunnen we de lijnen in het spel slepen. Sleep daarom de horizonale en verticale lijn allebei 2 keer in het spel venser (5). _Als de lijn heel groot lijkt, dan kan je uitzoomen met de scroll van de muis te draaien in het spel venster. Je kan ze alvast een beetje goed zetten, maar let daar nog niet te veel op, dat gaan we zo aanpassen._  

Als je de lijnen in het spel hebt gezet dan kan je ze daarna nog verslepen. Je moet dan alleen even vastpakken bij het middelste rondje als je een lijst geselecteerd hebt.  
![02-05](Resources/Snake/02-05-Verslepen.png)

Als ze ongeveer zo staan zoals in het plaatje is het prima voor nu.  
![02-06](Resources/Snake/02-06-Hernoemen.PNG)

Als je een lijn selecteert dan zie je in het 'Scene' venster (1) dat deze grijs (geselecteerd) wordt. We gaan nu even handige namen geven aan de lijntjes. Nu kan jij ze iets anders hebben staan dan mij. Maar als je de linker verticale lijn selecteerd, hernoem hem dan in het scene venster naar 'BorderLeft'. Het hernoemen kan je doen door in het scene venster op 'F2' te klikken of door in het eigenschappen venster de naam te wijzigen:  
![02-07](Resources/Snake/02-07-Hernoemen.png)

Doe dit voor alle lijntjes. Hernoem de lijntjes alsvolgt:

- linker verticale lijn = BorderLeft _(deze heb je net gedaan)_
- rechter verticale lijn = BorderRight
- bovenste horizontale lijn = BorderTop
- ondersten horizontale lijn = BorderBottom


