﻿using SWP391.CHCQS.DataAccess.Data;
using SWP391.CHCQS.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP391.CHCQS.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SWP391DBContext _db;
        public IStandardQuotationRepository StandardQuotation {  get; private set; }
        public IProjectRepository Project {  get; private set; }
        public IMaterialDetailRepository MaterialDetail { get; private set; }
        public ICustomQuotaionTaskRepository CustomQuotaionTask { get; private set; }
        public ICustomQuotationRepository CustomQuotation { get; private set; }
        public ITaskRepository Task { get; private set; }
        public IMaterialRepository Material { get; private set; }
        public IConstructDetailRepository ConstructDetail { get; private set; }
		public ITaskCategoryRepository TaskCategory { get; private set; }

		public UnitOfWork(SWP391DBContext db)
        {
            _db = db;
            StandardQuotation = new StandardQuotationRepository(_db);
            Project = new ProjectRepository(_db);
            MaterialDetail = new MaterialDetailRepository(_db);
            CustomQuotaionTask = new CustomQuotaionTaskRepository(_db);
            CustomQuotation = new CustomQuotationRepository(_db);
            Task = new TaskRepository(_db);
            Material = new MaterialRepository(_db);
            ConstructDetail = new ConstructDetailRepository(_db);
            TaskCategory = new TaskCategoryRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
