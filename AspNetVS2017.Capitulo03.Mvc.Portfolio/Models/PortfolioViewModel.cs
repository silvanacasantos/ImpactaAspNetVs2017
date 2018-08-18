using System.Collections.Generic;

namespace AspNetVS2017.Capitulo03.Mvc.Portfolio.Models
{
    public class PortfolioViewModel
    {
        ////metodo construtor 
        //public PortfolioViewModel()
        //{
        //    CaminhosImagens = new List<string>();
        //}

        //cria a estancia dentro da propria classe
        public List<string> CaminhosImagens { get; set; } = new List<string>();


    }
}