﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ViagensOnline.Mvc.Models;
using ViagensOnLine.Dominio;
using ViagensOnLine.Repositorios.SqlServer;

namespace ViagensOnline.Mvc.Areas.Admin.Controllers
{
    public class DestinosController : Controller
    {
        private ViagensOnLineDbContext db = new ViagensOnLineDbContext();
        private string _caminhoImagensDestinos = ConfigurationManager.AppSettings["caminhosImagensDestinos"];

        // GET: Admin/Destinos
        public ActionResult Index()
        {
            return View(Mapear(db.Destinos.ToList()));
        }

        private List<DestinoViewModel> Mapear(List<Destino> destinos)
        {
            var viewModels = new List<DestinoViewModel>();

            foreach (var destino in destinos)
            {
                viewModels.Add(Mapear(destino));
            }

            return viewModels;
        }

        private DestinoViewModel Mapear(Destino destino)
        {
            var viewModel = new DestinoViewModel();
            viewModel.CaminhoImagem = Path.Combine(_caminhoImagensDestinos,destino.NomeImagem);
            viewModel.Cidade = destino.Cidade;
            viewModel.Id = destino.Id;
            viewModel.Nome = destino.Nome;
            viewModel.Pais = destino.Pais;

            return viewModel;
           
        }

        // GET: Admin/Destinos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Destino destino = db.Destinos.Find(id);
            if (destino == null)
            {
                return HttpNotFound();
            }
            return View(destino);
        }

        // GET: Admin/Destinos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Destinos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Bind vai ajudar a você informar quais os campos
       // public ActionResult Create([Bind(Include = "Id,Nome,Pais,Cidade,NomeImagem")] Destino destino)
       public ActionResult Create( DestinoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var destino = Mapear(viewModel);

                SalvarFoto(viewModel.ArquivoFoto);

                db.Destinos.Add(destino);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        private void SalvarFoto(HttpPostedFileBase arquivoFoto)
        {
            var caminhoVirtual = Path.Combine(_caminhoImagensDestinos,arquivoFoto.FileName);
            var caminhoFisico = Request.MapPath(caminhoVirtual);

            arquivoFoto.SaveAs(caminhoFisico);
        }

        private Destino Mapear(DestinoViewModel viewModel)
        {
            //automapper é um nuget que faz o mapeamento entre duas classes que tem os campos com mesma nomeclatura

            var destino = new Destino();

            destino.Cidade = viewModel.Cidade;
            destino.Id = viewModel.Id;
            destino.Nome = viewModel.Nome;
            destino.NomeImagem = viewModel.ArquivoFoto.FileName;
            destino.Pais = viewModel.Pais;

            return destino;
        }

        // GET: Admin/Destinos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Destino destino = db.Destinos.Find(id);
            if (destino == null)
            {
                return HttpNotFound();
            }
            return View(destino);
        }

        // POST: Admin/Destinos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Pais,Cidade,NomeImagem")] Destino destino)
        {
            if (ModelState.IsValid)
            {
                db.Entry(destino).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(destino);
        }

        // GET: Admin/Destinos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Destino destino = db.Destinos.Find(id);
            if (destino == null)
            {
                return HttpNotFound();
            }
            return View(destino);
        }

        // POST: Admin/Destinos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Destino destino = db.Destinos.Find(id);
            db.Destinos.Remove(destino);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
