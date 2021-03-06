﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Panuon.UI.Silver
{
    #region MessageBoxStyle
    public enum MessageBoxStyle
    {
        Standard,
        Modern,
        //Poster
    }

    public enum MessageBoxIcon
    {
        None,
        Info,
        Success,
        Error,
    }

    public enum DefaultButton
    {
        None,
        YesOK,
        NoOrCancel,
        CancelOrNo,
    }
    #endregion

    #region ClickMode
    public enum ClickMode
    {
        Both,
        OnlyOne,
    }
    #endregion

    #region Button
    public enum ButtonStyle
    {
        Standard,
        Hollow,
        Outline,
        Link,
    }

    public enum ClickStyle
    {
        None,
        Sink,
    }
    #endregion

    #region RepeatButton
    public enum RepeatButtonStyle
    {
        Standard,
        Hollow,
        Outline,
        Link,
    }
    #endregion

    #region Loading
    public enum LoadingStyle
    {
        Standard,
        Ring,
        Wave,
        Ring2,
        Classic
    }
    #endregion

    #region TreeView
    public enum TreeViewStyle
    {
        Standard,
        Classic,
        Modern,
        Chain,
    }

    public enum SelectMode
    {
        Any,
        ChildOnly,
        Disabled
    }

    public enum ExpandMode
    {
        DoubleClick,
        SingleClick
    }

    public enum ExpandBehaviour
    {
        Any,
        OnlyOne,
    }
    #endregion

    #region Expander
    public enum ExpanderStyle
    {
        Standard,
        Classic,
    }
    #endregion

    #region CheckBox
    public enum CheckBoxStyle
    {
        Standard,
        Switch,
        Switch2,
        Button
    }
    #endregion

    #region RadioButton
    public enum RadioButtonStyle
    {
        Standard,
        Switch,
        Button
    }
    #endregion

    #region Calendar
    public enum CalendarMode
    {
        Date,
        YearMonth,
        Year,
    }
    #endregion

    #region Clock
    public enum ClockStyle
    {
        Standard,
        Dial,
    }
    #endregion

    #region Slider
    public enum SliderStyle
    {
        Standard,
        Classic,
        
    }
    #endregion

    #region ProgressBarStyle
    public enum ProgressBarStyle
    {
        Standard,
        Ring
    }
    #endregion

    #region DateTimePickerMode
    public enum DateTimePickerMode
    {
        DateTime,
        Date,
        Time,
    }
    #endregion

    #region TabControlStyle
    public enum TabControlStyle
    {
        Standard,
        Classic,
        Card,
    }
    #endregion

    #region ImageCuter
    public enum ImageType
    {
        Rectangle,
        Square,
    }
    #endregion

    #region NeonLabel
    public enum NeonLabelType
    {
        /// <summary>
        /// Fade out current background, and fade in next background.
        /// </summary>
        FadeBackground,
        /// <summary>
        /// Fade out current foreground, and fade in next foreground.
        /// </summary>
        FadeForeground,
        /// <summary>
        /// Fade out current content, and fade in next content.
        /// </summary>
        FadeNext,
        /// <summary>
        /// Slide out current content , and slide in next content.
        /// </summary>
        SlideNext,
        /// <summary>
        /// Scroll to end
        /// </summary>
        ScrollToEnd,
    }
    #endregion

    #region DropDown
    public enum DropDownPlacement
    {
        Bottom,
        RightBottom,
        LeftBottom
    }
    #endregion

    #region PopupPosition
    public enum PopupPosition
    {
        Bottom,
        Top,
        Center,
    }
    #endregion

    #region ColumnStyle
    public enum ColumnStyle
    {
        Standard,
        Hover
    }
    #endregion

    #region ItemsControl
    public enum ItemAnimation
    {
        None,
        Slide,
        Gradual,
        Fade,
    }
    #endregion

    #region PaginationStyle
    public enum PaginationStyle
    {
        Standard,
        Classic,
        Simple,
    }
    #endregion
}
