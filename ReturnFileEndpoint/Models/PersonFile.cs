namespace ReturnFileEndpoint.Models
{
    public class PersonFile
    {
        public byte[] Bytes { get; set; }
        public string AcceptHeader { get; set; }
        public string FileName { get; set; }
    }
}
