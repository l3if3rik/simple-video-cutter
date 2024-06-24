namespace SimpleVideoCutter.Actions
{
    internal interface IActionRemovesOriginalFile
    {
        public bool RemovesOriginalFile { get; }

        public string OriginalFilePath { get; set; }
    }
}
