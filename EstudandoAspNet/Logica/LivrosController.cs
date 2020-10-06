using EstudandoAspNet.ListaLeitura.App.Negocio;
using EstudandoAspNet.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EstudandoAspNet.ListaLeitura.App.Logica
{
    /*
     * Isolando os metodos de cada requisição para que no futuro, seja possível adicionar regras de negocio a cada url
     * também facilitando a manuntenção do codigo
     */

    public class LivrosController : Controller /*Controller : Classe responsável por 
                                                * ter propriedades diversas para transportar as informações
                                                * da classe para o html e vice versa*/
    {

        public IEnumerable<Livro> Livros { get; set; }  /*propriedade Livro que será requisitada no html*/

        public IActionResult ParaLer()
        {
            var _repo = new LivroRepositorioCSV();      /*instancia os livros*/

            //ViewBag : propriedade declarada na 'classe pai', ou seja utilizada para passar a 
            //propriedade livros para ela que por sua vez passará para o cshtml
            ViewBag.Livros = _repo.ParaLer.Livros;

            //responde a requisição web com a View lista (lista.cshtml) de livros
            return View("lista");
        }

        public IActionResult Lendo()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lendo.Livros;
            return View("lista");
        }

        public IActionResult Lidos()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lidos.Livros;
            return View("lista");
        }

        //usando o 'ModelBinding' para converter a string para int : https://docs.microsoft.com/pt-br/aspnet/core/mvc/models/model-binding?view=aspnetcore-3.1
        /*também pode ser utilizadas outros tipos de variaveis como string, boolean etc como parametro*/

        /*informa o framework que é necessario o ID de entrada na requisição. Pega a id daquele livro*/
        public string DetalhesLivro(int id) 
        {
            var repositorio = new LivroRepositorioCSV();                /*instancia o repositorio de livros para fazer a busca*/
            var livro = repositorio.Todos.First(l => l.Id == id);       /*faz uma busca pela id do livro fornecido*/

            return livro.Detalhes();      /*retorna os detalhes daquele livro*/
        }

        public string Teste()
        {
            return "Teste de Livros";
        }
    }
}
