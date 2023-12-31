﻿using System;
using System.Collections.Generic;

namespace SilkTouchX.Naming;

/// <summary>
/// Represents a name trimmer.
/// </summary>
public interface INameTrimmer
{
    /// <summary>
    /// Gets the name trimmer version i.e. the Silk.NET version that introduced this name trimming method. This is so
    /// new bindings released with or after this version don't have to have older trimming methods executed (the name
    /// version can be specified in the mod configuration)
    /// </summary>
    Version Version { get; }

    /// <summary>
    /// Trims prefixes from the given constituent names within the given container.
    /// </summary>
    /// <param name="container">
    /// The name of the container. e.g. if we're trimming enum members, this would be the enum type name.
    /// </param>
    /// <param name="hint">A prefix hint. Generally this is a global method prefix or what have you.</param>
    /// <param name="names">The names within the container.</param>
    /// <param name="prefixOverrides">The prefix overrides.</param>
    void Trim(
        string? container,
        string? hint,
        Dictionary<string, (string Primary, List<string>? Secondary)>? names,
        Dictionary<string, string>? prefixOverrides
    );
}
