// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Numerics;
using static JoltPhysicsSharp.JoltApi;

namespace JoltPhysicsSharp;

public sealed class CapsuleShapeSettings : ConvexShapeSettings
{
    public unsafe CapsuleShapeSettings(float halfHeightOfCylinder, float radius)
        : base(JPH_CapsuleShapeSettings_Create(halfHeightOfCylinder, radius))
    {
    }

    /// <summary>
    /// Finalizes an instance of the <see cref="CapsuleShapeSettings" /> class.
    /// </summary>
    ~CapsuleShapeSettings() => Dispose(isDisposing: false);
}

public sealed class CapsuleShape : ConvexShape
{
    public CapsuleShape(float halfHeightOfCylinder, float radius)
        : base(JPH_CapsuleShape_Create(halfHeightOfCylinder, radius))
    {
    }

    /// <summary>
    /// Finalizes an instance of the <see cref="CapsuleShape" /> class.
    /// </summary>
    ~CapsuleShape() => Dispose(isDisposing: false);

    public float Radius => JPH_CapsuleShape_GetRadius(Handle);
    public float HalfHeightOfCylinder => JPH_CapsuleShape_GetHalfHeightOfCylinder(Handle);
}
