
## Què haig de fer?

Has de completar la Calculadora de conversió implementant tot el que falta.

## Objectiu de la pràctica

Conversió entre llenguatge de marques. Crear un programa amb capacitat de llegir un xml i convertir-lo a json i viceversa.

## Què tenim ara?

Ara mateix tenim una solució i tres projectes. Aquests són els fitxers que tenim ara:

```
% tree -I 'bin|obj'
.
├── @Instruccions.md
├── AGENTS.md
├── CalculadoraConversio.slnx // <- Solució
├── Calculadora
│   ├── Calculadora.csproj // <- Projecte Calculadora
│   ├── Estat.cs
│   ├── Manager.cs
│   ├── Menu.cs
│   └── Program.cs
├── Conversors
│   ├── Abstract
│   │   ├── IPersistencia.cs
│   │   ├── IPersona2Json.cs
│   │   ├── IPersona2Xml.cs
│   │   ├── IJson2Persona.cs
│   │   └── IXml2Persona.cs
│   ├── Conversors.csproj // <- Projecte Conversors
│   └── Persona.cs
├── LICENSE
├── README.md
└── TestsConversors // <- Projecte Tests Conversors
    ├── Persona2JsonTest.cs
    └── TestsConversors.csproj
```

## Quins fitxers faltarien?

De fitxers en falterien:
* tres, els testos de `IPersona2Xml`, `IJson2Persona` i `IXml2Persona`.
* cinc fitxers dins `./Conversors` que seria la implementació de les interfaces de `./Conversors/Abstract`

## Quin codi faltaria?

Aquesta tasca l'has de fer tu. Has de mirar el codi que tenim i identificar les parts que falten per implementar.

## En quin ordre implemento?

Primer has de finalitzar el projecte `Conversors`. Per fer-ho, t'has d'ajuda del projecte `TestsConversors`. Pots avançar en paral·lel en tots dos projectes. El projecte de test t'ajudarà a saber si estàs fent correctament el projecte de conversors.

Un cop implementat converors, has de tocar `./Calculadora/Manager.cs` de manera que utilitzi les classes que has implementat a `Conversors`.

## Refactor

Aquest projecte està pensat per distribuir les responsabilitats de les classes de manera que cada classe s'encarregui d'una cosa i que cada mètode sigui el més petit possible. Tot i això hi ha un mètode dins `./Calculadora/Manager.cs` que pot arribar a quedar molt gros, pensa com ho pots refactoritzar per que aquest mètode quedi més simple i sigui testable.

## Entregables

* Fitxer `execucio.md` amb captura del text de l'execució del programa (en text)
* Codi del programa.

## Com es desenvolupa la pràctica

* Tenim 4 hores per a fer la pràctica.
* Farem [Pair Programing](https://ca.wikipedia.org/wiki/Programaci%C3%B3_en_parella) dinàmic:
  * Farem parelles, cada parella treballa sobre el mateix codi a la vegada.
  * Un programa i l'altre revisa, ajuda, aconsella, proposa, etc.
  * Cada hora canviarem les parelles.
  * Cada alumne, o sempre programa o sempre observa.

> Un dels rols de la parella és escriure el codi i l'altre revisar el que s'està implementant. Aquests es van intercanviant de forma freqüent. El rol d'observador no només es dedica a revisar errors, sinó que també degut a la seva posició adquireix la capacitat de saber veure la direcció que pren el desenvolupament i decidir canvis d'estratègia per millorar el treball. Alhora, la persona que escriu el codi va detallant els passos que va seguint, i entre els dos completant la feina de forma més segura, més estructurada i amb menys errors.

## Com ens avaluaran?

Hi haurà un examen per comprovar que l'alumne s'ha implicat a les pràctiques i ha entès el que feia.
