namespace mini_bot_api.Interface
{
    public interface IDao<T>
    {
        List<T> FindAll();
        T? FindById(Int64 id);
        void Insert(T Instancia);
        void Update(T Instancia);
        void Delete(T Instancia);
    }
}
