using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cromatic0._10
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int opcion = 0;

            Console.WindowHeight = 39;
            Console.WindowWidth = 70;
            do
            {
    
                Console.BackgroundColor= ConsoleColor.Black;
                Console.ForegroundColor= ConsoleColor.DarkCyan;
                
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("\r\n░█████╗░██████╗░░█████╗░███╗░░░███╗░█████╗░████████╗██╗░█████╗░\r\n██╔══██╗██╔══██╗██╔══██╗████╗░████║██╔══██╗╚══██╔══╝██║██╔══██╗\r\n██║░░╚═╝██████╔╝██║░░██║██╔████╔██║███████║░░░██║░░░██║██║░░╚═╝\r\n██║░░██╗██╔══██╗██║░░██║██║╚██╔╝██║██╔══██║░░░██║░░░██║██║░░██╗\r\n╚█████╔╝██║░░██║╚█████╔╝██║░╚═╝░██║██║░░██║░░░██║░░░██║╚█████╔╝\r\n░╚════╝░╚═╝░░╚═╝░╚════╝░╚═╝░░░░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░╚════╝░");
                //Console.WriteLine("____ ____ ____ _  _ ____ ___ _ ____    ___  ____ ___ ____ \r\n|    |__/ |  | |\\/| |__|  |  | |       |__] |___  |  |__| \r\n|___ |  \\ |__| |  | |  |  |  | |___    |__] |___  |  |  | \r\n                                                          ");
                Console.WriteLine(" __   __    __     ___  ___ ___ _  _   ___  ___  _   _ ___  ___ ___ \r\n \\ \\ / /  __\\ \\   / _ \\| _ | __| \\| | / __|/ _ \\| | | | _ \\/ __| __|\r\n  \\ V /  |___> > | (_) |  _| _|| .` | \\__ | (_) | |_| |   | (__| _| \r\n   \\_/      /_/   \\___/|_| |___|_|\\_| |___/\\___/ \\___/|_|_\\\\___|___|\r\n                                                                    ");
                Console.WriteLine("╔══════════════════════════════════════════════╗\r\n          Version 0.10  - BY: DALEXUR  \r\n╚══════════════════════════════════════════════╝");
                Console.WriteLine("\n\n▼▼|| Seleccione el programa que desea ABRIR  ||▼▼");
                Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                Console.WriteLine("" +
                    "\n ► 0. - ♥♥ Acerca de → Donar al creador ♥♥" +                   
                    "\n ______________________________________" +
                    "\n\n ► 1. - Adobe Photoshop" +
                    "\n ► 2. - Adobe Illustrator" +
                    "\n ______________________________________" +
                    "\n --------------------------------------" +
                    
                    "\n ► 3. - Descargar Power Design 1.0" +

                    "\n --------------------------------------" +
                    "\n\n ► 4. - Salir\n");
                Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                Console.WriteLine("\nDigite una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 0:
                        System.Diagnostics.Process.Start("IExplore.exe", "Tu_Sitio_para_obtener_ayuda_voluntaria");
                        break;
                    case 1:
                        System.Console.Clear();
                        Console.WriteLine("\r\n░█████╗░██████╗░░█████╗░███╗░░░███╗░█████╗░████████╗██╗░█████╗░\r\n██╔══██╗██╔══██╗██╔══██╗████╗░████║██╔══██╗╚══██╔══╝██║██╔══██╗\r\n██║░░╚═╝██████╔╝██║░░██║██╔████╔██║███████║░░░██║░░░██║██║░░╚═╝\r\n██║░░██╗██╔══██╗██║░░██║██║╚██╔╝██║██╔══██║░░░██║░░░██║██║░░██╗\r\n╚█████╔╝██║░░██║╚█████╔╝██║░╚═╝░██║██║░░██║░░░██║░░░██║╚█████╔╝\r\n░╚════╝░╚═╝░░╚═╝░╚════╝░╚═╝░░░░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░╚════╝░");
                        //Console.WriteLine("____ ____ ____ _  _ ____ ___ _ ____    ___  ____ ___ ____ \r\n|    |__/ |  | |\\/| |__|  |  | |       |__] |___  |  |__| \r\n|___ |  \\ |__| |  | |  |  |  | |___    |__] |___  |  |  | \r\n                                                          ");
                        Console.WriteLine(" __   __    __     ___  ___ ___ _  _   ___  ___  _   _ ___  ___ ___ \r\n \\ \\ / /  __\\ \\   / _ \\| _ | __| \\| | / __|/ _ \\| | | | _ \\/ __| __|\r\n  \\ V /  |___> > | (_) |  _| _|| .` | \\__ | (_) | |_| |   | (__| _| \r\n   \\_/      /_/   \\___/|_| |___|_|\\_| |___/\\___/ \\___/|_|_\\\\___|___|\r\n                                                                    ");
                        Console.WriteLine("╔══════════════════════════════════════════════╗\r\n          Version 0.10  - BY: DALEXUR  \r\n╚══════════════════════════════════════════════╝");
                        
                        //Process.Start("nombreDelPuntoExe.exe");
                        Console.WriteLine("\nCONFIGURANDO - INICIANDO PROGRAMA 1");
                        Thread.Sleep(2000);
                        Console.WriteLine("\n██▒▒▒▒▒▒▒▒ 20%");
                        Thread.Sleep(2000);
                        Console.WriteLine("\n██████████ 100%");
                        Console.WriteLine("\n<< Abriendo Programa 1 >>");
                        Thread.Sleep(10000);
                        //Environment.Exit(0);
                        break;
                    case 2:
                        System.Console.Clear();
                        Console.WriteLine("\r\n░█████╗░██████╗░░█████╗░███╗░░░███╗░█████╗░████████╗██╗░█████╗░\r\n██╔══██╗██╔══██╗██╔══██╗████╗░████║██╔══██╗╚══██╔══╝██║██╔══██╗\r\n██║░░╚═╝██████╔╝██║░░██║██╔████╔██║███████║░░░██║░░░██║██║░░╚═╝\r\n██║░░██╗██╔══██╗██║░░██║██║╚██╔╝██║██╔══██║░░░██║░░░██║██║░░██╗\r\n╚█████╔╝██║░░██║╚█████╔╝██║░╚═╝░██║██║░░██║░░░██║░░░██║╚█████╔╝\r\n░╚════╝░╚═╝░░╚═╝░╚════╝░╚═╝░░░░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░╚════╝░");
                        //Console.WriteLine("____ ____ ____ _  _ ____ ___ _ ____    ___  ____ ___ ____ \r\n|    |__/ |  | |\\/| |__|  |  | |       |__] |___  |  |__| \r\n|___ |  \\ |__| |  | |  |  |  | |___    |__] |___  |  |  | \r\n                                                          ");
                        Console.WriteLine(" __   __    __     ___  ___ ___ _  _   ___  ___  _   _ ___  ___ ___ \r\n \\ \\ / /  __\\ \\   / _ \\| _ | __| \\| | / __|/ _ \\| | | | _ \\/ __| __|\r\n  \\ V /  |___> > | (_) |  _| _|| .` | \\__ | (_) | |_| |   | (__| _| \r\n   \\_/      /_/   \\___/|_| |___|_|\\_| |___/\\___/ \\___/|_|_\\\\___|___|\r\n                                                                    ");
                        Console.WriteLine("╔══════════════════════════════════════════════╗\r\n          Version 0.10  - BY: DALEXUR  \r\n╚══════════════════════════════════════════════╝");

                        //Process.Start("nombreDelPuntoExe.exe");
                        Console.WriteLine("\nCONFIGURANDO - INICIANDO PROGRAMA 2");
                        Thread.Sleep(2000);
                        Console.WriteLine("\n██▒▒▒▒▒▒▒▒ 20%");
                        Thread.Sleep(2000);
                        Console.WriteLine("\n██████████ 100%");
                        Console.WriteLine("\n<< Abriendo Programa 2 >>");
                        Thread.Sleep(10000);
                        //Environment.Exit(0);
                        break;
                    case 3:
                        System.Console.Clear();
                        Console.WriteLine("\r\n░█████╗░██████╗░░█████╗░███╗░░░███╗░█████╗░████████╗██╗░█████╗░\r\n██╔══██╗██╔══██╗██╔══██╗████╗░████║██╔══██╗╚══██╔══╝██║██╔══██╗\r\n██║░░╚═╝██████╔╝██║░░██║██╔████╔██║███████║░░░██║░░░██║██║░░╚═╝\r\n██║░░██╗██╔══██╗██║░░██║██║╚██╔╝██║██╔══██║░░░██║░░░██║██║░░██╗\r\n╚█████╔╝██║░░██║╚█████╔╝██║░╚═╝░██║██║░░██║░░░██║░░░██║╚█████╔╝\r\n░╚════╝░╚═╝░░╚═╝░╚════╝░╚═╝░░░░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░╚════╝░");
                        //Console.WriteLine("____ ____ ____ _  _ ____ ___ _ ____    ___  ____ ___ ____ \r\n|    |__/ |  | |\\/| |__|  |  | |       |__] |___  |  |__| \r\n|___ |  \\ |__| |  | |  |  |  | |___    |__] |___  |  |  | \r\n                                                          ");
                        Console.WriteLine(" __   __    __     ___  ___ ___ _  _   ___  ___  _   _ ___  ___ ___ \r\n \\ \\ / /  __\\ \\   / _ \\| _ | __| \\| | / __|/ _ \\| | | | _ \\/ __| __|\r\n  \\ V /  |___> > | (_) |  _| _|| .` | \\__ | (_) | |_| |   | (__| _| \r\n   \\_/      /_/   \\___/|_| |___|_|\\_| |___/\\___/ \\___/|_|_\\\\___|___|\r\n                                                                    ");
                        Console.WriteLine("╔══════════════════════════════════════════════╗\r\n          Version 0.10  - BY: DALEXUR  \r\n╚══════════════════════════════════════════════╝");

                        Console.WriteLine("\nDescargando Recurso");
                        Thread.Sleep(2000);
                        Console.WriteLine("\n██████████ 100%");
                        Console.WriteLine("\n<< Carga completa >>");
                        Thread.Sleep(2000);
                        //Process.Start("NombreDelPuntoExe.exe");
                        Thread.Sleep(5000);
                        //Environment.Exit(0);
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                        
                    default:
                        Console.WriteLine("Digite una opcion valida");
                    break;

                }
                Console.ReadKey();

            } while (opcion != 4);
        }
    }
}
