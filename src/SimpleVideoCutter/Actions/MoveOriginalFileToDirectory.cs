using System.IO;
using static SimpleVideoCutter.FileHelper;

namespace SimpleVideoCutter.Actions
{
    internal class MoveOriginalFileToDirectory : ActionAfterTaskCompletion, IActionRemovesOriginalFile
    {
        public static readonly string ActionName = "move_original_file_to_directory";

        public readonly string TargetDirectory;

        public bool RemovesOriginalFile => true;

        public string OriginalFilePath { get; set; }

        public MoveOriginalFileToDirectory(string originalFilePath, string targetDirectory)
        {
            this.TargetDirectory = targetDirectory;
            this.OriginalFilePath = originalFilePath;
        }
        protected override void DoAction()
        {
            string targetPath = Path.Combine(TargetDirectory, Path.GetFileName(OriginalFilePath));
            
            MaybeCreateParentDirectory(targetPath);

            File.Move(this.OriginalFilePath, targetPath);
        }
    }
}
