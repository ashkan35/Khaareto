# Product imagery

`ImageSlot` renders a styled placeholder until the matching file exists here,
so the page is complete either way. Drop the PNGs exported from the
"Khaareto Homepage" design project into this folder to light them up:

| File          | Where it shows                          |
|---------------|-----------------------------------------|
| `kh-hero.png` | Hero panel (square, 1:1)                |
| `kh-p1.png`   | خار فنری (سگمنت) — Circlip              |
| `kh-p2.png`   | خار موازی (تخت) — Parallel Key          |
| `kh-p3.png`   | خار هلالی — Woodruff Key                |
| `kh-p4.png`   | پین استوانه‌ای — Dowel Pin              |
| `kh-p5.png`   | رول‌پین (شکافدار) — Slotted Spring Pin  |
| `kh-p6.png`   | پین چنگالی — Clevis Pin                 |
| `kh-p7.png`   | پین چنگالی استیل — Clevis Pin, Stainless|
| `kh-p8.png`   | خار ضامن‌دار — Linch Pin                |

Card slots are 176 px tall and cropped with `object-fit: cover`; roughly 4:3
landscape crops work best. The file names come from
`ProductCategory.ImagePath` (`products/{Id}.png`) in
`Khaareto.Client/Data/ProductCategory.cs` — change the `Id` there if you
rename a file.
