namespace HappyPaws_BE.Models.Domain
{
    public class Cats
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public byte[]  Image { get; set; }
        public bool IsAdopted { get; set; }
    }
}
