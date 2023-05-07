namespace pfffff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student("Fifi", 12 ,43254, 5, 5);
            teacher s2 = new teacher("Ivanov", "teacher", 25);

            Console.WriteLine("Hello Mr. " + s2.name);
            Console.WriteLine("Hello " + s1.name);
        }
    }
}