using static NETOOGenerics.Swap;

namespace NETOOGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 10;
            //Console.WriteLine($"Avant échange : a = {a}, b = {b}");
            //Swap.SwapValues(ref a, ref b);
            //Console.WriteLine($"Après échange : a = {a}, b = {b}");

            MyStack<int> stack = new MyStack<int>(5);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Élément supprimé : " + stack.Pop());
            Console.WriteLine("Élément au sommet de la pile : " + stack.Peek());

        }

    }
}
