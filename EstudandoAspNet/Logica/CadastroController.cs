using EstudandoAspNet.ListaLeitura.App.Negocio;
using EstudandoAspNet.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace EstudandoAspNet.ListaLeitura.App.Logica
{
    public class CadastroController
    {
        public string Incluir(Livro livro)
        {
            //cria um livro
            //var livro = new Livro()
            //{
            //    Titulo = contexto.Request.Form["campoTitulo"].First(),     /*faz uma query na resposta vinda da url do html apos o '?'*/
            //    Autor = contexto.Request.Form["campoAutor"].First(),
            //};

            //instancia o repositorio
            var repositorio = new LivroRepositorioCSV();

            //inclui livro no repositorio
            repositorio.Incluir(livro);

            return "Livro foi adicionado com sucesso =)";
        }

        //IActionResult : responsável por retornar o tipo da action
        //Action : nomeclatura dada aos metodos responsáveis pelas ações dos controllers
        public IActionResult ExibeFormulario()
        {
            //criando formulario html
            //ViewResult: Classe que implementa IActionResult e que representa um resultado do tipo HTML
            var html = new ViewResult { ViewName = "formulario"}; /*arquivo.cshtml*/
            return html;    /*retorna a página html*/
        }

        public string Teste()
        {
            return "Teste de CadastroController";
        }
    }
}
