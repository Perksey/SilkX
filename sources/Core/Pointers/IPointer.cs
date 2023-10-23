namespace Silk.NET.Core;

/// <summary>
/// Interface for all Pointer Types
/// </summary>
public unsafe interface IPointer
{
    internal void* Pointer { get; }
    internal int Depth { get; }
}

/// <summary>
/// Interface for Pointer types that point to const variables
/// </summary>
public unsafe interface IPointerToConst : IPointer { }

/// <summary>
/// Interface for Pointer types that point to mutable variables
/// </summary>
public unsafe interface IPointerToMutable : IPointer { }
