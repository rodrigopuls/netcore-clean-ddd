using BaseProject.ApplicationCore.Entities;
using System.Linq;

namespace BaseProject.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BaseProjectContext context)
        {
            //context.Database.EnsureCreated();

            if (context.Clientes.Any())
            {
                return;
            };

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Fulano da Silva",
                    CPF = "34221259817"
                },

                new Cliente
                {
                    Nome = "Fulano da Silva",
                    CPF = "34221259817"
                },
            };

            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    ClienteId = clientes[0].ClienteId,
                    Nome = "Contato 1",
                    Email = "email@email.com.br",
                    Telefone = "14999999999"
                },

                new Contato
                {
                    ClienteId = clientes[1].ClienteId,
                    Nome = "Contato 2",
                    Email = "email2@email.com.br",
                    Telefone = "14999998888"
                },
            };

            context.AddRange(contatos);

            context.SaveChanges();
        }


    }
}
