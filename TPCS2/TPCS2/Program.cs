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
            while (true)
            {
                Console.WriteLine("choisis un exo:");
                Console.WriteLine(" Hello World \n Echo \n Reverse \n Triforce \n Qcm \n Morse \n Message Morse \n Poney \n");
                string exo = Console.ReadLine();
                switch (exo.ToLower())
                {
                    case "hello world":
                        HelloWolrd();
                        break;
                    case "echo":
                        Echo();
                        break;
                    case "reverse":
                        Reverse();
                        break;
                    case "triforce":
                        Triforce();
                        break;
                    case "qcm":
                        QCM("Quelle est la difference entre un pigeon?", "1) les deux pattes, surtout la gauche", "2) Oui", "3) Obiwan Kenobi", "4) La reponse D", 1);
                        break;
                    case "morse":
                        Morse();
                        break;
                    case "message morse":
                        MessageMorse();
                        break;
                    case "poney":
                        MyPoney();
                        break;
                    default:
                        Console.WriteLine("Cet exercice n'existe pas, desole ");
                        break;
                }
                Console.WriteLine();
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
            for (int i = 0; i < msg.Length - 1; i++)
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
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("                          I AM A                                                                                                                                                                                                                                                  ");
                    Console.WriteLine(@"                                          
                           .o;.o&&&.      
                          ;**&*&&&88*     
                        .o*oo*;oo**88*    
                        .&oo**.;o***88&o  
                        o&oo***. ;o*&&&&o 
                        &8oooo**. .o*o;*& 
                        &&o;ooooo. .o*. ; 
                        &&oooooooo. .o*   
                        &&oo;o###**o;.o   
                        &&ooooo.&#@&o**   
                        &8&ooo. &###o*;   
                        &#&*oo; &@#*o*.   
                        &88&*oo..8#oooo   
                        &8#88*oo;;o;o*oo  
                        &8888&o;;oooooo   
        .......         &888&ooooo*ooo    
      ;*8#####&.        8#88&*oo;;;       
      &&88####8&ooooo; .8##&8&*.          
     .&&888888#8*o;oo***&##**&o           
    .*888#&oo&8&;. o**o;o##*o*o           
   .*888o;.*o*;*; .***o;o&#8ooo           
   ;88#o.;&&;  *o&8*o*o;o*8#ooo           
   &8#&.o&8;   **8o***o;o**8ooo           
  o&88*.*8&    *&&.o*****oo&**            
  *&&o.o&8;    ooo;;ooooo;oo&o            
 .*&&.;*8*.    ;*;oooooooo;oo             
 o*;o.o&8o     .o;o;o****o;o;             
 ooo;o&88o      ;oo;    ;o;o;             
 ..*.*8&*.      .oo;    ;o;o;             
   o;8&&*      .ooo;    ;o;o;             
   o;&ooo      ;*;o;    ;o;o;             
   o;*..       ;*;o;    ;o;o;             
   o;*         ;*;oo    ;o;oo             
   *o.         ;*;;*.   ;o;;*.            
   o&.         ;*;;*.   ;o;;*.            
   .&.         ;*oooo   ;*oooo            
    ;          .ooooo   .ooooo            
                                          
                                          
                                          
");    
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(450);
                    Console.Clear();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("                     PONEY                                                                                                                                                                                                                                                         ");
                    Console.WriteLine(@"                              .  ....           
                            .o*oo&88&o          
                           .oo*****&88*         
                          o&o*oo;o***88*.       
                          o*o*o*..;**&88&o      
                         .&&o*o**. .o*&*&&o     
                         ;8&oooo**. .o*..o*     
                         ;8&oooo;oo. .o*. .     
                         ;8&oooo**oo...oo       
                         ;8&oo;*#8#&8*;o;       
                         ;8&o;oo..&#@&o&;       
                         ;88*ooo..##&8o*        
                         ;88&*oo;.8@#ooo.       
                oooo.    ;8#8&*o;.;*&oo*o.      
               o*oo**.   ;88#88*;o;;;;oo*.      
              .*o;;o**   ;88888o;;;ooooo.       
         ;oooo**oooooo.  ;##88*oo****;;.        
       .*&####8ooooo;o*. ;##88&**...            
       ;&&8888&oooooo;*o;o##8*&&o               
       *&88888*oooooooo**o8##o*&.               
      *&888&;o*oooo;;;;o*;*##*o*.               
     o&88* .o&&*ooooooooooo&#8o*.               
    .&888.;*8&&*oo*&&&&*ooo*88o*.               
    ;88#o.*8*;&**&&&&&*ooooo*&oo.               
    &88&;o&&;;&&&&&*ooo;ooo;o&*;                
   .&&*..*8& ;&&&&*ooooooooo;o**.               
   **&o.o*8;  o&&&ooo*oooo*oo;o**.              
   *oo.;*88.  ;&&&o;*&*oooo&*ooooo.             
   o;*.*88&.   *&*oo**o    ;&**o;o;             
    ;;;8&&o    *&oo***;    .**&o;o;             
    ;;o8*&o    **;o***     .***oo*;             
    ;;o&;o.  .o**o***;     o&&ooo*.             
    ;;oo     *oo*****      ***oo*o              
    ;;o.    .*oo****.     ****&*o               
    ;**      o*oo*;.     ;&**&;;                
     o*                   o**.                  
     ;*                                         
");
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(450);
                    Console.Clear();
                }
            }
        }
    }
}