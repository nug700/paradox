﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
using System;
using System.Globalization;
using System.Windows.Data;

namespace SiliconStudio.Presentation.ValueConverters
{
    /// <summary>
    /// An abstract implementation of <see cref="ValueConverterBase{T}"/> that does not support <see cref="ConvertBack"/>.
    /// Invoking <see cref="ConvertBack"/> on this value converter will throw a <see cref="NotSupportedException"/>.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="IValueConverter"/> being implemented.</typeparam>
    public abstract class OneWayValueConverter<T> : ValueConverterBase<T> where T : class, IValueConverter, new()
    {
        /// <inheritdoc/>
        public override sealed object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("ConvertBack is not supported with this ValueConverter.");
        }
    }
}
