public record CultureWithName
{
    public string Name { get; init; } = default!;
    public string Culture { get; init; } = default!;

    public CultureWithName(string name, string culture)
    {
        Name = name;
        Culture = culture;
    }
}