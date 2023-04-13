namespace Serialize_Sample.Contract
{
    public interface ISerializer<T, S>
    {
        void Serialize(T entity, S filepath);
        T? Deerialize(S filepath);
    }
}
