using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace UserApi.Models
{
    public class UserDatabaseSettings:IUserDatabaseSettings
    {
        public string UserCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
    public interface IUserDatabaseSettings
    {
        string UserCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
    public class User
    {
        [BsonId]        //  To designate this property as the document's primary key
        [BsonRepresentation(BsonType.ObjectId)]   // To Allow passing the parameter as a type
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        // DOB:Date of birth
        public String DOB { get; set; }
    }
}