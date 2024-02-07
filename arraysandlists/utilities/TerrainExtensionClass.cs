

public static class TerrainExtensionClass
{

    public static ConsoleColor GetColor(this Terrain terrain)
    {
        return terrain switch
        {
            Terrain.GRASS => ConsoleColor.Green,
            Terrain.SAND => ConsoleColor.Yellow,
            Terrain.WATER => ConsoleColor.Blue,
            _ => ConsoleColor.DarkGray,
        };
    }


    public static char GetChar(this Terrain terrain)
    {
        return terrain switch
        {
            Terrain.GRASS => '\u201c',
            Terrain.SAND => '\u25cb',
            Terrain.WATER => '\u2248',
            _ => '\u25cf',
        };
    }

}