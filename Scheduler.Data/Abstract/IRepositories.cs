﻿using Scheduler.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler.Data.Abstract
{
  public  interface IScheduleRepository:IEntityBaseRepository<Schedule>
    {

    }

    public interface IUserRespository:IEntityBaseRepository<User>
    {

    }

    public interface IAttendeeRepository:IEntityBaseRepository<Attendee>
    {

    }
    
}
