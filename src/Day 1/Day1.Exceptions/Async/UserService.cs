using System;
using System.Threading.Tasks;

namespace Day1.Exceptions.Async
{
	public class UserService
	{
		public async Task FetchUserDataAsync(string username)
		{
			Console.WriteLine($"Started fetching {username}");
			await Task.Delay(3000);
			Console.WriteLine($"Finishes fetching {username}");
		}
	}
}
