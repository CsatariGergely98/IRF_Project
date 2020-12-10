Egy budapesti k�zm� szolg�ltat�, nevezz�k BPKSZ-nek, aki �gyf�lszolg�lati irod�t tart fenn �s �zemeltet.
Id�n azonban �ket is el�rte a pand�mia, az eddig bej�r� dolgoz�kat home-office-ba k�ldt�k haza. A
technikai felt�teleket haszn�lt business notebook-ok beszerz�s�vel rekordid� alatt meg tudt�k oldani, a
dolgoz�k VPN-en kereszt�l gond n�lk�l el�rik az intranetes webes tartalmat �s a CRM rendszert.
Azonban a csoport- �s oszt�lyvezet�k elvesztett�k a kontrolt a dolgoz�k felett a �folyamatos� szem�lyes
kontaktus megsz�n�se miatt. Az megl�v� �s bev�lt jelenl�ti-�ves rendszer helyett sz�ks�gess� v�lt egy �j
m�dszer kidolgoz�sa, mellyel a munk�ltat� monitorozni tudja a dolgoz� munkaidej�t.
A megold�st egy �sakk-�ra� szer� alkalmaz�sban k�pzelik el, melyben a dolgoz� r�gz�ti a tev�kenys�g�t
(�s kieg�sz�t� adatokat amennyiben sz�ks�ges), majd start-stop jelleggel a program t�rolja a r�ford�tott
id�t. Nyilv�nval�, hogy ezen alkalmaz�st legjobb lenne a megl�v� webes CRM-be integr�ltan kezelni,
azonban a c�gen bel�l nem �ll rendelkez�sre webes fejleszt�si kompetencia �s az id� r�vids�ge kiz�rja
egy CRM-et fejleszt� k�ls�s c�g bevon�s�t. Ezen okb�l a megold�s egy deszktop (windows) alkalmaz�s
lesz, amelynek a l�trehoz�s�t a bels�s fejleszt�k (�n) r�vid hat�rid�vel meg tudj�k oldani.
Az alkalmaz�s f�bb jellemz�i:
- a c�ges intraneten megosztott k�nyvt�rban lesz el�rhet�
- a felhaszn�l� kezel�s saj�t programba �p�tett authentik�ci�val t�rt�nik
- az adatok a c�g k�zponti MS-SQL szerver�n t�rol�dnak
- az egyes tev�kenys�gekkel t�lt�tt id�t a program automatikusan sz�molja (�s a k�perny�n meg
is jelen�ti)
- export k�sz�thet� (CSV form�tumban) a vezet�s�g r�sz�re, melyben tev�kenys�genk�nt
�sszes�tve jelenik meg a dolgoz�k ideje, k�pet adva arr�l, hogy �mire megy el az �gyf�lszolg�lati
id��