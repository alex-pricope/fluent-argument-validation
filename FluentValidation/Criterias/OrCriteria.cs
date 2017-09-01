namespace FluentValidation
{
    public sealed class OrCriteria<T>
    {
        internal OrCriteria(T parent)
        {
            Or = parent;
        }

        /// <summary>
        /// Fluently continue a series of Or criteria
        /// </summary>
        public T Or { get; }
    }
}
