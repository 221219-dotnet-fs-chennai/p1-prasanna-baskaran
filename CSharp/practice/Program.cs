using System;

public class manager{
    protected int x=3;
    public void result(int x){
Console.WriteLine(x);
    }
}
class teamlead:manager{
   protected int y=6;
    public void area(){
        Console.WriteLine(x*y);
    }

}
class employee:teamlead{
int z=5;
public void volume(){
    Console.WriteLine(x*y*z);
}
}
public class program{
    static void Main(string[] args)
    {
        employee x=new employee();
        x.volume();
    }
}