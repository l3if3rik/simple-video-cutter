using System;


namespace SimpleVideoCutter.Actions
{
    public interface IActionAfterTaskCompletion
    {
        public static readonly string actionName = "";

        public event EventHandler<ActionExecutingEventArgs> ActionExecuting;
        public void Execute();
    }
}
