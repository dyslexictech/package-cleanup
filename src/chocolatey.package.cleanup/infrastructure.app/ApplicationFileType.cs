// Copyright � 2015 - Present RealDimensions Software, LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// 
// You may obtain a copy of the License at
// 
// 	http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace chocolatey.package.cleanup.infrastructure.app
{
    /// <summary>
    ///   The file type of the file being upload
    /// </summary>
    public enum ApplicationFileType
    {
        /// <summary>
        ///   The path is contained in the fileName passed, just needs to be adjusted
        /// </summary>
        Default,

        /// <summary>
        ///   Documents (PDFs for the system)
        /// </summary>
        ApplicationFile,
    }
}
