using Content.Client.Stylesheets.Redux.Sheetlets;
using Robust.Client.UserInterface;

namespace Content.Client.Stylesheets.Redux.InterfaceSheetlets;

public sealed class InterfaceButtonSheetlet : ButtonSheetlet
{
    public override StyleRule[] GetRules(PalettedStylesheet sheet, object config)
    {
        var cfg = (IButtonConfig) sheet;
        var rules = new List<StyleRule>(base.GetRules(sheet, config));

        MakeButtonRules(cfg, rules, cfg.ButtonPalette, null);
        MakeButtonRules(cfg, rules, cfg.PositiveButtonPalette, StyleClasses.Positive);
        MakeButtonRules(cfg, rules, cfg.NegativeButtonPalette, StyleClasses.Negative);

        return rules.ToArray();
    }
}
