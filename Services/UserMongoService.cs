using System.Collections.Generic;
using System.Linq;
using UserApi.Models;
using MongoDB.Driver;
namespace UserApi.Services
{
    public class UserService
    {
        public IMongoCollection<User> _user;
        public UserService(IUserDatabaseSettings Settings)
    {
            var client = new MongoClient(Settings.ConnectionString);
            var database = client.GetDatabase(Settings.DatabaseName);

            _user = database.GetCollection<User>(Settings.UserCollectionName);
    }
        public List<User> Get() =>
                _user.Find(user => true).ToList();
        public User Get(int id) =>
            _user.Find<User>(user => user.Id == id).FirstOrDefault();
        public User Create(User user)
        {
            _user.InsertOne(user);
            return user;
        }
        public void Update(int id, User userIn) =>
            _user.ReplaceOne(user => userIn.Id == id,userIn);
        public void Remove(int id) =>
            _user.DeleteOne(user => user.Id == id);

}
}
