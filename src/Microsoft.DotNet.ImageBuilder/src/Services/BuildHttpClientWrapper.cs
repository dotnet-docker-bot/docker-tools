﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.Build.WebApi;
using Microsoft.VisualStudio.Services.WebApi;

namespace Microsoft.DotNet.ImageBuilder.Services
{
    internal class BuildHttpClientWrapper : IBuildHttpClient
    {
        private readonly BuildHttpClient inner;

        public BuildHttpClientWrapper(BuildHttpClient inner)
        {
            this.inner = inner ?? throw new ArgumentNullException(nameof(inner));
        }

        public void Dispose()
        {
            this.inner.Dispose();
        }

        public Task<IPagedList<Build>> GetBuildsAsync(Guid projectId, IEnumerable<int> definitions = null, BuildStatus? statusFilter = null)
        {
            return this.inner.GetBuildsAsync2(projectId, definitions: definitions, statusFilter: statusFilter);
        }

        public Task QueueBuildAsync(Build build)
        {
            return this.inner.QueueBuildAsync(build);
        }
    }
}
