using Gestor_de_estoque;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


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
            Console.WriteLine("1 - Listar\n2 - Adicionar\n3 - Remover\n4 - Registrar entrada\n5 - Regisrar saida\n6 - Sair ");
            int opInt = int.Parse(Console.ReadLine());

            if (opInt > 0 && opInt < 7)
            {

                Menu escolha = (Menu)opInt;

                switch (escolha)
                {
                    case Menu.Listar:                       
                        break;
                    case Menu.Adicionar:
                        Cadastro();
                        break;
                    case Menu.Remover:
                        break;
                    case Menu.Entrada:
                        break;
                    case Menu.Saida:
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;

                }
            }
            else
            {
                Console.WriteLine("Escolheu Sair");
                Console.ReadLine();
                escolheuSair = true;
            }
            Console.Clear();
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
                CadastrarCurso();
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
        Console.WriteLine("Produto cadastrado com sucesso ");
        Console.ReadLine();

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
        Salvar(cs);


    }

    static void Salvar()
    {
        StreamWriter escritor = new StreamWriter("Salvar.txt");
        escritor.WriteLine(cadastro);
   

       

     

    } 
}