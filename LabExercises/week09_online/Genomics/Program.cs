using System.Net;

class Genomics
{
    public string findGene(string dna) {
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

    public static void Main(string[] args)
    {
        //ATG is start codeon
        //TAA is stop codeon
        string dna = "CTATGATCGGGCCTAACT";
        //              ^            ^
    }
}