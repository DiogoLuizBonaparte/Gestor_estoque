using Gestor_de_estoque;
using System.Net.Http.Headers;

class Program
{
    static List<IEstoque> produtos = new List<IEstoque>();
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
                CadastrarPFisico();
                break;
            case 2:
                CadastrarEbook();
                break;
            case 3:
                break;
        }
    }

    static void CadastrarPFisico()
    {
        Console.WriteLine("Cadastro de produto físico");
        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Preço: ");
        float preco = float.Parse(Console.ReadLine());
        Console.WriteLine("Frete: ");
        float frete = float.Parse(Console.ReadLine());
        ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
        produtos.Add(pf);

    }

    static void CadastrarEbook()
    {
        Console.WriteLine("Cadastro de ebook");
        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Preço: ");
        float preco = float.Parse(Console.ReadLine());
        Console.WriteLine("Autor: ");
        string autor = Console.ReadLine();
        Ebook eb = new Ebook(nome, preco, autor);
        produtos.Add(eb);

    }
    static void CadastrarCurso()
    {
        Console.WriteLine("Cadastro de ebook");
        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Preço: ");
        float preco = float.Parse(Console.ReadLine());
        Console.WriteLine("Autor: ");
        string autor = Console.ReadLine();
        Curso cs = new Curso(nome, preco, autor);
        produtos.Add(cs);

    }
}