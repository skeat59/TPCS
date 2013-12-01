using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace TPCS2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("choisis un exo:");
            Console.WriteLine(" Hello World \n Echo \n Reverse \n Triforce \n Qcm \n Morse \n Message Morse \n Poney \n");
            Console.WriteLine("PS: respect les majuscules");
            string exo = Console.ReadLine();
            switch (exo)
            {
                case "Hello World":
                    HelloWolrd();
                    break;
                case "Echo":
                    Echo();
                    break;
                case "Reverse":
                    Reverse();
                    break;
                case "Triforce":
                    Triforce();
                    break;
                case "Qcm":
                    QCM("Quelle est la difference entre un pigeon?", "1) les deux pattes, surtout la gauche", "2) Oui", "3) Obiwan Kenobi", "4) La reponse D", 1);
                    break;
                case "Morse":
                    Morse();
                    break;
                case "Message Morse":
                    MessageMorse();
                    break;
                case "Poney":
                    MyPoney();
                    break;
                default:
                    Console.WriteLine("Cet exercice n'existe pas, desole ");
                    break;
            }


        }

        public static void HelloWolrd()
        {
            Console.WriteLine("Hello World");
        }

        static void Echo()
        {
            Console.WriteLine("Ecris un message: \n");
            Console.WriteLine(Console.ReadLine());
        }

        static void reverse_rec(string res, int i, string res2)
        {

            if (i >= 0)
            {
                res2 = res2 + Convert.ToString(res[i]);
                reverse_rec(res, --i, res2);

            }
            else
            {
                Console.WriteLine(res2);
            }
        }

        static void Reverse()
        {
            Console.WriteLine("Ecris un message: \n");
            string res = Console.ReadLine();
            int i = res.Length;
            reverse_rec(res, i - 1, "");
        }

        static void Triforce()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("    /\\ \n   /--\\ \n  /\\  /\\ \n /--\\/--\\ ");
            Console.ResetColor();
        }

        static void QCM(string question,
            string ans1,
            string ans2,
            string ans3,
            string ans4,
            int answer)
        {
            Console.WriteLine(question + "\n" + ans1 + "\n" + ans2 + "\n" + ans3 + "\n" + ans4);
            string good;
            switch (answer)
            {
                case 1:
                    good = ans1;
                    break;
                case 2:
                    good = ans2;
                    break;
                case 3:
                    good = ans3;
                    break;
                case 4:
                    good = ans4;
                    break;
                default:
                    good = "n'existe pas";
                    break;

            }

            int prop = Convert.ToInt32(Console.ReadLine());
            if (prop == answer)
            {
                Console.WriteLine("Go job Bro!");
            }
            else
            {
                if (prop >= 1 && prop <= 4)
                {
                    Console.WriteLine("You lose... The answer was" + " " + good);
                }
                else
                {
                    Console.WriteLine("So counting is too hard, n00b...");
                }
            }

        }

        static void Morse()
        {
            Console.WriteLine("Ecris un message en Morse: \n");
            string msg = Console.ReadLine();
            for (int i = msg.Length - 1; i > 0; i--)
            {
                switch (msg[i])
                {
                    case '_':
                        Console.Beep(900, 450);
                        break;
                    case '.':
                        Console.Beep(900, 150);
                        break;
                    default:
                        System.Threading.Thread.Sleep(450);
                        break;
                }
            }
        }


        static void MessageMorse()
        {
            Console.WriteLine("Ecris un message: \n");
            string[] alphabet = { "._", "_...", "_._.", "_..", ".", ".._.", "__.", "....", "..", ".___", "_._", "._..", "__", "_.", "___", ".__.", "__._", "._.", "...", "_", ".._", "..._", ".__", "_.._", "_.__", "__.." };
            string msg = Console.ReadLine();
            string msgM = " ";
            for (int i = msg.Length - 1; i >= 0; i--)
            {
                if (msg[i] == 32)
                {
                    msgM = msgM + " ";
                }
                else
                {


                    if (msg[i] >= 65 && msg[i] <= 90)
                    {
                        int nb = msg[i] - 65;                                     /* permet*/
                        msgM = msgM + alphabet[nb];
                    }
                    else
                    {
                        int nb = Convert.ToInt32(msg[i]) - 97;
                        msgM = msgM + " " + alphabet[nb];
                    }
                }
            }
            for (int i = msgM.Length - 1; i > 0; i--)
            {
                switch (msgM[i])
                {
                    case '_':
                        Console.Beep(900, 450);
                        break;
                    case '.':
                        Console.Beep(900, 150);
                        break;
                    default:
                        System.Threading.Thread.Sleep(450);
                        break;
                }
            }
        }


        static void MyPoney()
        {
            for (int i = 1; i < 60000; i++)
            {


                if ((i % 2) == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;

                    Console.WriteLine("                          I AM A                                                                                                                                                                                                                                                  ");
                    Console.WriteLine("                          #                                                                                                                                                                                                                                                           ");
                    Console.WriteLine("                         @@  ;                                                                                                                                                                                                                                                    ");
                    Console.WriteLine("                        @ @&8*                                                                                                                                                                                                                                                ");
                    Console.WriteLine("                        @ @   #                                                                                                                                                                                                                                                 ");
                    Console.WriteLine("                      .@ @  8                                                                                                                                                                                                                                                    ");
                    Console.WriteLine("                      #  @                                                                                                                                                                                                                                                          ");
                    Console.WriteLine("                       o@                                                                                                                                                                                                                                                           ");
                    Console.WriteLine("                     @   ;o   @                                                                                                                                                                                                                                                   ");
                    Console.WriteLine("                       @ @@   @                                                                                                                                                                                                                                               ");
                    Console.WriteLine("                       ;    @ #  @.                                                                                                                                                                                                                                              ");
                    Console.WriteLine("                              @       @                                                                                                                                                                                                                                             ");
                    Console.WriteLine("                     @  @    @                 .                                                                                                                                                                                                                                   ");
                    Console.WriteLine("                   @     @ @   ; @ o @@*@                                                                                                                                                                                                                              ");
                    Console.WriteLine("                        @      #    @                                                                                                                                                                                                                                                 ");
                    Console.WriteLine("                 @       8   8                                                                                                                                                                                                                                                         ");
                    Console.WriteLine("               8 *     @     &       @                                                                                                                                                                                                                                             ");
                    Console.WriteLine("              @  #      @@@8o;;* @@#                                                                                                                                                                                                                                  ");
                    Console.WriteLine("              ;       @        @  #                                                                                                                                                                                                                                                ");
                    Console.WriteLine("             ;   @   @  8 @@ @; @  o                                                                                                                                                                                                                                    ");
                    Console.WriteLine("              @       .      8                                                                                                                                                                                                                                                        ");
                    Console.WriteLine("            @   @ @     @   8                                                                                                                                                                                                                                                 ");
                    Console.WriteLine("            @   @ @     @   8                                                                                                                                                                                                                                                 ");
                    Console.WriteLine("                @    @       @  #                                                                                                                                                                                                                                                 ");
                    Console.WriteLine("              # @      @     #@.  @ @                                                                                                                                                                                                                                       ");
                    Console.WriteLine("                o@     @      @ @  @                                                                                                                                                                                                                                         ");
                    Console.WriteLine("                    @     &      @                                                                                                                                                                                                                                                  ");
                    Console.WriteLine("                              @     #o                 .                                                                                                                                                                                                                               ");
                    Console.WriteLine("                               @  @  @ o    @                                                                                                                                                                                                                                   ");
                    Console.WriteLine("                                @   #  @  &                                                                                                                                                                                                                                          ");
                    Console.WriteLine("                                 @   *  @                                                                                                                                                                                                                                              ");
                    Console.WriteLine("                                   &  @                                                                                                                                                                                                                                                ");
                    Console.WriteLine("                                    .    #                                                                                                                                                                                                                                                 ");
                    Console.WriteLine("                                   @  @  @                                                                                                                                                                                                                                           ");
                    Console.WriteLine("                               #    *    @           *                                                                                                                                                                                                                                  ");
                    Console.WriteLine("                             #        @          #                   1                                                                                                                                                                                                                  ");
                    Console.WriteLine("                             *     ##          o@&                                                                                                                                                                                                                                   ");
                    Console.WriteLine("                        &   .@    .* *o ; *@                                                                                                                                                                                                                                        ");
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(450);
                    Console.Clear();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("                     PONEY                                                                                                                                                                                                                                                         ");
                    Console.WriteLine("                          #                                                                                                                                                                                                                                                                 ");
                    Console.WriteLine("                         @@  ;                PONEY                                                                                                                                                                                                                               ");
                    Console.WriteLine("                        @ @&8*                                                                                                                                                                                                                                                      ");
                    Console.WriteLine("                        @ @   #                                                                                                                                                                                                                                                      ");
                    Console.WriteLine("       poney          .@ @  8                                                                                                                                                                                                                                              ");
                    Console.WriteLine("                      #  @                                                                                                                                                                                                                                                                   ");
                    Console.WriteLine("                       o@                                                                                                                                                                                                                                                              ");
                    Console.WriteLine("                     @   ;o   @                                                                                                                                                                                                                                                        ");
                    Console.WriteLine("                       @ @@   @                                                                                                                                                                                                                                               ");
                    Console.WriteLine("                       ;    @ #  @.                                                                                                                                                                                                                                             ");
                    Console.WriteLine("                              @       @                                                                                                                                                                                                                                                   ");
                    Console.WriteLine("                     @  @    @                 .                                                                                                                                                                                                                                                  ");
                    Console.WriteLine("                   @     @ @   ; @ o @@*@                                                                                                                                                                                                                                      ");
                    Console.WriteLine("                        @      #    @                                                                                                                                                                                                                      ");
                    Console.WriteLine("                 @       8   8                                                                                                                                                                                                                  ");
                    Console.WriteLine("               8 *     @     &       @                                                                                                                                                                                                       ");
                    Console.WriteLine("              @  #      @@@8o;;* @@#                                                                                                                                                                                                  ");
                    Console.WriteLine("              ;       @        @  #                                                                                                                                                                                                                           ");
                    Console.WriteLine("             ;   @   @  8 @@ @; @  o                                                                                                                                                                                                                       ");
                    Console.WriteLine("              @       .      8                                                                                                                                                                                                                    ");
                    Console.WriteLine("            @   @ @     @   8                                                                                                                                                                                                                   ");
                    Console.WriteLine("                @    @       @  #                                                                                                                                                                                                                              ");
                    Console.WriteLine("              # @      @     #@.  @ @                                                                                                                                                                                                                   ");
                    Console.WriteLine("                o@     @      @ @  @                                                                                                                                                                                                               ");
                    Console.WriteLine("                    @     &      @                                                                                                                                                                                                       ");
                    Console.WriteLine("                              @     #o                 .                                                                                                                                                                                                                            ");
                    Console.WriteLine("                               @  @  @ o    @                                                                                                                                                                                    ");
                    Console.WriteLine("                                @   #  @  &                                                                                                                                                                                  ");
                    Console.WriteLine("                                 @   *  @                                                                                                                                                                                                              ");
                    Console.WriteLine("                                   &  @                                                                                                                                                                                                                                            ");
                    Console.WriteLine("                                    .    #                                                                                                                                                                                                                                       ");
                    Console.WriteLine("                                   @  @  @                                                                                                                                                                                                                                       ");
                    Console.WriteLine("                               #    *    @           *                                                                                                                                                                                                                                 ");
                    Console.WriteLine("                             #        @          #                                                                                                                                                                                                                     ");
                    Console.WriteLine("                             *     ##          o@&                                                                                                                                                                                                           ");
                    Console.WriteLine("                        &   .@    .* *o ; *@                                                                                                                                                                                               ");
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(450);
                    Console.Clear();
                }
            }
        }
    }
}