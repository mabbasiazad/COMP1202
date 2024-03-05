using System.Security.Cryptography.X509Certificates;

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

    public string findValidGene(string dna){
        int startIndex = dna.IndexOf("ATG");
        if(startIndex == -1){
            return "No gene found";
        }

        int stopIndex = dna.IndexOf("TAA", startIndex + 3);

        while (stopIndex != -1)
        {
            if((stopIndex - startIndex) % 3 == 0){
            //...
                string gene = dna[startIndex..(stopIndex + 3)];
                return gene;
            }
            else {
                //stopIndex++;
                stopIndex = dna.IndexOf("TAA", stopIndex + 1);
            }            
        }

        return "No gene found";
        
        //in valid gene stopIndex - startIndex should be multiple of 3
        //if stopIndex - startIndex is not multiple of 3, find the next TAA (new stopCodon)
        //and repeat the process - Do this until you find a valid gene or stopIndex is -1
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
        
        string dna3 = "ATGxxxyyyzzzTAA";
        sub_gene = gene.findValidGene(dna3);
        Console.WriteLine("The gene section: " + sub_gene);

        string dna4 = "ATGxxxyyyzzzyyTAAxxxyyyzzzCTAA";
        sub_gene = gene.findValidGene(dna4);
        Console.WriteLine("The gene section: " + sub_gene);

        
    }
}
