using LetsMarket.Menu;

namespace LetsMarket.Menu4
{
    public class Funcionarios : ICadastro
    {
        public int Id { get; set; }

        public static Action CadastrarFuncionarios = () => { Console.WriteLine(); };
        
        public static void ListarFuncionarios()
        { 
        }
    }

}