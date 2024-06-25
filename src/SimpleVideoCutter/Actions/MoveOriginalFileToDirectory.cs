using System;
using System.IO;
using static SimpleVideoCutter.FileHelper;

namespace SimpleVideoCutter.Actions
{
    internal class MoveOriginalFileToDirectory : IActionAfterTaskCompletion, IActionRemovesOriginalFile
    {
        public static readonly string ActionName = "move_original_file_to_directory";

        public readonly string TargetDirectory;

        public bool RemovesOriginalFile => true;

        public string OriginalFilePath { get; set; }

        public event EventHandler<ActionExecutingEventArgs>? ActionExecuting;

        public MoveOriginalFileToDirectory(string originalFilePath, string targetDirectory)
        {
            this.TargetDirectory = targetDirectory;
            this.OriginalFilePath = originalFilePath;
        }

        public void Execute()
        {
            this.ActionExecuting?.Invoke(this, new ActionExecutingEventArgs(this, ActionName));

            string targetPath = Path.Combine(TargetDirectory, Path.GetFileName(OriginalFilePath));
            
            MaybeCreateParentDirectory(targetPath);

            File.Move(this.OriginalFilePath, targetPath);
        }
    }
}
