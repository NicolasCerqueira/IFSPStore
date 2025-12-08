using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class User : BaseEntity<int>
    {
        public User()
        {
            
        }
        public User(int id, string name, string login, string password, string email, DateTime registerDate,
            DateTime loginDate, bool isActive) : base(id)
        {
            Name = name;
            Login = login;
            Password = password;
            Email = email;
            RegisterDate = registerDate;
            LoginDate = loginDate;
            IsActive = isActive;
        }
        //public int? Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LoginDate { get; set; }
        public bool IsActive { get; set; }
    }
}
