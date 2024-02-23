namespace week07; 
class Genomics {
    public string findOneGene(string dna){
        //dna.IndexOf() , dna[a..b]
        //start codeon = ATG
        //stop codon = TAA 
        int startIndex = dna.IndexOf("ATG");
        int endIndex = dna.IndexOf("TAA", startIndex + 1);

        if (startIndex == -1 || endIndex == -1) 
        {
            return "";
        }
        
        return dna[startIndex..(endIndex + 3)];
    }

    public string findValidGene(string dna){
        int startIndex = dna.IndexOf("ATG");

        if (startIndex == -1) {
            return "";
        }

        int currentIndex = dna.IndexOf("TAA", startIndex + 1);


        while(currentIndex != -1) {
            if ((currentIndex - startIndex) % 3 == 0) {
                string result = dna[startIndex..(currentIndex + 3)];
                return result;
            }

            else {
                currentIndex = dna.IndexOf("TAA", currentIndex + 1);
            }
        }

        return "";


    }
}
class Program
{
    public static void Main(string[] args)
    {
        string dna_1 = "CGCATGCGATACGTAATACTTGA";
        //               ^           ^
        string dna_2 = "CGCATGCGATACGTATATACTTGA";
        Genomics genomicsObject = new Genomics();

        string geneString = genomicsObject.findOneGene(dna_1);
        Console.WriteLine("Gene is: " + geneString);

        geneString = genomicsObject.findOneGene(dna_2);
        Console.WriteLine("Gene is: " + geneString);

        string dna_3 = "AATGACTAAGTAA"; 
        geneString = genomicsObject.findValidGene(dna_3);
        Console.WriteLine("Gene is: " + geneString);

        string dna_4 = "AATGACTAAGATAA"; 
        geneString = genomicsObject.findValidGene(dna_4);
        Console.WriteLine("Gene is: " + geneString);
    }
}
