namespace ChallengeApp.Models
{
    public class NamedObject
    {
        public string Name { get; set; }

        public NamedObject(string name)
        {
            this.Name = name.ToUpper();
        }
    }
}