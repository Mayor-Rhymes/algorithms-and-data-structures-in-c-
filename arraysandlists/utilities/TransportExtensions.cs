

public static class TransportExtensions {

    public static char GetChar(this Transport transport) {
        return transport switch {
            Transport.BUS => 'U',
            Transport.SUBWAY => 'S',
            Transport.BIKE => 'B',
            Transport.WALK => 'W',
            Transport.CAR => 'C',
            _ => throw new Exception("Unknown transport")
        };
    }


    public static ConsoleColor GetColor(this Transport transport){
        return transport switch {
            Transport.BUS => ConsoleColor.DarkGreen,
            Transport.CAR => ConsoleColor.Red,
            Transport.BIKE => ConsoleColor.Blue,
            Transport.SUBWAY => ConsoleColor.DarkMagenta,
            Transport.WALK => ConsoleColor.DarkYellow,
            _ => throw new Exception("Unknown Transport"),
        };
    }
}