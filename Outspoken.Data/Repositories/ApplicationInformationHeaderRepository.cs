using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Outspoken.Model;
using static Outspoken.Data.IRepositories;

namespace Outspoken.Data
{
	public class ApplicationInformationHeaderRepository : EntityBaseRepository<ApplicationInformationHeader>, IApplicationRepository
	{
		private OutspokenContext context;

		public ApplicationInformationHeaderRepository(OutspokenContext context) : base(context)
		{
			this.context = context;
		}

		public async override Task<List<ApplicationInformationHeader>> GetAll()
		{
			var results = await context.Set<ApplicationInformationHeader>().ToListAsync();
			foreach (var result in results)
			{
				result.NumberOfRequests = await context.Entry(result).Collection(b => b.FeatureRequests).Query().CountAsync();
			}
			return results;
		}
	}
}
