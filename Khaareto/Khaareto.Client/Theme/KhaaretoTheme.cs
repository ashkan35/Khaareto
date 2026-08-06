using MudBlazor;

namespace Khaareto.Client.Theme;

/// <summary>
/// Dark "industrial" palette taken from the Khaareto homepage design source.
/// The site is dark-only, so only <see cref="MudTheme.PaletteDark"/> is filled in.
/// </summary>
public static class KhaaretoTheme
{
    public const string Background = "#0d1014";
    public const string BackgroundAlt = "#0f1318";
    public const string Surface = "#12171d";
    public const string SurfaceAlt = "#141a20";
    public const string Border = "#1e242c";
    public const string BorderStrong = "#2a333d";
    public const string Text = "#e8ecf1";
    public const string TextMuted = "#99a4b1";
    public const string TextDim = "#6d7887";
    public const string Accent = "#f0b323";
    public const string AccentHover = "#ffd166";
    public const string OnAccent = "#14181d";

    public static readonly MudTheme Instance = new()
    {
        PaletteDark = new PaletteDark
        {
            Primary = Accent,
            PrimaryLighten = AccentHover,
            PrimaryDarken = "#c8930f",
            PrimaryContrastText = OnAccent,
            Secondary = TextMuted,
            SecondaryContrastText = Background,
            Tertiary = BorderStrong,

            Black = "#000000",
            White = Text,

            Background = Background,
            BackgroundGray = BackgroundAlt,
            Surface = Surface,
            AppbarBackground = "rgba(13,16,20,.9)",
            AppbarText = Text,
            DrawerBackground = Surface,
            DrawerText = Text,
            DrawerIcon = TextMuted,

            TextPrimary = Text,
            TextSecondary = TextMuted,
            TextDisabled = TextDim,

            ActionDefault = TextMuted,
            ActionDisabled = "#4a5561",
            ActionDisabledBackground = "#1a2029",

            Divider = Border,
            DividerLight = "#161b22",
            LinesDefault = Border,
            LinesInputs = BorderStrong,
            TableLines = Border,

            Info = "#5aa9e6",
            Success = "#3fbf7f",
            Warning = Accent,
            Error = "#e05252",

            OverlayDark = "rgba(6,8,10,0.75)",
            HoverOpacity = 0.08,
        },
        Typography = new Typography
        {
            Default = new DefaultTypography
            {
                FontFamily = ["Vazirmatn", "system-ui", "sans-serif"],
                FontSize = "15px",
                LineHeight = "1.9",
            },
            H1 = new H1Typography
            {
                FontFamily = ["Vazirmatn", "system-ui", "sans-serif"],
                FontSize = "60px",
                FontWeight = "900",
                LineHeight = "1.22",
                LetterSpacing = "-1.2px",
            },
            H2 = new H2Typography
            {
                FontFamily = ["Vazirmatn", "system-ui", "sans-serif"],
                FontSize = "38px",
                FontWeight = "800",
                LineHeight = "1.3",
                LetterSpacing = "-.6px",
            },
            H3 = new H3Typography
            {
                FontFamily = ["Vazirmatn", "system-ui", "sans-serif"],
                FontSize = "25px",
                FontWeight = "900",
                LineHeight = "1.4",
                LetterSpacing = "-.5px",
            },
            H5 = new H5Typography
            {
                FontFamily = ["Vazirmatn", "system-ui", "sans-serif"],
                FontSize = "18px",
                FontWeight = "700",
                LineHeight = "1.5",
            },
            H6 = new H6Typography
            {
                FontFamily = ["Vazirmatn", "system-ui", "sans-serif"],
                FontSize = "17px",
                FontWeight = "700",
                LineHeight = "1.5",
            },
            Body1 = new Body1Typography
            {
                FontFamily = ["Vazirmatn", "system-ui", "sans-serif"],
                FontSize = "16px",
                LineHeight = "2",
            },
            Body2 = new Body2Typography
            {
                FontFamily = ["Vazirmatn", "system-ui", "sans-serif"],
                FontSize = "14px",
                LineHeight = "1.95",
            },
            Button = new ButtonTypography
            {
                FontFamily = ["Vazirmatn", "system-ui", "sans-serif"],
                FontSize = "15px",
                FontWeight = "700",
                TextTransform = "none",
            },
            Caption = new CaptionTypography
            {
                FontFamily = ["Vazirmatn", "system-ui", "sans-serif"],
                FontSize = "13px",
                LineHeight = "1.8",
            },
        },
        LayoutProperties = new LayoutProperties
        {
            DefaultBorderRadius = "10px",
        },
    };
}
