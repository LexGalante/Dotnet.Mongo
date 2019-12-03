using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dotnet.Mongo.Infra
{
    public class MongoContext<T> where T : class
    {
        private readonly IConfiguration _configuration;
        private readonly MongoClient _client;
        private readonly IMongoDatabase _context;
        private IMongoCollection<T> _collection;

        protected MongoContext(IConfiguration configuration, string collectionName)
        {
            _configuration = configuration;
            _client = new MongoClient(configuration.GetConnectionString("MongoConnection"));
            _context = _client.GetDatabase("Crud");
            _collection = _context.GetCollection<T>(collectionName);
        }

        public T Find(Expression<Func<T, bool>> filter) => _collection.Find<T>(filter).SingleOrDefault();

        public async Task<T> FindAsync(Expression<Func<T, bool>> filter) => await _collection.Find<T>(filter).SingleOrDefaultAsync();

        public void Create(T entity) => _collection.InsertOne(entity);

        public async Task CreateAsync(T entity) => await _collection.InsertOneAsync(entity);

        public void Create(List<T> entities) => _collection.InsertMany(entities);

        public async Task CreateAsync(List<T> entities) => await _collection.InsertManyAsync(entities);

        public void Update(Expression<Func<T, bool>> filter, T entity) => _collection.ReplaceOne(filter, entity);

        public async Task UpdateAsync(Expression<Func<T, bool>> filter, T entity) => await _collection.ReplaceOneAsync<T>(filter, entity);

        public void Delete(Expression<Func<T, bool>> filter) => _collection.DeleteOne(filter);

        public async Task DeleteAsync(Expression<Func<T, bool>> filter) => await _collection.DeleteOneAsync(filter);
    }
}
