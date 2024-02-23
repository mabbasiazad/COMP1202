namespace week07; 
class Genomics {
    public string findOneGene(string dna){
        //dna.IndexOf() , dna[a..b]
        //start codeon = ATG
        //stop codon = TAA 
        int startIndex = dna.IndexOf("ATG");
        int endIndex = dna.IndexOf("TAA");

        if (startIndex == -1 || endIndex == -1) 
        {
            return "";
        }
        
        return dna[startIndex..(endIndex + 3)];
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
    }
}
