// NAnt - A .NET build tool
// Copyright (C) 2001 Gerry Shaw
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//
// Gerry Shaw (gerry_shaw@yahoo.com)
// Ian MacLean (ian_maclean@another.com)

using System;
using System.IO;
using SourceForge.NAnt.Attributes;
using System.Globalization;

namespace SourceForge.NAnt.Tasks {


    /// <summary>Creates a directory and any non-existent parent directories if necessary.</summary>
    /// <example>
    ///     <para>Create the directory &quot;build&quot;.</para>
    ///     <code><![CDATA[<mkdir dir="build"/>]]></code>
    ///     <para>Create the directory tree &quot;one/two/three&quot;.</para>
    ///     <code><![CDATA[<mkdir dir="one/two/three"/>]]></code>
    /// </example>
    [TaskName("mkdir")]
    public class MkDirTask : Task {

        string _dir = null; // the directory to create
        
        /// <summary>The directory to create.</summary>
        [TaskAttribute("dir", Required=true)]
        public string Dir { get { return _dir; } set { _dir = value; } }

        protected override void ExecuteTask() {
            try {
                string directory = Project.GetFullPath(_dir);
                if (!Directory.Exists(directory)) {
                    Log.WriteLine(LogPrefix + "Creating directory {0}", directory);
                    DirectoryInfo result = Directory.CreateDirectory(directory);
                    if (result == null) {
                        string msg = String.Format(CultureInfo.InvariantCulture, "Unknown error creating directory '{0}'", directory);
                        throw new BuildException(msg, Location);
                    }
                }
            } catch (Exception e) {
                throw new BuildException(LogPrefix + "Failed", Location, e);
            }
        }
    }
}
