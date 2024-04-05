namespace funcEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, string> createString = (a, b) => $"{a}{b}";

            Console.WriteLine(createString(5, 6));

            //func возвращает результат действия и может принимать параметры
            //как action он может принимать до 16 параметров
            //Func<T1,...T16,Tout>
        }
    }
}