using AccessManager.DataAccess.Data;
using AccessManager.DataAccess.Repository.IRepository;
using AccessManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessManager.DataAccess.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



    }
}
