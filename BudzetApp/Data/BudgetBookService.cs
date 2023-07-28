using System.ComponentModel;

namespace BudzetApp.Data
{
	public class BudgetBookService
	{
		private static List<Entry> mockDB = new List<Entry>()
		{
			new Entry(){Description="test", Amount=10 }
		};

		public async Task<bool> AddEntry(Entry newEntry)
		{
			mockDB.Add(newEntry);
			return true;
		}

		public async Task<List<Entry>> GetAllEntries()
		{
			return mockDB;
		}
	}
}
