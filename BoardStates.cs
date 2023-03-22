namespace PongNet.Common
{
    [Flags]
    public enum BoardStates
    {
        Pause =         0b0000000100,
        HumanServe =    0b0000001000,
        ComputerServe = 0b0000010000,
        HumanPoint    = 0b0000100000,
        ComputerPoint = 0b0001000000,
        HumanWin =      0b0010000000,
        ComputerWin   = 0b0100000000,
        Hidden        = 0b1000000000
    }
}
