﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.SDK.UX.Interactable.Themes
{
    /// <summary>
    /// Theme property value types used for converting theme values back and forth from serialized objects
    /// </summary>
    public enum InteractableThemePropertyValueTypes {
        Float,
        Int,
        Color,
        ShaderFloat,
        shaderRange,
        Vector2,
        Vector3,
        Vector4,
        Quaternion,
        Texture,
        Material,
        AudioClip,
        Animaiton,
        GameObject,
        String,
        Bool,
        AnimatorTrigger
    }
}
