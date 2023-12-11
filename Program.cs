namespace Arrays
{
    class Program 
    { 
        static void Main(string[] args)
        {

           // int[] array1 = new int[5] { 1, 2, 3,4,5 };
           // Console.WriteLine("velor psicion 1");
           // ElementoVajilla[] l = new ElementoVajilla[5];
            object[] elemetoVajilla = new object[5];
            elemetoVajilla[0] = 0;
            elemetoVajilla[1] = 'a';
            elemetoVajilla[2] = 'a';
            elemetoVajilla[3] = 'a';
            elemetoVajilla[4] =0;

            Console.WriteLine("escribe el id ");  
            int id = Convert.ToInt32(Console.ReadLine());
            elemetoVajilla [0] = id;

            Console.WriteLine(elemetoVajilla[1]);
        }
    }
}