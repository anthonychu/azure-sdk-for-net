﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.ResourceManager.Core
{
    /// <summary>
    /// An attribute class indicating the constructor to use for initialization.
    /// </summary>
    [AttributeUsage(AttributeTargets.Constructor)]
    public class InitializationConstructorAttribute : Attribute
    {
        /// <summary>
        /// Instatiate a new InitializationConstructor attribute.
        /// </summary>
        public InitializationConstructorAttribute()
        {
        }
    }
}
