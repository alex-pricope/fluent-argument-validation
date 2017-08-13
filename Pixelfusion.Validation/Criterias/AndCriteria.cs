namespace SimpleValidation.Criterias
{
    public class AndCriteria<T>
    {
        public AndCriteria(T parent)
        {
            And = parent;
        }

        public T And { get; }
    }
}