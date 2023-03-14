namespace MonkeyIsland_Inselsicht_Strand_zur_Kneipe {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Kneipe - Good bye Strand!");

            // lege Inselobjekt an
            Insel insel = new Insel();

            // lege Spielfigur an
            Spielfigur guybrush = new Spielfigur();

            // Anfangssituation:
            // ================
            // Sag der Insel,
            // hol die Adresse vom Strand und
            // setze das Objekt "guybrush" auf den Spielfigurparkplatz 
            insel.GetStrand().SetSfpp(guybrush);
            // Damit steht unse Spielfigur auf dem Strand!


            // wir wollen, daß die Spielfigur vom Stand in die Kneipe geht:
            // also fragen wir die Insel nach der Adresse der Kneipe
            // und setzen die Spielfigur guybrush auf dem Spielfigurparkplatz der Kneipe
            insel.GetKneipe().SetSfpp(guybrush);

            // Problem:
            // die Spielfigur ist somit 2x da - einmal am Strand und 2. in der Kneipe
            // also - löschen wir das Spielfigurobjekt aus dem Spielfigurparkplatz, indem wir den Parkplatz auf null setzen
            insel.GetStrand().SetSfpp(null);

            Console.WriteLine(  insel.GetKneipe().GetSfpp() );
            Console.WriteLine(  insel.GetKneipe().GetSfpp().GetHashCode() + "=Hashcode der Spielfigur in der Kneipe" );
            Console.WriteLine(guybrush.GetHashCode()  + " Hashcode von Guybrush ") ;

            Console.ReadLine(  );
        }
    }
}