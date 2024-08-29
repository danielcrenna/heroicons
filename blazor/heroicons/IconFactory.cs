namespace heroicons;

public static class IconFactory
{
    public static IconType DefaultIconType = IconType.QuestionMarkCircle;
    public static Type DefaultIcon = typeof(Regular.Solid.QuestionMarkCircleIcon);

    public static Type GetIconType(IconType type, IconStyle style, IconSize size)
    {
        var typeName = $"{typeof(Icon).Namespace}.{size}.{style}.{type}Icon";
        var iconType = Type.GetType(typeName, false, true);
        return iconType ?? DefaultIcon;
    }
}