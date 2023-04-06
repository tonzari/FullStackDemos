namespace Demo_03_MVC_Forms_Validation.Models
{
    public class UserRepository
    {
        private List<UserInfo> AllUsers = new List<UserInfo>();

        public List<UserInfo> GetAllUsers()
        {
            return AllUsers;
        }

        public void AddNewUser(UserInfo userInfo)
        {
            AllUsers.Add(userInfo);
        }

        public UserInfo GetUserByEmail(string emailToFind)
        {
            return AllUsers.FirstOrDefault(u => u.EmailAddress == emailToFind);
        }
    }
}
