using System.Globalization;
using System.Text;

var iconTypes = new HashSet<string>();
await GenerateIconComponentsAsync(iconTypes, @"..\\..\\..\\..\\..\\optimized\\16\\solid", @"..\\..\\..\\..\\..\\blazor\\heroicons\\16\\solid\\");
await GenerateIconComponentsAsync(iconTypes, @"..\\..\\..\\..\\..\\optimized\\20\\solid", @"..\\..\\..\\..\\..\\blazor\\heroicons\\20\\solid\\");
await GenerateIconComponentsAsync(iconTypes, @"..\\..\\..\\..\\..\\optimized\\24\\solid", @"..\\..\\..\\..\\..\\blazor\\heroicons\\24\\solid\\");
await GenerateIconComponentsAsync(iconTypes, @"..\\..\\..\\..\\..\\optimized\\24\\outline", @"..\\..\\..\\..\\..\\blazor\\heroicons\\24\\outline\\");
await GenerateIconTypes(iconTypes);
return;
async Task GenerateIconComponentsAsync(ISet<string> typeSet, string sourceDir, string outputDir)
{
    foreach (var filePath in Directory.EnumerateFiles(sourceDir))
    {
        var filename = Path.GetFileNameWithoutExtension(filePath);
        var iconType = ConvertToTitleCase(filename);
        typeSet.Add(iconType);

        Console.WriteLine(iconType);

        var size = sourceDir.Contains("16") ? "Micro" : sourceDir.Contains("20") ? "Mini" : "Regular";
        var style = sourceDir.Contains("solid") ? "Solid" : "Outline";

        var sb = new StringBuilder();
        sb.AppendLine($"@namespace heroicons.{size}.{style}");
        sb.AppendLine("@inherits Icon");

        var svg = await File.ReadAllTextAsync(filePath);
        svg = svg.Replace("<svg xmlns=\"http://www.w3.org/2000/svg\"", "<svg xmlns=\"http://www.w3.org/2000/svg\" @attributes=\"@AdditionalAttributes\"");
        sb.AppendLine(svg);

        var component = sb.ToString();
        var componentName = $"{iconType}Icon.razor";
        await File.WriteAllTextAsync(Path.Combine(outputDir, componentName), component);
    }
}

async Task GenerateIconTypes(HashSet<string> hashSet)
{
    var sb = new StringBuilder();
    sb.AppendLine("namespace heroicons;");
    sb.AppendLine();
    sb.AppendLine("public enum IconType");
    sb.AppendLine("{");
    foreach (var iconType in hashSet)
    {
        sb.Append("    ");
        sb.Append(iconType);
        sb.Append(',');
        sb.AppendLine();
    }

    sb.AppendLine("}");
    await File.WriteAllTextAsync(@"..\\..\\..\\..\\..\\blazor\\heroicons\\IconType.cs", sb.ToString());
}

static string ConvertToTitleCase(string input)
{
    var textInfo = new CultureInfo("en-US", false).TextInfo;
    var replaced = input.Replace('-', ' ');
    var titleCased = textInfo.ToTitleCase(replaced);
    return titleCased.Replace(" ", "");
}