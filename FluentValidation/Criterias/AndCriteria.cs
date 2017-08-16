namespace FluentValidation.Criterias
{
    public sealed class AndCriteria<T>
    {
        public AndCriteria(T parent)
        {
            And = parent;
        }

        public T And { get; }
    }
}