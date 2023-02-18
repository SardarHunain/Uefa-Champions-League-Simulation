using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Groups
    {
        string[] group1 = { "Juventus", "Bayern Munchen", "Club Brugge", "Rapid" };
        int[] p1 = { 0, 0, 0, 0 };
        int[] goals1 = { 0, 0, 0, 0 };
        int[] Conceded1 = { 0, 0, 0, 0 };

        string[] group2 = { "Barcelona", "Werder Bremen", "Udinese", "Panathinaikos" };
        int[] p2 = { 0, 0, 0, 0 };
        int[] goals2 = { 0, 0, 0, 0 };
        int[] Conceded2 = { 0, 0, 0, 0 };

        string[] group3 = { "AC Milan", "PSV", "FC Schalke", "Fenerbahce" };
        int[] p3 = { 0, 0, 0, 0 };
        int[] goals3 = { 0, 0, 0, 0 };
        int[] Conceded3 = { 0, 0, 0, 0 };

        string[] group4 = { "Liverpool", "Chelsea", "Real Betis", "Anderlecht" };
        int[] p4 = { 0, 0, 0, 0 };
        int[] goals4 = { 0, 0, 0, 0 };
        int[] Conceded4 = { 0, 0, 0, 0 };

        string[] group5 = { "Arsenal", "Ajax", "Thun", "Sparta" };
        int[] p5 = { 0, 0, 0, 0 };
        int[] goals5 = { 0, 0, 0, 0 };
        int[] Conceded5 = { 0, 0, 0, 0 };

        string[] group6 = { "Villareal", "Benfica", "Lille", "Manchester United" };
        int[] p6 = { 0, 0, 0, 0 };
        int[] goals6 = { 0, 0, 0, 0 };
        int[] Conceded6 = { 0, 0, 0, 0 };

        string[] group7 = { "Lyon", "Real Madrid", "Rosenborg", "Olympiacos" };
        int[] p7 = { 0, 0, 0, 0 };
        int[] goals7 = { 0, 0, 0, 0 };
        int[] Conceded7 = { 0, 0, 0, 0 };

        string[] group8 = { "Internazionale", "Rangers", "Artmedia", "Porto" };
        int[] p8 = { 0, 0, 0, 0 };
        int[] goals8 = { 0, 0, 0, 0 };
        int[] Conceded8 = { 0, 0, 0, 0 };        
        public void displayGroups()
        {
            Console.WriteLine("\t\t\t\t\t******Group Stage Draws******");
            Console.WriteLine("\t\t\t\t*************************");
            Console.WriteLine("\t\t\t\t\tGroup1");
            for (int i = 0; i < group1.Length; i++)
            {
                Console.WriteLine("*" + group1[i]);
            }
            Console.WriteLine("\t\t\t\t*************************");

            Console.WriteLine("\t\t\t\t\tGroup2");
            for (int i = 0; i < group2.Length; i++)
            {
                Console.WriteLine("*" + group2[i]);
            }
            Console.WriteLine("\t\t\t\t*************************");

            Console.WriteLine("\t\t\t\t\tGroup3");
            for (int i = 0; i < group3.Length; i++)
            {
                Console.WriteLine("*" + group3[i]);
            }
            Console.WriteLine("\t\t\t\t*************************");


            Console.WriteLine("\t\t\t\t\tGroup4");
            for (int i = 0; i < group4.Length; i++)
            {
                Console.WriteLine("*" + group4[i]);
            }
            Console.WriteLine("\t\t\t\t*************************");

            Console.WriteLine("\t\t\t\t\tGroup5");
            for (int i = 0; i < group5.Length; i++)
            {
                Console.WriteLine("*" + group5[i]);
            }
            Console.WriteLine("\t\t\t\t*************************");


            Console.WriteLine("\t\t\t\t\tGroup6");
            for (int i = 0; i < group6.Length; i++)
            {
                Console.WriteLine("*" + group6[i]);
            }
            Console.WriteLine("\t\t\t\t*************************");


            Console.WriteLine("\t\t\t\t\tGroup7");
            for (int i = 0; i < group7.Length; i++)
            {
                Console.WriteLine("*" + group7[i]);
            }
            Console.WriteLine("\t\t\t\t*************************");


            Console.WriteLine("\t\t\t\t\tGroup8");
            for (int i = 0; i < group8.Length; i++)
            {
                Console.WriteLine("*" + group8[i]);
            }
            Console.WriteLine();
            Console.WriteLine("************************************************************************************************************************");
        }
        public void Matches()
        {
            displayGroups();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t************Matchday 1*************");
            Console.WriteLine(group1[1] + "  vs      " + group1[2]);
            Console.WriteLine(group2[1] + "\tvs\t" + group2[2]);
            Console.WriteLine(group3[1] + "\t\tvs\t" + group3[2]);
            Console.WriteLine(group4[1] + "\t\tvs\t" + group4[2]);
            Console.WriteLine(group5[1] + "\t\tvs\t" + group5[2]);
            Console.WriteLine(group6[1] + "\t\tvs\t" + group6[2]);
            Console.WriteLine(group7[1] + "\tvs\t" + group7[2]);
            Console.WriteLine(group8[1] + "\t\tvs\t" + group8[2]);
            Console.WriteLine("\t\t\t------------------");
            Console.WriteLine(group1[0] + "  \tvs      " + group1[3]);
            Console.WriteLine(group2[0] + "\tvs\t" + group2[3]);
            Console.WriteLine(group3[0] + "\tvs\t" + group3[3]);
            Console.WriteLine(group4[0] + "\tvs\t" + group4[3]);
            Console.WriteLine(group5[0] + "\t\tvs\t" + group5[3]);
            Console.WriteLine(group6[0] + "\tvs\t" + group6[3]);
            Console.WriteLine(group7[0] + "\t\tvs\t" + group7[3]);
            Console.WriteLine(group8[0] + "\tvs\t" + group8[3]);

            Console.WriteLine("\t\t\t\t************Matchday 2*************");
            Console.WriteLine(group1[0] + "  \tvs      " + group1[1]);
            Console.WriteLine(group2[0] + "\tvs\t" + group2[1]);
            Console.WriteLine(group3[0] + "\tvs\t" + group3[1]);
            Console.WriteLine(group4[0] + "\tvs\t" + group4[1]);
            Console.WriteLine(group5[0] + "\t\tvs\t" + group5[1]);
            Console.WriteLine(group6[0] + "\tvs\t" + group6[1]);
            Console.WriteLine(group7[0] + "\t\tvs\t" + group7[1]);
            Console.WriteLine(group8[0] + "\tvs\t" + group8[1]);
            Console.WriteLine("\t\t\t------------------");
            Console.WriteLine(group1[2] + "  \tvs      " + group1[1]);
            Console.WriteLine(group2[2] + "\t\tvs\t" + group2[3]);
            Console.WriteLine(group3[2] + "\tvs\t" + group3[3]);
            Console.WriteLine(group4[2] + "\tvs\t" + group4[3]);
            Console.WriteLine(group5[2] + "\t\tvs\t" + group5[3]);
            Console.WriteLine(group6[2] + "\t\tvs\t" + group6[3]);
            Console.WriteLine(group7[2] + "\tvs\t" + group7[3]);
            Console.WriteLine(group8[2] + "\tvs\t" + group8[3]);

            Console.WriteLine("\t\t\t\t************Matchday 3*************");
            Console.WriteLine(group1[2] + "     vs      " + group1[0]);
            Console.WriteLine(group2[2] + "\t\tvs\t" + group2[0]);
            Console.WriteLine(group3[2] + "\tvs\t" + group3[0]);
            Console.WriteLine(group4[2] + "\tvs\t" + group4[0]);
            Console.WriteLine(group5[2] + "\t\tvs\t" + group5[0]);
            Console.WriteLine(group6[2] + "\t\tvs\t" + group6[0]);
            Console.WriteLine(group7[2] + "\tvs\t" + group7[0]);
            Console.WriteLine(group8[2] + "\tvs\t" + group8[0]);
            Console.WriteLine("\t\t\t------------------");
            Console.WriteLine(group1[1] + "  vs      " + group1[0]);
            Console.WriteLine(group2[1] + "\tvs\t" + group2[3]);
            Console.WriteLine(group3[1] + "\t\tvs\t" + group3[3]);
            Console.WriteLine(group4[1] + "\t\tvs\t" + group4[3]);
            Console.WriteLine(group5[1] + "\t\tvs\t" + group5[3]);
            Console.WriteLine(group6[1] + "\t\tvs\t" + group6[3]);
            Console.WriteLine(group7[1] + "\tvs\t" + group7[3]);
            Console.WriteLine(group8[1] + "\t\tvs\t" + group8[3]);

            Console.WriteLine("\t\t\t\t************Matchday 4*************");
            Console.WriteLine(group1[0] + "  \tvs      " + group1[2]);
            Console.WriteLine(group2[0] + "\tvs\t" + group2[2]);
            Console.WriteLine(group3[0] + "\tvs\t" + group3[2]);
            Console.WriteLine(group4[0] + "\tvs\t" + group4[2]);
            Console.WriteLine(group5[0] + "\t\tvs\t" + group5[2]);
            Console.WriteLine(group6[0] + "\tvs\t" + group6[2]);
            Console.WriteLine(group7[0] + "\t\tvs\t" + group7[2]);
            Console.WriteLine(group8[0] + "\tvs\t" + group8[2]);
            Console.WriteLine("\t\t\t------------------");
            Console.WriteLine(group1[3] + "  \t\tvs      " + group1[1]);
            Console.WriteLine(group2[3] + "\tvs\t" + group2[1]);
            Console.WriteLine(group3[3] + "\tvs\t" + group3[1]);
            Console.WriteLine(group4[3] + "\tvs\t" + group4[1]);
            Console.WriteLine(group5[3] + "\t\tvs\t" + group5[1]);
            Console.WriteLine(group6[3] + "vs\t" + group6[1]);
            Console.WriteLine(group7[3] + "\tvs\t" + group7[1]);
            Console.WriteLine(group8[3] + "\t\tvs\t" + group8[1]);

            Console.WriteLine("\t\t\t\t************Matchday 5*************");
            Console.WriteLine(group1[2] + "     vs      " + group1[1]);
            Console.WriteLine(group2[2] + "\t\tvs\t" + group2[1]);
            Console.WriteLine(group3[2] + "\tvs\t" + group3[1]);
            Console.WriteLine(group4[2] + "\tvs\t" + group4[1]);
            Console.WriteLine(group5[2] + "\t\tvs\t" + group5[1]);
            Console.WriteLine(group6[2] + "\t\tvs\t" + group6[1]);
            Console.WriteLine(group7[2] + "\tvs\t" + group7[1]);
            Console.WriteLine(group8[2] + "\tvs\t" + group8[1]);
            Console.WriteLine("\t\t\t------------------");
            Console.WriteLine(group1[0] + "  \tvs      " + group1[3]);
            Console.WriteLine(group2[0] + "\tvs\t" + group2[3]);
            Console.WriteLine(group3[0] + "\tvs\t" + group3[3]);
            Console.WriteLine(group4[0] + "\tvs\t" + group4[3]);
            Console.WriteLine(group5[0] + "\t\tvs\t" + group5[3]);
            Console.WriteLine(group6[0] + "\tvs\t" + group6[3]);
            Console.WriteLine(group7[0] + "\t\tvs\t" + group7[3]);
            Console.WriteLine(group8[0] + "\tvs\t" + group8[3]);

            Console.WriteLine("\t\t\t\t************Matchday 6*************");
            Console.WriteLine(group1[1] + "  vs      " + group1[0]);
            Console.WriteLine(group2[1] + "\tvs\t" + group2[0]);
            Console.WriteLine(group3[1] + "\t\tvs\t" + group3[0]);
            Console.WriteLine(group4[1] + "\t\tvs\t" + group4[0]);
            Console.WriteLine(group5[1] + "\t\tvs\t" + group5[0]);
            Console.WriteLine(group6[1] + "\t\tvs\t" + group6[0]);
            Console.WriteLine(group7[1] + "\tvs\t" + group7[0]);
            Console.WriteLine(group8[1] + "\t\tvs\t" + group8[0]);
            Console.WriteLine("\t\t\t------------------");
            Console.WriteLine(group1[3] + "  \t\tvs      " + group1[2]);
            Console.WriteLine(group2[3] + "\tvs\t" + group2[2]);
            Console.WriteLine(group3[3] + "\tvs\t" + group3[2]);
            Console.WriteLine(group4[3] + "\tvs\t" + group4[2]);
            Console.WriteLine(group5[3] + "\t\tvs\t" + group5[2]);
            Console.WriteLine(group6[3] + "vs\t" + group6[2]);
            Console.WriteLine(group7[3] + "\tvs\t" + group7[2]);
            Console.WriteLine(group8[3] + "\t\tvs\t" + group8[2]);

        }
        public void results()
        {
            Random rand = new Random();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t************Matchday 1 Results*************");
            int a = rand.Next(7);
            int b = rand.Next(7);
            if (a > b)
            {
                p1[1] += 3;
            }
            else if (a == b)
            {
                p1[1] += 1;
                p1[2] += 1;
            }
            else
            {
                p1[2] += 3;
            }
            Console.WriteLine(group1[1] + "  vs      " + group1[2] + "(" + a + ":" + b + ")");
            goals1[1] += a;
            goals1[2] += b;
            Conceded1[1] += b;
            Conceded1[2] += a;
            
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p2[1] += 3;
            }
            else if (a == b)
            {
                p2[1] += 1;
                p2[2] += 1;
            }
            else
            {
                p2[2] += 3;
            }
            Console.WriteLine(group2[1] + "\tvs\t" + group2[2] + "(" + a + ":" + b + ")");
            goals2[1] += a;
            goals2[2] += b;
            Conceded2[1] += b;
            Conceded2[2] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p3[1] += 3;
            }
            else if (a == b)
            {
                p3[1] += 1;
                p3[2] += 1;
            }
            else
            {
                p3[2] += 3;
            }
            Console.WriteLine(group3[1] + "\t\tvs\t" + group3[2] + "(" + a + ":" + b + ")");
            goals3[1] += a;
            goals3[2] += b;
            Conceded3[1] += b;
            Conceded3[2] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p4[1] += 3;
            }
            else if (a == b)
            {
                p4[1] += 1;
                p4[2] += 1;
            }
            else
            {
                p4[2] += 3;
            }
            Console.WriteLine(group4[1] + "\t\tvs\t" + group4[2] + "(" + a + ":" + b + ")");
            goals4[1] += a;
            goals4[2] += b;
            Conceded4[1] += b;
            Conceded4[2] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p5[1] += 3;
            }
            else if (a == b)
            {
                p5[1] += 1;
                p5[2] += 1;
            }
            else
            {
                p5[2] += 3;
            }
            Console.WriteLine(group5[1] + "\t\tvs\t" + group5[2] + "(" + a + ":" + b + ")");
            goals5[1] += a;
            goals5[2] += b;
            Conceded5[1] += b;
            Conceded5[2] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p6[1] += 3;
            }
            else if (a == b)
            {
                p6[1] += 1;
                p6[2] += 1;
            }
            else
            {
                p6[2] += 3;
            }
            Console.WriteLine(group6[1] + "\t\tvs\t" + group6[2] + "(" + a + ":" + b + ")");
            goals6[1] += a;
            goals6[2] += b;
            Conceded6[1] += b;
            Conceded6[2] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p7[1] += 3;
            }
            else if (a == b)
            {
                p7[1] += 1;
                p7[2] += 1;
            }
            else
            {
                p7[2] += 3;
            }
            Console.WriteLine(group7[1] + "\tvs\t" + group7[2] + "(" + a + ":" + b + ")");
            goals7[1] += a;
            goals7[2] += b;
            Conceded7[1] += b;
            Conceded7[2] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p8[1] += 3;
            }
            else if (a == b)
            {
                p8[1] += 1;
                p8[2] += 1;
            }
            else
            {
                p8[2] += 3;
            }
            Console.WriteLine(group8[1] + "\t\tvs\t" + group8[2] + "(" + a + ":" + b + ")");
            goals8[1] += a;
            goals8[2] += b;
            Conceded8[1] += b;
            Conceded8[2] += a;
            Console.WriteLine("\t\t\t------------------");
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p1[0] += 3;
            }
            else if (a == b)
            {
                p1[0] += 1;
                p1[3] += 1;
            }
            else
            {
                p1[3] += 3;
            }
            Console.WriteLine(group1[0] + "  \tvs      " + group1[3] + "(" + a + ":" + b + ")");
            goals1[0] += a;
            goals1[3] += b;
            Conceded1[0] += b;
            Conceded1[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p2[0] += 3;
            }
            else if (a == b)
            {
                p2[0] += 1;
                p2[3] += 1;
            }
            else
            {
                p2[3] += 3;
            }
            Console.WriteLine(group2[0] + "\tvs\t" + group2[3] + "(" + a + ":" + b + ")");
            goals2[0] += a;
            goals2[3] += b;
            Conceded2[0] += b;
            Conceded2[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p3[0] += 3;
            }
            else if (a == b)
            {
                p3[0] += 1;
                p3[3] += 1;
            }
            else
            {
                p3[3] += 3;
            }
            Console.WriteLine(group3[0] + "\tvs\t" + group3[3] + "(" + a + ":" + b + ")");
            goals3[0] += a;
            goals3[3] += b;
            Conceded3[0] += b;
            Conceded3[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p4[0] += 3;
            }
            else if (a == b)
            {
                p4[0] += 1;
                p4[3] += 1;
            }
            else
            {
                p4[3] += 3;
            }
            Console.WriteLine(group4[0] + "\tvs\t" + group4[3] + "(" + a + ":" + b + ")");
            goals4[0] += a;
            goals4[3] += b;
            Conceded4[0] += b;
            Conceded4[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p5[0] += 3;
            }
            else if (a == b)
            {
                p5[0] += 1;
                p5[3] += 1;
            }
            else
            {
                p5[3] += 3;
            }
            Console.WriteLine(group5[0] + "\t\tvs\t" + group5[3] + "(" + a + ":" + b + ")");
            goals5[0] += a;
            goals5[3] += b;
            Conceded5[0] += b;
            Conceded5[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p6[0] += 3;
            }
            else if (a == b)
            {
                p6[0] += 1;
                p6[3] += 1;
            }
            else
            {
                p6[3] += 3;
            }
            Console.WriteLine(group6[0] + "\tvs\t" + group6[3] + "(" + a + ":" + b + ")");
            goals6[0] += a;
            goals6[3] += b;
            Conceded6[0] += b;
            Conceded6[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p7[0] += 3;
            }
            else if (a == b)
            {
                p7[0] += 1;
                p7[3] += 1;
            }
            else
            {
                p7[3] += 3;
            }
            Console.WriteLine(group7[0] + "\t\tvs\t" + group7[3] + "(" + a + ":" + b + ")");
            goals7[0] += a;
            goals7[3] += b;
            Conceded7[0] += b;
            Conceded7[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p8[0] += 3;
            }
            else if (a == b)
            {
                p8[0] += 1;
                p8[3] += 1;
            }
            else
            {
                p8[3] += 3;
            }
            Console.WriteLine(group8[0] + "\tvs\t" + group8[3] + "(" + a + ":" + b + ")");
            goals8[0] += a;
            goals8[3] += b;
            Conceded8[0] += b;
            Conceded8[3] += a;
            /* for(int i=0;i<p8.Length;i++)
             {
                 Console.WriteLine(p8[i]);
             }*/
            Console.WriteLine("\t\t\t\t************Matchday 2 Results*************");
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p1[0] += 3;
            }
            else if (a == b)
            {
                p1[0] += 1;
                p1[1] += 1;
            }
            else
            {
                p1[1] += 3;
            }
            Console.WriteLine(group1[0] + "  \tvs      " + group1[1] + "(" + a + ":" + b + ")");
            goals1[0] += a;
            goals1[1] += b;
            Conceded1[0] += b;
            Conceded1[1] += a;
            
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p2[0] += 3;
            }
            else if (a == b)
            {
                p2[0] += 1;
                p2[1] += 1;
            }
            else
            {
                p2[1] += 3;
            }
            Console.WriteLine(group2[0] + "\tvs\t" + group2[1] + "(" + a + ":" + b + ")");
            goals2[0] += a;
            goals2[1] += b;
            Conceded2[0] += b;
            Conceded2[1] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p3[0] += 3;
            }
            else if (a == b)
            {
                p3[0] += 1;
                p3[1] += 1;
            }
            else
            {
                p3[1] += 3;
            }
            Console.WriteLine(group3[0] + "\tvs\t" + group3[1] + "(" + a + ":" + b + ")");
            goals3[0] += a;
            goals3[1] += b;
            Conceded3[0] += b;
            Conceded3[1] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p4[0] += 3;
            }
            else if (a == b)
            {
                p4[0] += 1;
                p4[1] += 1;
            }
            else
            {
                p4[1] += 3;
            }
            Console.WriteLine(group4[0] + "\tvs\t" + group4[1] + "(" + a + ":" + b + ")");
            goals4[0] += a;
            goals4[1] += b;
            Conceded4[0] += b;
            Conceded4[1] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p5[0] += 3;
            }
            else if (a == b)
            {
                p5[0] += 1;
                p5[1] += 1;
            }
            else
            {
                p5[1] += 3;
            }
            Console.WriteLine(group5[0] + "\t\tvs\t" + group5[1] + "(" + a + ":" + b + ")");
            goals5[0] += a;
            goals5[1] += b;
            Conceded5[0] += b;
            Conceded5[1] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p6[0] += 3;
            }
            else if (a == b)
            {
                p6[0] += 1;
                p6[1] += 1;
            }
            else
            {
                p6[1] += 3;
            }
            Console.WriteLine(group6[0] + "\tvs\t" + group6[1] + "(" + a + ":" + b + ")");
            goals6[0] += a;
            goals6[1] += b;
            Conceded6[0] += b;
            Conceded6[1] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p7[0] += 3;
            }
            else if (a == b)
            {
                p7[0] += 1;
                p7[1] += 1;
            }
            else
            {
                p7[1] += 3;
            }
            Console.WriteLine(group7[0] + "\t\tvs\t" + group7[1] + "(" + a + ":" + b + ")");
            goals7[0] += a;
            goals7[1] += b;
            Conceded7[0] += b;
            Conceded7[1] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p8[0] += 3;
            }
            else if (a == b)
            {
                p8[0] += 1;
                p8[1] += 1;
            }
            else
            {
                p8[1] += 3;
            }
            Console.WriteLine(group8[0] + "\tvs\t" + group8[1] + "(" + a + ":" + b + ")");
            goals8[0] += a;
            goals8[1] += b;
            Conceded8[0] += b;
            Conceded8[1] += a;
            Console.WriteLine("\t\t\t------------------");
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p1[2] += 3;
            }
            else if (a == b)
            {
                p1[2] += 1;
                p1[3] += 1;
            }
            else
            {
                p1[3] += 3;
            }
            Console.WriteLine(group1[2] + "  \tvs      " + group1[3] + "(" + a + ":" + b + ")");
            goals1[2] += a;
            goals1[3] += b;
            Conceded1[2] += b;
            Conceded1[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p2[2] += 3;
            }
            else if (a == b)
            {
                p2[2] += 1;
                p2[3] += 1;
            }
            else
            {
                p2[3] += 3;
            }
            Console.WriteLine(group2[2] + "\t\tvs\t" + group2[3] + "(" + a + ":" + b + ")");
            goals2[2] += a;
            goals2[3] += b;
            Conceded2[2] += b;
            Conceded2[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p3[2] += 3;
            }
            else if (a == b)
            {
                p3[2] += 1;
                p3[3] += 1;
            }
            else
            {
                p3[3] += 3;
            }
            Console.WriteLine(group3[2] + "\tvs\t" + group3[3] + "(" + a + ":" + b + ")");
            goals3[2] += a;
            goals3[3] += b;
            Conceded3[2] += b;
            Conceded3[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p4[2] += 3;
            }
            else if (a == b)
            {
                p4[2] += 1;
                p4[3] += 1;
            }
            else
            {
                p4[3] += 3;
            }
            Console.WriteLine(group4[2] + "\tvs\t" + group4[3] + "(" + a + ":" + b + ")");
            goals4[2] += a;
            goals4[3] += b;
            Conceded4[2] += b;
            Conceded4[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p5[2] += 3;
            }
            else if (a == b)
            {
                p5[2] += 1;
                p5[3] += 1;
            }
            else
            {
                p5[3] += 3;
            }
            Console.WriteLine(group5[2] + "\t\tvs\t" + group5[3] + "(" + a + ":" + b + ")");
            goals5[2] += a;
            goals5[3] += b;
            Conceded5[2] += b;
            Conceded5[3] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p6[2] += 3;
            }
            else if (a == b)
            {
                p6[2] += 1;
                p6[3] += 1;
            }
            else
            {
                p6[3] += 3;
            }
            Console.WriteLine(group6[2] + "\t\tvs\t" + group6[3] + "(" + a + ":" + b + ")");
            goals6[2] += a;
            goals6[3] += b;
            Conceded6[2] += b;
            Conceded6[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p7[2] += 3;
            }
            else if (a == b)
            {
                p7[2] += 1;
                p7[3] += 1;
            }
            else
            {
                p7[3] += 3;
            }
            Console.WriteLine(group7[2] + "\tvs\t" + group7[3] + "(" + a + ":" + b + ")");
            goals7[2] += a;
            goals7[3] += b;
            Conceded7[2] += b;
            Conceded7[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p8[2] += 3;
            }
            else if (a == b)
            {
                p8[2] += 1;
                p8[3] += 1;
            }
            else
            {
                p8[3] += 3;
            }
            Console.WriteLine(group8[2] + "\tvs\t" + group8[3] + "(" + a + ":" + b + ")");
            goals8[2] += a;
            goals8[3] += b;
            Conceded8[2] += b;
            Conceded8[3] += a;

            Console.WriteLine("\t\t\t\t************Matchday 3 Results*************");
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p1[2] += 3;
            }
            else if (a == b)
            {
                p1[2] += 1;
                p1[0] += 1;
            }
            else
            {
                p1[0] += 3;
            }
            Console.WriteLine(group1[2] + "     vs      " + group1[0] + "(" + a + ":" + b + ")");
            goals1[2] += a;
            goals1[0] += b;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p2[2] += 3;
            }
            else if (a == b)
            {
                p2[2] += 1;
                p2[0] += 1;
            }
            else
            {
                p2[0] += 3;
            }
            Console.WriteLine(group2[2] + "\t\tvs\t" + group2[0] + "(" + a + ":" + b + ")");
            goals2[2] += a;
            goals2[0] += b;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p3[2] += 3;
            }
            else if (a == b)
            {
                p3[2] += 1;
                p3[0] += 1;
            }
            else
            {
                p3[0] += 3;
            }
            Console.WriteLine(group3[2] + "\tvs\t" + group3[0] + "(" + a + ":" + b + ")");
            goals3[2] += a;
            goals3[0] += b;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p4[2] += 3;
            }
            else if (a == b)
            {
                p4[2] += 1;
                p4[0] += 1;
            }
            else
            {
                p4[0] += 3;
            }
            Console.WriteLine(group4[2] + "\tvs\t" + group4[0] + "(" + a + ":" + b + ")");
            goals4[2] += a;
            goals4[0] += b;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p5[2] += 3;
            }
            else if (a == b)
            {
                p5[2] += 1;
                p5[0] += 1;
            }
            else
            {
                p5[0] += 3;
            }
            Console.WriteLine(group5[2] + "\t\tvs\t" + group5[0] + "(" + a + ":" + b + ")");
            goals5[2] += a;
            goals5[0] += b;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p6[2] += 3;
            }
            else if (a == b)
            {
                p6[2] += 1;
                p6[0] += 1;
            }
            else
            {
                p6[0] += 3;
            }
            Console.WriteLine(group6[2] + "\t\tvs\t" + group6[0] + "(" + a + ":" + b + ")");
            goals6[2] += a;
            goals6[0] += b;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p7[2] += 3;
            }
            else if (a == b)
            {
                p7[2] += 1;
                p7[0] += 1;
            }
            else
            {
                p7[0] += 3;
            }
            Console.WriteLine(group7[2] + "\tvs\t" + group7[0] + "(" + a + ":" + b + ")");
            goals7[2] += a;
            goals7[0] += b;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p8[2] += 3;
            }
            else if (a == b)
            {
                p8[2] += 1;
                p8[0] += 1;
            }
            else
            {
                p8[0] += 3;
            }
            Console.WriteLine(group8[2] + "\tvs\t" + group8[0] + "(" + a + ":" + b + ")");
            goals8[2] += a;
            goals8[0] += b;
            Console.WriteLine("\t\t\t------------------");

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p1[1] += 3;
            }
            else if (a == b)
            {
                p1[1] += 1;
                p1[3] += 1;
            }
            else
            {
                p1[3] += 3;
            }
            Console.WriteLine(group1[1] + "  vs      " + group1[3] + "(" + a + ":" + b + ")");
            goals1[1] += a;
            goals1[0] += b;
            Conceded1[1] += b;
            Conceded1[0] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p2[1] += 3;
            }
            else if (a == b)
            {
                p2[1] += 1;
                p2[3] += 1;
            }
            else
            {
                p2[3] += 3;
            }
            Console.WriteLine(group2[1] + "\tvs\t" + group2[3] + "(" + a + ":" + b + ")");
            goals2[1] += a;
            goals2[3] += b;
            Conceded2[1] += b;
            Conceded2[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p3[1] += 3;
            }
            else if (a == b)
            {
                p3[1] += 1;
                p3[3] += 1;
            }
            else
            {
                p3[3] += 3;
            }
            Console.WriteLine(group3[1] + "\t\tvs\t" + group3[3] + "(" + a + ":" + b + ")");
            goals3[1] += a;
            goals3[3] += b;
            Conceded3[1] += b;
            Conceded3[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p4[1] += 3;
            }
            else if (a == b)
            {
                p4[1] += 1;
                p4[3] += 1;
            }
            else
            {
                p4[3] += 3;
            }
            Console.WriteLine(group4[1] + "\t\tvs\t" + group4[3] + "(" + a + ":" + b + ")");
            goals4[1] += a;
            goals4[3] += b;
            Conceded4[1] += b;
            Conceded4[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p5[1] += 3;
            }
            else if (a == b)
            {
                p5[1] += 1;
                p5[3] += 1;
            }
            else
            {
                p5[3] += 3;
            }
            Console.WriteLine(group5[1] + "\t\tvs\t" + group5[3] + "(" + a + ":" + b + ")");
            goals5[1] += a;
            goals5[3] += b;
            Conceded5[1] += b;
            Conceded5[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p6[1] += 3;
            }
            else if (a == b)
            {
                p6[1] += 1;
                p6[3] += 1;
            }
            else
            {
                p6[3] += 3;
            }
            Console.WriteLine(group6[1] + "\t\tvs\t" + group6[3] + "(" + a + ":" + b + ")");
            goals6[1] += a;
            goals6[3] += b;
            Conceded6[1] += b;
            Conceded6[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p7[1] += 3;
            }
            else if (a == b)
            {
                p7[1] += 1;
                p7[3] += 1;
            }
            else
            {
                p7[3] += 3;
            }
            Console.WriteLine(group7[1] + "\tvs\t" + group7[3] + "(" + a + ":" + b + ")");
            goals7[1] += a;
            goals7[3] += b;
            Conceded7[1] += b;
            Conceded7[3] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p8[1] += 3;
            }
            else if (a == b)
            {
                p8[1] += 1;
                p8[3] += 1;
            }
            else
            {
                p8[3] += 3;
            }
            Console.WriteLine(group8[1] + "\t\tvs\t" + group8[3] + "(" + a + ":" + b + ")");
            goals8[1] += a;
            goals8[3] += b;
            Conceded8[1] += b;
            Conceded8[3] += a;

            Console.WriteLine("\t\t\t\t************Matchday 4 Results*************");
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p1[0] += 3;
            }
            else if (a == b)
            {
                p1[0] += 1;
                p1[2] += 1;
            }
            else
            {
                p1[2] += 3;
            }
            Console.WriteLine(group1[0] + "  \tvs      " + group1[2] + "(" + a + ":" + b + ")");
            goals1[0] += a;
            goals1[2] += b;
            Conceded1[0] += b;
            Conceded1[2] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p2[0] += 3;
            }
            else if (a == b)
            {
                p2[0] += 1;
                p2[2] += 1;
            }
            else
            {
                p2[2] += 3;
            }
            Console.WriteLine(group2[0] + "\tvs\t" + group2[2] + "(" + a + ":" + b + ")");
            goals2[0] += a;
            goals2[2] += b;
            Conceded2[0] += b;
            Conceded2[2] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p3[0] += 3;
            }
            else if (a == b)
            {
                p3[0] += 1;
                p3[2] += 1;
            }
            else
            {
                p3[2] += 3;
            }
            Console.WriteLine(group3[0] + "\tvs\t" + group3[2] + "(" + a + ":" + b + ")");
            goals3[0] += a;
            goals3[2] += b;
            Conceded3[0] += b;
            Conceded3[2] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p4[0] += 3;
            }
            else if (a == b)
            {
                p4[0] += 1;
                p4[2] += 1;
            }
            else
            {
                p4[2] += 3;
            }
            Console.WriteLine(group4[0] + "\tvs\t" + group4[2] + "(" + a + ":" + b + ")");
            goals4[0] += a;
            goals4[2] += b;
            Conceded4[0] += b;
            Conceded4[2] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p5[0] += 3;
            }
            else if (a == b)
            {
                p5[0] += 1;
                p5[2] += 1;
            }
            else
            {
                p5[2] += 3;
            }
            Console.WriteLine(group5[0] + "\t\tvs\t" + group5[2] + "(" + a + ":" + b + ")");
            goals5[0] += a;
            goals5[2] += b;
            Conceded5[0] += b;
            Conceded5[2] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p6[0] += 3;
            }
            else if (a == b)
            {
                p6[0] += 1;
                p6[2] += 1;
            }
            else
            {
                p6[2] += 3;
            }
            Console.WriteLine(group6[0] + "\tvs\t" + group6[2] + "(" + a + ":" + b + ")");
            goals6[0] += a;
            goals6[2] += b;
            Conceded6[0] += b;
            Conceded6[2] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p7[0] += 3;
            }
            else if (a == b)
            {
                p7[0] += 1;
                p7[2] += 1;
            }
            else
            {
                p7[2] += 3;
            }
            Console.WriteLine(group7[0] + "\t\tvs\t" + group7[2] + "(" + a + ":" + b + ")");
            goals7[0] += a;
            goals7[2] += b;
            Conceded7[0] += b;
            Conceded7[2] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p8[0] += 3;
            }
            else if (a == b)
            {
                p8[0] += 1;
                p8[2] += 1;
            }
            else
            {
                p8[2] += 3;
            }
            Console.WriteLine(group8[0] + "\tvs\t" + group8[2] + "(" + a + ":" + b + ")");
            goals8[0] += a;
            goals8[2] += b;
            Conceded8[0] += b;
            Conceded8[2] += a;
            Console.WriteLine("\t\t\t------------------");
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p1[3] += 3;
            }
            else if (a == b)
            {
                p1[3] += 1;
                p1[1] += 1;
            }
            else
            {
                p1[1] += 3;
            }
            Console.WriteLine(group1[3] + "  \t\tvs      " + group1[1] + "(" + a + ":" + b + ")");
            goals1[3] += a;
            goals1[1] += b;
            Conceded1[3] += b;
            Conceded1[1] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p2[3] += 3;
            }
            else if (a == b)
            {
                p2[3] += 1;
                p2[1] += 1;
            }
            else
            {
                p2[1] += 3;
            }
            Console.WriteLine(group2[3] + "\tvs\t" + group2[1] + "(" + a + ":" + b + ")");
            goals2[3] += a;
            goals2[1] += b;
            Conceded2[3] += b;
            Conceded2[1] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p3[3] += 3;
            }
            else if (a == b)
            {
                p3[3] += 1;
                p3[1] += 1;
            }
            else
            {
                p3[1] += 3;
            }
            Console.WriteLine(group3[3] + "\tvs\t" + group3[1] + "(" + a + ":" + b + ")");
            goals3[3] += a;
            goals3[1] += b;
            Conceded3[3] += b;
            Conceded3[1] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p4[3] += 3;
            }
            else if (a == b)
            {
                p4[3] += 1;
                p4[1] += 1;
            }
            else
            {
                p4[1] += 3;
            }
            Console.WriteLine(group4[3] + "\tvs\t" + group4[1] + "(" + a + ":" + b + ")");
            goals4[3] += a;
            goals4[1] += b;
            Conceded4[3] += b;
            Conceded4[1] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p5[3] += 3;
            }
            else if (a == b)
            {
                p5[3] += 1;
                p5[1] += 1;
            }
            else
            {
                p5[1] += 3;
            }
            Console.WriteLine(group5[3] + "\t\tvs\t" + group5[1] + "(" + a + ":" + b + ")");
            goals5[3] += a;
            goals5[1] += b;
            Conceded5[3] += b;
            Conceded5[1] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p6[3] += 3;
            }
            else if (a == b)
            {
                p6[3] += 1;
                p6[1] += 1;
            }
            else
            {
                p6[1] += 3;
            }
            Console.WriteLine(group6[3] + "vs\t" + group6[1] + "(" + a + ":" + b + ")");
            goals6[3] += a;
            goals6[1] += b;
            Conceded6[3] += b;
            Conceded6[1] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p7[3] += 3;
            }
            else if (a == b)
            {
                p7[3] += 1;
                p7[1] += 1;
            }
            else
            {
                p7[1] += 3;
            }
            Console.WriteLine(group7[3] + "\tvs\t" + group7[1] + "(" + a + ":" + b + ")");
            goals7[3] += a;
            goals7[1] += b;
            Conceded7[3] += b;
            Conceded7[1] += a;
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p8[3] += 3;
            }
            else if (a == b)
            {
                p8[3] += 1;
                p8[1] += 1;
            }
            else
            {
                p8[1] += 3;
            }
            Console.WriteLine(group8[3] + "\t\tvs\t" + group8[1] + "(" + a + ":" + b + ")");
            goals8[3] += a;
            goals8[1] += b;
            Conceded8[3] += b;
            Conceded8[1] += a;

            Console.WriteLine("\t\t\t\t************Matchday 5 Results*************");
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p1[2] += 3;
            }
            else if (a == b)
            {
                p1[2] += 1;
                p1[1] += 1;
            }
            else
            {
                p1[1] += 3;
            }
            Console.WriteLine(group1[2] + "     vs      " + group1[1] + "(" + a + ":" + b + ")");
            goals1[2] += a;
            goals1[1] += b;
            Conceded1[2] += b;
            Conceded1[1] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p2[2] += 3;
            }
            else if (a == b)
            {
                p2[2] += 1;
                p2[1] += 1;
            }
            else
            {
                p2[1] += 3;
            }
            Console.WriteLine(group2[2] + "\t\tvs\t" + group2[1] + "(" + a + ":" + b + ")");
            goals2[2] += a;
            goals2[1] += b;
            Conceded2[2] += b;
            Conceded2[1] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p3[2] += 3;
            }
            else if (a == b)
            {
                p3[2] += 1;
                p3[1] += 1;
            }
            else
            {
                p3[1] += 3;
            }
            Console.WriteLine(group3[2] + "\tvs\t" + group3[1] + "(" + a + ":" + b + ")");
            goals3[2] += a;
            goals3[1] += b;
            Conceded3[2] += b;
            Conceded3[1] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p4[2] += 3;
            }
            else if (a == b)
            {
                p4[2] += 1;
                p4[1] += 1;
            }
            else
            {
                p4[1] += 3;
            }
            Console.WriteLine(group4[2] + "\tvs\t" + group4[1] + "(" + a + ":" + b + ")");
            goals4[2] += a;
            goals4[1] += b;
            Conceded4[2] += b;
            Conceded4[1] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p5[2] += 3;
            }
            else if (a == b)
            {
                p5[2] += 1;
                p5[1] += 1;
            }
            else
            {
                p5[1] += 3;
            }
            Console.WriteLine(group5[2] + "\t\tvs\t" + group5[1] + "(" + a + ":" + b + ")");
            goals5[2] += a;
            goals5[1] += b;
            Conceded5[2] += b;
            Conceded5[1] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p6[2] += 3;
            }
            else if (a == b)
            {
                p6[2] += 1;
                p6[1] += 1;
            }
            else
            {
                p6[1] += 3;
            }
            Console.WriteLine(group6[2] + "\t\tvs\t" + group6[1] + "(" + a + ":" + b + ")");
            goals6[2] += a;
            goals6[1] += b;
            Conceded6[2] += b;
            Conceded6[1] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p7[2] += 3;
            }
            else if (a == b)
            {
                p7[2] += 1;
                p7[1] += 1;
            }
            else
            {
                p7[1] += 3;
            }
            Console.WriteLine(group7[2] + "\tvs\t" + group7[1] + "(" + a + ":" + b + ")");
            goals7[2] += a;
            goals7[1] += b;
            Conceded7[2] += b;
            Conceded7[1] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p8[2] += 3;
            }
            else if (a == b)
            {
                p8[2] += 1;
                p8[1] += 1;
            }
            else
            {
                p8[1] += 3;
            }
            Console.WriteLine(group8[2] + "\tvs\t" + group8[1] + "(" + a + ":" + b + ")");
            goals8[2] += a;
            goals8[1] += b;
            Conceded8[2] += b;
            Conceded8[1] += a;
            Console.WriteLine("\t\t\t------------------");

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p1[0] += 3;
            }
            else if (a == b)
            {
                p1[0] += 1;
                p1[3] += 1;
            }
            else
            {
                p1[3] += 3;
            }
            Console.WriteLine(group1[0] + "  \tvs      " + group1[3] + "(" + a + ":" + b + ")");
            goals1[0] += a;
            goals1[3] += b;
            Conceded1[0] += b;
            Conceded1[3] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p2[0] += 3;
            }
            else if (a == b)
            {
                p2[0] += 1;
                p2[3] += 1;
            }
            else
            {
                p2[3] += 3;
            }
            Console.WriteLine(group2[0] + "\tvs\t" + group2[3] + "(" + a + ":" + b + ")");
            goals2[0] += a;
            goals2[3] += b;
            Conceded2[0] += b;
            Conceded2[3] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p3[0] += 3;
            }
            else if (a == b)
            {
                p3[0] += 1;
                p3[3] += 1;
            }
            else
            {
                p3[3] += 3;
            }
            Console.WriteLine(group3[0] + "\tvs\t" + group3[3] + "(" + a + ":" + b + ")");
            goals3[0] += a;
            goals3[3] += b;
            Conceded3[0] += b;
            Conceded3[3] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p4[0] += 3;
            }
            else if (a == b)
            {
                p4[0] += 1;
                p4[3] += 1;
            }
            else
            {
                p4[3] += 3;
            }
            Console.WriteLine(group4[0] + "\tvs\t" + group4[3] + "(" + a + ":" + b + ")");
            goals4[0] += a;
            goals4[3] += b;
            Conceded4[0] += b;
            Conceded4[3] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p5[0] += 3;
            }
            else if (a == b)
            {
                p5[0] += 1;
                p5[3] += 1;
            }
            else
            {
                p5[3] += 3;
            }
            Console.WriteLine(group5[0] + "\t\tvs\t" + group5[3] + "(" + a + ":" + b + ")");
            goals5[0] += a;
            goals5[3] += b;
            Conceded5[0] += b;
            Conceded5[3] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p6[0] += 3;
            }
            else if (a == b)
            {
                p6[0] += 1;
                p6[3] += 1;
            }
            else
            {
                p6[3] += 3;
            }
            Console.WriteLine(group6[0] + "\tvs\t" + group6[3] + "(" + a + ":" + b + ")");
            goals6[0] += a;
            goals6[3] += b;
            Conceded6[0] += b;
            Conceded6[3] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p7[0] += 3;
            }
            else if (a == b)
            {
                p7[0] += 1;
                p7[3] += 1;
            }
            else
            {
                p7[3] += 3;
            }
            Console.WriteLine(group7[0] + "\t\tvs\t" + group7[3] + "(" + a + ":" + b + ")");
            goals7[0] += a;
            goals7[3] += b;
            Conceded7[0] += b;
            Conceded7[3] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p8[0] += 3;
            }
            else if (a == b)
            {
                p8[0] += 1;
                p8[3] += 1;
            }
            else
            {
                p8[3] += 3;
            }
            Console.WriteLine(group8[0] + "\tvs\t" + group8[3] + "(" + a + ":" + b + ")");
            goals8[0] += a;
            goals8[3] += b;
            Conceded8[0] += b;
            Conceded8[3] += a;

            Console.WriteLine("\t\t\t\t************Matchday 6 Results*************");
            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p1[1] += 3;
            }
            else if (a == b)
            {
                p1[1] += 1;
                p1[0] += 1;
            }
            else
            {
                p1[0] += 3;
            }
            Console.WriteLine(group1[1] + "  vs      " + group1[0] + "(" + a + ":" + b + ")");
            goals1[1] += a;
            goals1[0] += b;
            Conceded1[1] += b;
            Conceded1[0] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p2[1] += 3;
            }
            else if (a == b)
            {
                p2[1] += 1;
                p2[0] += 1;
            }
            else
            {
                p2[0] += 3;
            }
            Console.WriteLine(group2[1] + "\tvs\t" + group2[0] + "(" + a + ":" + b + ")");
            goals2[1] += a;
            goals2[0] += b;
            Conceded2[1] += b;
            Conceded2[0] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p3[1] += 3;
            }
            else if (a == b)
            {
                p3[1] += 1;
                p3[0] += 1;
            }
            else
            {
                p3[0] += 3;
            }
            Console.WriteLine(group3[1] + "\t\tvs\t" + group3[0] + "(" + a + ":" + b + ")");
            goals3[1] += a;
            goals3[0] += b;
            Conceded3[1] += b;
            Conceded3[0] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p4[1] += 3;
            }
            else if (a == b)
            {
                p4[1] += 1;
                p4[0] += 1;
            }
            else
            {
                p4[0] += 3;
            }
            Console.WriteLine(group4[1] + "\t\tvs\t" + group4[0] + "(" + a + ":" + b + ")");
            goals4[1] += a;
            goals4[0] += b;
            Conceded4[1] += b;
            Conceded4[0] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p5[1] += 3;
            }
            else if (a == b)
            {
                p5[1] += 1;
                p5[0] += 1;
            }
            else
            {
                p5[0] += 3;
            }
            Console.WriteLine(group5[1] + "\t\tvs\t" + group5[0] + "(" + a + ":" + b + ")");
            goals5[1] += a;
            goals5[0] += b;
            Conceded5[1] += b;
            Conceded5[0] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p6[1] += 3;
            }
            else if (a == b)
            {
                p6[1] += 1;
                p6[0] += 1;
            }
            else
            {
                p6[0] += 3;
            }
            Console.WriteLine(group6[1] + "\t\tvs\t" + group6[0] + "(" + a + ":" + b + ")");
            goals6[1] += a;
            goals6[0] += b;
            Conceded6[1] += b;
            Conceded6[0] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p7[1] += 3;
            }
            else if (a == b)
            {
                p7[1] += 1;
                p7[0] += 1;
            }
            else
            {
                p7[0] += 3;
            }
            Console.WriteLine(group7[1] + "\tvs\t" + group7[0] + "(" + a + ":" + b + ")");
            goals7[1] += a;
            goals7[0] += b;
            Conceded7[1] += b;
            Conceded7[0] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p8[1] += 3;
            }
            else if (a == b)
            {
                p8[1] += 1;
                p8[0] += 1;
            }
            else
            {
                p8[0] += 3;
            }
            Console.WriteLine(group8[1] + "\t\tvs\t" + group8[0] + "(" + a + ":" + b + ")");
            goals8[1] += a;
            goals8[0] += b;
            Conceded8[1] += b;
            Conceded8[0] += a;
            Console.WriteLine("\t\t\t------------------");

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p1[3] += 3;
            }
            else if (a == b)
            {
                p1[3] += 1;
                p1[2] += 1;
            }
            else
            {
                p1[2] += 3;
            }
            Console.WriteLine(group1[3] + "  \t\tvs      " + group1[2] + "(" + a + ":" + b + ")");
            goals1[3] += a;
            goals1[2] += b;
            Conceded1[3] += b;
            Conceded1[2] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p2[3] += 3;
            }
            else if (a == b)
            {
                p2[3] += 1;
                p2[2] += 1;
            }
            else
            {
                p2[2] += 3;
            }
            Console.WriteLine(group2[3] + "\tvs\t" + group2[2] + "(" + a + ":" + b + ")");
            goals2[3] += a;
            goals2[2] += b;
            Conceded2[3] += b;
            Conceded2[2] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p3[3] += 3;
            }
            else if (a == b)
            {
                p3[3] += 1;
                p3[2] += 1;
            }
            else
            {
                p3[2] += 3;
            }
            Console.WriteLine(group3[3] + "\tvs\t" + group3[2] + "(" + a + ":" + b + ")");
            goals3[3] += a;
            goals3[2] += b;
            Conceded3[3] += b;
            Conceded3[2] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p4[3] += 3;
            }
            else if (a == b)
            {
                p4[3] += 1;
                p4[2] += 1;
            }
            else
            {
                p4[2] += 3;
            }
            Console.WriteLine(group4[3] + "\tvs\t" + group4[2] + "(" + a + ":" + b + ")");
            goals4[3] += a;
            goals4[2] += b;
            Conceded4[3] += b;
            Conceded4[2] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p5[3] += 3;
            }
            else if (a == b)
            {
                p5[3] += 1;
                p5[2] += 1;
            }
            else
            {
                p5[2] += 3;
            }
            Console.WriteLine(group5[3] + "\t\tvs\t" + group5[2] + "(" + a + ":" + b + ")");
            goals5[3] += a;
            goals5[2] += b;
            Conceded5[3] += b;
            Conceded5[2] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p6[3] += 3;
            }
            else if (a == b)
            {
                p6[3] += 1;
                p6[2] += 1;
            }
            else
            {
                p6[2] += 3;
            }
            Console.WriteLine(group6[3] + "vs\t" + group6[2] + "(" + a + ":" + b + ")");
            goals6[3] += a;
            goals6[2] += b;
            Conceded6[3] += b;
            Conceded6[2] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p7[3] += 3;
            }
            else if (a == b)
            {
                p7[3] += 1;
                p7[2] += 1;
            }
            else
            {
                p7[2] += 3;
            }
            Console.WriteLine(group7[3] + "\tvs\t" + group7[2] + "(" + a + ":" + b + ")");
            goals7[3] += a;
            goals7[2] += b;
            Conceded7[3] += b;
            Conceded7[2] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            if (a > b)
            {
                p8[3] += 3;
            }
            else if (a == b)
            {
                p8[3] += 1;
                p8[2] += 1;
            }
            else
            {
                p8[2] += 3;
            }
            Console.WriteLine(group8[3] + "\t\tvs\t" + group8[2] + "(" + a + ":" + b + ")");
            goals8[3] += a;
            goals8[2] += b;
            Conceded8[3] += b;
            Conceded8[2] += a;
            /*for (int i = 0; i < p1.Length; i++)
            {
                Console.WriteLine(p1[i]);
            }*/
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
        }
        public void qualified()
        {
            Console.WriteLine("\t\t*******Teams that qualified from each group are******");
            Console.WriteLine("************GROUP1*************");
            int largest,secLarge;
            if (p1[0] < p1[1])
            {
                largest = p1[1];
                secLarge = p1[0];
            }
            else
            {
                largest = p1[0];
                secLarge = p1[1];
            }

            for (int i = 2; i < p1.Length; i++)
            {
                if(p1[i] > largest)
                {
                    secLarge = largest;
                    largest = p1[i];
                }
                else if(p1[i] > secLarge && p1[i]!=largest)
                {
                    secLarge = p1[i];
                }
            }
            int h1 = Array.IndexOf(p1, largest);
            int h2 = Array.IndexOf(p1, secLarge);

            string [] q1 = { group1[h1], group1[h2] };//teams that qualified from group 1
            Console.WriteLine(q1[0]);
            Console.WriteLine(q1[1]);
            
            Console.WriteLine("************GROUP2*************");
            if (p2[0] < p2[1])
            {
                largest = p2[1];
                secLarge = p2[0];
            }
            else
            {
                largest = p2[0];
                secLarge = p2[1];
            }

            for (int i = 2; i < p2.Length; i++)
            {
                if (p2[i] > largest)
                {
                    secLarge = largest;
                    largest = p2[i];
                }
                else if (p2[i] > secLarge && p2[i] != largest)
                {
                    secLarge = p2[i];
                }
            }
            h1 = Array.IndexOf(p2, largest);
            h2 = Array.IndexOf(p2, secLarge);

            string[] q2 = { group2[h1], group2[h2] };
            Console.WriteLine(q2[0]);
            Console.WriteLine(q2[1]);

            Console.WriteLine("************Group3************");
            if (p3[0] < p3[1])
            {
                largest = p3[1];
                secLarge = p3[0];
            }
            else
            {
                largest = p3[0];
                secLarge = p3[1];
            }

            for (int i = 2; i < p3.Length; i++)
            {
                if (p3[i] > largest)
                {
                    secLarge = largest;
                    largest = p3[i];
                }
                else if (p3[i] > secLarge && p3[i] != largest)
                {
                    secLarge = p3[i];
                }
            }
            h1 = Array.IndexOf(p3, largest);
            h2 = Array.IndexOf(p3, secLarge);

            string[] q3 = { group3[h1], group3[h2] };
            Console.WriteLine(q3[0]);
            Console.WriteLine(q3[1]);

            Console.WriteLine("**************Group4**************");
           
            if (p4[0] < p4[1])
            {
                largest = p4[1];
                secLarge = p4[0];
            }
            else
            {
                largest = p4[0];
                secLarge = p4[1];
            }

            for (int i = 2; i < p4.Length; i++)
            {
                if (p4[i] > largest)
                {
                    secLarge = largest;
                    largest = p4[i];
                }
                else if (p4[i] > secLarge && p4[i] != largest)
                {
                    secLarge = p4[i];
                }
            }
            h1 = Array.IndexOf(p4, largest);
            h2 = Array.IndexOf(p4, secLarge);

            string[] q4 = { group4[h1], group4[h2] };
            Console.WriteLine(q4[0]);
            Console.WriteLine(q4[1]);

            Console.WriteLine("*****************Group5******************");
           
            if (p5[0] < p5[1])
            {
                largest = p5[1];
                secLarge = p5[0];
            }
            else
            {
                largest = p5[0];
                secLarge = p5[1];
            }

            for (int i = 2; i < p5.Length; i++)
            {
                if (p5[i] > largest)
                {
                    secLarge = largest;
                    largest = p5[i];
                }
                else if (p5[i] > secLarge && p5[i] != largest)
                {
                    secLarge = p5[i];
                }
            }
            h1 = Array.IndexOf(p5, largest);
            h2 = Array.IndexOf(p5, secLarge);

            string[] q5 = { group5[h1], group5[h2] };
            Console.WriteLine(q5[0]);
            Console.WriteLine(q5[1]);

            Console.WriteLine("*************Group6*****************");
            if (p6[0] < p6[1])
            {
                largest = p6[1];
                secLarge = p6[0];
            }
            else
            {
                largest = p6[0];
                secLarge = p6[1];
            }

            for (int i = 2; i < p6.Length; i++)
            {
                if (p6[i] > largest)
                {
                    secLarge = largest;
                    largest = p6[i];
                }
                else if (p6[i] > secLarge && p6[i] != largest)
                {
                    secLarge = p6[i];
                }
            }
            h1 = Array.IndexOf(p6, largest);
            h2 = Array.IndexOf(p6, secLarge);

            string[] q6 = { group6[h1], group6[h2] };
            Console.WriteLine(q6[0]);
            Console.WriteLine(q6[1]);

            Console.WriteLine("************Group7***************");
            if (p7[0] < p7[1])
            {
                largest = p7[1];
                secLarge = p7[0];
            }
            else
            {
                largest = p7[0];
                secLarge = p7[1];
            }

            for (int i = 2; i < p7.Length; i++)
            {
                if (p7[i] > largest)
                {
                    secLarge = largest;
                    largest = p7[i];
                }
                else if (p7[i] > secLarge && p7[i] != largest)
                {
                    secLarge = p7[i];
                }
            }
            h1 = Array.IndexOf(p7, largest);
            h2 = Array.IndexOf(p7, secLarge);

            string[] q7 = { group7[h1], group7[h2] };
            Console.WriteLine(q7[0]);
            Console.WriteLine(q7[1]);

            Console.WriteLine("**************Group8****************");
          
            if (p8[0] < p8[1])
            {
                largest = p8[1];
                secLarge = p8[0];
            }
            else
            {
                largest = p8[0];
                secLarge = p8[1];
            }

            for (int i = 2; i < p8.Length; i++)
            {
                if (p8[i] > largest)
                {
                    secLarge = largest;
                    largest = p8[i];
                }
                else if (p8[i] > secLarge && p8[i] != largest)
                {
                    secLarge = p8[i];
                }
            }
            h1 = Array.IndexOf(p8, largest);
            h2 = Array.IndexOf(p8, secLarge);

            string[] q8 = { group8[h1], group8[h2] };
            Console.WriteLine(q8[0]);
            Console.WriteLine(q8[1]);

            /*Console.WriteLine(q8[0]);
            Console.WriteLine(q8[1]);*/
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("**********ROUND OF 16-----RESULTS***********");

            string[] winners = { q1[0], q2[0], q3[0], q4[0], q5[0], q6[0], q7[0], q8[0] };
            int[] goalsW = { 0, 0, 0, 0, 0, 0, 0, 0 };//array to store goals by teams of winners array
            int[] concededW = { 0, 0, 0, 0, 0, 0, 0, 0 };//array to store goals conceded by winners array teams
            int[] pointsW = { 0, 0, 0, 0, 0, 0, 0, 0 };//array to store points of teams in winners array
            string[] runnersUp = { q1[1], q2[1], q3[1], q4[1], q5[1], q6[1], q7[1], q8[1] };
            int[] goalsRup = { 0, 0, 0, 0, 0, 0, 0, 0 };//array to store goals scored by teams in runner up array
            int[] concededRup = { 0, 0, 0, 0, 0, 0, 0, 0 };//array to store goals conceded by teams in runner up array
            int[] pointsRup = { 0, 0, 0, 0, 0, 0, 0, 0 };//array to store points of teams in runner up array

            string[] qfinals = new string[8];
            int[] gqf = { 0, 0, 0, 0, 0, 0, 0, 0 }; //goals scored in quarter finals
            int[] gcqf = { 0, 0, 0, 0, 0, 0, 0, 0 }; //goals conceded in quarter finals

            string[] semiFinal = new string[4];
            int[] goalsSemi = { 0, 0, 0, 0 };
            int[] goalsConcededSemi = { 0, 0, 0, 0 };

            Random rand = new Random();
            
            int a = rand.Next(8);
            int b = rand.Next(8);
            Console.WriteLine(winners[0] + "--------"+ runnersUp[1] + "(" + a +":" + b + ")" );
            goalsW[0] += a;
            goalsRup[1] += b;
            concededW[0] += b;
            concededRup[1] += a;

            a = rand.Next(8);
            b = rand.Next(8);
            Console.WriteLine(runnersUp[1] + "--------" + winners[0] + "(" + a + ":" + b + ")");
            goalsW[0] += b;
            goalsRup[1] += a;
            concededW[0] += a;
            concededRup[1] += b;

            if (goalsW[0] > goalsRup[1])
            {
                Console.WriteLine(winners[0] + " is winner");
                pointsW[0] += 3;
                qfinals[0] = winners[0];
            }
            else
            {
                Console.WriteLine(runnersUp[1] + " is winner");
                pointsRup[1] += 3;
                qfinals[0] = runnersUp[1];
            }

            a = rand.Next(8);
            b = rand.Next(8);
            Console.WriteLine(winners[1] + "--------" + runnersUp[0] + "(" + a + ":" + b + ")");
            goalsW[1] += a;
            goalsRup[0] += b;
            concededW[1] += b;
            concededRup[0] += a;

            a = rand.Next(8);
            b = rand.Next(8);
            Console.WriteLine(runnersUp[0] + "--------" + winners[1] + "(" + a + ":" + b + ")");
            goalsW[1] += b;
            goalsRup[0] += a;
            concededW[1] += a;
            concededRup[0] += b;
            if (goalsW[1] > goalsRup[0])
            {
                Console.WriteLine(winners[1] + " is winner");
                pointsW[1] += 3;
                qfinals[1] = winners[1];
            }
            else
            {
                Console.WriteLine(runnersUp[0] + " is winner");
                pointsRup[0] += 3;
                qfinals[1] = runnersUp[0];
            }

            a = rand.Next(8);
            b = rand.Next(8);
            Console.WriteLine(winners[2] + "--------" + runnersUp[3] + "(" + a + ":" + b + ")");
            goalsW[2] += a;
            goalsRup[3] += b;
            concededW[2] += b;
            concededRup[3] += a;

            a = rand.Next(8);
            b = rand.Next(8);
            Console.WriteLine(runnersUp[3] + "--------" + winners[2] + "(" + a + ":" + b + ")");
            goalsW[2] += b;
            goalsRup[3] += a;
            concededW[2] += a;
            concededRup[3] += b;

            if (goalsW[2] > goalsRup[3])
            {
                Console.WriteLine(winners[2] + " is winner");
                pointsW[2] += 3;
                qfinals[2] = winners[2];
            }
            else
            {
                Console.WriteLine(runnersUp[3] + " is winner");
                pointsRup[3] += 3;
                qfinals[2] = runnersUp[3];
            }

            a = rand.Next(8);
            b = rand.Next(8);
            Console.WriteLine(winners[3] + "--------" + runnersUp[2] + "(" + a + ":" + b + ")");
            goalsW[3] += a;
            goalsRup[2] += b;
            concededW[3] += b;
            concededRup[2] += a;
            
            a = rand.Next(8);
            b = rand.Next(8);
            Console.WriteLine(runnersUp[2] + "--------" + winners[3] + "(" + a + ":" + b + ")");
            goalsW[3] += b;
            goalsRup[2] += a;
            concededW[3] += a;
            concededRup[2] += b;

            if (goalsW[3] > goalsRup[2])
            {
                Console.WriteLine(winners[3] + " is winner");
                pointsW[3] += 3;
                qfinals[3] = winners[3];
            }
            else
            {
                Console.WriteLine(runnersUp[2] + " is winner");
                pointsRup[2] += 3;
                qfinals[3] = runnersUp[2];
            }

            a = rand.Next(8);
            b = rand.Next(8);
            Console.WriteLine(winners[4] + "--------" + runnersUp[5] + "(" + a + ":" + b + ")");
            goalsW[4] += a;
            goalsRup[5] += b;
            concededW[4] += b;
            concededRup[5] += a;

            a = rand.Next(8);
            b = rand.Next(8);
            Console.WriteLine(runnersUp[5] + "--------" + winners[4] + "(" + a + ":" + b + ")");
            goalsW[4] += b;
            goalsRup[5] += a;
            concededW[4] += a;
            concededRup[5] += b;
            if (goalsW[4] > goalsRup[5])
            {
                Console.WriteLine(winners[4] + " is winner");
                pointsW[4] += 3;
                qfinals[4] = winners[4];
            }
            else
            {
                Console.WriteLine(runnersUp[5] + " is winner");
                pointsRup[5] += 3;
                qfinals[4] = runnersUp[5];
            }

            a = rand.Next(8);
            b = rand.Next(8);
            Console.WriteLine(winners[5] + "--------" + runnersUp[4] + "(" + a + ":" + b + ")");
            goalsW[5] += a;
            goalsRup[4] += b;
            concededW[5] += b;
            concededRup[4] += a;

            a = rand.Next(8);
            b = rand.Next(8);
            Console.WriteLine(runnersUp[4] + "--------" + winners[5] + "(" + a + ":" + b + ")");
            goalsW[5] += b;
            goalsRup[4] += a;
            concededW[5] += a;
            concededRup[4] += b;

            if (goalsW[5] > goalsRup[4])
            {
                Console.WriteLine(winners[5] + " is winner");
                pointsW[5] += 3;
                qfinals[5] = winners[5];
            }
            else
            {
                Console.WriteLine(runnersUp[4] + " is winner");
                pointsRup[4] += 3;
                qfinals[5] = runnersUp[4];
            }

            a = rand.Next(8);
            b = rand.Next(8);
            Console.WriteLine(winners[6] + "--------" + runnersUp[7] + "(" + a + ":" + b + ")");
            goalsW[6] += a;
            goalsRup[7] += b;
            concededW[6] += b;
            concededRup[7] += a;

            a = rand.Next(8);
            b = rand.Next(8);
            Console.WriteLine(runnersUp[7] + "--------" + winners[6] + "(" + a + ":" + b + ")");
            goalsW[6] += b;
            goalsRup[7] += a;
            concededW[6] += a;
            concededRup[7] += b;

            if (goalsW[6] > goalsRup[7])
            {
                Console.WriteLine(winners[6] + " is winner");
                pointsW[6] += 3;
                qfinals[6] = winners[6];
            }
            else
            {
                Console.WriteLine(runnersUp[7] + " is winner");
                pointsRup[7] += 3;
                qfinals[6] = runnersUp[7];
            }

            a = rand.Next(8);
            b = rand.Next(8);
            Console.WriteLine(winners[7] + "--------" + runnersUp[6] + "(" + a + ":" + b + ")");
            goalsW[7] += a;
            goalsRup[6] += b;
            concededW[7] += b;
            concededRup[6] += a;

            a = rand.Next(8);
            b = rand.Next(8);
            Console.WriteLine(runnersUp[6] + "--------" + winners[7] + "(" + a + ":" + b + ")");
            goalsW[7] += b;
            goalsRup[6] += a;
            concededW[7] += a;
            concededRup[6] += b;

            if (goalsW[7] > goalsRup[6])
            {
                Console.WriteLine(winners[7] + " is winner");
                pointsW[7] += 3;
                qfinals[7] = winners[7];

            }
            else
            {
                Console.WriteLine(runnersUp[6] + " is winner");
                pointsRup[6] += 3;
                qfinals[7] = runnersUp[6];
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Teams that have qualified for quarterfinals are");
            for(int i = 0;i<qfinals.Length; i++)
            {
                Console.WriteLine("=> "+qfinals[i]);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t*************Quarter Finals************\t\t");
            //ist vs 3rd--------2nd vs 4th--------5th vs 7th------------6th vs 8th
            a = rand.Next(7);
            b = rand.Next(7);
            Console.WriteLine(qfinals[0] + "------" + qfinals[2] + "(" + a + ":" + b + ")");
            gqf[0] += a;
            gcqf[0] += b;
            gqf[2] += b;
            gcqf[2] += a;
                

            a = rand.Next(7);
            b = rand.Next(7);
            Console.WriteLine(qfinals[2] + "------" + qfinals[0] + "(" + a + ":" + b + ")");
            gqf[0] += b;
            gcqf[0] += a;
            gqf[2] += a;
            gcqf[2] += b;

            if (gqf[0] > gqf[2])
            {
                Console.WriteLine(qfinals[0] + " is winner");
                semiFinal[0] = qfinals[0];
            }
            else
            {
                Console.WriteLine(qfinals[2] + " is winner");
                semiFinal[0] = qfinals[2];
            }

            a = rand.Next(7);
            b = rand.Next(7);
            Console.WriteLine(qfinals[1] + "------" + qfinals[3] + "(" + a + ":" + b + ")");
            gqf[1] += a;
            gcqf[1] += b;
            gqf[3] += b;
            gcqf[3] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            Console.WriteLine(qfinals[3] + "------" + qfinals[1] + "(" + a + ":" + b + ")");
            gqf[3] += a;
            gcqf[3] += b;
            gqf[1] += b;
            gcqf[1] += a;

            if (gqf[1] > gqf[3])
            {
                Console.WriteLine(qfinals[1] + " is winner");
                semiFinal[1] = qfinals[1];
            }
            else
            {
                Console.WriteLine(qfinals[3] + " is winner");
                semiFinal[1] = qfinals[3];
            }

            a = rand.Next(7);
            b = rand.Next(7);
            Console.WriteLine(qfinals[4] + "------" + qfinals[6] + "(" + a + ":" + b + ")");
            gqf[4] += a;
            gcqf[4] += b;
            gqf[6] += b;
            gcqf[6] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            Console.WriteLine(qfinals[6] + "------" + qfinals[4] + "(" + a + ":" + b + ")");
            gqf[6] += a;
            gcqf[6] += b;
            gqf[4] += b;
            gcqf[4] += a;
            if (gqf[4] > gqf[6])
            {
                Console.WriteLine(qfinals[4] + " is winner");
                semiFinal[2] = qfinals[4];
            }
            else
            {
                Console.WriteLine(qfinals[6] + " is winner");
                semiFinal[2] = qfinals[6];
            }

            a = rand.Next(7);
            b = rand.Next(7);
            Console.WriteLine(qfinals[5] + "------" + qfinals[7] + "(" + a + ":" + b + ")");
            gqf[5] += a;
            gcqf[5] += b;
            gqf[7] += b;
            gcqf[7] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            Console.WriteLine(qfinals[7] + "------" + qfinals[5] + "(" + a + ":" + b + ")");
            gqf[7] += a;
            gcqf[7] += b;
            gqf[5] += b;
            gcqf[5] += a;
            if (gqf[5] > gqf[7])
            {
                Console.WriteLine(qfinals[5] + " is winner");
                semiFinal[3] = qfinals[5];
            }
            else
            {
                Console.WriteLine(qfinals[7] + " is winner");
                semiFinal[3] = qfinals[7];
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t**********SEMIFINALS*****************");

            string[] final = new string[2];
            int[] goalsFinal = { 0, 0 };
            int[] goalsConcededFinal = { 0, 0 };
            
            a = rand.Next(7);
            b = rand.Next(7);
            Console.WriteLine(semiFinal[0] + "-------" + semiFinal[2] + "(" + a + ":" + b + ")");
            goalsSemi[0]+= a;
            goalsSemi[2] += b;
            goalsConcededSemi[0] += b;
            goalsConcededSemi[2] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            Console.WriteLine(semiFinal[2] + "-------" + semiFinal[0] + "(" + a + ":" + b + ")");
            goalsSemi[2] += a;
            goalsSemi[0] += b;
            goalsConcededSemi[2] += b;
            goalsConcededSemi[0] += a;

            if(goalsSemi[0] > goalsSemi[2])
            {
                Console.WriteLine(semiFinal[0] + " is winner");
                final[0] = semiFinal[0];
            }
            else
            {
                Console.WriteLine(semiFinal[2] + " is winner");
                final[0] = semiFinal[2];
            }

            a = rand.Next(7);
            b = rand.Next(7);
            Console.WriteLine(semiFinal[1] + "-------" + semiFinal[3] + "(" + a + ":" + b + ")");
            goalsSemi[1] += a;
            goalsSemi[3] += b;
            goalsConcededSemi[1] += b;
            goalsConcededSemi[3] += a;

            a = rand.Next(7);
            b = rand.Next(7);
            Console.WriteLine(semiFinal[3] + "-------" + semiFinal[1] + "(" + a + ":" + b + ")");
            goalsSemi[3] += a;
            goalsSemi[1] += b;
            goalsConcededSemi[3] += b;
            goalsConcededSemi[1] += a;

            if (goalsSemi[1] > goalsSemi[3])
            {
                Console.WriteLine(semiFinal[1] + " is winner");
                final[1] = semiFinal[1];
            }
            else
            {
                Console.WriteLine(semiFinal[3] + " is winner");
                final[1] = semiFinal[3];
            }
            Console.WriteLine("_____________");
            Console.WriteLine("\t\t\t**********The finalists are***********");
            for (int i = 0; i < final.Length; i++)
            {
              
                Console.WriteLine(final[i]);
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t************FINAL**************");
            Console.WriteLine(final[0] + "-------vs------" + final[1]);

            a = rand.Next(7);
            b = rand.Next(7);
            Console.WriteLine(final[0] + "-------" + final[1] + "(" + a + ":" + b + ")");
            goalsFinal[0] += a;
            goalsFinal[1] += b;
            goalsConcededFinal[0] += b;
            goalsConcededFinal[1] += a;
            Console.WriteLine("________________________________________________________________________________________________");
            if (goalsFinal[0] > goalsFinal[1])
            {
                Console.WriteLine(final[0] + " is winner");
                Console.WriteLine("Congratulations=> \n" + final[0] + "\nfor winning the UEFA CHAMPIONS LEAGUE");
            }
            else
            {
                Console.WriteLine(final[1] + " is winner");
                Console.WriteLine("Congratulations=> \n" + final[1] + "\nfor winning the UEFA CHAMPIONS LEAGUE");
            }
            Console.WriteLine("________________________________________________________________________________________________");
        }
    }    
}
