using System;
using System.Collections.Generic;
using System.Linq;

namespace AtividadeLogistica
{
    
    class Program
    {
        public class Motorista
        {
            public string NomeMotorista { get; set; }
            public string EndMotorista { get; set; }

            public int IdMotorista { get; set; }

            public Motorista() { }

            

        }


        static void Main(string[] args)
        {
            int opcoes ;
            MenuPrincipal();
            opcoes = int.Parse(Console.ReadLine());

            Motorista motorista = new Motorista();

            List<String> motoList = new List<String>();









            switch (opcoes)

            {
                //Cadastro

                case 0:
                    MenuPrincipal();
                    break;



                case 1:
                    Console.WriteLine("O que irá cadastrar?");
                    Console.WriteLine("1-Motorista");
                    Console.WriteLine("2-Caminhao");

                    int menuCadastro = int.Parse(Console.ReadLine());

                    if (menuCadastro == 1)
                    {
                        Console.WriteLine("Digite o Nome,Endereço e ID do motorista:");

                        Console.WriteLine("Nome: ");
                        motorista.NomeMotorista = Console.ReadLine();
                        Console.WriteLine("Endereço: ");
                        motorista.EndMotorista = Console.ReadLine();
                        Console.WriteLine("ID: ");
                        motorista.IdMotorista = int.Parse(Console.ReadLine());

                        //Adicionando na Lista de Motorista.
                        motoList.Add(motorista.NomeMotorista);
                        motoList.Add(motorista.EndMotorista);


                    }
                    if (menuCadastro == 2)
                    {
                        Console.WriteLine("Digite o Nome,Endereço e ID do Caminhao:");
                        Caminhao caminhao = new Caminhao();
                        Console.WriteLine("Nome: ");
                        caminhao.NomeCaminhao = Console.ReadLine();
                        Console.WriteLine("Endereço: ");
                        caminhao.EnderecoCaminhao = Console.ReadLine();
                        Console.WriteLine("ID: ");
                        caminhao.IdCaminhao = int.Parse(Console.ReadLine());

                    }

                    break;

                //Atualizar
                case 2:
                    Console.WriteLine("O que deseja atualizar?");
                    Console.WriteLine("1-Motorista");
                    Console.WriteLine("2-Caminhao");

                    int MenuAtualizar = int.Parse(Console.ReadLine());
                    


                    if (MenuAtualizar == 1)
                    {


                        foreach (string m in motoList)
                        {
                            if (m == null)
                            {
                                Console.WriteLine("Não possui motoristas para atualizar.");
                            }
                            Console.WriteLine("Não possui motoristas para atualizar.");
                        }
                    }





                    break;

            }
        }

        









        //Menu de opções
        static void MenuPrincipal()
            {
                Console.WriteLine("<>----------------------------LOGISTICA.NET----------------------------<>");
                Console.WriteLine("Digite seu nome:");
                string nome = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Olá, " + nome + "...");
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("<>--------0-Sair do programa--------<>");
                Console.WriteLine("<>--------1-Cadastrar--------<>");
                Console.WriteLine("<>--------2-Atualizar--------<>");
                Console.WriteLine("<>--------3-Remover--------<>");
                
                
            }
       
        
        
        
        
        }


    }

