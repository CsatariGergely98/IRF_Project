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
# Tevékenység rögzítõ 1.0.0.0.

A tevékenység rögzítõ egy c#-ban íródott windwos form-os alkalmazás.
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
# Installation

A program közvetlenül futtatható az IRF_Beadando.exe futtatásával. A program futtatásához legalább 2017 (RTM) - 14.0.1000.169 verziójú Microsoft SQL Server szükséges. 
A csatolt .mdf és .ldf fájlokat be kell másolni az SQL szerver data alkönyvtárába és felcsatolni.
A program mellett található config fájlban (IRF_Beadando.exe.config) két helyen be kell állítani az SQL szerver elérését, DataSource=… értékének módosításával. 8. és a 9. sor.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
# Usage
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
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
# Main specifications

- a céges intraneten megosztott könyvtárban lesz elérhetõ
- a felhasználó kezelés saját programba épített authentikációval történik
- az adatok a cég központi MS-SQL szerverén tárolódnak
- az egyes tevékenységekkel töltött idõt a program automatikusan számolja (és a képernyõn meg
is jeleníti)
- export készíthetõ (CSV formátumban) a vezetõség részére, melyben tevékenységenként
összesítve jelenik meg a dolgozók ideje, képet adva arról, hogy „mire megy el az ügyfélszolgálati
idõ”
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#Contributing
A fejlesztési javaslatokat szívesen fogadom. A nagyobb változtatások miatt kérem vegye fel a kapcsolatot velem.
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#Support
gergely.csatari@gmail.com
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
# Licence
MIT License

Copyright (c) 2020 Csatári Gergely

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