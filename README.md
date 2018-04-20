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

## Azure bot channel registration

Alkalmazás név: LenyugozoCsharpWu
Alkalmazás azonosító: 8fb3babb-5b6b-4265-a510-4391f38c13a2
Alkalmazás jelszó: vlsxzRKBS49997+(-ccVMA%

## Alkalmazás telepítése Azure-ra
Azure CLI használatával

```
az webapp new --name lenyugozocsharpwu --location "North Europe" --dryrun
```

Figyelem: az üzenetküldő végpont, az nem az alkalmazás címe, hanem a MessageController címe!!!


## Raspberry PI alkalmazás készítése

```
md rpi.server
cd .\rpi.server\
dotnet new webapi
```

Raspberry IO GPIO eléréshez
```
dotnet add package Unosquare.Raspberry.IO --version 0.14.0
```
![Raspberry szerelés](pics/szereles.png)

## Ajánlott tanfolyamok

[Hálózati alapismeretek (ingyenes!)](https://app.netacademia.hu/Tanfolyam/HA-halozati-alapismeretek)
[Elektronikai alapismeretek (ingyenes)](https://app.netacademia.hu/Tanfolyam/ELAI-I-az-elektronika-alapismeretei-i)
[Linux alapok Raspberry PI-vel](https://app.netacademia.hu/Tanfolyam/2017bevLINUX-bevezetes-a-linux-vilagaba-raspberry-pi)
