using Memento;
using StatePattern;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {


            RunStatePattern();

        }

        private static void RunMemento()
        {
            Editor editor = new Editor();

            History history = new History();

            editor.SetContent("a");

            history.Push(editor.CreateState());

            editor.SetContent("b");
            history.Push(editor.CreateState());

            editor.SetContent("c");


            Console.WriteLine(editor.GetContent());

            editor.Restore(history.Pop());

            Console.WriteLine(editor.GetContent());

        }

        private static void RunStatePattern()
        {
            DirectionService service = new DirectionService();

            service.SetTravelMode(new Bicycling());

            service.GetDirection();
        }
    }
}
