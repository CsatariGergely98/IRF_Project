echo "                                                                                                                                                                                                         ";
echo "      _____            ______         ____   _________________       ____        _____    ____             _____         ______        _____         _____         ______    ____       _____      _____ ";
echo "  ___|\    \       ___|\     \   ____|\   \ /                 \ ____|\   \   ___|\    \  |    |        ___|\    \    ___|\     \   ___|\    \    ___|\    \    ___|\     \  |    |     |\    \    /    /|";
echo " /    /\    \     |    |\     \ /    /\    \\______     ______//    /\    \ |    |\    \ |    |       /    /\    \  |     \     \ |    |\    \  /    /\    \  |     \     \ |    |     | \    \  /    / |";
echo "|    |  |    |    |    |/____/||    |  |    |  \( /    /  )/  |    |  |    ||    | |    ||    |      |    |  |____| |     ,_____/||    | |    ||    |  |____| |     ,_____/||    |     |  \____\/    /  /";
echo "|    |  |____| ___|    \|   | ||    |__|    |   ' |   |   '   |    |__|    ||    |/____/ |    |      |    |    ____ |     \--'\_|/|    |/____/ |    |    ____ |     \--'\_|/|    |  ____\ |    /    /  / ";
echo "|    |   ____ |    \    \___|/ |    .--.    |     |   |       |    .--.    ||    |\    \ |    |      |    |   |    ||     /___/|  |    |\    \ |    |   |    ||     /___/|  |    | |    |\|___/    /  /  ";
echo "|    |  |    ||    |\     \    |    |  |    |    /   //       |    |  |    ||    | |    ||    |      |    |   |_,  ||     \____|\ |    | |    ||    |   |_,  ||     \____|\ |    | |    |    /    /  /   ";
echo "|\ ___\/    /||\ ___\|_____|   |____|  |____|   /___//        |____|  |____||____| |____||____|      |\ ___\___/  /||____ '     /||____| |____||\ ___\___/  /||____ '     /||____|/____/|   /____/  /    ";
echo "| |   /____/ || |    |     |   |    |  |    |  |\`   |         |    |  |    ||    | |    ||    |      | |   /____ / ||    /_____/ ||    | |    || |   /____ / ||    /_____/ ||    |     ||  |\`    | /   ";
echo " \|___|    | / \|____|_____|   |____|  |____|  |____|         |____|  |____||____| |____||____|       \|___|    | / |____|     | /|____| |____| \|___|    | / |____|     | /|____|_____|/  |_____|/      ";
echo "   \( |____|/     \(    )/       \(      )/      \(             \(      )/    \(     )/    \(           \( |____|/    \( |_____|/   \(     )/     \( |____|/    \( |_____|/   \(    )/        )/         ";
echo "    '   )/         '    '         '      '        '              '      '      '     '      '            '   )/        '    )/       '     '       '   )/        '    )/       '    '         '          ";
echo "        '                                                                                                    '              '                          '              '                                  ";
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
# Tev�kenys�g r�gz�t� 1.0.0.0.

A tev�kenys�g r�gz�t� egy c#-ban �r�dott windwos form-os alkalmaz�s.
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
# Installation

A program k�zvetlen�l futtathat� az IRF_Beadando.exe futtat�s�val. A program futtat�s�hoz legal�bb 2017 (RTM) - 14.0.1000.169 verzi�j� Microsoft SQL Server sz�ks�ges. 
A csatolt .mdf �s .ldf f�jlokat be kell m�solni az SQL szerver data alk�nyvt�r�ba �s felcsatolni.
A program mellett tal�lhat� config f�jlban (IRF_Beadando.exe.config) k�t helyen be kell �ll�tani az SQL szerver el�r�s�t, DataSource=� �rt�k�nek m�dos�t�s�val. 8. �s a 9. sor.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
# Usage
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
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
# Main specifications

- a c�ges intraneten megosztott k�nyvt�rban lesz el�rhet�
- a felhaszn�l� kezel�s saj�t programba �p�tett authentik�ci�val t�rt�nik
- az adatok a c�g k�zponti MS-SQL szerver�n t�rol�dnak
- az egyes tev�kenys�gekkel t�lt�tt id�t a program automatikusan sz�molja (�s a k�perny�n meg
is jelen�ti)
- export k�sz�thet� (CSV form�tumban) a vezet�s�g r�sz�re, melyben tev�kenys�genk�nt
�sszes�tve jelenik meg a dolgoz�k ideje, k�pet adva arr�l, hogy �mire megy el az �gyf�lszolg�lati
id��
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#Contributing
A fejleszt�si javaslatokat sz�vesen fogadom. A nagyobb v�ltoztat�sok miatt k�rem vegye fel a kapcsolatot velem.
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#Support
gergely.csatari@gmail.com
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
# Licence
MIT License

Copyright (c) 2020 Csat�ri Gergely

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------