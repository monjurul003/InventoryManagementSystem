namespace Ims.Infrastructure.Model
{
    public class ActionResult<T> : Result<ActionError, T>
    {
        public ActionResult(ActionError error) : base(error)
        {
        }

        public ActionResult(T value) : base(value)
        {
        }

        public void RethrowIfFailedWithException()
        {
            if (IsFailed && Error != null)
            {
                Error.ReThrowIfFailedWithException();
            }
        }
    }
}