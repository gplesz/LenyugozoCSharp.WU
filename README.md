# Lenyűgöző C# programozás jegyzet

## Feladat

```
                                                                      Varázsdoboz
+----+        Szezám tárulj/Szezám zárulj                     +------------------------------------------------------+
|    |                                                        |                                                      |
|    | +----------------------------------------------------> |                                                      |
|    |                                                        |                                                      |
+----+                                                        |                                                      |
                                                              |                                                      |
                                                              |                                                      |
                                                              |                                                      |
                                                              |                                                      |
                                                              |                                                      |
                                                              |                                                      |
                                                              |                                                      |
                                                              |                                                      |
                                                              |                                                      |
                                                              |                                                      |
                                                              |                                                      |
                                                              |                                                      |
                                                              |                                                      |
                                                              |                                                      |
                                                              |                                                      |
                                                              |                                                      |
                                                              |                                                      |
       Garázskapu helyett LED   Raspberry PI                  |                                                      |
             +------+           +-----------------+           |                                                      |
             |      +<--------+ |                 | <---------+                                                      |
             |      |           |                 |           |                                                      |
             |      |           |                 |           |                                                      |
             +------+           |                 |           |                                                      |
                                |                 |           |                                                      |
                                +-----------------+           +------------------------------------------------------+
```

## Első alkalmazás készítése

Fontos: ASP.NET **Core** alkalmazást készítünk

Létrehozzuk az első alkalmazásunkat
```
md bot.server
cd .\bot.server\
dotnet new webapi
```

futtatjuk
```
dotnet run
```
## Csevegőrobot bekötése
- Azure bot service megkapja a különbözp csevegőprogramoktól az üzenetet, és továbbítja a mi alkalmazásunk felé
- A mi alkalmazásunk képes arra, hogy ezt az üzenetet fogadja, és válaszoljon.
  - ehhez külső fejlesztők eszközeire lesz szükség (nuget.org-on keresztül). Ez a csomag: Microsoft.Bot.Connector.AspNetCore, és nem apha verziót használunk, ezért kiválasztjuk a speciális verziót, ami nekünk kell.
  ```
  dotnet add package Microsoft.Bot.Connector.AspNetCore --version 2.0.1.3
  ```


## Ajánlott tanfolyamok

[Hálózati alapismeretek (ingyenes!)](https://app.netacademia.hu/Tanfolyam/HA-halozati-alapismeretek)