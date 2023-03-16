namespace Training_Act_I.Act3
{
    public class Age
    {
        public int AgeYear
        { get; set; }

        public int ageLength(int Year) 
        {
            AgeYear = AgeYear * 365;
            return AgeYear;
        }
    }
}
