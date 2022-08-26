﻿using System.ComponentModel;
using System;
using System.Threading.Tasks;

namespace Downloader
{
    public interface IDownload
    {
        public string Url { get; }
        public string Folder { get; }
        public string Filename { get; }
        public long DownloadedFileSize { get; }
        public long TotalFileSize { get; }
        public DownloadStatus Status { get; }

        public event EventHandler<DownloadProgressChangedEventArgs> ChunkDownloadProgressChanged;
        public event EventHandler<AsyncCompletedEventArgs> DownloadFileCompleted;
        public event EventHandler<DownloadProgressChangedEventArgs> DownloadProgressChanged;
        public event EventHandler<DownloadStartedEventArgs> DownloadStarted;

        public void Clear();
        public Task StartAsync();
        public void Stop();
        public void Pause();
        public void Resume();
    }
}
