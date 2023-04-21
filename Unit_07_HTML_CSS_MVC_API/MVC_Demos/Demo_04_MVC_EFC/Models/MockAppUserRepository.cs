namespace Demo_04_MVC_EFC.Models
{
    public class MockAppUserRepository : IAppUserRepository
    {
        public AppUser AddSingleUser(AppUser appUser)
        {
            return new AppUser()
            {
                AppUserId = appUser.AppUserId + 100,
                FirstName = appUser.FirstName + "!",
                EmailAddress = appUser.EmailAddress + "!"
            };
        }

        public List<AppUser> GetAppUsers()
        {
            return new List<AppUser> {
                new AppUser() { AppUserId = 1, EmailAddress = "test@test.test", FirstName = "Sam"},
                new AppUser() { AppUserId = 2, EmailAddress = "dog@dog.dog", FirstName = "Tam"},
                new AppUser() { AppUserId = 3, EmailAddress = "cat@cat.cat", FirstName = "Jam"},
                new AppUser() { AppUserId = 4, EmailAddress = "rabbit@rabbit.rabbit", FirstName = "Pam"},
            };
        }
    }
}
