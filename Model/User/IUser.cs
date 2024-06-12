namespace Model.User
{
    public interface IUser
    {
        void Add(User user);
        List<User> Get();
    }
}