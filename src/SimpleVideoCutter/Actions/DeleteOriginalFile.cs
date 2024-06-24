using System;
using System.IO;

namespace SimpleVideoCutter.Actions
{
    internal class DeleteOriginalFile : IActionAfterTaskCompletion, IActionRemovesOriginalFile
    {
        public static readonly string ActionName = "delete_original_file";

        public bool RemovesOriginalFile => true;

        public string OriginalFilePath { get; set; }

        public event EventHandler<ActionExecutingEventArgs>? ActionExecuting;

        public DeleteOriginalFile(string originalFilePath)
        {
            this.OriginalFilePath = originalFilePath;
        }

        public void Execute()
        {
            this.ActionExecuting?.Invoke(this, new ActionExecutingEventArgs(this, ActionName));

            File.Delete(this.OriginalFilePath);
        }
    }
}
