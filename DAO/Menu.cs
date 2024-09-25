using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models;

namespace DesafioPOO.DAO
{
    public class Menu
    {
        public void menu()
        {
            string telefone, modelo, imei;
            int memoria;
            Console.Write("| Digite o numero do seu celular : ");
            telefone = Console.ReadLine();
        
            Console.WriteLine("| Selecione o Modelo : \n 1-Nokia\n 2-IPhone");
            modelo = Console.ReadLine();
            if(modelo == "1" || modelo == "Nokia")
            {
                modelo = "Nokia";
            }
            else if(modelo == "2" || modelo == "iPhone")
            {
                modelo = "iPhone";
            }
            else
            {
                Console.WriteLine("Modelo inválido, não existem aplicativos para esse modelo...");
                Console.WriteLine("|---- Encerrando Sistema ----|");
                Environment.Exit(0);
            }
            Console.Write("| Digite o IMEI :");
            imei = Console.ReadLine();

            Console.Write("| Digite o tamanho da Memória :");
            memoria = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("| Escolha o aplicativo que deseja instalar : ");
            string aplicativo = ListarAplicativos(modelo);
            if(modelo == "Nokia")
            {
                Nokia meuNokia = new Nokia(telefone, modelo, imei, memoria);
                meuNokia.Ligar();
                meuNokia.ReceberLigacao();
                meuNokia.InstalarAplicativo(aplicativo);  
            }
            else
            {
                Iphone meuiPhone = new Iphone(telefone,modelo,imei,memoria);
                meuiPhone.Ligar();
                meuiPhone.ReceberLigacao();
                meuiPhone.InstalarAplicativo(aplicativo);
            }
            Console.WriteLine($"{aplicativo} instalado com sucesso !\n Aperte ENTER para continuar :");
            Console.ReadLine();
            Console.WriteLine($"{aplicativo} pronto para uso... ");
            Environment.Exit(0);
        }
        static string ListarAplicativos(string modelo)
        {
            string app = "";
            string appAdc = "";
            
            if(modelo == "Nokia")
            {
                appAdc = "Meu Nokia";
            }
            else
            {
                appAdc = "Meu iPhone";
            }

            List<string> apis = new List<string>();
            // Adicionar aplicativos à lista
            apis.Add("WhatsApp");
            apis.Add("Facebook");
            apis.Add("Instagram");
            apis.Add(appAdc);
            if(modelo == "iPhone")
            {
                Console.WriteLine("|----BEM VINDO A APP STORE----||");
            }
            else
            {
                Console.WriteLine("|----BEM VINDO A PLAY STORE----||");
            }
            // Exibir aplicativos
            for (int i = 0; i < apis.Count; i++)
            {
                Console.WriteLine($"{i} - {apis[i]}");
            }
            app = Console.ReadLine();
            switch(app)
            {
                case "0":
                case "WhatsApp":
                    app = "WhatsApp";
                break;
                case "1":
                case "Facebook":
                    app = "Facebook";
                break;
                case "2":
                case "Instagram":
                    app = "Instagram";
                break;
                case "3":
                    app = appAdc;
                break;
            }
            if(app == appAdc)
            {
                app = appAdc;
            }
            return app; 
        }
    }

    
    
}