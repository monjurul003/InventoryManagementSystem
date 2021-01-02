namespace Ims.Infrastructure.Model
{
    public abstract class Result<TError, TSuccess>
    {
        public bool Success { get; }
        public TError Error { get; }
        public TSuccess Value { get; }
        public bool IsSuccessful => Success;
        public bool IsFailed => !Success;

        public Result(TError error)
        {
            Success = false;
            Error = error;
        }
        public Result(TSuccess value)
        {
            Success = true;
            Value = value;
        }
    }
}