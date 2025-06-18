# Service Locator
Modelul Service Locator este un model de design utilizat pentru a decupla crearea obiectelor de serviciu de utilizarea lor. Acesta oferă un registru central unde serviciile pot fi înregistrate și recuperate, permițând un cod mai flexibil și mai ușor de întreținut.
fata de alte modele de design, cum ar fi Singleton, Service Locator are toate depentențele înregistrate într-un singur loc, ceea ce facilitează gestionarea și testarea acestora. La fel este mai usor adaugarea de noi servicii.

## Utilizare
A fost creat pentru a fi utilizat cu Unity, in special in proiecte mici sau pentru prototipare rapida.

## Implimentare
'SeviceLocator.cs' este clasa principală care implementează modelul Service Locator. Aceasta permite înregistrarea și recuperarea serviciilor prin intermediul unui registru central. Scurt este un fel de container de dependențe.
Avem doua instante de ServiceLocator, Globala si de Scena. 
1. Instanta globala poate fi folosit ori unde (daca nu esxista se creaza una noua)
2. Instante de scena (fiecare scena paote avea doar un singur ServiceLocator) 
3. 
## Exemplu
In folderul Sample este un exemplu de utilizare a patternului Service Locator.

Pentru inceput trebue de acaugat initializatorul in scena "GameObject/ServiceLocator/Add Scene" va dauga un GameObject cu un component ServiceLocator, care va fi folosit pentru a inregistra si accesa serviciile.
Apoi, pentru a înregistra un serviciu, se poate utiliza metoda `RegisterService<T>(T service)` din clasa `ServiceLocator`. De exemplu:

```csharp
ServiceLocator.Instance.RegisterService<IMyService>(new MyService());
```
Pentru a recupera un serviciu înregistrat, se poate utiliza metoda `GetService<T>()`:

```csharp
IMyService myService = ServiceLocator.Instance.GetService<IMyService>();
```

