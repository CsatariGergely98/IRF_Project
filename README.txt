Egy budapesti közmû szolgáltató, nevezzük BPKSZ-nek, aki ügyfélszolgálati irodát tart fenn és üzemeltet.
Idén azonban õket is elérte a pandémia, az eddig bejáró dolgozókat home-office-ba küldték haza. A
technikai feltételeket használt business notebook-ok beszerzésével rekordidõ alatt meg tudták oldani, a
dolgozók VPN-en keresztül gond nélkül elérik az intranetes webes tartalmat és a CRM rendszert.
Azonban a csoport- és osztályvezetõk elvesztették a kontrolt a dolgozók felett a „folyamatos” személyes
kontaktus megszûnése miatt. Az meglévõ és bevált jelenléti-íves rendszer helyett szükségessé vált egy új
módszer kidolgozása, mellyel a munkáltató monitorozni tudja a dolgozó munkaidejét.
A megoldást egy „sakk-óra” szerû alkalmazásban képzelik el, melyben a dolgozó rögzíti a tevékenységét
(és kiegészítõ adatokat amennyiben szükséges), majd start-stop jelleggel a program tárolja a ráfordított
idõt. Nyilvánvaló, hogy ezen alkalmazást legjobb lenne a meglévõ webes CRM-be integráltan kezelni,
azonban a cégen belül nem áll rendelkezésre webes fejlesztési kompetencia és az idõ rövidsége kizárja
egy CRM-et fejlesztõ külsõs cég bevonását. Ezen okból a megoldás egy deszktop (windows) alkalmazás
lesz, amelynek a létrehozását a belsõs fejlesztõk (én) rövid határidõvel meg tudják oldani.
Az alkalmazás fõbb jellemzõi:
- a céges intraneten megosztott könyvtárban lesz elérhetõ
- a felhasználó kezelés saját programba épített authentikációval történik
- az adatok a cég központi MS-SQL szerverén tárolódnak
- az egyes tevékenységekkel töltött idõt a program automatikusan számolja (és a képernyõn meg
is jeleníti)
- export készíthetõ (CSV formátumban) a vezetõség részére, melyben tevékenységenként
összesítve jelenik meg a dolgozók ideje, képet adva arról, hogy „mire megy el az ügyfélszolgálati
idõ”