﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McMDK.Data
{
    /// <summary>
    /// McMDKで作成される、Modごとのプロジェクト
    /// </summary>
    [Serializable]
    public class Project
    {
        public string Name { set; get; }

        public string MCVersion { set; get; }

        public string ForgeVersion { set; get; }

        public string MCPVersion { set; get; }

        public List<Mod> Mod { set; get; }
    }
}
