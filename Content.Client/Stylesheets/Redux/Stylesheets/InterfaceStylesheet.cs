using System.Linq;
using Content.Client.Stylesheets.Redux.Fonts;
using Content.Client.Stylesheets.Redux.InterfaceSheetlets;
using Robust.Client.ResourceManagement;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Shared.Utility;
using static Robust.Client.UserInterface.StylesheetHelpers;


namespace Content.Client.Stylesheets.Redux.Stylesheets;

[Virtual]
public partial class InterfaceStylesheet : PalettedStylesheet
{
    public override FontStack BaseFont { get; }

    public override Dictionary<Type, ResPath[]> Roots => new()
    {
        { typeof(TextureResource), new[] { new ResPath("/Textures/Interface/Nano") } }
    };

    private const int PrimaryFontSize = 12;
    private const int FontSizeStep = 2;

    private readonly List<(string?, int)> _commonFontSizes = new()
    {
        (null, PrimaryFontSize),
        (StyleClasses.SmallLabel, PrimaryFontSize - FontSizeStep),
        (StyleClasses.LargeLabel, PrimaryFontSize + FontSizeStep),
    };

    public InterfaceStylesheet(object config) : base(config)
    {
        BaseFont = new NotoFontStack(ResCache);
        var rules = new[]
        {
            // Base rules from the base stylesheet.
            BaseRules(),
            // Set up important rules that need to go first.
            GetRulesForFont(null, BaseFont, _commonFontSizes),
            // Set up our core rules.
            [
                // Declare the default font.
                Element().Prop(Label.StylePropertyFont, BaseFont.GetFont(PrimaryFontSize)),
            ],
            // Rules for common buttons.
            GetSheetletRules<InterfaceButtonSheetlet>(),
            // Rules for hover-over tooltips
            GetSheetletRules<InterfaceTooltipSheetlet>(),
            // Finally, load all the other sheetlets.
            GetAllSheetletRules<CommonSheetletAttribute>(),
        };

        Stylesheet = new Stylesheet(rules.SelectMany(x => x).ToArray());
    }
}
