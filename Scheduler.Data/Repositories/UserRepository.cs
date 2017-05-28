using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Scheduler.Model;
using Scheduler.Data;
using Scheduler.Data.Repositories;
using Scheduler.Data.Abstract;
using Scheduler.Model.Entities;

namespace Scheduler.Data.Repositories
{
    public class UserRepository : EntityBaseRepository<User>, IUserRespository
    {
        public UserRepository(SchedulerContext context)
            : base(context)
        { }
    }
}
