using LetsMarket.Menu4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LetsMarket.Menu
{
    internal static class Arquivo
    {
        public static void InicializarArquivos()
        {
            CriarArquivo<Funcionarios>();
            CriarArquivo<Produtos>();
        }

        private static void CriarArquivo<T>()
        {
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "arquivos");
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            string arquivo;
            XmlSerializer serializer;

            arquivo = Path.Combine(dir, typeof(T).Name + ".xml");
            if (!File.Exists(arquivo))
            {
                serializer = new XmlSerializer(typeof(List<T>));
                using (TextWriter write = new StreamWriter(arquivo))
                {
                    serializer.Serialize(write, new List<T>());
                }
            }
        }

        private static object? LerArquivo<T>()
        {
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "arquivos");
            string arquivo;
            XmlSerializer serializer;

            arquivo = Path.Combine(dir, typeof(T).Name + ".xml");
            serializer = new XmlSerializer(typeof(List<T>));
            using (TextReader reader = new StreamReader(arquivo))
            {
                return serializer.Deserialize(reader);
            }
        }

        public static List<T>? BuscarTodos<T>()
        {
            var itens = LerArquivo<T>();

            return itens as List<T>;
        }

        public static T? BuscarUm<T>(int id) where T : ICadastro, new()
        {
            var itens = LerArquivo<T>();

            return (itens as List<T>)!.FirstOrDefault(it => it.Id == id);
        }

        public static Funcionarios? BuscarFuncionario(string login, string senha)
        {
            var itens = LerArquivo<Funcionarios>();
            var funcionario = (itens as List<Funcionarios>)!
                .FirstOrDefault(f => f.Login == login && f.Senha == senha);

            return funcionario;
        }
    }
}