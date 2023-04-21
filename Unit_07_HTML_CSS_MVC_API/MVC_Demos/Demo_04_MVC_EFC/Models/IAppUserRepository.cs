namespace Demo_04_MVC_EFC.Models
{
    // WHY have a repository interface??

    // We can define 'how' we want the rest of our application to access the database here.
    // Instead of accessing the dbContext directly in our controllers, we can inject a repository class that implements this interface/contract.
    
    // Having an interface allows us to easily swap between different repositories, such as a:
    // - mock repository that doesn't rely on a database connection. See: MockAppUserRepository.cs
    // - a repository that connects to a database. See: AppUserRepository.cs

    // In program.cs you can swap between the two and your app will work as expected! This is becausethe different repositories
    // satisfy the contract defined by the interface! Cool, right?

    public interface IAppUserRepository
    {
        AppUser AddSingleUser(AppUser appUser);
        List<AppUser> GetAppUsers();
    }
}