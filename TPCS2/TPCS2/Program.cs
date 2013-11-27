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
           HelloWolrd();
           Echo();
           Console.WriteLine();
           Reverse();
           Triforce();
           QCM("Quelle est la difference entre un pigeon?", "1) les deux pattes, surtout la gauche", "2) Oui", "3) Obiwan Kenobi", "4) La reponse D", 1);
           Morse();
            
            MessageMorse();
        }

        public static void HelloWolrd()
        {
            Console.WriteLine("Hello World");
        }

        static void Echo()
        {
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
            string res = Console.ReadLine();
            int i = res.Length;
            reverse_rec(res, i - 1, "");
        }

        static void Triforce()
        {
            Console.WriteLine("    /\\ \n   /--\\ \n  /\\  /\\ \n /--\\/--\\ ");

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
                case 4 :
                    good = ans4;
                    break;
                default :
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
            string msg = Console.ReadLine();
            for (int i = msg.Length - 1; i >0 ; i--)
            {
                switch (msg[i])
                {
                    case '_':
                        Console.Beep(900, 450);
                        break;
                    case '.':
                        Console.Beep(900, 150);
                        break;
                    default :
                        System.Threading.Thread.Sleep(450);
                        break;
                }
            }
        }

       
        static void MessageMorse()
        {
            string[] alphabet = {"._","_...","_._.","_..",".",".._.","__.","....","..",".___","_._","._..","__","_.","___",".__.","__._","._.","...","_",".._","..._",".__","_.._","_.__","__.."};
            string msg = Console.ReadLine();
            string msgM = " ";
            for (int i = msg.Length - 1  ; i >= 0; i--)
            {
                if (msg[i] == 32)
                {
                    msgM = msgM + " ";
                }
                else
                {


                    if (msg[i] >= 65 && msg[i] <= 90)
                    {
                        int nb = msg[i] - 65;
                        msgM = msgM + " " + alphabet[nb];
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

        }
               /\ 
            ( .        )
        ( (     a       ))
       /        ._ )       )) 
     (     . _      j          ))))____________. . ,_        ,+%$% .
        `''         |                                            `_%* ' " '~%$ .
                    : .                                           ` .              68%%9
           _____(                                               ;          C8%%).
        ."    __       . ______________________.    |_ .          \86'
        ;   |       :  |                                         "  .     ' .          %
        ;   |       :  |                                              " .   ?
         ` . ` :    :  |                                                 :    |  
            `'    /_|                                                  ;   (
                 /__|                                                   /.. ..\



                 /\ 
            ( .         )
        ( (     a       ))
       /        ._ )       )) 
     (     . _      j          ))))____________. . ,_        ,+%$% .              
        `''         |                                            `_%* ' " '~%$ .  %$%        %-  
                    : .                                           ` .              68%%9  68%$%
           ____ (                                               ;          
        ."    __ |     . ______________________.    |_ .          
        ;   |       :  |                                         "  .     ' .        
        ;   |       :  |                                              " .   ?
         ` . ` :    :  |                                                 :    |  
            `'     ;   |                                                   ;   (
                 /__|                                                   /.. ..\
                                                                               
    }
}
