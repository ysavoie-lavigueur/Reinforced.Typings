﻿using Reinforced.Typings.Ast;

namespace Reinforced.Typings.Generators
{
    /// <summary>
    ///     TypeScript code generator interface
    /// </summary>
    /// <typeparam name="TElement"></typeparam>
    public interface ITsCodeGenerator<in TElement>
    {
        /// <summary>
        ///     Export settings
        /// </summary>
        ExportContext Context { get; set; }

        /// <summary>
        ///     Main code generator method. This method should write corresponding TypeScript code for element (1st argument) to
        ///     WriterWrapper (3rd argument) using TypeResolver if necessary
        /// </summary>
        /// <param name="element">Element code to be generated to output</param>
        /// <param name="resolver">Type resolver</param>
        RtNode Generate(TElement element, TypeResolver resolver);
    }
}