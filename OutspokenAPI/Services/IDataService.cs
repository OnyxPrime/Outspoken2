using System;
using System.Collections.Generic;
using Outspoken.Model;
namespace OutspokenAPI
{
	public interface IDataService
	{
		bool Add(string applicationName);
		IEnumerable<ApplicationInformationHeader>GetAll();
	}
}
