using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RegistrationAuthorizationCore
{
    [BsonDiscriminator("User")]
    public class User
    {
        public ObjectId _id;
        public string Login { get; set; }
        public string Password { get; set; }
        public string repPassword;
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
