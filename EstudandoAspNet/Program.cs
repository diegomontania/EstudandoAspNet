using EstudandoAspNet.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Hosting;

namespace EstudandoAspNet.ListaLeitura.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var _repo = new LivroRepositorioCSV();

            //objeto que hospeda os pedidos web
            IWebHost host = new WebHostBuilder()    /*WebHostBuilder : responsável por construir um hospedeiro web*/
                .UseKestrel()                       /*Responsável por utilizar o servidor kestrel para este host*/
                .UseStartup<Startup>()              /*Classe responsável por inicialiazar este host*/
                .Build(); 

            host.Run();   /*faz o host ficar disponível para receber as chamadas*/
        }
    }
}
