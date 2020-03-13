﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Microsoft.DotNet.ImageBuilder.Models.Image
{
    public class RepoData
    {
        [JsonProperty(Required = Required.Always)]
        public string Repo { get; set; }

        public List<ImageData> Images { get; set; } = new List<ImageData>();
    }
}
