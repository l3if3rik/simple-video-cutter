using System.IO;

namespace SimpleVideoCutter.Actions
{
    internal class DeleteOriginalFile : ActionAfterTaskCompletion, IActionRemovesOriginalFile
    {
        public new static readonly string ActionName = "delete_original_file";

        public bool RemovesOriginalFile => true;

        public string OriginalFilePath { get; set; }

        public DeleteOriginalFile(string originalFilePath)
        {
            this.OriginalFilePath = originalFilePath;
        }
        protected override void DoAction()
        {
            File.Delete(this.OriginalFilePath);
        }
    }
}
