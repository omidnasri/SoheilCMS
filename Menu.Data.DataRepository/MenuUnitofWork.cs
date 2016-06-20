﻿using System.Data.Entity;
using Menu.DomainModel;
using FrameWork.Application;
using System;

namespace Menu.Data.DataRepository
{
    public class MenuUnitofWork : IMenuUnitofWork
    {

        MenuDbContext db;
        DbContextTransaction tran;
        public MenuUnitofWork(MenuDbContext _db)
        {
            db = _db;
        }
        public void Dispose()
        {


            //Todo:Write Correct Object Dispose
            //if (db != null)
            //    db.Dispose();

        }

        public EntityAction SaveChanges()
        {
            if (db.SaveChanges() > 0)
                return EntityAction.Success;
            return EntityAction.Exception;
        }

        public MenuDbContext Context
        {
            get
            {
                return db;
            }
        }

        public void BeginTransAction()
        {
            tran = db.Database.BeginTransaction();
        }

        public void Commit()
        {
            if (ChackingTransactionInitialize())
                tran.Commit();
            else
            {
                throw new NullReferenceException("Transaction Must Be Initialize");
            }
        }

        public void RollBack()
        {
            if (ChackingTransactionInitialize())
                tran.Rollback();
            else
            {
                throw new NullReferenceException("Transaction Must Be Initialize");
            }
        }

        private bool ChackingTransactionInitialize()
        {
            return tran != null;
        }
    }
}