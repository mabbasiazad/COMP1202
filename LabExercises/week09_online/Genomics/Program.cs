using System.Net;

class Genomics
{
    public static string findGene(string dna) {
        //your code here
        //1- I find the first occurence of ATG
        int start = dna.IndexOf("ATG");
        if(start == -1)
        {
            return "";
        }
        //2- I find the occurance of TAA
        int stop = dna.IndexOf("TAA", start + 3);
        if (stop == -1)
        {
            return "";
        }
        //3- I will report all letters between ATG index and TAA index
        return dna[start..(stop + 3)];

    }

    public string findValidGene(string dna) {
        //excercise
        //1- find start codeone (ATG)
        int startIndex = dna.IndexOf("ATG");  
        
        if(startIndex == -1)
        {
            return "";
        }

        int stopIndex = dna.IndexOf("TAA", startIndex);


        while (stopIndex != -1)
        {
            if((stopIndex - stopIndex) % 3 == 0){
                return dna[startIndex..(stopIndex)];
            }

            //...
        }

        //LOOP (stop != -1) {
        //2- find stop codeone after ATG (stop codeon = TAA)

        //3- check if the (stop - start) % 3 == 0
            //true: report my gene dna[start..stop + 3]
            //false: return to step 2
        //}
    }

    public static void Main(string[] args)
    {
        //ATG is start codeon
        //TAA is stop codeon
        string dna = "CTATGATCGGGCCTAACT";
        //              ^            ^
        Genomics obj= new Genomics();
        //string gene = obj.findGene(dna);
        string gene = Genomics.findGene(dna);

        Console.WriteLine($"The final result will be: {gene}");
        //pass dna to findGene() method and print the gene

        dna = "ATCGTATACTGAAAACAGCTTTGAGATTGTTAAACACCGAAGAGTTATGATTT";
        //gene = obj.findGene(dna);
        gene = Genomics.findGene(dna);
        Console.WriteLine($"The final result will be: {gene}");

        dna = "TGTATGAGCATACGACGGTCTAGAGCTGGGATGAGGCCCGAACACTAAGTTATGGGT";
        //gene = obj.findGene(dna);
        gene = Genomics.findGene(dna);
        Console.WriteLine($"The final result will be: {gene}");

    }
}