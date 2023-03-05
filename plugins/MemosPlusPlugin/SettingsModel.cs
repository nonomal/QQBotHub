﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using PluginCore.Models;

namespace MemosPlusPlugin
{
    public class SettingsModel : PluginSettingsModel
    {
        public MemosModel Memos { get; set; }

        public class MemosModel 
        {
            public string OpenId { get; set; }

            public string MemosSession { get; set; }
        }

        public GitHubModel GitHub { get; set; }

        public class GitHubModel
        {
            public string AccessToken { get; set; }

            public string RepoOwner { get; set; }

            public string RepoName { get; set; }

            public string RepoBranch { get; set; }

            public string RepoTargetDirPath { get; set; }
        }
    }
}
