// Copyright (c) Microsoft. All rights reserved. 
// Licensed under the MIT license. See LICENSE file in the project root for full license information. 

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Sarif;
using Microsoft.Sarif.Viewer.Models;

namespace Microsoft.Sarif.Viewer.Sarif
{
    static class ThreadFlowLocationExtensions
    {
        public static ThreadFlowLocationModel ToThreadFlowLocationModel(this ThreadFlowLocation threadFlowLocation, IDictionary<string, Uri> originalUriBaseIds)
        {
            var model = threadFlowLocation.Location != null
                ? threadFlowLocation.Location.ToThreadFlowLocationModel(originalUriBaseIds)
                : new ThreadFlowLocationModel();

            model.IsEssential = threadFlowLocation.Importance == ThreadFlowLocationImportance.Essential;

            return model;
        }
    }
}
