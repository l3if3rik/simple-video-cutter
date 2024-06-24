using System;


namespace SimpleVideoCutter.Actions
{
    public class ActionExecutingEventArgs: EventArgs
    {
        public IActionAfterTaskCompletion Action;

        public string ActionName;

        public ActionExecutingEventArgs(IActionAfterTaskCompletion action, string actionName)
        { 
            this.Action = action;
            this.ActionName = actionName;
        }
    }
}
