namespace FluentValidation.Criterias
{
    public sealed class OrCriteria<T>
    {
        public OrCriteria(T parent)
        {
            Or = parent;
        }

        public T Or { get; }
    }
}
