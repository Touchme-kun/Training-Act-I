namespace Training_Act_I.Models
{
    public class Trainer : Person
    {
        public Trainer(string personName) : base(personName) { }

        public string Explain()
            {
                return $"Trainer {PersonName} is explaning!";
            }
        
    }
}
