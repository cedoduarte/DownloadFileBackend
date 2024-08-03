using Newtonsoft.Json;
using ReturnFileEndpoint.Models;

namespace ReturnFileEndpoint.Services
{
    public interface ITemporaryFileService
    {
        Task<PersonFile> GetFile();
    }

    public class TemporaryFileService : ITemporaryFileService
    {
        public async Task<PersonFile> GetFile()
        {
            var person = new Person()
            {
                FirstName = "Carlos",
                LastName = "Duarte",
                Age = 29
            };
            string jsonString = JsonConvert.SerializeObject(person);
            string temporaryFilePath = Path.GetTempFileName();
            File.WriteAllText(temporaryFilePath, jsonString);
            return new PersonFile()
            {
                Bytes = File.ReadAllBytes(temporaryFilePath),
                AcceptHeader = "application/json",
                FileName = "person.txt"
            };
        }
    }
}
