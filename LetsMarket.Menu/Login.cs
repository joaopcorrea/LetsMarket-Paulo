using LetsMarket.Menu4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMarket.Menu
{
    internal class Login
    {
        internal static int Entrar()
        {
            Console.Clear();
            Console.WriteLine("LOGIN");
            Console.WriteLine(new String('-', Console.WindowWidth));

            Console.Write("Login: ");
            string login = Console.ReadLine();
            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            if (Arquivo.BuscarTodos<Funcionarios>().Count == 0)
            {
                if (login.ToUpperInvariant() == senha.ToUpperInvariant() && 
                    senha.ToUpperInvariant() == "ADMIN")
                {
                    return 0;
                }
            }
            else
            {
                var funcionario = Arquivo.BuscarFuncionario(login, senha);
                if (funcionario != null)
                    return funcionario.Id;
            }

            Console.WriteLine();
            Console.WriteLine(new String('-', Console.WindowWidth));
            Console.WriteLine("CREDENCIAIS INVÁLIDAS!");
            Console.ReadKey();

            return -1;
        }
    }
}
