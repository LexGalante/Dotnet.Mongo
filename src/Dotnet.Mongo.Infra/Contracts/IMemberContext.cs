using Dotnet.Mongo.Domain.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Mongo.Infra.Contracts
{
    public interface IMemberContext
    {
        Member Find(Expression<Func<Member, bool>> filter);

        Task<Member> FindAsync(Expression<Func<Member, bool>> filter);
        
        void Create(Member entity);

        Task CreateAsync(Member entity);

        void Create(List<Member> entities);

        Task CreateAsync(List<Member> entities);

        void Update(Expression<Func<Member, bool>> filter, Member entity);

        Task UpdateAsync(Expression<Func<Member, bool>> filter, Member entity);

        void Delete(Expression<Func<Member, bool>> filter);

        Task DeleteAsync(Expression<Func<Member, bool>> filter);
    }
}
