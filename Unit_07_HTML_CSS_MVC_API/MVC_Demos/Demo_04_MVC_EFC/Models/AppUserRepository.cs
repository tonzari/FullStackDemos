using System;
namespace Demo_04_MVC_EFC.Models
{
	public class AppUserRepository
	{
		private readonly AppUserContext _db;

		public AppUserRepository(AppUserContext appUserContext)
		{
			_db = appUserContext;
		}

		// Get all users
		public List<AppUser> GetAppUsers()
		{
			return _db.AppUsers.ToList();
		}

		// Add single user
		public AppUser AddSingleUser(AppUser appUser)
		{
			_db.AppUsers.Add(appUser);

			// Any time you make changes to a database, you need to save those changes.
			_db.SaveChanges();

			// To do: Return the actual user that was saved to the database, not just pass the same object back.
			return appUser;
		}
	}
}

