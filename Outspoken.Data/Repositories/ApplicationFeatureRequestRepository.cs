using System;
using Outspoken.Model;
using static Outspoken.Data.IRepositories;
namespace Outspoken.Data
{
	public class ApplicationFeatureRequestRepository : EntityBaseRepository<ApplicationFeatureRequest>, IApplicationFeaturesRepository
	{
		public ApplicationFeatureRequestRepository(OutspokenContext context) : base(context)
		{
		}
	}
}
