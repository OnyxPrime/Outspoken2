using System;
using System.Collections.Generic;
using Outspoken.Model;
namespace OutspokenAPI
{
	public class TestApplicationDataservice : IDataService
	{
		List<ApplicationInformationHeader> apps;
		public TestApplicationDataservice()
		{
			PreloadData();
		}

		public bool Add(string name){
			if (string.IsNullOrWhiteSpace(name))
				throw new ArgumentException();
			
			apps.Add(new ApplicationInformationHeader() { ApplicationName = name, NumberOfRequests = 0 });
			return true;
		}

		public IEnumerable<ApplicationInformationHeader> GetAll(){
			return apps;
		}

		private void PreloadData()
		{
			apps = new List<ApplicationInformationHeader>();
			apps.Add(new ApplicationInformationHeader() { ApplicationName = "Outspoken", NumberOfRequests = 7 });
			apps.Add(new ApplicationInformationHeader() { ApplicationName = "Monkeys 2.0", NumberOfRequests = 0 });
		}
	}
}
