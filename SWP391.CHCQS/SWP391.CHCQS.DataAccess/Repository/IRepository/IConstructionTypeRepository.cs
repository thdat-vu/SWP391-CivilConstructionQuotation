﻿using SWP391.CHCQS.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP391.CHCQS.DataAccess.Repository.IRepository
{
	public interface IConstructionTypeRepository : IRepository<ConstructionType>
	{
		void Update(ConstructionType obj);
		void UpdateRange(List<ConstructionType> obj);
		string GetName(string id);
	}
}
