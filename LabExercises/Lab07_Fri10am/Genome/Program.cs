class Genomics
{
    public string findGene(string dna){
        //Start codon: ATG
        //Stop codon: TAA
        
        //find ATG index
        int index_atg = dna.IndexOf("ATG");

        if(index_atg == -1){
            return "No gene found";
        }

        //Console.WriteLine("ATG index: " + index_atg);

        //find TAA index after ATC
        int index_taa = dna.IndexOf("TAA", index_atg);

        if(index_taa == -1){
            return "No gene found";
        }

        Console.WriteLine("TAA index: " + index_taa);
        //report substring between ATG and TAA (codon included)
        return dna[index_atg..(index_taa + 3)];
    }
}

class Program
{
    public static void Main(string[] args)
    {
        // start codeon: ATG
        // stop codon: TAA

        string dna = "ACGATGCGTAAGC";
        //               ^      ^
        var gene = new Genomics();
        string sub_gene = gene.findGene(dna);
        Console.WriteLine("The gene section: " + sub_gene);

        string dna2 = "ACGACTGCGTAAAGC";
        sub_gene = gene.findGene(dna2);
        Console.WriteLine("The gene section: " + sub_gene);
        
        
    }
}
