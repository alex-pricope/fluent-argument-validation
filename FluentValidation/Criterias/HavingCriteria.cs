namespace FluentValidation.Criterias
{
    public sealed class HavingCriteria<T>
    {
        public HavingCriteria(T parent)
        {
            Having = parent;
        }

        public T Having { get; }
    }
}
