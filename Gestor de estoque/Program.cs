﻿using System.Net.Http.Headers;

class Program
{
    enum Menu { Listar = 1, Adicionar, Remover, Entrada, Saida, Sair}


    public static void Main(string[] args)
    {
        bool escolheuSair = false;
        while (escolheuSair == false)
        {
            Console.WriteLine("Controle de estoque");
            Console.WriteLine("1 - Listar\n2 - Adicionar\n3 - Remover\n4 - Adicionar\n5 - Registrar entrada\n6 - Regisrar saida\n7 - Sair ");
            int opInt = int.Parse(Console.ReadLine());

            if (opInt < 1 && opInt > 7)
            {

                Menu escolha = (Menu)opInt;

                switch (escolha)
                {
                    case Menu.Listar:
                        break;
                    case Menu.Adicionar:
                        break;
                    case Menu.Remover:
                        break;
                    case Menu.Entrada:
                        break;
                    case Menu.Saida:
                        break;
                    case Menu.Sair:
                        escolheuSair |= true;
                        break;

                }
            }
            else
            {
                escolheuSair = true;
            }

        }

    }

    static void Cadastro()
    {
        Console.WriteLine("Cadastro de Produtos");
        Console.WriteLine("1 - Produto Físic0\n2 - Ebook\n3 - Curso");

        int opcao = int.Parse(Console.ReadLine());

        switch(opcao) 
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }

    static void CadastrarPFisico()
    {
         

    }
}