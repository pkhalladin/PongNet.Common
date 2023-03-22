namespace PongNet.Common
{
    // TODO: przenieść co można do FlagsExtender
    public abstract class StatableGameComponent<T> : UpdatableGameComponent where T: Enum
    {
        public T State { get; set; }

            
    }
}
