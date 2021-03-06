﻿using System;
using System.Collections.Generic;
using System.Linq;
using FrameWork.Application;
using WorkSample.Contracts;
using WorkSamples.Data.DataRepository;
using WorkSamples.DomainModel;

namespace WorkSample.Data.DataAccess
{
    public class WorkSampleRepository : IWorkSampleRepository
    {

        private readonly IWorkSampleUnitofWork unit;

        public WorkSampleRepository(IWorkSampleUnitofWork _unit)
        {

            this.unit = _unit;
        }

        public SampleWork Get(int id)
        {
            var model = unit.Context.SampleWork.FirstOrDefault(a => a.Id == id);

            return model;

        }

        public int GetNextId()
        {
            var query = "dbo." + "WorkSampleSEQUENCE";
            int result = unit.Context
                .Database.SqlQuery<int>("SELECT NEXT VALUE FOR  " + query + ";").SingleOrDefault();
            return result;
        }

        public EntityAction Create(SampleWork entity)
        {
            unit.Context.SampleWork.Add(entity);

            if (unit.SaveChanges() == EntityAction.Success)
                return EntityAction.Added;
            return EntityAction.Exception;
        }

        public EntityAction Update(SampleWork entity)
        {
            unit.Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            if (unit.SaveChanges() == EntityAction.Success)
                return EntityAction.Updated;
            return EntityAction.Exception;

        }

        public EntityAction Delete(int id)
        {
            unit.Context.SampleWork.Remove(Get(id));
            if (unit.SaveChanges() == EntityAction.Success)
                return EntityAction.Deleted;
            return EntityAction.Exception;


        }



        public int Count()
        {
            return unit.Context.SampleWork.Count();
        }


        public List<SampleWork> Select()
        {
            var model = unit.Context.SampleWork.ToList();
            return model;
        }

        public List<WorkSampleListDTO> SelectPaging(int skip, int take)
        {

            var model = unit.Context.SampleWork.OrderByDescending(a => a.Id).Skip(skip).Take(take).Select(a => new WorkSampleListDTO()
            {
                Id = a.Id,
                Image = a.Image,
                ParentName = a.WorkCategory.Title,
                Slug = a.Slug
            });
            return model.ToList();
        }


        public void Dispose()
        {
            //if (rep != null)
            //    rep.Dispose();
            //if (unit != null)
            //    unit.Dispose();
        }


    }

}