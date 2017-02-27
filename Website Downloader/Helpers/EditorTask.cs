﻿namespace WebsiteDownloader.Helpers
{
    using System;

    internal class EditorTask : TaskTemplate
    {
        public EditorTask(Helpers.OfflineFile file, Action<TaskTemplate> listener = null) : base(listener)
        {
            this.File = file;
        }

        internal OfflineFile File { get; }
    }
}