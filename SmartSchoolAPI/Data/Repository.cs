namespace SmartSchoolAPI.Data
{
    public class Repository : IRepository
    {
        private readonly SmartContext _database;
        public Repository(SmartContext database)
        {
            this._database = database;
        }


        public void Add<T>(T entity) where T : class
        {
            _database.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _database.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _database.Remove(entity);
        }

        public bool SaveChanges()
        {
            return (_database.SaveChanges() > 0);
        }
    }
}