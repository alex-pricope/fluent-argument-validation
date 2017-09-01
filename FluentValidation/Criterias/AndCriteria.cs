namespace FluentValidation
{
    public sealed class AndCriteria<T>
    {
        internal AndCriteria(T parent)
        {
            And = parent;
        }

        /// <summary>
        /// Fluently continue a series of And criteria
        /// </summary>
        public T And { get; }
    }
}