﻿namespace Content.Client.Stylesheets.Redux;

public static class StyleClasses
{
    public const string PrimaryColor = "color-primary";
    public const string SecondaryColor = "color-secondary";
    public const string PositiveColor = "color-positive";
    public const string NegativeColor = "color-negative";
    public const string HighlightColor = "color-highlight";

    public static string GetColorClass(string styleclass, uint index)
    {
        return $"{styleclass}-{index}";
    }

    public const string LargeLabel = "font-large";
    public const string SmallLabel = "font-small";
    public const string Negative = "negative";
    public const string Positive = "positive";
    public const string BorderedWindowPanel = "BorderedWindowPanel";
    public const string AlertWindowHeader = "windowHeaderAlert";
    public const string WindowContentsContainer = "WindowContentsContainer";

    public const string HighDivider = "HighDivider";
    public const string LowDivider = "LowDivider";

    public const string LabelHeading = "LabelHeading";
    public const string LabelSubtext = "LabelSubText";
    public const string Italic = "Italic";

    public const string BackgroundPanel = "AngleRect";
    public const string BackgroundPanelOpenLeft = "BackgroundOpenLeft";
    public const string BackgroundPanelOpenRight = "BackgroundOpenRight";

    public const string ButtonOpenRight = "OpenRight";
    public const string ButtonOpenLeft = "OpenLeft";
    public const string ButtonOpenBoth = "OpenBoth";
    public const string ButtonSquare = "ButtonSquare";
    public const string ButtonSmall = "ButtonSmall";

    public const string StyleClassSliderRed = "Red";
    public const string StyleClassSliderGreen = "Green";
    public const string StyleClassSliderBlue = "Blue";
    public const string StyleClassSliderWhite = "White";
    public const string StyleClassItemStatus = "ItemStatus";
    public const string StyleClassItemStatusNotHeld = "ItemStatusNotHeld";
    public const string ChatPanel = "ChatPanel";
    public const string ChatLineEdit = "chatLineEdit";
    public const string StyleClassLabelKeyText = "LabelKeyText";

    public const string TooltipPanel = "tooltipPanel";
    public const string TooltipTitle = "tooltipTitle";
    public const string TooltipDesc = "tooltipDesc";
}
