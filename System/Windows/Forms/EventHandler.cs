





namespace System.Windows.Forms
{
    internal class EventHandler
    {
        private System.EventHandler lostFocus;

        public EventHandler(System.EventHandler lostFocus)
        {
            this.lostFocus = lostFocus;
        }
    }
}