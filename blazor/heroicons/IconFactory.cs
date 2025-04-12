namespace heroicons;

public static class IconFactory
{
    internal static IconType DefaultIconType = IconType.QuestionMarkCircle;
    internal static IconStyle DefaultIconStyle = IconStyle.Solid;
    internal static IconSize DefaultIconSize = IconSize.Regular;

    public static Type GetIconType(IconType type, IconStyle style, IconSize size)
    {
        var typeName = $"{typeof(Icon).Namespace}.{size}.{style}.{type}Icon";
        var iconType = Type.GetType(typeName, false, true);
        if (iconType != null)
            return iconType;

        return size switch
        {
            IconSize.Regular => style == IconStyle.Solid
                ? typeof(Regular.Solid.QuestionMarkCircleIcon)
                : typeof(Regular.Outline.QuestionMarkCircleIcon),
            IconSize.Mini => typeof(Mini.Solid.QuestionMarkCircleIcon),
            IconSize.Micro => typeof(Micro.Solid.QuestionMarkCircleIcon),
            _ => throw new ArgumentOutOfRangeException(nameof(size), size, null)
        };
    }
}