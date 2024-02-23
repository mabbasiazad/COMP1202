class Genomics
{
    public string findGene(string dna){
        //Start codon: ATG
        //Stop codon: TAA
        
        //find ATG index
        int index_atg = dna.IndexOf("ATG");

        //find TAA index after ATC
        int index_taa = dna.IndexOf("TAA", index_atg + 1);
        //report substring between ATG and TAA (codon included)
        return dna[index_atg..(index_taa + 3)];
    }
}

class Program
{
    public static void Main(string[] args)
    {
        string dna = "ACGATGCGTAAGC";
        //               ^      ^
        var gene = new Genomics();
        string sub_gene = gene.findGene(dna);
        Console.WriteLine("The gene section: " + sub_gene);
        
    }
}
