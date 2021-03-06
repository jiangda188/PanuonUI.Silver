﻿using System.Windows;

namespace Panuon.UI.Silver
{
    public class ExpanderHelper
    {
        #region ExpanderStyle
        public static ExpanderStyle GetExpanderStyle(DependencyObject obj)
        {
            return (ExpanderStyle)obj.GetValue(ExpanderStyleProperty);
        }

        public static void SetExpanderStyle(DependencyObject obj, ExpanderStyle value)
        {
            obj.SetValue(ExpanderStyleProperty, value);
        }

        public static readonly DependencyProperty ExpanderStyleProperty =
            DependencyProperty.RegisterAttached("ExpanderStyle", typeof(ExpanderStyle), typeof(ExpanderHelper), new PropertyMetadata(ExpanderStyle.Standard));
        #endregion

        #region Icon
        public static object GetIcon(DependencyObject obj)
        {
            return (object)obj.GetValue(IconProperty);
        }

        public static void SetIcon(DependencyObject obj, object value)
        {
            obj.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(ExpanderHelper));
        #endregion

        #region HeaderHeight
        public static double GetHeaderHeight(DependencyObject obj)
        {
            return (double)obj.GetValue(HeaderHeightProperty);
        }

        public static void SetHeaderHeight(DependencyObject obj, double value)
        {
            obj.SetValue(HeaderHeightProperty, value);
        }

        public static readonly DependencyProperty HeaderHeightProperty =
            DependencyProperty.RegisterAttached("HeaderHeight", typeof(double), typeof(ExpanderHelper));


        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ExpanderHelper));



        #endregion
    }
}
