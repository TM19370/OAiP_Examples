namespace predicateEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isPositive = (int x) => x > 0;

            isPositive(1);

            //predicate принимает однин параметр и возвращает значение типа bool
            //как правило делегат predicate используется для сравнения какого либо объекта и получения результата в формате true или false
        }

        
    }
}