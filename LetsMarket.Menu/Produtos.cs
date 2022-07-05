using LetsMarket.Menu;

namespace LetsMarket.Menu4
{
    public class Produtos : ICadastro
    {
        public int Id { get; set; }

        public static Action ListarProdutos = () => Console.WriteLine("Listando Produtos");
        public static Action CadastrarProdutos = () => Console.WriteLine("Cadastrando Produtos");
    }
}