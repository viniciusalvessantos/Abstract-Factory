/*
Implementação do padrão Abstract Factory, onde há duas fábricas (Fábrica 1 e Fábrica 2), cada uma responsável pela produção de dois tipos de produtos: Produto A e Produto B. Cada fábrica gera suas próprias variações desses produtos, garantindo a criação de famílias de objetos relacionados entre si sem especificar suas classes concretas
*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        new Cliente().Main();
    }

}

public class Cliente
{
    public void Main()
    {
        ClienteMetodo(new FabricaProduto1());
        ClienteMetodo(new FabricaProduto2());

    }
    public void ClienteMetodo(IFabricaProduto fabricaProduto)
    {
        var produtoA = fabricaProduto.CriarProdutoA();
        var produtoB = fabricaProduto.CriarProdutoB();
        Console.WriteLine(nameof(fabricaProduto) + " " + produtoA.FazerAlgoA());
        Console.WriteLine(nameof(fabricaProduto) + " " + produtoB.FazerAlgoB());
    }
}




public interface IFabricaProduto
{
    IProdutoA CriarProdutoA();
    IProdutoB CriarProdutoB();
}

public class FabricaProduto1 : IFabricaProduto
{
    public IProdutoA CriarProdutoA()
    {
        return new ProdutoA1();
    }

    public IProdutoB CriarProdutoB()
    {
        return new ProdutoB1();
    }
}

public class FabricaProduto2 : IFabricaProduto
{
    public IProdutoA CriarProdutoA()
    {
        return new ProdutoA2();
    }

    public IProdutoB CriarProdutoB()
    {
        return new ProdutoB2();
    }
}





public interface IProdutoA
{
    string FazerAlgoA();
}
public interface IProdutoB
{
    string FazerAlgoB();
}

public class ProdutoA1 : IProdutoA
{
    public string FazerAlgoA()
    {
        return "Produto A1";
    }
}
public class ProdutoA2 : IProdutoA
{
    public string FazerAlgoA()
    {
        return "Produto A2";
    }
}

public class ProdutoB1 : IProdutoB
{
    public string FazerAlgoB()
    {
        return "Produto B1";
    }
}
public class ProdutoB2 : IProdutoB
{
    public string FazerAlgoB()
    {
        return "Produto B2";
    }
}