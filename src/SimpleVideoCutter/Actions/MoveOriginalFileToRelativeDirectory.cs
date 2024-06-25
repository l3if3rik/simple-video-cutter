using System;
using System.IO;
using static SimpleVideoCutter.FileHelper;

namespace SimpleVideoCutter.Actions
{
    internal class MoveOriginalFileToRelativeDirectory : IActionAfterTaskCompletion, IActionRemovesOriginalFile
    {
        public static readonly string ActionName = "move_original_file_to_relative_directory";

        public readonly string TargetRelativeDirectory;

        public bool RemovesOriginalFile => true;

        public string OriginalFilePath { get; set; }

        public event EventHandler<ActionExecutingEventArgs>? ActionExecuting;

        public MoveOriginalFileToRelativeDirectory(string originalFilePath, string targetRelativeDirectory)
        {
            this.TargetRelativeDirectory = targetRelativeDirectory;
            this.OriginalFilePath = originalFilePath;
        }

        public void Execute()
        {
            this.ActionExecuting?.Invoke(this, new ActionExecutingEventArgs(this, ActionName));

            string targetDirectory = Path.Combine(Path.GetDirectoryName(this.OriginalFilePath) ?? ".", this.TargetRelativeDirectory);
            string targetPath = Path.Combine(targetDirectory, Path.GetFileName(this.OriginalFilePath));

            MaybeCreateParentDirectory(targetPath);

            File.Move(this.OriginalFilePath, targetPath);
        }
    }
}
