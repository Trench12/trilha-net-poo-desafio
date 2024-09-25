using System.Reflection;
using DesafioPOO.Models;
using DesafioPOO.DAO;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Usar Menu?\n1-Sim\n2-Não");
        string resposta = Console.ReadLine();
        if(resposta == "Sim" || resposta == "1")
        {
            Menu m = new Menu();
            m.menu();
        }
        else
        {
            Console.WriteLine("Nokia");
            Smartphone nokia = new Nokia("123456789", "Nokia", "1111111", 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("Iphone");
            Smartphone iphone = new Iphone("123456789", "iPhone", "1111111", 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("Telegram");
        } 
    }
}