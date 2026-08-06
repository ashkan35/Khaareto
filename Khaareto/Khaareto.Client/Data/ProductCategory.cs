namespace Khaareto.Client.Data;

/// <summary>One product family shown in the homepage category grid.</summary>
/// <param name="Id">Slug, also used as the image file name.</param>
/// <param name="Name">Persian display name.</param>
/// <param name="EnglishName">English/technical name, rendered LTR.</param>
/// <param name="Standard">DIN / ISO standard the sizes follow.</param>
/// <param name="Description">Short Persian blurb.</param>
public sealed record ProductCategory(
    string Id,
    string Name,
    string EnglishName,
    string Standard,
    string Description)
{
    /// <summary>Path of the product photo under <c>wwwroot</c>.</summary>
    public string ImagePath => $"products/{Id}.png";
}

/// <summary>
/// The homepage is a single static landing page, so the catalogue lives in code
/// rather than behind a data store.
/// </summary>
public static class ProductCatalog
{
    public static readonly IReadOnlyList<ProductCategory> Categories =
    [
        new("kh-p1", "خار فنری (سگمنت)", "Circlip / Retaining Ring", "DIN 471 / 472",
            "بیرونی برای شفت و داخلی برای بوش؛ قطر ۳ تا ۱۰۰ میلی‌متر، فولاد فنری."),
        new("kh-p2", "خار موازی (تخت)", "Parallel Key", "DIN 6885",
            "انتقال گشتاور بین شفت و پولی؛ برش در طول دلخواه."),
        new("kh-p3", "خار هلالی", "Woodruff Key", "DIN 6888",
            "نیم‌دایره‌ای، مناسب شفت‌های مخروطی و جای‌خار فرزکاری‌شده."),
        new("kh-p4", "پین استوانه‌ای", "Dowel Pin", "ISO 2338",
            "موقعیت‌دهی دقیق قالب و فیکسچر؛ تلرانس m6 سنگ‌زنی‌شده."),
        new("kh-p5", "رول‌پین (شکافدار)", "Slotted Spring Pin", "ISO 8752",
            "پین فنری جدارِ شکافدار؛ نصب پرسی بدون نیاز به مهره."),
        new("kh-p6", "پین چنگالی", "Clevis Pin", "DIN 1444",
            "سرتخت با سوراخ اسپلیت‌پین؛ مخصوص اتصال لینک و سیلندر."),
        new("kh-p7", "پین چنگالی استیل", "Clevis Pin, Stainless", "ISO 2341",
            "استیل ۳۰۴ ضدزنگ؛ برای محیط مرطوب و صنایع غذایی و دریایی."),
        new("kh-p8", "خار ضامن‌دار (لینچ‌پین)", "Linch Pin", "DIN 11023",
            "قفل فنری سریع برای ادوات کشاورزی و اتصالات باز و بسته‌شونده."),
    ];
}
