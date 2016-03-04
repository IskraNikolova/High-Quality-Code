namespace CompositePattern
{
    using CompositePattern.Models;

    public class CompositePatternMainTest
    {
        public static void Main()
        {
            Commander king = new Commander("King");

            Commander general = new Commander("General");

            Commander officerTonga = new Commander("Officer Tonga");
            officerTonga.Add(new Person("First person"));
            officerTonga.Add(new Person("Second person"));
            officerTonga.Add(new Person("Third person"));

            Commander officerHerin = new Commander("Officer Herin");
            officerHerin.Add(new Person("First person Herin"));
            officerHerin.Add(new Person("Second person Herin"));
            officerHerin.Add(new Person("Third person Herin"));

            general.Add(officerTonga);
            general.Add(officerHerin);

            king.Add(general);

            king.Display(1);
        }
    }
}