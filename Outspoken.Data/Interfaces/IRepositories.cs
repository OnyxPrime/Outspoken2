using System;
using Outspoken.Model;
namespace Outspoken.Data
{
	public class IRepositories
	{
		public interface IApplicationRepository : IEntityBaseRepository<ApplicationInformationHeader> { };
		public interface IApplicationFeaturesRepository : IEntityBaseRepository<ApplicationFeatureRequest> { };
	}
}
