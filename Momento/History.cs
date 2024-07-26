namespace Memento
{
    public class History
    {
        public Stack<EditorState> State;

        public History()
        {
            State = new Stack<EditorState>();
        }

        public void Push(EditorState state)
        {
            State.Push(state);
        }

        public EditorState Pop()
        {
            return State.Pop();
        }
    }
}
