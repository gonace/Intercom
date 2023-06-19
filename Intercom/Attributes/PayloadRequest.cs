namespace Intercom.Attributes
{
    public abstract class PayloadRequest
    {
        public abstract object Payload { get; }
        public abstract string Uri { get; }
    }
}
