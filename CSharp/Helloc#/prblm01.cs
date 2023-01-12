
namespace Helloc
{
    public class prblm01
    {
    static void Main(string[] args)
    {
          string s=Console.ReadLine();
        bool f=false;
        string s1="";
        char[]rever=s.ToCharArray();
        for(int i=rever.Length-1;i>=0;i++)
           s1+=rever[i].ToString();
        if(s==s1)
            f=true;
        else
           f=false;
           
            Console.WriteLine(f);           
        }
        
    }
}
    