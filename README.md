# خارتو | Khaareto

Homepage for **Khaareto** (خارتو), a specialist supplier of industrial retaining
rings, keys and pins — circlips, parallel and Woodruff keys, dowel pins, spring
pins, clevis pins and linch pins.

A single-page, right-to-left Persian landing page built with **Blazor** and
**MudBlazor**, implemented from a Claude Design source file.

## Stack

- .NET 10 — Blazor Web App (`InteractiveAuto` render mode)
- [MudBlazor](https://mudblazor.com/) 9.8
- Vazirmatn (Google Fonts) for Persian typography

## Running

```bash
dotnet run --project Khaareto/Khaareto/Khaareto.csproj
```

Then open <http://localhost:5063>.

## Layout

```
Khaareto/
├── Khaareto/                     # ASP.NET Core host
│   ├── Components/App.razor      # HTML shell — lang="fa" dir="rtl", fonts, MudBlazor assets
│   └── wwwroot/
│       ├── app.css               # Design tokens, base styles, keyframes
│       ├── khaareto.css          # Page styling
│       └── products/             # Product photography (see products/README.md)
└── Khaareto.Client/              # Razor components
    ├── Components/ImageSlot.razor    # Photo with a designed placeholder fallback
    ├── Data/ProductCategory.cs       # The eight product families, as static data
    ├── Layout/MainLayout.razor       # MudRTLProvider + MudBlazor providers
    ├── Pages/Home.razor              # The page
    └── Theme/KhaaretoTheme.cs        # Dark palette and typography
```

### Notes

The site is dark-only and right-to-left throughout. `MudRTLProvider` handles
direction; only `MudTheme.PaletteDark` is populated.

`khaareto.css` is deliberately a global stylesheet rather than a scoped
`.razor.css`: most of its rules target elements rendered by MudBlazor
components, which never receive the caller's CSS-isolation scope attribute.

Product photography lives in
[`Khaareto/Khaareto/wwwroot/products/`](Khaareto/Khaareto/wwwroot/products/).
`ImageSlot` falls back to a styled placeholder whenever a file is missing, so
the page stays presentable while imagery is still being shot — see that
folder's `README.md` for the filename map.

This is a launch-announcement page; the catalogue lives in code rather than
behind a data store, and the "notify me" form validates input and confirms
locally without persisting anything.
