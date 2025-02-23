namespace EspacioAscii
{
    public class Ascii
    {
        public void titulo()
        {
            string titulo = @"
 ███▄ ▄███▓ ▒█████   ██▀███  ▄▄▄█████▓ ▄▄▄       ██▓        ██ ▄█▀ ▒█████   ███▄ ▄███▓ ▄▄▄▄    ▄▄▄     ▄▄▄█████▓
▓██▒▀█▀ ██▒▒██▒  ██▒▓██ ▒ ██▒▓  ██▒ ▓▒▒████▄    ▓██▒        ██▄█▒ ▒██▒  ██▒▓██▒▀█▀ ██▒▓█████▄ ▒████▄   ▓  ██▒ ▓▒
▓██    ▓██░▒██░  ██▒▓██ ░▄█ ▒▒ ▓██░ ▒░▒██  ▀█▄  ▒██░       ▓███▄░ ▒██░  ██▒▓██    ▓██░▒██▒ ▄██▒██  ▀█▄ ▒ ▓██░ ▒░
▒██    ▒██ ▒██   ██░▒██▀▀█▄  ░ ▓██▓ ░ ░██▄▄▄▄██ ▒██░       ▓██ █▄ ▒██   ██░▒██    ▒██ ▒██░█▀  ░██▄▄▄▄██░ ▓██▓ ░ 
▒██▒   ░██▒░ ████▓▒░░██▓ ▒██▒  ▒██▒ ░  ▓█   ▓██▒░██████▒   ▒██▒ █▄░ ████▓▒░▒██▒   ░██▒░▓█  ▀█▓ ▓█   ▓██▒ ▒██▒ ░ 
░ ▒░   ░  ░░ ▒░▒░▒░ ░ ▒▓ ░▒▓░  ▒ ░░    ▒▒   ▓▒█░░ ▒░▓  ░   ▒ ▒▒ ▓▒░ ▒░▒░▒░ ░ ▒░   ░  ░░▒▓███▀▒ ▒▒   ▓▒█░ ▒ ░░   
░  ░      ░  ░ ▒ ▒░   ░▒ ░ ▒░    ░      ▒   ▒▒ ░░ ░ ▒  ░   ░ ░▒ ▒░  ░ ▒ ▒░ ░  ░      ░▒░▒   ░   ▒   ▒▒ ░   ░    
░      ░   ░ ░ ░ ▒    ░░   ░   ░        ░   ▒     ░ ░      ░ ░░ ░ ░ ░ ░ ▒  ░      ░    ░    ░   ░   ▒    ░      
       ░       ░ ░     ░                    ░  ░    ░  ░   ░  ░       ░ ░         ░    ░            ░  ░        
                                                                                            ░                   
";
            EscribirCentrado(titulo);
        }

        public void Logo()
        {
            string logo = @"             @@@@@@@@@@@@@@             
         @@@@%@#==----:-=+%@@@@         
       @@@%@==#@=--*---------+@@@       
     @@@+=+*#@@@@@@@@@@%-------=@@@     
    @@**@@@@@@@@@@@@@@@@@@@---===+@@@   
  @@@*%@@@@@@@@@@@@@@@#@@@+-=======@@@  
 @@@+%@@@@@@@@@@@@@@@%%@@@@@%*======@@@ 
 @@+%@@@@@@@@@@@@@@@%====%@@+#@@@@==+@@ 
@@#+@@@@@@@@@#@@@%*==+%%+==#@@@@@#+++#@@
@@*+@@@@@@@@@+==========#@%==%###+++++@@
@@**@@@@@@@@@*++++=======+#%@@%#%+++++@@
@@**@@@@@@@@@@@#++++++++***+++++@+++*#@@
@@%@@%@@@@@@@@@@@@@@@@@@@@@@@@#+#@*+*%@@
@@#***@@@@@@@@@@@@@@@@@@@@@@@@@@##@*##@@
 @@****#@@@@@@@@@@@@@@@@@@@@@@@@@%***@@ 
 @@@***#@@@@@@@@@@@@@@@@@@@@@@@@@@**@@@ 
  @@@**#@**@@@@@@@@@@@@@@@@@@@@@@@*@@@  
    @@*****@****@@@@@@@@@@@@@@@@@@@@@   
     @@@#*******%@@@@@@@@@@@@@@@@@@     
       @@@@@@@@@@@@@@@@@@@@@@@@@@       
         @@@@@@@@@@@@@@@@@@@@@@         
            @@@@@@@@@@@@@@@@ ";
            Console.WriteLine(logo);
        }

        public void Logo2()
        {
            string logo = @"        @@@@@@%%@@@@@@        
     @@@@###--------=#@@@     
   @@@*+#@@@@@@@@#=----+%@@   
  @@##@@@@@@@@%+#@@@*====*@@  
 @@*@@@@@@@@@@@@@@@@#+====+@@ 
@@#%@@@@@%@@@@@#*=+%@@@@@*=*@@
@%*@@@@@@@**+====#%==*@@%+++%@
@%*@@@@@@@+++======#%%@%#+++#@
@%#@@@@@@@@%%###%%%%%*+*%*+*%@
@%**%@@@@@@@@@@@@@@@@@@%#@@%%@
@@#**#@@@@@@@@@@@@@@@@@@@###@@
 @@**#@#@@@@@@@@@@@@@@@@@%*@@ 
  @@%%#*###%@@@@@@@@@@@@@%@@  
   @@@%#****%@@@@@@@@@@@@@@   
     @@@@@@@@@@@@@@@@@@@@     
@@@@@@@@@@@@@@";
            EscribirCentrado(logo);
        }

        public void Menu()
        {
            string menu = @"
 ____ ____ ____ ____ 
||M |||e |||n |||u ||
||__|||__|||__|||__||
|/__\|/__\|/__\|/__\|
";
            Console.WriteLine(menu);
        }

        public void Personajes()
        {
            string lista = @"
 ____ ____ ____ ____ ____ ____ ____ 
||L |||i |||s |||t |||a |||d |||o ||
||__|||__|||__|||__|||__|||__|||__||
|/__\|/__\|/__\|/__\|/__\|/__\|/__\|
";
            Console.WriteLine(lista);
        }

        public void Historial()
        {
            string histo = @"
 ____ ____ ____ ____ ____ ____ ____ ____ ____ 
||H |||i |||s |||t |||o |||r |||i |||a |||l ||
||__|||__|||__|||__|||__|||__|||__|||__|||__||
|/__\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|
";
            Console.WriteLine(histo);
        }

        public void fight()
        {
            string fight = @"  █████▒██▓  ▄████  ██░ ██ ▄▄▄█████▓
▓██   ▒▓██▒ ██▒ ▀█▒▓██░ ██▒▓  ██▒ ▓▒
▒████ ░▒██▒▒██░▄▄▄░▒██▀▀██░▒ ▓██░ ▒░
░▓█▒  ░░██░░▓█  ██▓░▓█ ░██ ░ ▓██▓ ░ 
░▒█░   ░██░░▒▓███▀▒░▓█▒░██▓  ▒██▒ ░ 
 ▒ ░   ░▓   ░▒   ▒  ▒ ░░▒░▒  ▒ ░░   
 ░      ▒ ░  ░   ░  ▒ ░▒░ ░    ░    
 ░ ░    ▒ ░░ ░   ░  ░  ░░ ░  ░      
        ░        ░  ░  ░  ░         ";
            EscribirCentrado(fight);
        }

        public void fatality()
        {
            string fatality = @"
  █████▒▄▄▄     ▄▄▄█████▓ ▄▄▄       ██▓     ██▓▄▄▄█████▓▓██   ██▓
▓██   ▒▒████▄   ▓  ██▒ ▓▒▒████▄    ▓██▒    ▓██▒▓  ██▒ ▓▒ ▒██  ██▒
▒████ ░▒██  ▀█▄ ▒ ▓██░ ▒░▒██  ▀█▄  ▒██░    ▒██▒▒ ▓██░ ▒░  ▒██ ██░
░▓█▒  ░░██▄▄▄▄██░ ▓██▓ ░ ░██▄▄▄▄██ ▒██░    ░██░░ ▓██▓ ░   ░ ▐██▓░
░▒█░    ▓█   ▓██▒ ▒██▒ ░  ▓█   ▓██▒░██████▒░██░  ▒██▒ ░   ░ ██▒▓░
 ▒ ░    ▒▒   ▓▒█░ ▒ ░░    ▒▒   ▓▒█░░ ▒░▓  ░░▓    ▒ ░░      ██▒▒▒ 
 ░       ▒   ▒▒ ░   ░      ▒   ▒▒ ░░ ░ ▒  ░ ▒ ░    ░     ▓██ ░▒░ 
 ░ ░     ░   ▒    ░        ░   ▒     ░ ░    ▒ ░  ░       ▒ ▒ ░░  
             ░  ░              ░  ░    ░  ░ ░            ░ ░     
                                                         ░ ░     
";
            EscribirCentrado(fatality);
        }

        public void mostarPersonajeAscii(string nombre)
        {

            switch (nombre)
            {
                case "Raiden":
                string raiden=@"
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@%###*#+==%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@###*****#%%#%%%#%%#%###*+-=--:@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
*##*########%%##%%#%%%#%%#%###**+--:--=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
##%%##%%%#%%%%%%%%#%%%%##%#*#***==---:--+%@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@%%%%%%%%%%%%%%%%#%%##%####**+#+=+---------%@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@#####%%%%%##%%##%#*#**+*==+:=-:=--=:-=@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@%######*#%###%*+*+=+==-==-=-:-----=@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@%#**##*****++*+--===-=-==-=--=-+@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@%%#*=-=+++-=+-===:-+=:=------=%@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@%#*#++-::-++:=+====::-:--=---%@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@%#+=-::-+++=:-===+---:--------%@@@@@@@@@@@@@@
*#*#@@@@@@@@@@@@@@@@@@@@@@%%+-:::=+::.-*#+-===-=----=-:--#@@@@@@@@@@@@
#+=*#**@@@@@%*#%@@@@@@@@%@@%*=:-**#-.:@@@@@@@%*======------#@@@@@@@@@@
*+##+**=*#%@#@@@@@@@@@%%%%%#*+*#%%#-:%@@@@@@@@@@@@@%#+=====-=*@@@@@@@@
+##**+*#*%%#@@@@@@@@@@%%%%%#****+=-=@@@@@@@@@@@@@@@@@@@@@@%*+==+@@@@@@
*#+*+***#%%#@@@@@@@@@@@@@%%#**#*+*#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
#*+****#%%#*@@@@%@@@@@@@@@@%*+**++@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
#+*##*##%%#=@@@@%@@@@@@@@@@@%*=:-%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
++*#**#%##*+*@@@@%%@@@%@%%%%%#%%*=%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
+*#***##*+++##%@@@%%%%##%#*+*%%#*=+=%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
*##**##+---*%%#%@%%%%%#*++*%%#**=**=-=%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
##***#*-.:+##%%#*%%%+=-=*%%#***+*#*+==++=*@@@@@@@@@@@@@@@@@@@@@@@@@@@@
#***#*-..=#######%%+==+#%#***++##*+++***+*+*@@@@@@@@@@@@@@@@@@@@@@@@@@
***##=:.=##%+-*###=::=*##**++*#*+*+*##*#***+=-+#@@@@@@@@@@@@@@@@@@@@@@
**##+:.=#########=:-+##***+*#+=+***##*#%#+::::-------==##*=-:*@@@@@@@@
+*#*:.=##+-+*###=:-*##***+*+==*++##*#%%#+=--:::...:--+--=*@@%*=+--@@@@
+##=:+#######*#=:=##****++==+*+*#**#%%#***+++===---=+*+-#@@@@%**##+*@@
*#+:+#*#*#*###=-+##**###**********#%%#******+++++--+=+%@@@@@@%**=#+=@@
#*-+*##+=+###=-*##*###%%%%#**++***#%#*=--=++++====*%*=+@@@@+:::=+*#+@@
%++####%*##%+=*##*#%%%%*=+*%%#***#%##*+++===----::%@%*-#@@@%#*+--*#@@@
#*#**++####*+##*+*%#%%#+=+*%%##*#%#+===-:::::::::.#@@#+-=#%*=*%*+%@@@@
####%#*#*%#*#***+=##%%%#**#%##*#%*++=-::::::....::#@@@#+=-++*#***@@@@@
%%%%%%#%%%#%#***--=#++####%####%#++==--:::::....:.@@@@%**#+=-:*-*@@@@@
@%%+=#@@%%####+=====+#%#*#%%####*+++==----:::::..:@@@@@#**%%#+-+%@@@@@
@@@%#%%@@%%%#*+**+==+#*+++####+***##%##*+=--:::..#@@@@@%*##%%*=-#@@@@@
@@@%@@@@@@%####**++*#**+*######*#%%%%%%%#*+--:::+@@@@@@@#+%##*=:%@@@@@
@@@@@@@@@%%%%####*######%###+=+%%%%%%%%%##*=--:*@@@@@@@@%%#%*+:.%@@@@@
@@%%%@%%%%%%%%%%#%%##%%%%%#*++*%%%@@@%#+++-::..*@@@@@#%%%%#%*=:*@#@@@@
%#**#%%%@@@@@@@@@%%%%%%@%*+=+#@%%%@@@@%#**+-:::+@@##+*@%#%%%#+=@@#%@@@
*****#%%%%%%%@@@@%%%%%@#*++#@@@@%%%%@@%#*=::::=#*+:-+#@%%%@%#*%@#%@@@@
#**#########%%%%%%%%%%#*+=%@@@@@@%%%@@@%*=::=%#:-=+#*%%@%%%#*%#@@@@@@@
#%#########%%%%%%%%@#+=-*@@@@@@@@%%@@@@@%#++@%#*#*#*##%#%@%%%%@@@@@@@@
%######%%%%%%%###%%*+=*@@@@@@@@@@%%%%@@@@%#%@%@%%+*###%##%%*%@@@@@@@@@
%%%%#%%%%%########+==%@@@@@@@@@@@@%%%%@@@#+#@@%@%%**#%%%%%*%@@@@@@@@@@
";
                EscribirCentrado(raiden);
                break;

                case "Liu Kang":
                string liuKang=@"
@@@@@@@@@@@@@@@@@@@@@@@@%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@%@@@@%%#%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@%@@@@@%%@%#%%#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@%%@%%#%@@@@%%@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@%%%#%@@@%%@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@%%@@%@@@@@@@@@@@@@@%#%#+*@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@%%%@@%%@@@@@@@@@@@@@##%#*+*%@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@##%@@@@@%#@@@@@@@@@@@%@%=*=+**@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@#*##%@@@@@@@@##%@@@@@%**#*%@@#%%**@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@%#@@@@@@%*--=+*#+++-@@@@@@@@@@@@@@@@@@@@@@@@@@@@
**++=+#@@@@%@@@@@@@@@@@@@@@@@@@#+--+##=::+@@@@@@@@@@@@@@@@@@@@@@@@@@@@
*+++****+#@@@@@@@@@@@@@@@@@@@@@@##%@*#=--@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
++=---=+*@@@@@@@@@@@@@@@@@@@@@@@%##*##=+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
+==---=+*%%@@@@@@@@@@@%%@@@@@@@@%%%%#+=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
**++***##***#@@@%%@@@@#*%@@@@@@@@%###+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
%%%%%%%%#%#*+*###%@@@%*++*#%%%%@@%+--@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@%%%%%##****#*+++#%%@#++====-=--=+**@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
%%%##****++++***==*#%*++++---:-=+++===#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
%%%#****+++++==+*+=+*+**++==-=+++*++===-=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
%%#**++++++======++*###*+++*##*****++=====-%@@@@@@@@@@@@@@@@@@@@@@@@@@
%%##*+++====---=++*%#*+==++++++++*++++**#*+++#@@@@@@@@@@@@@@@@@@@@@@@@
%%#**++===-----=+*%%*+========+++++++*####*++==-=%@@@@@@@@@@@@@@@@@@@@
%##*++===--::-=+#%%#*+==========---=+*####**+=---:-@@@@@@@@@@@@@@@@@@@
%%#*++===----=+#%%#*+==----------:::-+*###**=-----::#@@@@@@@@@@@@@@@@@
@%##*+=====+*#%%%#*+=+++-::--:::::::-=*####*+--::-:::%@@@@@@@@@@@@@@@@
@@%%#**+++++*%%%#*+=+*#+-::.:::::::--+*#####+=-::::::-@@@@@@@@@@@@@@@@
@@%%%%####**#@%#*+=+*%#=:--::::::--=++*%%%%#*+=----::.%@@@@@@@@@@@@@@@
@@%%##*+==+#%@%#*+++##%#=-::--::-=++**#@@@%%#**+==--::+@@@@@@@@@@@@@@@
@%%%#*+===#%%%@%##*%#%*=:::-----#%%%##%@@@%%%##*++=--:*@@@@@@@@@@@@@@@
@%%%#*===*%%#%%%%%@%%###+=-::--+%%%%@@#*#@@%%%##**+--:*@@@@@@@@@@@@@@@
@%%%#*+=+%@%####%%%@%%%%###+=--+#**#%@##*++=%%%##*+=-:-@@@@@@@@@@@@@@@
@###%%#*#%@%%#*==+*#%@@@@@%%%#**%##+*%%*###+*#%%#*+=-::*@@@@@@@@@@@@@@
@#*++++*#%%%%##++++++**#%%%@@@@@@@@#**%###%#*==***+=-:::@@@@@@@@@@@@@@
@@#*+==+#%%##*++=----++*******#%@@@@%+*%*##*#%#**#*=-:::*@@@@@@@@@@@@@
@@%#*++*%%%#*+=---=+**+++*####%@@@@@@%**%+#%%*###*+*=-::=@@@@@@@@@@@@@
%%%##*#%%@%%##****+=-=*#####%@@@@@@@@@@%#%*#**##*#%*+#-:-@@@@@@@@@@@@@
@@%#+=+#%%###********+==+*%@@@@@@@@@@@@@%###*##%%%#%**++-@@@@@@@@@@@@@
%%%%%%#%%%#*+=---=+##+++#%@@@@@@@@@@@@@@@%##%*##**##*+*+*%@@@@@@@@@@@@
@@@%%%%%%%%#%%##*#%##%%%#%@@@@@@@@@@@@@@@@@#*#%*#**%#%####%@@@@@@@@@@@
@@@@#**#%#%%#*+==*#%@%%#%%%@@@@@@@@@@@@@@@@@%#+*%%#*#%%%##@@@@@@@@@@@@
";
                EscribirCentrado(liuKang);
                break;

                case "Kung Lao":
                string kungLao = @"
@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%#*#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%%%##@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%###%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@
**#%%@@@@@@@@@@@@@@@%%%@@@@@@@@@%%####%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@
+-=---=++++***#####%@@@@@@@@@@@@%%###%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@%#+-::::-+#%%%%%%@@@@@@@@@%#***##%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@%#+=-:--=+#%%%%%%@@%%#####%%##*@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@%@%+=---=+*#%%%%#******##%@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@##@@@@@@@#+-::-=-=+***++**++*@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@*%%%@@@%%**%%%%%#+-:...::-=+*++++*@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@%+#%%@@##%@@%%%#=-::-*%*+#*#@@#+=:.   .:-==*%@@@@@@@@@@@@
@@@@@@@@@@@@@%+@@@@@%%%@%%%%%*-...:**.. @@@@@@@@@@@%*=:::---=#@@@@@@@@
@@@@@@@@@@@@@@##@@@@@@@@%%%%%%*-:+#+=. -@@@@@@@@@@@@@@@@@@@@@%#*%@@@@@
@@@@@@@@%##%@@@+%@@@@@@@@%%%%#+-===+#:=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
%=##%%%%%%%%@@@@*%@@@@@@@@%%#*+##+=-:+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
+#@@%%%%%%%%@@@@@*#%%%@@@@@%%*+##+=+=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
=@@@@@@@@@@@@@@@@@%**+*@@@@@%#*+=--=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
#@@@@@@@@@@@@@@@@@@@#+*##**#%@@#-:.%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
%@@@@@@@@@@@@@@@@@@@@=+**####**#####@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
%@@@@@@@@@@@@%%%%%%%%*+%@@%%%%#%%%%##%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
%@@@@@@@@%%%%%%####%%*%%%%%%%%###%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@%%%%%%####%#+%%########%#%%####%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@%#%%@@%%%%%%%*+%#############%%%%%%=@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@%##%%%@@%%++##+++################%%%+=@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@%%%#%%%%%%%%%%%*=-*****####%%#####%%#--+@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@#%%##@%%+=*%%##%**%%###%#%%%#######%#=*+==--*@@@@@@@@@@@@@@@@@@@@@@
@@@%#%#%%%#+++*##%%**%%###%%####*####%#=***+=-::.-@@@@@@@@@@@@@@@@@@@@
@@%%*+%@%%+=###**%#+@%#**#+*+##%*###%#:+**++=-:::..*@@@@@@@@@@@@@@@@@@
@@#*+++***++*##*#@+*@%**#*=--*##*###%-:=**+==-::....+@@@@@@@@@@@@@@@@@
@@@%#%%***=*#***%%+%%#####*-**###*#%*::-**++=-::.....%@@@@@@@@@@@@@@@@
@@@@@@@%%##%#*+**--*%#**++.-#*#***%%-:::+#**+=-:.....+@@@@@@@@@@@@@@@@
@@@@@@@@@@%@%##%#--***+*#=-=:---*#%*-..-****++=-:::::+@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@%#%#+@%#*#%##++==+-+#@=-.=@%%###**+***-..-%@@@@@@@@@@@@@@
%%%%%%%@@@@@@#*%+#@@%%%%%#%#*#**+#%-.*@@@%%%#%#+=+*##%#*@@@@@@@@@@@@@@
@%%%%%%%%%%##*##*#@@@@@@@@%%%%###%#--@@@@%%%= :*%%%#+*++%@@@@@@@@@@@@@
@@@%%%%%#****#*=+####%%@@@@@@@+#%%*=@%+*%@%#*%%%%%#*##+*=@@@@@@@@@@@@@
@@%%%%%%%%#=-..:::..::-:::::-=:#%%#%%@%-%%#@@%%#####%#%+:=#@@@@@@@@@@@
@@@%%####=======**+++*+-:.:--=+=#%%%%@@#=%*=++##%%+-=***==+%@@@@@@@@@@
@@@@@%%%@%####+++==--==++=-::-=+=*%%%%@@=%%#+**---=***+-:..#@@@@@@@@@@
@@@@@%%###***=:==**=-::..:=++=-----#%%%%*##%##%%+.  :==%+:..@@@@@@@@@@
@@%%%%##%%%%#++%#+-====+##=:-:::::-=+=*##%%%%%%*+=*+- .%%*..+@@@@@@@@@
";
                EscribirCentrado(kungLao);
                break;

                case "Johnny Cage":
                string johnny=@"
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%@%%@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%##%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#%@@@@@%#%@@%@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*::-=+*#+=@%@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@-::-=+**+=@%@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@###%#%@@@@%%@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#*#%:#%@@%=#%@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*=-=+-**@@#+#%@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*====#@@@%*#@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+=-+#%@@%#%@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*#=:+%@%%##@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%--*%@@@@@*+@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%#:--=+++%%#==@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@%=-----=+--=======+*+====++----%@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@%-:::-=*=--::--:---=++-===---::::::-+*#@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@::.::-**--==----====::-------====-:-::...:%@@@@@@@@@@@
@@@@@@@@@@@@@@@=-===--=+*###+:++=--:::---========-:::::::..-@@@@@@@@@@
@@@@@@@@@@@@@@------=+##########*+=-+++-==+++=--=+*#*+++++=-#@@@@@@@@@
@@@@@@@@@@@@@%::-=+#%#%@@%###*#%%%#%##@%#%%#+=+*#%%%=::-###+*@@@@@@@@@
@@@@@@@@@@@@@=------=+#%@@@@%%####%%@*=-::-+@%*+++++++++=+%+#@@@@@@@@@
@@@@@@@@@@@@-::::.::::##%%%%@@%%##%%=--==-==-:.:-=*#%%%#*+-*@@@@@@@@@@
@@@@@@@@@@@+::::.....:**%%%#%@@@%%%*=:-=++=+****+*###%##+-#@@@@@@@@@@@
@@@@@@@@@@@=-::::--===#%@@@@@@@@@@%=::-=+****#%%%%%#+=--:*@@@@@@@@@@@@
@@@@@@@@@@@@#**+++++=+%@@@@@@@@@@@@+-====++**#@@@%*==*%@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@%%%%@@@@@@@@@@@@@@@@%*###%##%%@@%#+==@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%--=+++#@@@@@@%*-::%@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@+@@%*==+-::-=**##%@@@%%*-:+@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@=:::::--::-=+#%@@@@@%%#==@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@:::...::..:=*%@@@@@@%#**@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@%:::...:..:=+#%@@@%%%%#+@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@=:-...::..:=+%%%@%**##*-@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@=-.---::::--==+++=--=+#*=-@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@%.-=+--::-==*+***#%#*#%%#=-@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@=.--+-..-+-+*+###%@@**%%%**@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@=:-=+=-:=++=**##%%@@*#%%%+-#@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@%#%%#########%#@@@@##%@@%*%@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@%%%%%%%%%@@@@@@@@@@@@@@@@@%%@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@%####%%%##%%@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@%%#####%%###%@@@%%%%%@@@@@@@@%#@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@###***##%%%%@@@%%%%%%%@@@@@@@%#@@@@@@@@@@@@@@@@@@@@@@
";
                EscribirCentrado(johnny);
                break;

                case "Cyrax":
                case "Sektor":
                string cyrax = @"
@@@@@@@@@@@@@@@@@@@@@@@@@#*#+*%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@%@@@@@###*####*-:*#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@%@@@@%#%@@%@@%###-++*%#+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@%%@%@@%#@@@@@@%%##@=--**#+:@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@%%@@@@%%*@@%@@#%*##@==:.##@=-@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@%%%%@@%@#%@@@@@%%#%*%=-:.%#@=.@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@%@%@%@@*%@@@@@%#@@#*-:-=-##@+:%@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@%%@@%@%%%%@@@%@%%@@##:...=%#%+:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@%@%@%@@@@%%@@@%@%*%@@*----=##+..@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
*++**####@%@%%@@@@#%%@@%%%%#%*++*%#%#*:.-@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
%*%#%%*+##%%%%@@@@*@@@@%%%#*+=*%%@@=.:=#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
****#:*#@%%-%%@@@#%*%@@@@%#++..-+#%:..:@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
***#+.*@@@@*=%#%%@%%@@@@@@%+.:=-+#+....@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
++++.-@@%##*#@@@@@%@@@@@@@@@%=*+%%=:.=%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
=+=:.%%%#*+*=@@@@%*@@@@@@@%@%+*@%#:..*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
##%%%#**=*+*++@%%%#@@@@%@@@%%%%%%#-:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
*#+%##*+*#*****#%%##%#**%%%@#@%%%++*#%@@%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@
%%+#%%*-=#%@#*##**%%%%%%##@@@@%%%%%#@@*@@%##@@@@@@@@@@@@@@@@@@@@@@@@@@
%%+@%%#+#****%%**%%#+**#%%@%%%%%%%%%%%%%@@**+%@@@@@@@@@@@@@@@@@@@@@@@@
%+#@%##*+*+++-=@*=#*==+######****%##%%%@@%-==++%@@@@@@@@@@@@@@@@@@@@@@
#:@@%**#%%*+---=+-=*#@+==*#%%%%%@++*###@%-:::*+:#@@@@@@@@@@@@@%%%%@@@@
%-@%%#*#%%%#*=-=:.=*##%@%##**#%@*--=+**#-:-::.:-:%@@@@@@@@%%#**+++=*-@
#-%%#*##*##++=+:+=#*####*-==+*@*++=+%:.%-:::....:-@@@@@@@@@%%%*#==*:*%
%+=%###+%+===++-#%#@@###*%%%%%*--=+**:-#+....:#-:-*@@@@@@@%%###%#=:=:@
##@**#%+-----===#%%@#*#*+*%%%*=+===%-.=**....:*%-:-@@@@@@@%#@%=:**+-:@
%%##***+==-----*%@@#=+++==+*#*=::-++:.%+**+-..:+*=:#@@@@@@@@%#*%#*-:-@
##%%####++**=-=#%@@=--:---+##=::-*+:..%%%%%%+++=:..=@@@@@@@@@%+%*--:#@
######*-:=+=:=#%%@@*+===-:+%%+++#=...:@@@%%###*#@#*@@@@@@@@@@%**---:@@
@%####*..---+#%%%@%-=-+++#****#---:..#@@@@%=:..*@@@@@@@@@@@@@%#+---=@@
@@@@@@@+==+*%@*#%@@+=====*+***#*=-::=*@@*=#@%##=*%@@@@@@@@@%@@%*=+*@@@
*#####%%@@%%##%**%@+-:.-#*####**+--:*@@%*@@@@%#*=+@@@@@@@@@@%@@%%#%@@@
+*****##=##%%%%+=#@@%=******#*****=:%@@@*@@@@%###**@@@@%@@@@@%%%##@@@@
**#**#*+**==+#=+###%@%%%%%#*####*+=+@@@@#@@@@@%#*+=%@%#@@%%%%@##*-%@@@
*##%%%%%=+:#*%::-:--+++*#%@@%#*=:.+@@@@@@@%%%%%#**++@@%@##%%%#%*-#@@@@
@@**++=-#*=+%=+.:.::...:::--:.:. *@@@@@@@%%%%%%#+#%@@@%@%##%###--@@@@@
%@#**=.:*#++#+.**#%+.......=.:..#@@@@@@@@%%%%%#%%@%@@%%%@%%###=-#@@@@@
%%%*++:.:*+%:-%%#**++*-.::-.=-=@@@@@@@@@@%%%#%@@@@%@*#%%%%###+:-@@@@@@
#%@#**-.-:-**%*-::.---*#=:--=%@@@@@@@@@@@@%%*%@@@@%@%#*%%%%#*-.#@@@@@@
=:--*@%%==-+-:---:----+@*+=+@@@@@@@@@@@@@@%%%@@@@#%%@%%%#%%#=:=@@@@@@@
#%#*+@#*#%#+==+*#+--=-%%==%@@@@@@@@@@@@@@@@%@@@@%%#@%@%#%%#+:.%@@@@@@@
++==#@**#*##**+=*=====+#@@@@@@@@@@@@@@@@@@@@@@@%%%%%@%#%%#*-:-@@@@@@@@
#%#*%*=%%##====#*+==+%*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#%%%#=:-@@@@@@@@@
";
                EscribirCentrado(cyrax);
                break;

                case "Scorpion":
                string scorpion = @"
@@@@@@@@@%@@#++*@@@@@@@@@@@@#*+=*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@#+*#@@@@@@@*:-=====+:==+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@%*+#@@@@@*+*##%@@%*++-=+=+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@%**%@@@@#%%@@@%%%###=**:++-#@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@
@@@@@@@@@@@@@#+@@@@%@@@@@@@@*+**#+*#-+=-%@@@@@@@@@@@@@@%@@@@@@@@@@@@@@
@@@@@@@@@@@@@###@@@@@@@@@@@%#++*+=*#+-+-+%@@@@@@@@@@@@#@@@@@@@@@@@@@@@
=:+%@@@@@@@@@%%@@@@@@@@@@@%%*+%*+-=**+**=*@@@@*====*###@@@@@@@@@@@@@@@
===--*+**=*@@%#%@@@@@@@@@@%@%++*=-=#-:-+=*@@#%%++==*##@@@@@@@@@@@@@@@@
*=+=+#*-##*::**#@@@@@@@@%@@@@%*:-+=+#=**+-%%%%*++*##@@@@@@@@@@@@@@@@@@
#%##***+#=-=#==%@@@@@@@@@%@%@@@@%#*=*+=+=-%%##%%@#%@@@@@@@@@@@@@@@@@@@
%%%%%%#*+::.:%%#@@@@@@@@@%@%***==#%%%#++###%@@@@@@@@@@@@@@@@@@@@@@@@@@
%%%%%###*-...-*%%@@@@@@@@@@%##+-::**.=-*%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@
%%%#####%%%###@@@@@@@@@@%%%@%=+=*+=+=.-%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
+*%%###**##%@@@@@@@@@@@@@@#+#%%%#=:-==-%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
*=+**+*#%%@@@@@@@@@@@@@@%@@%*++%#*==-+*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
#+*+=*%@%@@@@@@@@@@@@@@@@%%@@%%+=::-=+#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
%@@%%%%@@@@@@@@@@@@@@@@@@@@#*%@%%--*+=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
##**##%*@@@@@@@%@@@@@@@@@@@@%##+*++*#-==%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
#*+**#*%@@@@@@@@@@%%%%%%%%@@@@@%%*++*==**-#@@@@@@@@@@@@@@@@@@@@@@@@@@@
*=+=#*#@@@@%%%@@@#@@#%%%%%@@@@%@@@%*-*%#+*#*@@@@@@@@@@@@@@@@@@@@@@@@@@
++=#**@@@@@@#%%@@@%%%%%@%%@@@%%%@@+*=+@+*##++@@@@@@@@@@@@@@@@@@@@@@@@@
-==#+%@%%%%#*###%@%==+**#%@#*+#@@@%+=-#**%%#*+%@@@@@@@@@@@@@@@@@@@@@@@
=:#**%@%###%#######@@%@@%%+*+###%@@%*+++#####*+++#%@@@@@@%+*#@@@@@@@@@
.+#+@%%%=++==*%@%**%%@@@#=+-*++*#%@@@%#==+####*##*+=++%@@@@%+%@@@@@@@@
:#+#%#%++%%%#%**@%#++*%+=+-*==+*###**%@%#+===#*##*###***#%@%%@@@@@@@@@
+#+#%#+*#%**+#%#*+%##%====*==+***+=+=+#+@%%#+=-++=+*******%@@@@@@@@@@@
%**#%+*%#*+++##**%#%%-=-=+-=++++=-=:===%*===+*#*##%%%%@@@@@@@@@@@@@@@@
#+#*%*+%%%++*##+##%*-+:+=-=+++=---:+-+#+-::......:=@@@@@@@@@@@@@@@@@@@
##%+*%+@%+*#%*++#@+-+.*+==+++-:+:-+:**+-::.........+@@@@@@@@@@@@@@@@@@
##%+#%*@#%%**%%%%===.:+======-=:-+:*#*=-::..........#@@@@@@@@@@@@@@@@@
*#%*%**@%#*%%##%==+.:*=---=+=::=-=##%#*+=-:........-*@@@@@@@@@@@@@@@@@
**#*@++#+#@%#@%-==.-*===-+=..-=:**#@@%%#*=-:.....-+:-*@@@@@@@@@@@@@@@@
*@@%%*=+%@%@@#-...:*===-+:.:-=-#+#@@@@@%%#+=::.=*=-:+::#@@@@@@@@@@@@@@
*@@%%###@%@@*=*#+:. .-+-:.-==*%+#@@@@@@@@%*+-+##+:-+:.:-=%@@@@@@@@@@@@
*##@%#@@%@%++*-:=-.:::-**##**+*%@@@@@@@@@%##%%#-:**+*+:.:=+@@@@@@@@@@@
*#*%%@%%@#+*=-::=*#=..:#%%#****+*#@@@@@@%+%%%*+#%##*-:.:*=-*@@@@@@@@@@
*@@@@%@%##*=--=+**==*-.=%%++###%=*###@@@%*-::+-+#*==-:=*--=.*@@@@@@@@@
**%@@@%%#*+===**=-===*#=:.*%%%#####%+%@@@@*+**#=:.*#-...:+*=:*@@@@@@@@
*#@@@%%#*+++====-==+*+*%#%%#**##%+%@+#%@@@@*.==+::-+#+-=+##*+=-%@@@@@@
";
                EscribirCentrado(scorpion);
                break;

                case "Sub-Zero":
                string subzero = @"
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@%**#%%%%#*=+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@#%@@@@@@@@@@@%*-%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@%%#++@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@%%##*@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%####*#@@@@@@@@@@@@@@@@@@@@@@@@@@@
+*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%###***@@@@@@@@@@@@@@@@@@@@@@@@@@@
**+=+@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@%###****@@@@@@@@@@@@@@@@@@@@@@@@@@@
###****#@@@@@@@@@@@@@@@@@@@@@@@@@@%%###***#@@@@@@@@@@@@@@@@@@@@@@@@@@@
##########*+**+#@@@@@@@@@#%@@%*@%#@#*%##*+%@@@@@@@@@@@@@@@@@@@@@@@@@@@
*########***%%%%####%@@@@@@@@%+*--+%#=#*-#@@@@@@@@@@@@@@@@@@@@@@@@@@@@
****###%##*%@%@@#@##%@@@@@@@@#+**##%%%+--*@@@@@@@@@@@@@@@@@@@@@@@@@@@@
******##***@%%@%@@@@@@@@@%@@@@@*=*#%%#=:-%@@@@@@@@@@@@@@@@@@@@@@@@@@@@
******%***%@%@@@@@@@@@@@@@%@@@@@@%+##-@=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
*****##***@%%@@@%@@@@@@@@@%%@@@@#@%%###@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
*****#***#@%@%%%%@@@@@@@@@%%%%#%%@%*=#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
*****#***%%%@%%%%%@@%@@@@@@%%%%%@%@%%#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
****##***@%%%%@#%#%@@@@@@@@@@@@%@%*+=*%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
****#***#%%%%%%#%#%@@%%%%@%%%%%%@%*%=%#*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
*####***@%%%%%%####%@%%%%%%%%%%%%%@@%%##*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
*##%*#*#%%%%%#%####%%%%%%%%%%%%%%@@%%%#%#*#@@@@@@@@@@@@@@@@@@@@@@@@@@@
**+#%##%%%%%#######%%#%%%%%%%%%%@%@%%#%%+*##@@@@@@@@@@@@@@@@@@@@@@@@@@
*##****#%%%%##%#####%%%%%%%%%%%@%%%%#%%#+##+#@@@@@@@@@@@@@@@@@@*=+@@@@
++*++++###%%##%%%#%%%###%#%%%%@%%%%####*##*+#+@@@@@@@@@@@@@@@@@@%*-#@@
++**+++%%##%%#%%%%####%##%%%@@%%%%#######*+##***@@@@@@@@@@@@@@@@@@*-#@
****+**%%%%%%%#####%#*%%%#%@%%%%%#**#**#**###+**#%@@@@@@@%+==-%@@%%+=@
#******@%%@%###%%##%%%%##%@%%%%#***#*****##****#%@@@@%+-:-=@%*-:-#*#@@
*******@%%@@%###%%%###%@@%%%%#*#*#****#****##%%#+@@@@@@*++=-=#@#+-@@@@
#*+##**@%%@@%%#####*#@@%%%%#****#**#****#%%%%%*+*@@@@@@@%#-:-*%+-#@@@@
#####**@%%%%######%@@%%%%#********###%%#=-=%*+++=@@@@@@@@@%#+---+*@@@@
***##**%%%%@%%#%@@%%%%%**********#%+---::-*#*==+@@@@@@@@@@@@#=::-#@@@@
%#%%#**#%%%@@@%@%%%%%**********#@%#+=--:::*%*#++:@@@@@%#++*=+*==#*@@@@
%#%#%###@%%%%%%%@%######*****#%%%@%*++=-:-%%#==+#@@@@@@@%*=-:*##**@@@@
%%%%@@@@%%%%%%%%%####+==++**%@%%%%%#***#%%%%%#-=-@@@@@@@@#+=*##*+#%%@@
@@@@@@%%%%%%%%%%%###*+*+**%@@@@%%@@@@@%%%##%+==+:@@@@@%#@%**##**#@@%%@
%%%%%%%%%%%%%%%%%%#####%@@@@@%@@@@@@%*++=-:%*++==:%%+%%%@%##%%##%@@#@@
%%%###%%#%%%#####%@@@@@@@@@@@@@%%*#@%#*=--:+%*+%%+%#%@@%%@%@#%%%#*@@@@
%%###########*#%#@@@@@@@@@@@@@@@%**%@%*+==--#%%@%%@@@@@@%%@%@@%#%@@@@@
*****##%%%%%%#*%@@@@@@@@@@@@@@@@@#*#%%##@@@%@@@@@%%@@@@@%@%###%+@@@@@@
***#########*###%@@@@@@@@@@@@@@@%%@@@@@@@@%@@@@@%@@@@@@@%%%%#%@@@@@@@@
+++===++*+==*%##@@@@@@@@@@@@@@@@@%@@@%#%%%%@@@@@@%@@@@@@#%%%#@@@@@@@@@
";
                EscribirCentrado(subzero);
                break;

                case "Fujin":
                string fujin = @"
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@####**++*#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@%*+**++*++++***#%@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@#*#*+=#*++-++++=++==+#@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@%#++**+=***+++=====++++++#@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@%##*#%%#*##++=====++===+*#**%@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@%%##*+++==*#%#++====+***++++#@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@##*++===--=*#%%#+==+==**##*+*%@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@%##*++===----=*#%%#==+=+**####%@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@###*++=------:-=#%%#+=+==****#%@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@###**++====------*%%#==+=**++*%@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@###%#%%%*+#%%%#*+=+%%*-+++*+***+==++*%%@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@#####%@%+=%@@+-*#%**%#===+*+==+#%@@%%%%####%%%@@@
@@@@@@@@@@@@@@@@@@@@%#######*-:=+###*==--+%++===+#%%#**#@@@%%%%%%%%%%@
@@@@@@@@@@@@@@@@@@@@%#**+=+*=::--=+==-----*++**+**++++#@%###%%%%%%%%%%
@@@@@@@@@@@@@@@@@@@@%##*++*+=---++===-====**=+++==+++***+*#%%%%%%%%%%%
@@@@@@@@@@@@@@@@@@@@###***#%#%%#**++++****#+=+*#*#*+=+*#++#%%%%%%%%%%@
@@@@@@@@@@@@@@@@@@@%###*#####*+=--=++***+*#+#####%@%%%%#**#%%%######%%
@@@@@@@@@@@@@@@@@@%%#####%%%###*+*+==++++#**%%@@@@@@@@@@%%%%%##++*#%%%
@@@@@@@@@@@@@@@@@%###%%#####***++**+++++*%+%@@@@@@@@@@@@@@@@%%#***#%%%
@@@@@@@@@@@@@@@######%@@###*###**+++++*#%#+%@@@@@@@@@@@@%*=#%%%#+*#%%@
@@@@@@@@@@@@@%#****#%@@@@%#*+++===+*%@@@#**%@@@@@@@@@#+=-=+=--=*#%%@@@
@@@@@@@@@@@@@###**#%@@@@@@%%@%%%%@@%%%%#*#%*===-------::=+=-=*%@@@@@@@
@@@@@@@@@@@@@##*#%@@@@@@@@@@@@@@@@%%%@@@@@@@**+=------=#%*++*=+%@@@@@@
@@@@@@@@@@@@#**#%%%%@@@@@@@@@@@%%#%@@@@@@@@@##**+=---=*@@@@@@@%@@@@@@@
@@@@@@@@@@@@%%%%#####%%%%%%%@%%%@@@@@@@@@@@@%%@@@@*=+#@@@@@@@@@@@@@@@@
@@@@@@@@@@@@%%%%%%%%%%####%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@%%#****#%%%%%%####%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@#+====--------=*#%%%####*##*#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@*+=====------------=#%%%##******+++*##@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@%###*+++=-::--::::::---*%%#***#**+====*###%@%*++*+=*##%@@@@@@@@@@
%%%%%%%%%%%%%%%%%%%%%########%%######*+==+*=**#@@%%%%%##**####%@@@@@@@
%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%###%%%%*=*%%***+*@%%#*+++**##%@#@@@
%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%#####%###%%#*#**%%%%###*###%%%##@@
%%%%%%%####################%%%%%%%%%%%%%%%@%@@@%#%##@%%%%%%%%%%@@%%%@@
@@@###*++++===---==---==*#####***+**+===++*@%#@%@@@@@@%%%%%%%%%@@%@@@@
@@@###*+++++===========+%@%%%##**##*++++++%%%#%%%@@@@@@%%%%%%%##%%@@@@
@#%##*#*++*++==========*%@@%%%######**#@@@@%%####%%@@@@@@@%%%###%@@@@@
@@@%***#****++========++*%@@@%%%%%***#@@@@@@@@@@%%%%%%#%@@%%#####@@@@@
@@@@%#******#*++=======--=%@@@%@%%%###@@@@@@@@@@@@%%%%%%@@%%%%##%@@@@@
@@@@%#*++***#****+===----=+%@@@@@%%%%@@@@@@@@@@@@@@@@@@@@##%%%%+*@@@@@
@@@@@##*++==++++++====-----#@@@@@@@@@@@@@@@@@@@@@@%%@@@@@%%##*-+@@@@@@
@@@@@##++=====++++++=------*@@@@@@@@@@@@@@@@@%%%%%%%%%%@@@@%#=*@@@@@@@
@@@@@%#******+==--------=++#@@@@@@@@@@@@%#%%%%%%%%%%%%%%%%@@@@@@@@@@@@
@@@@@@##**+++========+#%%%@@@@@@@@@@@%%###%###%%%%%%%%@%%%%%@@@@@@@@@@
@@@@@@%#******++++*#%%%%%%%@@@@@@@%%######*###%%%%%%%%%@%%%@@@@@@@@@@@
@@@@@@@@#**++++#%%%%%%%%%%%@##%%%%######*#%%%%%%%%%@@@@%%%%@@@@@@@@@@@
";
                EscribirCentrado(fujin);
                break;

                case "Shinnok":
                string shinnok = @"
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%@@@@@@@%#@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@##%%%%@@@@@#@%%@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#%%%@@@@%@%%@%*@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@%%@%%%@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#%%@@@@@@%#%%*%@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*-*%%@@@#=:.##=@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%=*#%%%%#*+%++*@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+*#%@@%=-:-+:#@@@@@@@@@@@@@@@@@@@@
@@@@#+%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#**%@@%#=+%%=%@@@@@@@@@@@@@@@@@@@@
@@%*+%%=%@@@@@@@@@@@@%@@@@@@@@@@@@@@#*@%@%%#=#*+@@@@@@@@@@@@@@@@@@@@@@
@@#%@*==%#*#@@@@@@@@@@@@@@@@%:.*%@@@*+%@@@@@+--=@@@@@@@@@@@@@@@@@@@@@@
@@=-:-=-%@@@@@@@@@@%@%@@@@@@%**@@@%@%*@@@@@@@%+*@@@@@@@@@@@@@@@@@@@@@@
@+-**%**@@@@@@@@@@@@@*%#*%##%@@@@@%@@@@@@@@@%##@@%#**%@@@@@@@@@@@@@@@@
@%#%#%@%%@@@@@@@@@@%-=#%**+%@@@@@##@@@@@@@%%%#%@@%%%%#%@@@@@@@@@@@@@@@
@#@@@@%%%#@@@@@%+-:-+*+#%@%@*%%%###%%%%#%##%##%@@%#+=*%%%@@@@@@@@@@@@@
@#@@@@@@%%#@*--=++*%%@**+%%#%##%=#%@%%%%%%#%###@@@%%##%@%#@@###%@@@@@@
@@%@@%@@@%####+#%@@@@@%=:#@@@%@++%-*@%%%@@%=%%##@##=##%%@##%#%@@@@@@@@
@@@%@%%@%%%%%%%%%%%%@@@*#@%@%@@*=**-#%%*%%++%*#%@##:*#%##=-###%@@@@@@@
@@@@@%@@@%++#%@@@@@@@@@#@@@@@@@**+--=*#%%*+%##%##%@@*#%@**##@@@@@@@@@@
@@@%%@@@@%%@@@@@@@@@@@@%@@@@@@@#+*#+*#%%#+#%%##%%###@@%+-::=@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@%%%@@@@@@*#%%@@@#*%%%%%##++-+@@%+-:::-@@@@@@@@@
@@@%@@@@@@@@@@@@@@@@@@@@#%@@@@@@%%@@@@##@%%%###*#++*@@%%-.::.=@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@%%@@@@@%#@@@##@@@@@%%#****%@@@##:....%@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@%#%@@@@#=@@%%@@@@@@%#***++@@@@@##:...+@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@+*@@@@##@%#@%@@@@##**+++@@@@@@@%+::..*@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@==%%@@%*@##@@%%%#+*++=*@@@@@@@@@#*-...=@%@@@
@@@@@@@@@@@@@@@@@@@@@@@%@@*-#%@@###*%%#%%**=---=@@@@@@@@@@:+#+*==*@@@@
@@@@@@@@@@@@@@@@@@@@@@%%@%*++%%*+#=%%@%%#*=--:-@@@@@@@@@@@+.=%+=**#@@@
@@@@@@@@@@@@@@@@@@@@@@@@@%#=%*:+%%*%%%%*#=-::.+@@@@@@@@@@@%-#%%##%%@@@
@@@@@@@@@@@@@@@@@@@@@@@@%%+#*-%@%%@*+%%#+#+##:*@@@@@@@@@@@%@%@##***@@@
@@@@@@@@@@@@@@@@@@@@@@@%--#%#%@%%%%#-%%**%##%*#@@@@@@@@@@@@%@@%##%@@@@
@@@@@@@@@@@@@@@@@@@@@@@%+*#%@@@@@@@%%@@%%#%#%##@@@@@@@@@@@%@@@@@@@#%@@
@@@@@@@@@@@@@@@@@@@@@%%*%@#%@@@@@@@@@%%##*###%@@@@@@@@@@@@@@@@@%%%@@@@
@@@@@@@@@@@@@@@@@@@%##%@@*@%@@@@@@@@%%%%%#%@%%%@@@@@@@@@@@@@@@@@%%@@@@
";
                EscribirCentrado(shinnok);
                break;

                default:
                break;
            }
        }

        public void fatal()
        {
            string fatality = @"======================================================================
:::::::::-=####%###-:--:::::::---------=======+++++++++**********######
::::::::#%##=----###%#--::::::---------======+++++++++***********#####
::::::::::::::::::--=-:-::::::----------======++++++++***********#####
::::::::::--::--::-::::+=::::::---------=======++++++++**********#####
:::::::-:::::::::----=+=%+::::::--------========++++++++**********####
:::::::-:-==:::::=+:::+-*+-::::::-------========++++++++***********###
:::::::+:---:::::=+=---==**-:::::-------=========++++++++**********###
:::::::=:::::::::::-===--*+==-:::::----=++++*+====++++++++*********###
:::::::--=-::::-=-==:-====::==+-:::---=*+++****===++++++++**********##
::::::::-:==::::--==-:=-::::-==+==----+*+****##====+++++++*********###
::::::::::+=-::::-*=-:-:::::=+---**---=+*****#*===++++++++**********##
::::::::-=======**=-:::::=-=++-:-+#==+**+***+#=====++++++++*********##
::::::::::-=**####=:::::::==:::::=#+--=###*+#*=====++++++++*********##
:::::::::::--++#==-:::::::::-::-:-*+---=%#***#=====+++++++**********##
:::::::::::::=+#=:::::::::::--:::-+*=---*#+=+%#+===++++++++********###
:::::::::::::-+%-::::::::::::=-:-=*+----+#+++#+=+#+++++++++********###
:::::::::::::-+++::::::::::::-+==+*+----=##*#+++*#*++++++++********###
:::::::::::::-++#=::::::::::::=#:-=*=--==*%#*#*%#%*++++++++********###
::::::::::::::=++#=::::::::::::----*#+++*%%*=+#*%+**+++++++********###
::::::::::::::=###+:::::::::::::--=*##+=+#%+=+*%*++#*++++++********###
::::::::::::::*##%-:::::::::::::-==+++++=#%+**%+*##**+++++*********###
:::::::::::::+**%+::::::::::::::-=+******%%*#%##**###+++++*********###
::::::::::::-**%%+::::::::::::::-++++*++*##*#%*##**+**+++*********####
::::::::::::=##%%=::::::::::::--+*+*****#*###*=+++**+#*++********#####
:::::::::::=*#%%*:::::::::::---=++++**#%**%%%+=+++*%%%%+********######
::::::::::-+*#%%#:::::::::----===**++*#%+*%%%#+++##%%%%*********######
::::::::::+**%%#=:::::::-----=*#****###%+#%%%%*++*#%#%##********######
:::::::::-*%#%%*-:::::-------=*##**#*+##+*%#%%%+++#%#%%%********######
:::-------+%%%%%-:-----------*#*+++**+#%*###%#%#++*#%%%%*******#######
----------=#**%#%-----------==+=++=*++%%%#**#*+*++*%%#%%*******#######
----------+#**%%%=---------==+==++=+#*%%%%##**+*#**%%%%%******########
-----------*%%%%%=------=======++==++*%##%#*+**#**##%%##*****#########
===========+%%%*%%#========+**++++=++*%*#%+++***#**#%#******##########
============#%%%%#=========*#**#*+++*+++#++*#%##%**********###########
=============+%%%=========+++++++++*+++++*+*****#********#############
+++===========%#========++*%#*++++++++++*#**************#############%
++++++++++++==*+====++++++***##****+++++***###%%%#****#############%%%
+++++++++++++++*++++++++*#*+**##**+++++***####*#%#***##############%%%
+++++++++++++++++++++++*%#*****%*++++*****######%%**#############%%%%%
++++++++++++++++++++++*%%##***##**********#%%%%%%%#############%%%%%%%
***********+++++++++**#%##%%%%%**********#%%%%%%%%%###########%%%%%%%%
**********************#%###%%%%***********%%%%%#%%%########%%%%%%%%%%%
======================================================================";
            EscribirCentrado(fatality);
        }

        public void EscribirCentrado(string texto)
        {
            int ventanaAncho = Console.WindowWidth;
            string[] lineas = texto.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string linea in lineas)
            {
                int espaciosBlancos = (ventanaAncho - linea.Length) / 2;
                string espacios = new string(' ', Math.Max(espaciosBlancos, 0)); // Asegurar que no sea negativo
                Console.WriteLine(espacios + linea);
            }
        }

        public void TiempoDeTexto(string texto, int retrasoEnMilisegundos)
        {
            foreach (char c in texto)
            {
                Console.Write(c);
                Thread.Sleep(retrasoEnMilisegundos);
            }
            Console.WriteLine();
        }


        public void TiempoDeTextoCentrado(string texto, int retrasoEnMilisegundos)
        {
            int ventanaAncho = Console.WindowWidth;
            int textoLongitud = texto.Length;
            int espacios = (ventanaAncho - textoLongitud) / 2;

            if (espacios > 0)
            {
                Console.Write(new string(' ', espacios));
            }

            TiempoDeTexto(texto, retrasoEnMilisegundos);
        }
    }
}