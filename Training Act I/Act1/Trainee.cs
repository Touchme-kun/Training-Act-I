using Microsoft.Identity.Client;

namespace Training_Act_I.Models
{
    public class Trainee : Person
    {
        public Trainee(string personName) : base(personName) { }
        
            public string Study()
            {
                return $"Trainee {PersonName} is studying!";
            }
        
    }
}
