﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class DateTimePicker : Control
    {
        #region Constructor
        static DateTimePicker()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DateTimePicker), new FrameworkPropertyMetadata(typeof(DateTimePicker)));
        }

        public DateTimePicker()
        {
            Loaded += delegate
            {
                UpdateText();
            };
        }
        #endregion

        #region Event
        public static readonly RoutedEvent SelectedDateTimeChangedEvent = EventManager.RegisterRoutedEvent("SelectedDateTimeChanged", RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<DateTime>), typeof(DateTimePicker));
        public event RoutedPropertyChangedEventHandler<DateTime> SelectedDateTimeChanged
        {
            add { AddHandler(SelectedDateTimeChangedEvent, value); }
            remove { RemoveHandler(SelectedDateTimeChangedEvent, value); }
        }
        void RaiseSelectedDateTimeChanged(DateTime oldValue, DateTime newValue)
        {
            var arg = new RoutedPropertyChangedEventArgs<DateTime>(oldValue, newValue, SelectedDateTimeChangedEvent);
            RaiseEvent(arg);
        }
        
        #endregion

        #region Property
        public DateTimePickerMode DateTimePickerMode
        {
            get { return (DateTimePickerMode)GetValue(DateTimePickerModeProperty); }
            set { SetValue(DateTimePickerModeProperty, value); }
        }

        public static readonly DependencyProperty DateTimePickerModeProperty =
            DependencyProperty.Register("DateTimePickerMode", typeof(DateTimePickerMode), typeof(DateTimePicker), new PropertyMetadata(DateTimePickerMode.Date, OnDateTimePickerModeChanged));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(DateTimePicker));


        public Color ShadowColor
        {
            get { return (Color)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            DependencyProperty.Register("ShadowColor", typeof(Color), typeof(DateTimePicker));

        public Brush ThemeBrush
        {
            get { return (Brush)GetValue(ThemeBrushProperty); }
            set { SetValue(ThemeBrushProperty, value); }
        }

        public static readonly DependencyProperty ThemeBrushProperty =
            DependencyProperty.Register("ThemeBrush", typeof(Brush), typeof(DateTimePicker));


        public DateTime SelectedDateTime
        {
            get { return (DateTime)GetValue(SelectedDateTimeProperty); }
            set { SetValue(SelectedDateTimeProperty, value); }
        }

        public static readonly DependencyProperty SelectedDateTimeProperty =
            DependencyProperty.Register("SelectedDateTime", typeof(DateTime), typeof(DateTimePicker), new PropertyMetadata(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0), OnSelectedDateSelectedDateTimeChanged));

        public DateTime? MaxDate
        {
            get { return (DateTime?)GetValue(MaxDateProperty); }
            set { SetValue(MaxDateProperty, value); }
        }

        public static readonly DependencyProperty MaxDateProperty =
            DependencyProperty.Register("MaxDate", typeof(DateTime?), typeof(DateTimePicker));

        public DateTime? MinDate
        {
            get { return (DateTime?)GetValue(MinDateProperty); }
            set { SetValue(MinDateProperty, value); }
        }

        public static readonly DependencyProperty MinDateProperty =
            DependencyProperty.Register("MinDate", typeof(DateTime?), typeof(DateTimePicker));

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(DateTimePicker));

        public object Icon
        {
            get { return (object)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(object), typeof(DateTimePicker));

        public bool IsSundayFirst
        {
            get { return (bool)GetValue(IsSundayFirstProperty); }
            set { SetValue(IsSundayFirstProperty, value); }
        }

        public static readonly DependencyProperty IsSundayFirstProperty =
            DependencyProperty.Register("IsSundayFirst", typeof(bool), typeof(DateTimePicker), new PropertyMetadata(true));
        #endregion

        #region Event Handler
        private static void OnSelectedDateSelectedDateTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var picker = d as DateTimePicker;
            picker.UpdateText();
            picker.RaiseSelectedDateTimeChanged((DateTime)e.NewValue, (DateTime)e.OldValue);
        }

        private static void OnDateTimePickerModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var picker = d as DateTimePicker;
            picker.UpdateText();
        }
        #endregion

        #region Function
        private void UpdateText()
        {
            switch (DateTimePickerMode)
            {
                case DateTimePickerMode.DateTime:
                    Text = SelectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                    break;
                case DateTimePickerMode.Date:
                    Text = SelectedDateTime.ToString("yyyy-MM-dd");
                    break;
                case DateTimePickerMode.Time:
                    Text = SelectedDateTime.ToString("HH:mm:ss");
                    break;
            }
        }
        #endregion
    }
}
