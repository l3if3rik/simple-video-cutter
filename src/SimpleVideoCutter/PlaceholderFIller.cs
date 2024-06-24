using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVideoCutter
{
    [SupportedOSPlatform("windows")]
    internal class PlaceholderFiller
    {
        private readonly VideoCutterTimeline videoCutterTimeline;

        public PlaceholderFiller(VideoCutterTimeline videoCutterTimeline)
        {
            this.videoCutterTimeline = videoCutterTimeline;
        }

        public string ReplaceStandardDirectoryPatterns(string str, string? path)
        {
            return str
                .Replace("{SameFolder}", Path.GetDirectoryName(path))
                .Replace("{UserVideos}", Environment.GetFolderPath(Environment.SpecialFolder.MyVideos))
                .Replace("{UserDocuments}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
                .Replace("{MyComputer}", Environment.GetFolderPath(Environment.SpecialFolder.MyComputer));
        }

        public string ReplaceFilePatterns(string str, string path)
        {
            var fileInfo = new FileInfo(path);

            return str
                .Replace("{FileName}", Path.GetFileName(path))
                .Replace("{FileNameWithoutExtension}", Path.GetFileNameWithoutExtension(path))
                .Replace("{FileExtension}", Path.GetExtension(path))
                .Replace("{FileDate}", string.Format("{0:yyyyMMdd-HHmmss}", fileInfo.LastWriteTime))
                .Replace("{Timestamp}", string.Format("{0:yyyyMMdd-HHmmss}", DateTime.Now))
                .Replace("{SelectionStart}", string.Format("{0:hhmmss}", TimeSpan.FromMilliseconds(this.videoCutterTimeline.Selections.OverallStart!.Value)))
                .Replace("{SelectionEnd}", string.Format("{0:hhmmss}", TimeSpan.FromMilliseconds(this.videoCutterTimeline.Selections.OverallEnd!.Value)))
                .Replace("{SelectionStartMs}", string.Format("{0}", this.videoCutterTimeline.Selections.OverallStart.Value))
                .Replace("{SelectionEndMs}", string.Format("{0}", this.videoCutterTimeline.Selections.OverallEnd.Value))
                .Replace("{Duration}", string.Format("{0:hhmmss}", TimeSpan.FromMilliseconds(this.videoCutterTimeline.Selections.OverallDuration)));
        }
    }
}
