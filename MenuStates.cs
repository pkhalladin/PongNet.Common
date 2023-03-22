namespace PongNet.Common
{
    [Flags]
    public enum MenuStates
    {
        Main     = 0b0001,
        Settings = 0b0010,
        Hidden   = 0b0100
    }
}
