namespace MonkeyIsland_Inselsicht_Strand_zur_Kneipe {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello Monkey Island Spieler!");

            // lege Inselobjekte an
            Insel insel_1 = new Insel();
            Insel insel_2 = new Insel();

            // lege Spielfigur an
            Spielfigur guybrush = new Spielfigur();

            // lege Schiff an
            Schiff schiff = new Schiff();

            // lege Meer an
            Meer meer = new Meer();

            // Inseln ins Meer bringen
            meer.AddInsel(insel_1);
            meer.AddInsel(insel_2);

            // setze Spielfigut
            meer.GetInsel(0).GetStrand().SetSfpp(guybrush);

            Console.WriteLine( meer.GetInsel(0).GetStrand().GetSfpp().GetHashCode() );
            Console.WriteLine(  insel_1.GetStrand().GetSfpp().GetHashCode());
            Console.WriteLine(  guybrush.GetHashCode() );

            Console.ReadLine(  );
        }
    }
}