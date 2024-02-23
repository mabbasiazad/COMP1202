using System.Reflection.Emit;

class Genome{
    public string findOneGene(string dna){
        //start codon is ATG
        //stop codon is TAA

        string result = "";
        int startIndex = dna.IndexOf("ATG");
       
        if(startIndex == -1){
            return "";
        }
        
        int stopIndex = dna.IndexOf("TAA", startIndex + 3);
       
        if(stopIndex == -1){
            return "";
        }
        
        result = dna[startIndex..(stopIndex + 3)];

        return result;
    }

    public string findOneValidGenes(string dna){
        
}

class Program
{
    public static void Main(string[] args)
    {
        Genome g = new Genome();
        string dna = "AATGCGTAATATGGT";
        //            0123456789  
        Console.WriteLine("DNA strand is: " + dna);
        Console.WriteLine("Gene is: " + g.findOneGene(dna));

        dna = "AATGCGTACGTATGGT";
        Console.WriteLine("DNA strand is: " + dna);
        Console.WriteLine("Gene is: " + g.findOneGene(dna));
        
    }
}