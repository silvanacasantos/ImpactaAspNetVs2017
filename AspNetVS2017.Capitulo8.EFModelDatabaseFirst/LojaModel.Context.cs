﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetVS2017.Capitulo8.EFModelDatabaseFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LojaModelContainer : DbContext
    {
        public LojaModelContainer()
            : base("name=LojaModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<ProdutoImagem> ProdutoImagem { get; set; }
        public virtual DbSet<Produto> ProdutoSet { get; set; }
        public virtual DbSet<Fornecedores> Fornecedores { get; set; }
    }
}
