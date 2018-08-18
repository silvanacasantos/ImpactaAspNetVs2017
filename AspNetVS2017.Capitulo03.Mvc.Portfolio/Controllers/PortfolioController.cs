﻿using AspNetVS2017.Capitulo03.Mvc.Portfolio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetVS2017.Capitulo03.Mvc.Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            //caminho das imagens devem estar dentro do webconfig
            const string diretorioImagens = "/Content/Imagens/Portfolio";
            
            //server.mappath = busca o caminho físico da pasta /Content/Imagens/Portfolio.
            var caminhos = Directory.EnumerateFiles(Server.MapPath(diretorioImagens));

            //estancio o objeto para ganhar o conteúdo da classe
            var viewModel = new PortfolioViewModel();
            //viewModel.CaminhosImagens = new List<string>();

            foreach (var caminho in caminhos)
            {
                //transforma o caminho fisico na minha imagem.
                viewModel.CaminhosImagens.Add($"{diretorioImagens}/{Path.GetFileName(caminho)}");
            }
            return View(viewModel);
        }
    }
}