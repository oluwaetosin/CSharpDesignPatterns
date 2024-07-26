namespace Memento
{
    public class EditorState
    {
        private string Content;

        public EditorState(string content)
        {
            this.Content = content;
        }

        public string GetContent() { return this.Content; }
    }
}
