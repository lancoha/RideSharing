# RideSharing    

#### Avtorja:  
- **Lan Čoha** - 63230043  
- **Tone Pivk** - 63230250   

RideSharing je spletna in mobilna aplikacija, ki uporabnikom omogoča organizacijo in iskanje skupnih voženj. Sistem omogoča
registracijo voznikov in potnikov, oddajo voženj, pošiljanje prošenj za sedeže ter upravljanje rezervacij.    

#### Delovanje sistema:  
- Uporabniki se registrirajo in prijavijo v sistem.  
- Vozniki lahko ustvarjajo vozila in vožnje, določijo lokacijo, datum, ceno in število sedežev. S pomočjo GoogleDirections API lahko določijo čas in dolžino vožnje  
- Potniki lahko poiščejo vožnje in pošljejo prošnjo za rezervacijo sedeža.  
- Vozniki lahko sprejmejo ali zavrnejo prošnje potnikov.  
- Podatki se shranjujejo v SQL podatkovno bazo v Azure. (Tabele: Vehicle, Rides, RideRequest in AspNetUsers)  
- Mobilna aplikacija uporablja REST API za pridobivanje podatkov in pošiljanje zahtevkov.

## Opis nalog, ki jih je izvedel vsak izmed študentov:
- **Registracija in Prijava** - Lan Čoha
- **Tabele Vehicle, Rides, RideRequest ter funkcionalnosti** - Lan Čoha
- **Integracija GoogleDirections API** - Lan Čoha
- **Azure SQL in objava v oblaku Microsoft Azure** - Tone Pivk in Lan Čoha
- **Android aplikacija** - Tone Pivk

## Nekaj slik strani aplikacije:

### Glavna stran - Rides
![image](https://github.com/user-attachments/assets/f3250e77-cf39-4fd5-8e88-eb95a10c859b)  
### Ride details
![image](https://github.com/user-attachments/assets/9d7807e6-03e4-407e-ba19-c9b7df1e2fbf)
### Create new ride (GoogleDirections API pridobi dolžino in trajanje vožnje)
![image](https://github.com/user-attachments/assets/6ef3ad1e-ddf1-431e-972e-86d3720c9320)
### Incoming ride requests
![image](https://github.com/user-attachments/assets/1bbde0a9-2267-453b-907e-367c7856247f)
### My rides
![image](https://github.com/user-attachments/assets/35ed56f8-2427-4576-9527-7381b7ae443d)



## Slika podatkovnega modela:

<img src="https://github.com/user-attachments/assets/147ffff9-5c69-43ad-b0b9-20074ffa7d6e" alt="Database Diagram" width="1000">


### Opis tabel:

- **Users**: Hrani podatke o uporabnikih (ID, Email, PasswordHash, Role...).
- **Rides**: Shranjuje informacije o vožnjah (Origin, Destination, DateTime, DriverId...).
- **RideRequests**: Hrani prošnje za sedeže (RideId, PassengerId, Status...).
- **Vehicles**: Povezana s Rides, hrani informacije o vozilih voznikov.
- **__EFMigrationsHistory**: Hrani podatke o migracijah

