﻿using Formen;

public class Program
{
    public static void Main(string[] args)
    {
        Point p1 = new Point(0,0);
        Point p2 = new Point(5,5);

        Rechteck r = new Rechteck(p1, p2);

        Console.WriteLine($"getDistance: {p1.getDistance(p2)}");
        Console.WriteLine($"getUpperLeft: {r.getUpperLeft()}");
        Console.WriteLine($"getUpperRight: {r.getUpperRight()}");
        Console.WriteLine($"getLowerLeft: {r.getLowerLeft()}");
        Console.WriteLine($"getLowerRight: {r.getLowerRight()}");
        Console.WriteLine($"getDiagonal: {r.getDiagonal()}");


        //char choice;
        //Dreieck d = new Dreieck();
        ////Rechteck r = new Rechteck();
        //Kreis k = new Kreis();

        //Console.WriteLine("Dreieck (d), Rechteck (r) oder Kreis (k)?");
        //choice = char.Parse(Console.ReadLine());

        //switch (choice)
        //{
        //    case 'd':
        //        Console.WriteLine("Seitenlänge A eingeben:");
        //        d.SeiteA = decimal.Parse(Console.ReadLine());
        //        Console.WriteLine("Seitenlänge B eingeben:");
        //        d.SeiteB = decimal.Parse(Console.ReadLine());
        //        Console.WriteLine("Seitenlänge C eingeben:");
        //        d.SeiteC = decimal.Parse(Console.ReadLine());

        //        Console.WriteLine($"Seite A: {d.SeiteA}");
        //        Console.WriteLine($"Seite B: {d.SeiteB}");
        //        Console.WriteLine($"Seite C: {d.SeiteC}");
        //        Console.WriteLine($"Fläche: {d.berechne_flaeche()}");
        //        Console.WriteLine($"Umfang: {d.berechne_umfang()}");
        //        break;
        //    case 'r':
        //        //Console.WriteLine("Länge eingeben:");
        //        //r.Length = decimal.Parse(Console.ReadLine());
        //        //Console.WriteLine("Breite eingeben:");
        //        //r.Width = decimal.Parse(Console.ReadLine());

        //        //Console.WriteLine($"Länge: {r.Length}");
        //        //Console.WriteLine($"Breite: {r.Width}");
        //        //Console.WriteLine($"Fläche: {r.berechne_flaeche()}");
        //        //Console.WriteLine($"Umfang: {r.berechne_umfang()}");
        //        break;
        //    case 'k':
        //        Console.WriteLine("Radius eingeben:");
        //        k.Radius = decimal.Parse(Console.ReadLine());

        //        Console.WriteLine($"Radius: {k.Radius}");
        //        Console.WriteLine($"Fläche: {k.berechne_flaeche()}");
        //        Console.WriteLine($"Umfang: {k.berechne_umfang()}");
        //        break;

        //    default:
        //        Console.WriteLine("Ungültige Eingabe");
        //        break;
        //}   
    }
}