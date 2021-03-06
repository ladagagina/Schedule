﻿using System;
using Editor.ViewModels.Windows;

namespace Editor.Converters
{
    public class ListsEditorTabToIntConverter : BaseConverter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (int) ((TabCategory) value);
        }

        public override object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (TabCategory) ((int) value);
        }
    }
}
