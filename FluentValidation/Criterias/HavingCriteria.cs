namespace FluentValidation
{
    public sealed class HavingCriteria<T>
    {
        internal HavingCriteria(T parent)
        {
            Having = parent;
        }

        /// <summary>
        /// Fluently continue a series of Having criteria
        /// </summary>
        public T Having { get; }
    }
}
