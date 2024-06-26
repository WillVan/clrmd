// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace Microsoft.Diagnostics.Runtime.Interfaces
{
    public interface IClrDelegate
    {
        bool HasMultipleTargets { get; }
        IClrValue Object { get; }

        IEnumerable<IClrDelegateTarget> EnumerateDelegateTargets();
        IClrDelegateTarget? GetDelegateTarget();
    }
}