using LetsMarket.Menu;

namespace LetsMarket.Menu4
{
    public class Funcionarios : ICadastro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool EGerente { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }


        public static Action CadastrarFuncionarios = () => { Console.WriteLine(); };
        
        public static void ListarFuncionarios()
        { 
        }
    }

}