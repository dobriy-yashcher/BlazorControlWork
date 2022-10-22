

namespace RegistrationAuthorizationCore
{
    public class User
    {
        //[BsonDiscriminator("Unit")]
        //public ObjectId _id;

        public int IdUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }

        public User() { }

        public override string ToString()
        {
            return Name;
        }
    }
}
