﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace StreetFighterGame
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class DoAnGameLoEntities : DbContext
{
    public DoAnGameLoEntities()
        : base("name=DoAnGameLoEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<LICH_SU_TRAN_DAU> LICH_SU_TRAN_DAU { get; set; }

    public virtual DbSet<NHAN_VAT> NHAN_VAT { get; set; }

    public virtual DbSet<TAI_KHOAN> TAI_KHOAN { get; set; }

    public virtual DbSet<XEP_HANG> XEP_HANG { get; set; }

}

}

