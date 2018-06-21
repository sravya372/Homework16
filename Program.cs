using System.Diagnostics;
using System;

namespace myStory
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ProcessStartInfo theProcess = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
                       
            theProcess.Arguments = "https://www.dccomics.com/sites/default/files/imce/2015/10-OCT/DCSHG-3-trimmed_560d69df63dac1.85807477.jpg";

            ProcessStartInfo thePicture = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");

            thePicture.Arguments = "http://images4.fanpop.com/image/answers/251000/251281_1306924617102_437_293.jpg";

            ProcessStartInfo Celebration = new ProcessStartInfo("c:/Program Files (X86)/Google/Chrome/Application/Chrome.exe");
            Celebration.Arguments = "https://pa1.narvii.com/6693/fd8cc1208afd39da4175b94686b2347133b4340a_hq.gif";



            Process.Start(theProcess);
            
            Console.WriteLine("There was a Kingdom called Mahishmathi and they have two superheros one is me and other is my sister and , we have so many god gifted super powers one day we discoverd the an army of savages about to attack us so we are into war now");
            Console.ReadKey();
            Console.WriteLine("Now its war time.....press any key to begin");
            Console.ReadKey();

            Console.Write("you can give a name to me[entername]: ");
            String sname = Console.ReadLine();
            SuperHuman princess = new SuperHuman(50, sname, 500);
            Console.ReadKey();

            Console.WriteLine("{0}: thank you for giving me a name now give a name to my sister: [entername]", princess._name);
            String hname = Console.ReadLine();
            SuperHero princess2 = new SuperHero(hname, 45, 400, 50);
            
            Console.ReadKey();

            Console.WriteLine("{0}: thank you for the name lets go to the war {1}.", princess2._name, princess._name);
            Console.ReadKey();

           
            
            SuperVillan enemy = new SuperVillan(10, "Evil King", 3, 200, 30);
            int _life = enemy._life--;
            int _strength = enemy._strength--;

            Console.WriteLine("Enemy started the war me and my sister started attacking {0}", enemy._name);
                      
            Console.WriteLine("{0} total hits untill now {1}  and Villan strength is {2}", princess2._name, princess2._hits, enemy._strength);
            Console.ReadKey();

            

            int reduce = enemy._strength - 4;
            Console.WriteLine("By taking hits from {0} Evil King power is  reducing : {1}", princess2._name, reduce);
            Console.ReadKey();
           
            Console.WriteLine("its time for {0} to use all her super powers {1}", princess._name, princess._superpower);
            Console.ReadKey();
            Console.WriteLine("Power Punch!!!!!!!!!!!!!!111");
            Console.ReadKey();
           
            Process.Start(thePicture);

            Console.Write("Now enter how much u want {0} Strength to reduce choose between 1 to 10",enemy._name);
            String enter = Console.ReadLine();

            int enterint = int.Parse(enter);
            Console.WriteLine("now the {0} Strength is {1}",enemy._name,enter);
            
            enemy.damage(10);

            Console.WriteLine("{0} dead and the super sisters won the war Press any key to watch celebrations.....", enemy._name); 
            Console.ReadKey();
            Process.Start(Celebration);


        }
    }
}