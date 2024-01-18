// notes to self for learning and clarification
// System.Console.ReadLine(): allows the user to enter in whatever they want on a blank slate (in this case, their name)
// the name entered needs a placed to be stored so that it can be called on later. create a string variable
// string name = ""
// putting something in as a defalut (the empty "") is called initializing the variable.
// good to know: the variable "name" on exists between the two curly brackets of the method Main(). likewise,
// the variable "n" only exists between the two curly brackets in the method PrintName(). One method can't see the variable 
// of the other

// writing code with these two separate methods (one to enter content, the other to print content) is for organization and readability
// ps is an instance

using MoreCSharpFun;
public class Program
{
    private static void Main(string[] args)
    {
        PrintStuff ps = new PrintStuff();

        string name = "";

        System.Console.WriteLine("Please enter your name");
        name = System.Console.ReadLine();

        ps.PrintName(name);
    }
}

// ...OR

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        string name = "";

//        System.Console.WriteLine("Please enter your name");
//        name = System.Console.ReadLine();
//        System.Console.WriteLine(PrintName(name));
//    }

//    private static string PrintName(string n)
//    {
//        string output = "";
//        output = "Hello, " + n;

//        return output;
//    }
//}