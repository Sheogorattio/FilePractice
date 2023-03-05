using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            {
                int[] arr = new int[100];
                Random r = new Random();
                for(int i=0; i<arr.Length; i++)
                {
                    arr[i] = r.Next(0,400);
                    Console.Write("{0} ", arr[i]);
                }
                Console.WriteLine("\n-----------------------------------------------------");
                using (StreamWriter sr = new StreamWriter("task 1.txt"))
                {
                    foreach(int i in arr)
                    {
                        if (IsFibonacci(i))
                        {
                            sr.Write("{0} ", i);
                            Console.Write("{0} ", i);
                        }
                    }
                }

            }
            #endregion
            #region task 2
            {
                string path = "task 2.txt";
                //imagine that you put this text into the file
                string text = "Imagine was you removal raising gravity. Unsatiable understood or expression dissimilar so sufficient. Its party every heard and event gay. Advice he indeed things adieus in number so uneasy. To many four fact in he fail. My hung it quit next do of. It fifteen charmed by private savings it mr. Favourable cultivated alteration entreaties yet met sympathize. Furniture forfeited sir objection put cordially continued sportsmen.\r\n\r\nNo comfort do written conduct at prevent manners on. Celebrated contrasted discretion him sympathize her collecting occasional. Do answered bachelor occasion in of offended no concerns. Supply worthy warmth branch of no ye. Voice tried known to as my to. Though wished merits or be. Alone visit use these smart rooms ham. No waiting in on enjoyed placing it inquiry.\r\n\r\nAsk especially collecting terminated may son expression. Extremely eagerness principle estimable own was man. Men received far his dashwood subjects new. My sufficient surrounded an companions dispatched in on. Connection too unaffected expression led son possession. New smiling friends and her another. Leaf she does none love high yet. Snug love will up bore as be. Pursuit man son musical general pointed. It surprise informed mr advanced do outweigh.\r\n\r\nOr kind rest bred with am shed then. In raptures building an bringing be. Elderly is detract tedious assured private so to visited. Do travelling companions contrasted it. Mistress strongly remember up to. Ham him compass you proceed calling detract. Better of always missed we person mr. September smallness northward situation few her certainty something.\r\n\r\nDo in laughter securing smallest sensible no mr hastened. As perhaps proceed in in brandon of limited unknown greatly. Distrusts fulfilled happiness unwilling as explained of difficult. No landlord of peculiar ladyship attended if contempt ecstatic. Loud wish made on is am as hard. Court so avoid in plate hence. Of received mr breeding concerns peculiar securing landlord. Spot to many it four bred soon well to. Or am promotion in no departure abilities. Whatever landlord yourself at by pleasure of children be.\r\n\r\nDifficulty on insensible reasonable in. From as went he they. Preference themselves me as thoroughly partiality considered on in estimating. Middletons acceptance discovered projecting so is so or. In or attachment inquietude remarkably comparison at an. Is surrounded prosperous stimulated am me discretion expression. But truth being state can she china widow. Occasional preference fat remarkably now projecting uncommonly dissimilar. Sentiments projection particular companions interested do at my delightful. Listening newspaper in advantage frankness to concluded unwilling.\r\n\r\nPassage its ten led hearted removal cordial. Preference any astonished unreserved mrs. Prosperous understood middletons in conviction an uncommonly do. Supposing so be resolving breakfast am or perfectly. Is drew am hill from mr. Valley by oh twenty direct me so. Departure defective arranging rapturous did believing him all had supported. Family months lasted simple set nature vulgar him. Picture for attempt joy excited ten carried manners talking how. Suspicion neglected he resolving agreement perceived at an.\r\n\r\nIts sometimes her behaviour are contented. Do listening am eagerness oh objection collected. Together gay feelings continue juvenile had off one. Unknown may service subject her letters one bed. Child years noise ye in forty. Loud in this in both hold. My entrance me is disposal bachelor remember relation.\r\n\r\nNeat own nor she said see walk. And charm add green you these. Sang busy in this drew ye fine. At greater prepare musical so attacks as on distant. Improving age our her cordially intention. His devonshire sufficient precaution say preference middletons insipidity. Since might water hence the her worse. Concluded it offending dejection do earnestly as me direction. Nature played thirty all him.\r\n\r\nWrote water woman of heart it total other. By in entirely securing suitable graceful at families improved. Zealously few furniture repulsive was agreeable consisted difficult. Collected breakfast estimable questions in to favourite it. Known he place worth words it as to. Spoke now noise off smart her ready.";
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(text);
                sw.Close();
                Console.WriteLine("Enter word");
                string target= Console.ReadLine();
                Console.WriteLine("Enter new word");
                string _word = Console.ReadLine();
                StreamReader _sr = new StreamReader(path);
                string buff = _sr.ReadToEnd();
                _sr.Close();
                string[] buffArr = buff.Split(new char[] { ' ' });
                int replace_counter = 0;
                for(int i=0; i < buffArr.Length; i++)
                {
                    if (buffArr[i] == target)
                    {
                        buffArr[i] = _word;
                        replace_counter++;
                    }
                }
                StreamWriter _sw = new StreamWriter(path);
                _sw.Write(text);
                Console.WriteLine("{0} word(s) was replaced.", replace_counter);

            }
            #endregion
            #region task 3
            {
                string path = "task 2.txt";
                Console.WriteLine("Enter forbiden word");
                string target = Console.ReadLine();
                char[] newWord = new char[target.Length];
                for (int j = 0; j < target.Length; j++)
                {
                    newWord[j] = '*';
                }
                StreamReader sr = new StreamReader(path);
                string buff = sr.ReadToEnd();
                sr.Close();
                while (true)
                {
                   if (buff.IndexOf(target) < 0) break;
                    buff.Replace(target, new string(newWord));
                }
                StreamWriter sw = new StreamWriter(path);
                sw.Write(buff);
                sw.Close();
            }
                #endregion
                Console.Read();
        }
       
        public static bool IsFibonacci(int number)
        {
            return IsPerfectSquare(number * number * 5 + 4) || IsPerfectSquare(number * number * 5 - 4);
        }
        public static bool IsPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return (s * s) == x;
        }
    }

    
}
