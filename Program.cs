internal class Program
{
    private static void Main(string[] args)
    {
       // baitap_01();
       // baitap_02();
        baitap_03();
    }
    static void baitap_01()
    {
        float celsius, kelvin, fahrenheit;
        Console.WriteLine("Enter a number as Celcius de:");
        celsius = Convert.ToSingle(Console.ReadLine());
        kelvin = celsius + 273;
        fahrenheit = celsius * 18 / 10 + 32;

        Console.WriteLine("{0} in C = {1} in K", celsius, kelvin);
        Console.WriteLine("{0} in C = {1} in F", celsius, fahrenheit);
        Console.ReadLine();
    }
    static void baitap_02()
    {
    //    //float;
    //    float PI = 3.14f;
    //    Console.WriteLine("Enter radius of the sphere");
    //    float radius = Convert.ToSingle(Console.ReadLine());
    //    float surface = 4 * PI * radius * radius;
    //    float volume = 4 / 3 * PI * radius * radius * radius;

    //    Console.WriteLine("{0} in R = {1} in S", radius, surface);
    //    Console.WriteLine("{0} in R = {1} in V", radius, volume);
    //    Console.ReadLine();

        //double;
        double PI = Math.PI;
        Console.WriteLine("Enter radius of the sphere");
        double radius = Convert.ToSingle(Console.ReadLine());
        double surface = 4 * Math.PI * Math.Pow(radius,2);
        double volume = 4 / 3 * Math.PI * Math.Pow(radius,3);

        Console.WriteLine("{0} in R = {1} in S", radius, surface);
        Console.WriteLine("{0} in R = {1} in V", radius, volume);
        Console.ReadLine();
    }
    static void baitap_03()
    {
        Console.Write("Enter 1st number:");
        int number_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd number:");
        int number_2 = Convert.ToInt32(Console.ReadLine());

        int adding = number_1 + number_2;
        int subtracting = number_1 - number_2;
        int multiplying = number_1 * number_2;
        int dividing = number_1 / number_2;
        int remanding = number_1 % number_2;

        Console.WriteLine($"{number_1} + {number_2} = {adding}");
        Console.WriteLine($"{number_1} - {number_2} = {subtracting}");
        Console.WriteLine($"{number_1} * {number_2} = {multiplying}");
        Console.WriteLine($"{number_1} / {number_2} = {dividing}");
        Console.WriteLine($"{number_1} % {number_2} = {remanding}");
        Console.ReadLine();

    }

}