using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

//http://www.macoratti.net/19/07/aspnc_start1.htm

namespace EstudandoAspNet.ListaLeitura.App
{
    public class Startup
    {
        //O método ConfigureServices nos permite adicionar ou registrar serviços no Aplicativo
        public void ConfigureServices(IServiceCollection services)
        {
            //mais informações: https://bit.ly/33tVSAm
            services.AddMvc();      /*adiciona MVC que adiciona os serviços essenciais para uma aplicação*/
        }

        //IApplicationBuilder : responsável por configurar a sequencia de respostas para cada tipo de requisição
        //chamado de RequestPipeline
        public void Configure(IApplicationBuilder app)
        {
            //Controller : indica qual é a classe que é utilizada para tratar a requisição
            //Action : indica qual é o metodo da classe indicada anteriormente responsável por fazer o tratamento


            app.UseDeveloperExceptionPage();      //utilizado para mostrar erros de execução em ambiente de desenvolvimento apenas!
            app.UseMvcWithDefaultRoute();         //inicia a aplicação utilizando o roteamento padrão mvc
        }

        //public static void Configure_FeitoNaMao(IApplicationBuilder app)
        //{
        //    //cada rota precisa ser encapsulada em um objeto
        //    //criando uma colecao de objetos que representam rotas

        //    //configurando as rotas
        //    var builder = new RouteBuilder(app);                      /*RouteBuilder: Responsável por construir rotas do site ou seja as urls*/
        //    builder.MapRoute("Livros/ParaLer", LivrosController.ParaLer); /*MapRoute: recebe a rota e o metodo que atende a essa requisicao*/
        //    builder.MapRoute("Livros/Lendo", LivrosController.Lendo);
        //    builder.MapRoute("Livros/Lidos", LivrosController.Lidos);
        //    builder.MapRoute("Livros/Detalhes/{id:int}", LivrosController.DetalhesLivro);   /*:int cria uma restrição de tipo na requisição pela url se não for int a task não é executada*/
        //    builder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", CadastroController.NovoLivro);
        //    builder.MapRoute("Cadastro/ExibeFormulario", CadastroController.ExibeFormulario);
        //    builder.MapRoute("Cadastro/Incluir", CadastroController.Incluir);

        //    var rotas = builder.Build();  //cria as rotas
        //    app.UseRouter(rotas); //inicia a aplicação utilizando o roteamento do aspnet core
        //}

        //responsavel por mostrar os 'livros para ler' ao acessar a página web


        //public Task RoteamentoManual(HttpContext contexto) /*HttpContext: Responsável pela requição web.
        //                                               ou seja, tudo que front solicitar a resposta será devolvida por essa classe*/
        //{
        //    var _repo = new LivroRepositorioCSV();

        //    //dicionario responsavel por armazenar os caminhos do site e suas respostas de requisição
        //    var caminhoAtendidos = new Dictionary<string, RequestDelegate>
        //    {
        //        { "/Livros/ParaLer", ParaLer },
        //        { "/Livros/Lendo", Lendo },
        //        { "/Livros/Lidos", Lidos }
        //    };

        //    //checa 'contexto.Request.Path' existe dentro do dicionario, ou seja, se o caminho url está mapeado
        //    if (caminhoAtendidos.ContainsKey(contexto.Request.Path))
        //    {
        //        //contexto.Request.Path : Responsável por responder com uma resposta diferente por roteamento do site (url)
        //        var metodo = caminhoAtendidos[contexto.Request.Path];
        //        return metodo.Invoke(contexto); /*.Invoke : Invoca um metodo do tipo delegate*/
        //    }
        //    else 
        //    {
        //        contexto.Response.StatusCode = 404;     /*statusCode 404 para pagina não existente*/
        //        return contexto.Response.WriteAsync("Caminho inexistente!");
        //    }
        //}
    }
}