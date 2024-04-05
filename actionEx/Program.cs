namespace actionEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation(1, 2, Add);


            //action представляет собой какое либо действие которое не возвращает значение
            //action имеет 16 перегрузок от T1 до T16
            //обект (сущность(Entity)) это класс, от которого наследуется все классы в языке C#
            //сущность T даёт возможность как экземпляр класса object создавать на базе себя любые объекты
            //как правило, делегат action передается в качестве аргумента метода и проедусматривает вызов определенных действий
        }

        static void Operation(int x,int y, Action<int,int> Op) => Op(x,y);

        static void Mutiply(int x, int y) => Console.WriteLine(x * y);
        static void Add(int x, int y) => Console.WriteLine(x + y);
    }
}