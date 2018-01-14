using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{

    public class Kaart //loo klass
    {//määra millised omadused klassil on ning mis nimetuste all need on
        public string mast;
        public string tugevus;
        public int väärtus;
        //get on vajalik, et programm oskaks võtta vastavat infot
        public string Card
        {
            get
            {
                return mast + " " + tugevus;
            }
        }
        //public string Tugevus
        //{
        //    get
        //    {
        //        return tugevus;
        //    }
        //}
        //public int Väärtus
        //{
        //    get
        //    {
        //        return väärtus;
        //    }
        //}


        public Kaart(string _mast, string _tugevus, int _väärtus)
        {
            mast = _mast;
            tugevus = _tugevus;
            väärtus = _väärtus;
        }



        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Tere tulemast BlackJacki lauda, kus panused ja võidud on suured!");
                Console.WriteLine();
                Console.WriteLine("Alustamiseks vajuta suvalist numbrit");
                Console.ReadKey();
                Console.Clear();

                int kontoseis = 1000;
                bool mängumootor = true;
                var Kaardipakk = new List<Kaart>(); //Loon listi nimega kaardipakk, mis on uus List ja mille kannete sisu/omadused vastab <kaart> klassile omadustele (string, string, int).

                while (mängumootor)
                {
                    int summa1 = 0; //mängija käe suurus
                    int summa2 = 0; //diileri käe suurus
                    int äss1 = 0; //mängija ässad
                    int äss2 = 0; //diileri ässad

                    bool mängija = true;
                    bool võrdlus = true;
                    bool tõstmine = false;
                    bool plusskonto = false;
                    bool diiler = true;
                    Kaardipakk.Clear();
                    //2 decki
                    Kaardipakk.Add(new Kaart("Poti", "Äss", 11));
                    Kaardipakk.Add(new Kaart("Poti", "2", 2));
                    Kaardipakk.Add(new Kaart("Poti", "3", 3));
                    Kaardipakk.Add(new Kaart("Poti", "4", 4));
                    Kaardipakk.Add(new Kaart("Poti", "5", 5));
                    Kaardipakk.Add(new Kaart("Poti", "6", 6));
                    Kaardipakk.Add(new Kaart("Poti", "7", 7));
                    Kaardipakk.Add(new Kaart("Poti", "8", 8));
                    Kaardipakk.Add(new Kaart("Poti", "9", 9));
                    Kaardipakk.Add(new Kaart("Poti", "10", 10));
                    Kaardipakk.Add(new Kaart("Poti", "Soldat", 10));
                    Kaardipakk.Add(new Kaart("Poti", "Emand", 10));
                    Kaardipakk.Add(new Kaart("Poti", "Kuningas", 10));

                    Kaardipakk.Add(new Kaart("Ärtu", "Äss", 11));
                    Kaardipakk.Add(new Kaart("Ärtu", "2", 2));
                    Kaardipakk.Add(new Kaart("Ärtu", "3", 3));
                    Kaardipakk.Add(new Kaart("Ärtu", "4", 4));
                    Kaardipakk.Add(new Kaart("Ärtu", "5", 5));
                    Kaardipakk.Add(new Kaart("Ärtu", "6", 6));
                    Kaardipakk.Add(new Kaart("Ärtu", "7", 7));
                    Kaardipakk.Add(new Kaart("Ärtu", "8", 8));
                    Kaardipakk.Add(new Kaart("Ärtu", "9", 9));
                    Kaardipakk.Add(new Kaart("Ärtu", "10", 10));
                    Kaardipakk.Add(new Kaart("Ärtu", "Soldat", 10));
                    Kaardipakk.Add(new Kaart("Ärtu", "Emand", 10));
                    Kaardipakk.Add(new Kaart("Ärtu", "Kuningas", 10));

                    Kaardipakk.Add(new Kaart("Risti", "Äss", 11));
                    Kaardipakk.Add(new Kaart("Risti", "2", 2));
                    Kaardipakk.Add(new Kaart("Risti", "3", 3));
                    Kaardipakk.Add(new Kaart("Risti", "4", 4));
                    Kaardipakk.Add(new Kaart("Risti", "5", 5));
                    Kaardipakk.Add(new Kaart("Risti", "6", 6));
                    Kaardipakk.Add(new Kaart("Risti", "7", 7));
                    Kaardipakk.Add(new Kaart("Risti", "8", 8));
                    Kaardipakk.Add(new Kaart("Risti", "9", 9));
                    Kaardipakk.Add(new Kaart("Risti", "10", 10));
                    Kaardipakk.Add(new Kaart("Risti", "Soldat", 10));
                    Kaardipakk.Add(new Kaart("Risti", "Emand", 10));
                    Kaardipakk.Add(new Kaart("Risti", "Kuningas", 10));

                    Kaardipakk.Add(new Kaart("Ruutu", "Äss", 11));
                    Kaardipakk.Add(new Kaart("Ruutu", "2", 2));
                    Kaardipakk.Add(new Kaart("Ruutu", "3", 3));
                    Kaardipakk.Add(new Kaart("Ruutu", "4", 4));
                    Kaardipakk.Add(new Kaart("Ruutu", "5", 5));
                    Kaardipakk.Add(new Kaart("Ruutu", "6", 6));
                    Kaardipakk.Add(new Kaart("Ruutu", "7", 7));
                    Kaardipakk.Add(new Kaart("Ruutu", "8", 8));
                    Kaardipakk.Add(new Kaart("Ruutu", "9", 9));
                    Kaardipakk.Add(new Kaart("Ruutu", "10", 10));
                    Kaardipakk.Add(new Kaart("Ruutu", "Soldat", 10));
                    Kaardipakk.Add(new Kaart("Ruutu", "Emand", 10));
                    Kaardipakk.Add(new Kaart("Ruutu", "Kuningas", 10));

                    Kaardipakk.Add(new Kaart("Poti", "Äss", 11));
                    Kaardipakk.Add(new Kaart("Poti", "2", 2));
                    Kaardipakk.Add(new Kaart("Poti", "3", 3));
                    Kaardipakk.Add(new Kaart("Poti", "4", 4));
                    Kaardipakk.Add(new Kaart("Poti", "5", 5));
                    Kaardipakk.Add(new Kaart("Poti", "6", 6));
                    Kaardipakk.Add(new Kaart("Poti", "7", 7));
                    Kaardipakk.Add(new Kaart("Poti", "8", 8));
                    Kaardipakk.Add(new Kaart("Poti", "9", 9));
                    Kaardipakk.Add(new Kaart("Poti", "10", 10));
                    Kaardipakk.Add(new Kaart("Poti", "Soldat", 10));
                    Kaardipakk.Add(new Kaart("Poti", "Emand", 10));
                    Kaardipakk.Add(new Kaart("Poti", "Kuningas", 10));

                    Kaardipakk.Add(new Kaart("Ärtu", "Äss", 11));
                    Kaardipakk.Add(new Kaart("Ärtu", "2", 2));
                    Kaardipakk.Add(new Kaart("Ärtu", "3", 3));
                    Kaardipakk.Add(new Kaart("Ärtu", "4", 4));
                    Kaardipakk.Add(new Kaart("Ärtu", "5", 5));
                    Kaardipakk.Add(new Kaart("Ärtu", "6", 6));
                    Kaardipakk.Add(new Kaart("Ärtu", "7", 7));
                    Kaardipakk.Add(new Kaart("Ärtu", "8", 8));
                    Kaardipakk.Add(new Kaart("Ärtu", "9", 9));
                    Kaardipakk.Add(new Kaart("Ärtu", "10", 10));
                    Kaardipakk.Add(new Kaart("Ärtu", "Soldat", 10));
                    Kaardipakk.Add(new Kaart("Ärtu", "Emand", 10));
                    Kaardipakk.Add(new Kaart("Ärtu", "Kuningas", 10));

                    Kaardipakk.Add(new Kaart("Risti", "Äss", 11));
                    Kaardipakk.Add(new Kaart("Risti", "2", 2));
                    Kaardipakk.Add(new Kaart("Risti", "3", 3));
                    Kaardipakk.Add(new Kaart("Risti", "4", 4));
                    Kaardipakk.Add(new Kaart("Risti", "5", 5));
                    Kaardipakk.Add(new Kaart("Risti", "6", 6));
                    Kaardipakk.Add(new Kaart("Risti", "7", 7));
                    Kaardipakk.Add(new Kaart("Risti", "8", 8));
                    Kaardipakk.Add(new Kaart("Risti", "9", 9));
                    Kaardipakk.Add(new Kaart("Risti", "10", 10));
                    Kaardipakk.Add(new Kaart("Risti", "Soldat", 10));
                    Kaardipakk.Add(new Kaart("Risti", "Emand", 10));
                    Kaardipakk.Add(new Kaart("Risti", "Kuningas", 10));

                    Kaardipakk.Add(new Kaart("Ruutu", "Äss", 11));
                    Kaardipakk.Add(new Kaart("Ruutu", "2", 2));
                    Kaardipakk.Add(new Kaart("Ruutu", "3", 3));
                    Kaardipakk.Add(new Kaart("Ruutu", "4", 4));
                    Kaardipakk.Add(new Kaart("Ruutu", "5", 5));
                    Kaardipakk.Add(new Kaart("Ruutu", "6", 6));
                    Kaardipakk.Add(new Kaart("Ruutu", "7", 7));
                    Kaardipakk.Add(new Kaart("Ruutu", "8", 8));
                    Kaardipakk.Add(new Kaart("Ruutu", "9", 9));
                    Kaardipakk.Add(new Kaart("Ruutu", "10", 10));
                    Kaardipakk.Add(new Kaart("Ruutu", "Soldat", 10));
                    Kaardipakk.Add(new Kaart("Ruutu", "Emand", 10));
                    Kaardipakk.Add(new Kaart("Ruutu", "Kuningas", 10));

                    if (kontoseis < 1)
                    {
                        Console.WriteLine("Sul ei ole rohkem raha ja sa pead 1000 $ laenu võtma");
                        kontoseis = 1000;
                    }
                    Console.WriteLine("Sinu kontoseis on: " + kontoseis);
                    Console.Write("Sisesta panus: ");
                    string panusesuurus = Console.ReadLine();
                    int panus = int.Parse(panusesuurus);
                    if (panus > kontoseis)
                    {
                        Console.WriteLine("Sul ei ole panustamiseks nii palju raha, diiler eemaldas su lauast!");
                        break;
                    }
                    kontoseis = kontoseis - panus;
                    Console.Clear();
                    Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + panus);
                    Console.WriteLine();

                    Random rnd = new Random(); //Random classi rnd loomine
                    int index = rnd.Next(Kaardipakk.Count);
                    var ChosenOne = Kaardipakk[index];
                    summa1 = summa1 + ChosenOne.väärtus;
                    Kaardipakk.RemoveAt(index);


                    int index2 = rnd.Next(Kaardipakk.Count);
                    var ChosenOne2 = Kaardipakk[index2];
                    summa2 = summa2 + ChosenOne2.väärtus;
                    Kaardipakk.RemoveAt(index2);

                    int index3 = rnd.Next(Kaardipakk.Count);
                    var ChosenOne3 = Kaardipakk[index3];
                    summa1 = summa1 + ChosenOne3.väärtus;
                    Kaardipakk.RemoveAt(index3);


                    int index4 = rnd.Next(Kaardipakk.Count);
                    var ChosenOne4 = Kaardipakk[index4];
                    summa2 = summa2 + ChosenOne4.väärtus; //Diileri teine kaart
                    Kaardipakk.RemoveAt(index4);

                    if (ChosenOne.väärtus == 11)
                    {
                        äss1++;
                    }
                    if (ChosenOne2.väärtus == 11)
                    {
                        äss2++;
                    }
                    if (ChosenOne3.väärtus == 11)
                    {
                        äss1++;
                    }
                    if (ChosenOne4.väärtus == 11)
                    {
                        äss2++;
                    }
                    Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + " ja varjatud kaart"); //ChosenOne4.mast + " " + ChosenOne4.tugevus);
                    Console.WriteLine("Sinu kaardid on \t" + ChosenOne.Card + " ja " + ChosenOne3.Card);
                    Console.WriteLine();
                    Console.WriteLine("Sinu kord valik teha");
                    Console.WriteLine();

                    while (mängija)
                    {
                        if (summa1 > 21) //if juhuks kui on kohe 2 ässa ehk 22
                        {
                            if (äss1 > 0)
                            {
                                summa1 = summa1 - 10;
                                äss1 = äss1 - 1;
                            }
                        }
                        Console.WriteLine("Sinu käe väärtus on " + summa1);
                        Console.WriteLine();
                        Console.WriteLine("Vajuta suvalist numbrit, et võtta kaart juurde, klahvi nr 2, et passida või klahvi nr 3, et tõsta panust");
                        ConsoleKeyInfo input = Console.ReadKey();
                        int sisend = int.Parse(input.KeyChar.ToString());


                        if (sisend == 2)
                        {
                            Console.WriteLine("Passid");
                            break; //stand
                        }
                        if (sisend == 3)
                        {
                            Console.WriteLine("Tõstad panust");
                            tõstmine = true;
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + panus);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + " ja varjatud kaart");
                        Console.WriteLine();
                        int index5 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne5 = Kaardipakk[index5];
                        summa1 = summa1 + ChosenOne5.väärtus;
                        Kaardipakk.RemoveAt(index5);
                        Console.WriteLine("Sa võtsid endale juurde \t" + ChosenOne5.Card);
                        Console.WriteLine();
                        Console.WriteLine("Sul on nüüd käes \t" + ChosenOne.Card + "\t" + ChosenOne3.Card + "\t" + ChosenOne5.Card);
                        if (ChosenOne5.väärtus == 11)
                        {
                            äss1++;
                        }

                        if (summa1 > 21)
                        {
                            if (äss1 > 0)
                            {
                                summa1 = summa1 - 10;
                                äss1 = äss1 - 1;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Sinu käe väärtus on " + summa1);
                        Console.WriteLine();
                        Console.WriteLine("Vajuta suvalist numbrit, et võtta kaart juurde, klahvi nr 2, et passida või klahvi nr 3, et tõsta panust");
                        ConsoleKeyInfo input2 = Console.ReadKey();
                        int sisend2 = int.Parse(input2.KeyChar.ToString());


                        if (sisend2 == 2)
                        {
                            Console.WriteLine("Passid");
                            break; //stand
                        }
                        if (sisend2 == 3)
                        {
                            Console.WriteLine("Tõstad panust");
                            tõstmine = true;
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + panus);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + " ja varjatud kaart");
                        Console.WriteLine();
                        int index6 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne6 = Kaardipakk[index6];
                        summa1 = summa1 + ChosenOne6.väärtus;
                        Kaardipakk.RemoveAt(index6);
                        Console.WriteLine("Sa võtsid endale juurde \t" + ChosenOne6.Card);
                        Console.WriteLine();
                        Console.WriteLine("Sul on nüüd käes \t" + ChosenOne.Card + "\t" + ChosenOne3.Card + "\t" + ChosenOne5.Card + "\t" + ChosenOne6.Card);
                        if (ChosenOne6.väärtus == 11)
                        {
                            äss1++;
                        }

                        if (summa1 > 21)
                        {
                            if (äss1 > 0)
                            {
                                summa1 = summa1 - 10;
                                äss1 = äss1 - 1;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Sinu käe väärtus on " + summa1);
                        Console.WriteLine();
                        Console.WriteLine("Vajuta suvalist numbrit, et võtta kaart juurde, klahvi nr 2, et passida või klahvi nr 3, et tõsta panust");
                        ConsoleKeyInfo input3 = Console.ReadKey();
                        int sisend3 = int.Parse(input3.KeyChar.ToString());


                        if (sisend3 == 2)
                        {
                            Console.WriteLine("Passid");
                            break; //stand
                        }
                        if (sisend3 == 3)
                        {
                            Console.WriteLine("Tõstad panust");
                            tõstmine = true;
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + panus);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + " ja varjatud kaart");
                        Console.WriteLine();
                        int index7 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne7 = Kaardipakk[index7];
                        summa1 = summa1 + ChosenOne7.väärtus;
                        Kaardipakk.RemoveAt(index7);
                        Console.WriteLine("Sa võtsid endale juurde \t" + ChosenOne7.Card);
                        Console.WriteLine();
                        Console.WriteLine("Sul on nüüd käes \t" + ChosenOne.Card + "\t" + ChosenOne3.Card + "\t" + ChosenOne5.Card + "\t" + ChosenOne6.Card + "\t" + ChosenOne7.Card);
                        if (ChosenOne7.väärtus == 11)
                        {
                            äss1++;
                        }

                        if (summa1 > 21)
                        {
                            if (äss1 > 0)
                            {
                                summa1 = summa1 - 10;
                                äss1 = äss1 - 1;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Sinu käe väärtus on " + summa1);
                        Console.WriteLine();
                        Console.WriteLine("Vajuta suvalist numbrit, et võtta kaart juurde, klahvi nr 2, et passida või klahvi nr 3, et tõsta panust");
                        ConsoleKeyInfo input4 = Console.ReadKey();
                        int sisend4 = int.Parse(input4.KeyChar.ToString());


                        if (sisend4 == 2)
                        {
                            Console.WriteLine("Passid");
                            break; //stand
                        }
                        if (sisend4 == 3)
                        {
                            Console.WriteLine("Tõstad panust");
                            tõstmine = true;
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + panus);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + " ja varjatud kaart");
                        Console.WriteLine();
                        int index8 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne8 = Kaardipakk[index8];
                        summa1 = summa1 + ChosenOne8.väärtus;
                        Kaardipakk.RemoveAt(index8);
                        Console.WriteLine("Sa võtsid endale juurde \t" + ChosenOne8.Card);
                        Console.WriteLine();
                        Console.WriteLine("Sul on nüüd käes \t" + ChosenOne.Card + "\t" + ChosenOne3.Card + "\t" + ChosenOne5.Card + "\t" + ChosenOne6.Card + "\t" + ChosenOne7.Card + "\t" + ChosenOne8.Card);
                        if (ChosenOne8.väärtus == 11)
                        {
                            äss1++;
                        }

                        if (summa1 > 21)
                        {
                            if (äss1 > 0)
                            {
                                summa1 = summa1 - 10;
                                äss1 = äss1 - 1;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Sinu käe väärtus on " + summa1);
                        Console.WriteLine();
                        Console.WriteLine("Vajuta suvalist numbrit, et võtta kaart juurde, klahvi nr 2, et passida või klahvi nr 3, et tõsta panust");
                        ConsoleKeyInfo input5 = Console.ReadKey();
                        int sisend5 = int.Parse(input5.KeyChar.ToString());


                        if (sisend5 == 2)
                        {
                            Console.WriteLine("Passid");
                            break; //stand
                        }
                        if (sisend5 == 3)
                        {
                            Console.WriteLine("Tõstad panust");
                            tõstmine = true;
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + panus);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + " ja varjatud kaart");
                        Console.WriteLine();
                        int index9 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne9 = Kaardipakk[index9];
                        summa1 = summa1 + ChosenOne9.väärtus;
                        Kaardipakk.RemoveAt(index9);
                        Console.WriteLine("Sa võtsid endale juurde \t" + ChosenOne9.Card);
                        Console.WriteLine();
                        Console.WriteLine("Sul on nüüd käes \t" + ChosenOne.Card + "\t" + ChosenOne3.Card + "\t" + ChosenOne5.Card + "\t" + ChosenOne6.Card + "\t" + ChosenOne7.Card + "\t" + ChosenOne8.Card + "\t" + ChosenOne9.Card);
                        if (ChosenOne9.väärtus == 11)
                        {
                            äss1++;
                        }

                        if (summa1 > 21)
                        {
                            if (äss1 > 0)
                            {
                                summa1 = summa1 - 10;
                                äss1 = äss1 - 1;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Sinu käe väärtus on " + summa1);
                        Console.WriteLine();
                        Console.WriteLine("Vajuta suvalist numbrit, et võtta kaart juurde, klahvi nr 2, et passida või klahvi nr 3, et tõsta panust");
                        ConsoleKeyInfo input6 = Console.ReadKey();
                        int sisend6 = int.Parse(input6.KeyChar.ToString());


                        if (sisend6 == 2)
                        {
                            Console.WriteLine("Passid");
                            break; //stand
                        }
                        if (sisend6 == 3)
                        {
                            Console.WriteLine("Tõstad panust");
                            tõstmine = true;
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + panus);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + " ja varjatud kaart");
                        Console.WriteLine();
                        int index10 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne10 = Kaardipakk[index10];
                        summa1 = summa1 + ChosenOne10.väärtus;
                        Kaardipakk.RemoveAt(index10);
                        Console.WriteLine("Sa võtsid endale juurde \t" + ChosenOne10.Card);
                        Console.WriteLine();
                        Console.WriteLine("Sul on nüüd käes \t" + ChosenOne.Card + "\t" + ChosenOne3.Card + "\t" + ChosenOne5.Card + "\t" + ChosenOne6.Card + "\t" + ChosenOne7.Card + "\t" + ChosenOne8.Card + "\t" + ChosenOne9.Card + "\t" + ChosenOne10.Card);
                        if (ChosenOne10.väärtus == 11)
                        {
                            äss1++;
                        }

                        if (summa1 > 21)
                        {
                            if (äss1 > 0)
                            {
                                summa1 = summa1 - 10;
                                äss1 = äss1 - 1;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Sinu käe väärtus on " + summa1);
                        Console.WriteLine();
                        Console.WriteLine("Vajuta suvalist numbrit, et võtta kaart juurde, klahvi nr 2, et passida või klahvi nr 3, et tõsta panust");
                        ConsoleKeyInfo input7 = Console.ReadKey();
                        int sisend7 = int.Parse(input7.KeyChar.ToString());


                        if (sisend7 == 2)
                        {
                            Console.WriteLine("Passid");
                            break; //stand
                        }
                        if (sisend7 == 3)
                        {
                            Console.WriteLine("Tõstad panust");
                            tõstmine = true;
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + panus);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + " ja varjatud kaart");
                        Console.WriteLine();
                        int index11 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne11 = Kaardipakk[index11];
                        summa1 = summa1 + ChosenOne11.väärtus;
                        Kaardipakk.RemoveAt(index11);
                        Console.WriteLine("Sa võtsid endale juurde \t" + ChosenOne11.Card);
                        Console.WriteLine();
                        Console.WriteLine("Sul on nüüd käes \t" + ChosenOne.Card + "\t" + ChosenOne3.Card + "\t" + ChosenOne5.Card +
                        "\t" + ChosenOne6.Card + "\t" + ChosenOne7.Card + "\t" + ChosenOne8.Card + "\t" + ChosenOne9.Card +
                        "\t" + ChosenOne10.Card + "\t" + ChosenOne11.Card);
                        if (ChosenOne11.väärtus == 11)
                        {
                            äss1++;
                        }

                        if (summa1 > 21)
                        {
                            if (äss1 > 0)
                            {
                                summa1 = summa1 - 10;
                                äss1 = äss1 - 1;
                            }
                            else
                            {
                                break;
                            }
                        }

                        Console.WriteLine("Sinu käe väärtus on " + summa1);
                        Console.WriteLine();
                        Console.WriteLine("Vajuta suvalist numbrit, et võtta kaart juurde, klahvi nr 2, et passida või klahvi nr 3, et tõsta panust");
                        ConsoleKeyInfo input8 = Console.ReadKey();
                        int sisend8 = int.Parse(input8.KeyChar.ToString());


                        if (sisend8 == 2)
                        {
                            Console.WriteLine("Passid");
                            break; //stand
                        }
                        if (sisend8 == 3)
                        {
                            Console.WriteLine("Tõstad panust");
                            tõstmine = true;
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + panus);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + " ja varjatud kaart");
                        Console.WriteLine();
                        int index12 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne12 = Kaardipakk[index12];
                        summa1 = summa1 + ChosenOne12.väärtus;
                        Kaardipakk.RemoveAt(index12);
                        Console.WriteLine("Sa võtsid endale juurde \t" + ChosenOne12.Card);
                        Console.WriteLine();
                        Console.WriteLine("Sul on nüüd käes \t" + ChosenOne.Card + "\t" + ChosenOne3.Card + "\t" + ChosenOne5.Card +
                        "\t" + ChosenOne6.Card + "\t" + ChosenOne7.Card + "\t" + ChosenOne8.Card + "\t" + ChosenOne9.Card +
                        "\t" + ChosenOne10.Card + "\t" + ChosenOne11.Card + "\t" + ChosenOne12.Card);
                        if (ChosenOne12.väärtus == 11)
                        {
                            äss1++;
                        }

                        if (summa1 > 21)
                        {
                            if (äss1 > 0)
                            {
                                summa1 = summa1 - 10;
                                äss1 = äss1 - 1;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Sinu käe väärtus on " + summa1);
                        Console.WriteLine();
                        Console.WriteLine("Vajuta suvalist numbrit, et võtta kaart juurde, klahvi nr 2, et passida või klahvi nr 3, et tõsta panust");
                        ConsoleKeyInfo input9 = Console.ReadKey();
                        int sisend9 = int.Parse(input9.KeyChar.ToString());


                        if (sisend9 == 2)
                        {
                            Console.WriteLine("Passid");
                            break; //stand
                        }
                        if (sisend9 == 3)
                        {
                            Console.WriteLine("Tõstad panust");
                            tõstmine = true;
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + panus);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + " ja varjatud kaart");
                        Console.WriteLine();
                        int index13 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne13 = Kaardipakk[index13];
                        summa1 = summa1 + ChosenOne13.väärtus;
                        Kaardipakk.RemoveAt(index13);
                        Console.WriteLine("Sa võtsid endale juurde \t" + ChosenOne13.Card);
                        Console.WriteLine();
                        Console.WriteLine("Sul on nüüd käes \t" + ChosenOne.Card + "\t" + ChosenOne3.Card + "\t" + ChosenOne5.Card +
                        "\t" + ChosenOne6.Card + "\t" + ChosenOne7.Card + "\t" + ChosenOne8.Card + "\t" + ChosenOne9.Card +
                        "\t" + ChosenOne10.Card + "\t" + ChosenOne11.Card + "\t" + ChosenOne12.Card + "\t" + ChosenOne13.Card);
                        if (ChosenOne13.väärtus == 11)
                        {
                            äss1++;
                        }

                        if (summa1 > 21)
                        {
                            if (äss1 > 0)
                            {
                                summa1 = summa1 - 10;
                                äss1 = äss1 - 1;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Sinu käe väärtus on " + summa1);
                        Console.WriteLine();
                        Console.WriteLine("Vajuta suvalist numbrit, et võtta kaart juurde, klahvi nr 2, et passida või klahvi nr 3, et tõsta panust");
                        ConsoleKeyInfo input10 = Console.ReadKey();
                        int sisend10 = int.Parse(input10.KeyChar.ToString());


                        if (sisend10 == 2)
                        {
                            Console.WriteLine("Passid");
                            break; //stand
                        }
                        if (sisend10 == 3)
                        {
                            Console.WriteLine("Tõstad panust");
                            tõstmine = true;
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + panus);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + " ja varjatud kaart");
                        Console.WriteLine();
                        int index14 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne14 = Kaardipakk[index14];
                        summa1 = summa1 + ChosenOne14.väärtus;
                        Kaardipakk.RemoveAt(index14);
                        Console.WriteLine("Sa võtsid endale juurde \t" + ChosenOne14.Card);
                        Console.WriteLine();
                        Console.WriteLine("Sul on nüüd käes \t" + ChosenOne.Card + "\t" + ChosenOne3.Card + "\t" + ChosenOne5.Card +
                        "\t" + ChosenOne6.Card + "\t" + ChosenOne7.Card + "\t" + ChosenOne8.Card + "\t" + ChosenOne9.Card +
                        "\t" + ChosenOne10.Card + "\t" + ChosenOne11.Card + "\t" + ChosenOne12.Card + "\t" + ChosenOne13.Card + "\t" + ChosenOne14.Card);
                        if (ChosenOne14.väärtus == 11)
                        {
                            äss1++;
                        }

                        if (summa1 > 21)
                        {
                            if (äss1 > 0)
                            {
                                summa1 = summa1 - 10;
                                äss1 = äss1 - 1;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Sinu käe väärtus on " + summa1);
                        Console.WriteLine();
                        Console.WriteLine("Vajuta suvalist numbrit, et võtta kaart juurde, klahvi nr 2, et passida või klahvi nr 3, et tõsta panust");
                        ConsoleKeyInfo input11 = Console.ReadKey();
                        int sisend11 = int.Parse(input11.KeyChar.ToString());


                        if (sisend11 == 2)
                        {
                            Console.WriteLine("Passid");
                            break; //stand
                        }
                        if (sisend11 == 3)
                        {
                            Console.WriteLine("Tõstad panust");
                            tõstmine = true;
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + panus);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + " ja varjatud kaart");
                        Console.WriteLine();
                        int index15 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne15 = Kaardipakk[index15];
                        summa1 = summa1 + ChosenOne15.väärtus;
                        Kaardipakk.RemoveAt(index15);
                        Console.WriteLine("Sa võtsid endale juurde \t" + ChosenOne15.Card);
                        Console.WriteLine();
                        Console.WriteLine("Sul on nüüd käes \t" + ChosenOne.Card + "\t" + ChosenOne3.Card + "\t" + ChosenOne5.Card +
                        "\t" + ChosenOne6.Card + "\t" + ChosenOne7.Card + "\t" + ChosenOne8.Card + "\t" + ChosenOne9.Card +
                        "\t" + ChosenOne10.Card + "\t" + ChosenOne11.Card + "\t" + ChosenOne12.Card + "\t" + ChosenOne13.Card +
                        "\t" + ChosenOne14.Card + "\t" + ChosenOne15.Card);
                        if (ChosenOne15.väärtus == 11)
                        {
                            äss1++;
                        }

                        if (summa1 > 21)
                        {
                            if (äss1 > 0)
                            {
                                summa1 = summa1 - 10;
                                äss1 = äss1 - 1;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Sinu käe väärtus on " + summa1);
                        Console.WriteLine();
                        Console.WriteLine("Vajuta suvalist numbrit, et võtta kaart juurde, klahvi nr 2, et passida või klahvi nr 3, et tõsta panust");
                        ConsoleKeyInfo input12 = Console.ReadKey();
                        int sisend12 = int.Parse(input12.KeyChar.ToString());


                        if (sisend12 == 2)
                        {
                            Console.WriteLine("Passid");
                            break; //stand
                        }
                        if (sisend12 == 3)
                        {
                            Console.WriteLine("Tõstad panust");
                            tõstmine = true;
                            break;
                        }

                        Console.Clear();
                        Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + panus);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + " ja varjatud kaart");
                        Console.WriteLine();
                        int index16 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne16 = Kaardipakk[index16];
                        summa1 = summa1 + ChosenOne16.väärtus;
                        Kaardipakk.RemoveAt(index16);
                        Console.WriteLine("Sa võtsid endale juurde \t" + ChosenOne16.Card);
                        Console.WriteLine();
                        Console.WriteLine("Sul on nüüd käes \t" + ChosenOne.Card + "\t" + ChosenOne3.Card + "\t" + ChosenOne5.Card +
                        "\t" + ChosenOne6.Card + "\t" + ChosenOne7.Card + "\t" + ChosenOne8.Card + "\t" + ChosenOne9.Card +
                        "\t" + ChosenOne10.Card + "\t" + ChosenOne11.Card + "\t" + ChosenOne12.Card + "\t" + ChosenOne13.Card +
                        "\t" + ChosenOne14.Card + "\t" + ChosenOne15.Card + "\t" + ChosenOne16.Card);
                        if (ChosenOne16.väärtus == 11)
                        {
                            äss1++;
                        }

                        if (summa1 > 21)
                        {
                            if (äss1 > 0)
                            {
                                summa1 = summa1 - 10;
                                äss1 = äss1 - 1;
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Sinu käe väärtus on " + summa1);
                    }
                    while (tõstmine)
                    {
                        kontoseis = kontoseis - panus;
                        panus = panus + panus;
                        Console.Clear();
                        Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + panus);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + " ja varjatud kaart");
                        Console.WriteLine();
                        int index30 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne30 = Kaardipakk[index30];
                        summa1 = summa1 + ChosenOne30.väärtus;
                        Kaardipakk.RemoveAt(index30);
                        Console.WriteLine("Sa duubeldasid panust");
                        Console.WriteLine("Sa võtsid uue kaardi: " + ChosenOne30.mast + " " + ChosenOne30.tugevus);
                        if (ChosenOne30.väärtus == 11)
                        {
                            äss1++;
                        }
                        Console.WriteLine("Sinu käe väärtus on " + summa1);
                        if (summa1 > 21)
                        {
                            if (äss1 > 0)
                            {
                                summa1 = summa1 - 10;
                                äss1 = äss1 - 1;
                            }
                        }
                        break;
                    }
                    if (summa1 > 21)
                    {
                        võrdlus = false;
                        diiler = false;
                        plusskonto = false;
                        Console.WriteLine("Kahjuks läksid Sa lõhki ja jääd rahast ilma!");
                        Console.WriteLine();
                        Console.WriteLine("Sinu käe väärtus oli " + summa1);
                    }



                    while (diiler)
                    {
                        Console.Clear();
                        if (tõstmine)
                        {
                            Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + (panus + panus));
                        }
                        else
                        {
                            Console.WriteLine("Sinu kontoseis on:\t" + kontoseis + "\t" + "Sinu panus on:\t" + panus);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Sinu käe väärtus on " + summa1);
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + "\t" + ChosenOne4.Card);
                        Console.WriteLine();
                        if (summa2 == 21)
                        {
                            Console.WriteLine("Diileril on BlackJack!");
                            break;
                        }
                        if (summa2 > 21)
                        {
                            if (äss2 > 0)
                            {
                                summa2 = summa2 - 10;
                                äss2 = äss2 - 1;
                            }
                        }
                        if (summa2 >= 17)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2 + "ja diiler passib");
                            break;
                        }

                        Console.WriteLine("Diileri käe väärtus on " + summa2);
                        Console.WriteLine();
                        int index17 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne17 = Kaardipakk[index17];
                        summa2 = summa2 + ChosenOne17.väärtus;
                        Kaardipakk.RemoveAt(index17);
                        Console.WriteLine("Diiler võttis uue kaardi " + ChosenOne17.Card);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + "\t" + ChosenOne4.Card + "\t" + ChosenOne17.Card);
                        Console.WriteLine();
                        if (ChosenOne17.väärtus == 11)
                        {
                            äss2++;
                        }

                        if (summa2 > 21)
                        {
                            if (äss2 > 0)
                            {
                                summa2 = summa2 - 10;
                                äss2 = äss2 - 1;
                            }
                        }
                        if (summa2 > 21)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2);
                            Console.WriteLine();
                            Console.WriteLine("Diiler läks lõhki, Sa võitsid!");
                            plusskonto = true;
                            võrdlus = false;
                            break;
                        }
                        if (summa2 >= 17)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2 + "ja diiler passib");
                            break;
                        }

                        Console.WriteLine("Diileri käe väärtus on " + summa2);
                        Console.WriteLine();
                        int index18 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne18 = Kaardipakk[index18];
                        summa2 = summa2 + ChosenOne18.väärtus;
                        Kaardipakk.RemoveAt(index18);
                        Console.WriteLine("Diiler võttis uue kaardi " + ChosenOne18.Card);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + "\t" + ChosenOne4.Card + "\t" + ChosenOne17.Card + "\t" + ChosenOne18.Card);
                        Console.WriteLine();
                        if (ChosenOne18.väärtus == 11)
                        {
                            äss2++;
                        }

                        if (summa2 > 21)
                        {
                            if (äss2 > 0)
                            {
                                summa2 = summa2 - 10;
                                äss2 = äss2 - 1;
                            }
                        }
                        if (summa2 > 21)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2);
                            Console.WriteLine();
                            Console.WriteLine("Diiler läks lõhki, Sa võitsid!");
                            plusskonto = true;
                            võrdlus = false;
                            break;
                        }
                        if (summa2 >= 17)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2 + "ja diiler passib");
                            break;
                        }

                        Console.WriteLine("Diileri käe väärtus on " + summa2);
                        Console.WriteLine();
                        int index19 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne19 = Kaardipakk[index19];
                        summa2 = summa2 + ChosenOne19.väärtus;
                        Kaardipakk.RemoveAt(index19);
                        Console.WriteLine("Diiler võttis uue kaardi " + ChosenOne19.Card);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + "\t" + ChosenOne4.Card + "\t" + ChosenOne17.Card + "\t" + ChosenOne18.Card +
                        "\t" + ChosenOne19.Card);
                        Console.WriteLine();
                        if (ChosenOne19.väärtus == 11)
                        {
                            äss2++;
                        }

                        if (summa2 > 21)
                        {
                            if (äss2 > 0)
                            {
                                summa2 = summa2 - 10;
                                äss2 = äss2 - 1;
                            }
                        }
                        if (summa2 > 21)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2);
                            Console.WriteLine();
                            Console.WriteLine("Diiler läks lõhki, Sa võitsid!");
                            plusskonto = true;
                            võrdlus = false;
                            break;
                        }
                        if (summa2 >= 17)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2 + "ja diiler passib");
                            break;
                        }
                        Console.WriteLine("Diileri käe väärtus on " + summa2);
                        Console.WriteLine();
                        int index20 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne20 = Kaardipakk[index20];
                        summa2 = summa2 + ChosenOne20.väärtus;
                        Kaardipakk.RemoveAt(index20);
                        Console.WriteLine("Diiler võttis uue kaardi " + ChosenOne20.Card);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + "\t" + ChosenOne4.Card + "\t" + ChosenOne17.Card + "\t" + ChosenOne18.Card +
                        "\t" + ChosenOne19.Card + "\t" + ChosenOne20.Card);
                        Console.WriteLine();
                        if (ChosenOne20.väärtus == 11)
                        {
                            äss2++;
                        }

                        if (summa2 > 21)
                        {
                            if (äss2 > 0)
                            {
                                summa2 = summa2 - 10;
                                äss2 = äss2 - 1;
                            }
                        }
                        if (summa2 > 21)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2);
                            Console.WriteLine();
                            Console.WriteLine("Diiler läks lõhki, Sa võitsid!");
                            plusskonto = true;
                            võrdlus = false;
                            break;
                        }
                        if (summa2 >= 17)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2 + "ja diiler passib");
                            break;
                        }
                        Console.WriteLine("Diileri käe väärtus on " + summa2);
                        Console.WriteLine();
                        int index21 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne21 = Kaardipakk[index21];
                        summa2 = summa2 + ChosenOne21.väärtus;
                        Kaardipakk.RemoveAt(index21);
                        Console.WriteLine("Diiler võttis uue kaardi " + ChosenOne21.Card);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + "\t" + ChosenOne4.Card + "\t" + ChosenOne17.Card + "\t" + ChosenOne18.Card +
                        "\t" + ChosenOne19.Card + "\t" + ChosenOne20.Card + "\t" + ChosenOne21.Card);
                        Console.WriteLine();
                        if (ChosenOne21.väärtus == 11)
                        {
                            äss2++;
                        }

                        if (summa2 > 21)
                        {
                            if (äss2 > 0)
                            {
                                summa2 = summa2 - 10;
                                äss2 = äss2 - 1;
                            }
                        }
                        if (summa2 > 21)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2);
                            Console.WriteLine();
                            Console.WriteLine("Diiler läks lõhki, Sa võitsid!");
                            plusskonto = true;
                            võrdlus = false;
                            break;
                        }
                        if (summa2 >= 17)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2 + "ja diiler passib");
                            break;
                        }
                        Console.WriteLine("Diileri käe väärtus on " + summa2);
                        Console.WriteLine();
                        int index22 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne22 = Kaardipakk[index22];
                        summa2 = summa2 + ChosenOne22.väärtus;
                        Kaardipakk.RemoveAt(index22);
                        Console.WriteLine("Diiler võttis uue kaardi " + ChosenOne22.Card);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + "\t" + ChosenOne4.Card + "\t" + ChosenOne17.Card + "\t" + ChosenOne18.Card +
                        "\t" + ChosenOne19.Card + "\t" + ChosenOne20.Card + "\t" + ChosenOne21.Card + "\t" + ChosenOne22.Card);
                        Console.WriteLine();
                        if (ChosenOne22.väärtus == 11)
                        {
                            äss2++;
                        }

                        if (summa2 > 21)
                        {
                            if (äss2 > 0)
                            {
                                summa2 = summa2 - 10;
                                äss2 = äss2 - 1;
                            }
                        }
                        if (summa2 > 21)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2);
                            Console.WriteLine();
                            Console.WriteLine("Diiler läks lõhki, Sa võitsid!");
                            plusskonto = true;
                            võrdlus = false;
                            break;
                        }
                        if (summa2 >= 17)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2 + "ja diiler passib");
                            break;
                        }
                        Console.WriteLine("Diileri käe väärtus on " + summa2);
                        Console.WriteLine();
                        int index23 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne23 = Kaardipakk[index23];
                        summa2 = summa2 + ChosenOne23.väärtus;
                        Kaardipakk.RemoveAt(index23);
                        Console.WriteLine("Diiler võttis uue kaardi " + ChosenOne23.Card);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + "\t" + ChosenOne4.Card + "\t" + ChosenOne17.Card + "\t" + ChosenOne18.Card +
                        "\t" + ChosenOne19.Card + "\t" + ChosenOne20.Card + "\t" + ChosenOne21.Card + "\t" + ChosenOne22.Card + "\t" + ChosenOne23.Card);
                        Console.WriteLine();
                        if (ChosenOne23.väärtus == 11)
                        {
                            äss2++;
                        }

                        if (summa2 > 21)
                        {
                            if (äss2 > 0)
                            {
                                summa2 = summa2 - 10;
                                äss2 = äss2 - 1;
                            }
                        }
                        if (summa2 > 21)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2);
                            Console.WriteLine();
                            Console.WriteLine("Diiler läks lõhki, Sa võitsid!");
                            plusskonto = true;
                            võrdlus = false;
                            break;
                        }
                        if (summa2 >= 17)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2 + "ja diiler passib");
                            break;
                        }
                        Console.WriteLine("Diileri käe väärtus on " + summa2);
                        Console.WriteLine();
                        int index24 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne24 = Kaardipakk[index24];
                        summa2 = summa2 + ChosenOne24.väärtus;
                        Kaardipakk.RemoveAt(index24);
                        Console.WriteLine("Diiler võttis uue kaardi " + ChosenOne24.Card);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + "\t" + ChosenOne4.Card + "\t" + ChosenOne17.Card + "\t" + ChosenOne18.Card +
                        "\t" + ChosenOne19.Card + "\t" + ChosenOne20.Card + "\t" + ChosenOne21.Card + "\t" + ChosenOne22.Card + "\t" + ChosenOne23.Card +
                        "\t" + ChosenOne24.Card);
                        Console.WriteLine();
                        if (ChosenOne24.väärtus == 11)
                        {
                            äss2++;
                        }

                        if (summa2 > 21)
                        {
                            if (äss2 > 0)
                            {
                                summa2 = summa2 - 10;
                                äss2 = äss2 - 1;
                            }
                        }
                        if (summa2 > 21)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2);
                            Console.WriteLine();
                            Console.WriteLine("Diiler läks lõhki, Sa võitsid!");
                            plusskonto = true;
                            võrdlus = false;
                            break;
                        }
                        if (summa2 >= 17)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2 + "ja diiler passib");
                            break;
                        }
                        Console.WriteLine("Diileri käe väärtus on " + summa2);
                        Console.WriteLine();
                        int index25 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne25 = Kaardipakk[index25];
                        summa2 = summa2 + ChosenOne25.väärtus;
                        Kaardipakk.RemoveAt(index25);
                        Console.WriteLine("Diiler võttis uue kaardi " + ChosenOne25.Card);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + "\t" + ChosenOne4.Card + "\t" + ChosenOne17.Card + "\t" + ChosenOne18.Card +
                        "\t" + ChosenOne19.Card + "\t" + ChosenOne20.Card + "\t" + ChosenOne21.Card + "\t" + ChosenOne22.Card + "\t" + ChosenOne23.Card +
                        "\t" + ChosenOne24.Card + "\t" + ChosenOne25.Card);
                        Console.WriteLine();
                        if (ChosenOne25.väärtus == 11)
                        {
                            äss2++;
                        }

                        if (summa2 > 21)
                        {
                            if (äss2 > 0)
                            {
                                summa2 = summa2 - 10;
                                äss2 = äss2 - 1;
                            }
                        }
                        if (summa2 > 21)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2);
                            Console.WriteLine();
                            Console.WriteLine("Diiler läks lõhki, Sa võitsid!");
                            plusskonto = true;
                            võrdlus = false;
                            break;
                        }
                        if (summa2 >= 17)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2 + "ja diiler passib");
                            break;
                        }
                        Console.WriteLine("Diileri käe väärtus on " + summa2);
                        Console.WriteLine();
                        int index26 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne26 = Kaardipakk[index26];
                        summa2 = summa2 + ChosenOne26.väärtus;
                        Kaardipakk.RemoveAt(index26);
                        Console.WriteLine("Diiler võttis uue kaardi " + ChosenOne26.Card);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + "\t" + ChosenOne4.Card + "\t" + ChosenOne17.Card + "\t" + ChosenOne18.Card +
                        "\t" + ChosenOne19.Card + "\t" + ChosenOne20.Card + "\t" + ChosenOne21.Card + "\t" + ChosenOne22.Card + "\t" + ChosenOne23.Card +
                        "\t" + ChosenOne24.Card + "\t" + ChosenOne25.Card + "\t" + ChosenOne26.Card);
                        Console.WriteLine();
                        if (ChosenOne26.väärtus == 11)
                        {
                            äss2++;
                        }

                        if (summa2 > 21)
                        {
                            if (äss2 > 0)
                            {
                                summa2 = summa2 - 10;
                                äss2 = äss2 - 1;
                            }
                        }
                        if (summa2 > 21)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2);
                            Console.WriteLine();
                            Console.WriteLine("Diiler läks lõhki, Sa võitsid!");
                            plusskonto = true;
                            võrdlus = false;
                            break;
                        }
                        if (summa2 >= 17)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2 + "ja diiler passib");
                            break;
                        }
                        Console.WriteLine("Diileri käe väärtus on " + summa2);
                        Console.WriteLine();
                        int index27 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne27 = Kaardipakk[index27];
                        summa2 = summa2 + ChosenOne27.väärtus;
                        Kaardipakk.RemoveAt(index27);
                        Console.WriteLine("Diiler võttis uue kaardi " + ChosenOne27.Card);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + "\t" + ChosenOne4.Card + "\t" + ChosenOne17.Card + "\t" + ChosenOne18.Card +
                        "\t" + ChosenOne19.Card + "\t" + ChosenOne20.Card + "\t" + ChosenOne21.Card + "\t" + ChosenOne22.Card + "\t" + ChosenOne23.Card +
                        "\t" + ChosenOne24.Card + "\t" + ChosenOne25.Card + "\t" + ChosenOne26.Card + "\t" + ChosenOne27.Card);
                        Console.WriteLine();
                        if (ChosenOne27.väärtus == 11)
                        {
                            äss2++;
                        }

                        if (summa2 > 21)
                        {
                            if (äss2 > 0)
                            {
                                summa2 = summa2 - 10;
                                äss2 = äss2 - 1;
                            }
                        }
                        if (summa2 > 21)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2);
                            Console.WriteLine();
                            Console.WriteLine("Diiler läks lõhki, Sa võitsid!");
                            plusskonto = true;
                            võrdlus = false;
                            break;
                        }
                        if (summa2 >= 17)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2 + "ja diiler passib");
                            break;
                        }
                        Console.WriteLine("Diileri käe väärtus on " + summa2);
                        Console.WriteLine();
                        int index28 = rnd.Next(Kaardipakk.Count);
                        var ChosenOne28 = Kaardipakk[index28];
                        summa2 = summa2 + ChosenOne28.väärtus;
                        Kaardipakk.RemoveAt(index28);
                        Console.WriteLine("Diiler võttis uue kaardi " + ChosenOne28.Card);
                        Console.WriteLine();
                        Console.WriteLine("Diileri kaardid on \t" + ChosenOne2.Card + "\t" + ChosenOne4.Card + "\t" + ChosenOne17.Card + "\t" + ChosenOne18.Card +
                        "\t" + ChosenOne19.Card + "\t" + ChosenOne20.Card + "\t" + ChosenOne21.Card + "\t" + ChosenOne22.Card + "\t" + ChosenOne23.Card +
                        "\t" + ChosenOne24.Card + "\t" + ChosenOne25.Card + "\t" + ChosenOne26.Card + "\t" + ChosenOne27.Card + "\t" + ChosenOne28.Card);
                        Console.WriteLine();
                        if (ChosenOne28.väärtus == 11)
                        {
                            äss2++;
                        }

                        if (summa2 > 21)
                        {
                            if (äss2 > 0)
                            {
                                summa2 = summa2 - 10;
                                äss2 = äss2 - 1;
                            }
                        }
                        if (summa2 > 21)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2);
                            Console.WriteLine();
                            Console.WriteLine("Diiler läks lõhki, Sa võitsid!");
                            plusskonto = true;
                            võrdlus = false;
                            break;
                        }
                        if (summa2 >= 17)
                        {
                            Console.WriteLine("Diileri käe väärtus on " + summa2 + "ja diiler passib");
                            break;
                        }
                    }
                    while (võrdlus)
                    {
                        //võrdle käte suurusi ja vali võitja
                        if (summa1 > summa2)
                        {
                            Console.WriteLine("Palju õnne, Sa võitsid!");
                            Console.WriteLine("Sinu käe väärtus oli " + summa1);
                            Console.WriteLine("Diileri käe väärtus oli " + summa2);
                            plusskonto = true;
                            break;
                        }
                        if (summa2 > summa1)
                        {
                            Console.WriteLine("Kahjuks diiler võitis!");
                            Console.WriteLine("Sinu käe väärtus oli " + summa1);
                            Console.WriteLine("Diileri käe väärtus oli " + summa2);
                            break;
                        }
                        if (summa1 == summa2)
                        {
                            Console.WriteLine("Jäite diileriga viiki!");
                            Console.WriteLine("Sinu käe väärtus oli " + summa1);
                            Console.WriteLine("Diileri käe väärtus oli " + summa2);
                            kontoseis = kontoseis + panus;
                            break;
                        }
                    }
                    while (plusskonto)
                    {
                        if (tõstmine)
                        {
                            kontoseis = kontoseis + panus + panus + panus + panus;
                            Console.WriteLine();
                            Console.WriteLine("Sa võitsid " + (panus + panus + panus + panus) + " raha");
                        }
                        else
                        {
                            kontoseis = kontoseis + panus + panus;
                            Console.WriteLine();
                            Console.WriteLine("Sa võitsid " + (panus + panus) + " raha");
                        }
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Uue mängu jaoks vajuta numbrit 1 kuni 8");
                    Console.WriteLine("Juhul kui sa soovid mängimise lõpetada, siis sisesta 9");
                    ConsoleKeyInfo väljumiseks = Console.ReadKey();
                    int väljumine = int.Parse(väljumiseks.KeyChar.ToString());
                    if (väljumine == 9)
                    {
                        break;
                    }

                    Console.Clear();
                }
            }


        }

    }
}