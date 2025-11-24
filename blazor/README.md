# Heroicons for Blazor

A Blazor component wrapper for [Heroicons](https://github.com/tailwindlabs/heroicons), the beautiful hand-crafted SVG icons by the makers of Tailwind CSS.

This project is a fork that provides Blazor components for all Heroicons, making them easy to use in Blazor applications. All icons and designs are created by the original Heroicons team at Tailwind Labs.

## Installation

Install the package from NuGet:

```bash
dotnet add package heroicons
```

## Usage

### Basic Usage

Import the namespace in your `_Imports.razor`:

```razor
@using heroicons
```

Then use the HeroIcon component in your Blazor pages:

```razor
<HeroIcon Type="IconType.AcademicCap" Style="IconStyle.Outline" Size="IconSize.Regular" />
```

### Icon Styles

Icons are available in two styles:
- **Outline** - 24x24 outline icons (only available in Regular size)
- **Solid** - Available in all sizes (16x16, 20x20, and 24x24)

### Icon Sizes

Available sizes:
- `IconSize.Micro` - 16x16 (solid only)
- `IconSize.Mini` - 20x20 (solid only)
- `IconSize.Regular` - 24x24 (outline and solid)

### Examples

```razor
<!-- 24x24 outline icon -->
<HeroIcon Type="IconType.Bell" Style="IconStyle.Outline" Size="IconSize.Regular" />

<!-- 20x20 solid icon -->
<HeroIcon Type="IconType.Heart" Style="IconStyle.Solid" Size="IconSize.Mini" />

<!-- 16x16 solid icon with custom CSS classes -->
<HeroIcon Type="IconType.Star" Style="IconStyle.Solid" Size="IconSize.Micro" class="text-yellow-500" />

<!-- With additional attributes -->
<HeroIcon Type="IconType.ArrowRight" 
          Style="IconStyle.Solid" 
          Size="IconSize.Regular" 
          class="text-blue-500 hover:text-blue-700" 
          @onclick="HandleClick" />
```

### Direct Component Usage

You can also use icon components directly:

```razor
@using heroicons.Regular.Outline

<BellIcon class="w-6 h-6 text-gray-500" />
```

```razor
@using heroicons.Mini.Solid

<HeartIcon class="w-5 h-5 text-red-500" />
```

```razor
@using heroicons.Micro.Solid

<StarIcon class="w-4 h-4 text-yellow-500" />
```

### Styling

Icons are preconfigured to be styled by setting the `color` CSS property, either manually or using utility classes like `text-gray-500` in a framework like Tailwind CSS.

```razor
<!-- Using Tailwind CSS -->
<HeroIcon Type="IconType.CheckCircle" 
          Style="IconStyle.Solid" 
          Size="IconSize.Regular" 
          class="text-green-500" />

<!-- Using inline styles -->
<HeroIcon Type="IconType.ExclamationTriangle" 
          Style="IconStyle.Outline" 
          Size="IconSize.Regular" 
          style="color: #f59e0b;" />
```

## Available Icons

The `IconType` enum includes all available icons. Some examples:
- `IconType.AcademicCap`
- `IconType.AdjustmentsHorizontal`
- `IconType.AdjustmentsVertical`
- `IconType.ArchiveBox`
- `IconType.ArrowDown`
- `IconType.ArrowLeft`
- `IconType.ArrowRight`
- `IconType.ArrowUp`
- `IconType.Bell`
- `IconType.Calendar`
- `IconType.Camera`
- `IconType.ChatBubbleLeft`
- `IconType.Check`
- `IconType.ChevronDown`
- `IconType.ChevronLeft`
- `IconType.ChevronRight`
- `IconType.ChevronUp`
- `IconType.Clock`
- `IconType.Cloud`
- `IconType.Cog`
- `IconType.CreditCard`
- `IconType.Document`
- `IconType.Download`
- `IconType.Envelope`
- `IconType.ExclamationCircle`
- `IconType.ExclamationTriangle`
- `IconType.Eye`
- `IconType.Filter`
- `IconType.Fire`
- `IconType.Folder`
- `IconType.Globe`
- `IconType.Heart`
- `IconType.Home`
- `IconType.InformationCircle`
- `IconType.Key`
- `IconType.LightBulb`
- `IconType.Link`
- `IconType.LockClosed`
- `IconType.MagnifyingGlass`
- `IconType.Map`
- `IconType.Menu`
- `IconType.Microphone`
- `IconType.Moon`
- `IconType.PaperAirplane`
- `IconType.PaperClip`
- `IconType.Pencil`
- `IconType.Phone`
- `IconType.Photo`
- `IconType.Plus`
- `IconType.Printer`
- `IconType.QuestionMarkCircle`
- `IconType.Save`
- `IconType.Search`
- `IconType.Settings`
- `IconType.Share`
- `IconType.ShoppingCart`
- `IconType.Star`
- `IconType.Sun`
- `IconType.Tag`
- `IconType.Trash`
- `IconType.User`
- `IconType.UserGroup`
- `IconType.VideoCamera`
- `IconType.Wifi`
- `IconType.XMark`
- And many more...

The full list of available icons can be found at [heroicons.com](https://heroicons.com).

## Requirements

- .NET 10.0 or later
- Blazor WebAssembly or Blazor Server

## License

This library is MIT licensed.

## Credits

All icon designs are created by the [Heroicons](https://heroicons.com) team at [Tailwind Labs](https://tailwindcss.com).

This Blazor wrapper is an unofficial port and is not affiliated with Tailwind Labs.