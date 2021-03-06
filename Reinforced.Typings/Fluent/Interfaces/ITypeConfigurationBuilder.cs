﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Reinforced.Typings.Attributes;

namespace Reinforced.Typings.Fluent.Interfaces
{
    /// <summary>
    ///     Technical interface for type (class/interface) configuration builder
    /// </summary>
    public interface ITypeConfigurationBuilder : IReferenceConfigurationBuilder
    {
        /// <summary>
        ///     Configurations for method parameters
        /// </summary>
        Dictionary<ParameterInfo, IExportConfiguration<TsParameterAttribute>> ParametersConfiguration { get; }

        /// <summary>
        ///     Configurations for type members
        /// </summary>
        Dictionary<MemberInfo, IExportConfiguration<TsAttributeBase>> MembersConfiguration { get; }

        /// <summary>
        ///     Type is being configured
        /// </summary>
        Type Type { get; }
    }
}