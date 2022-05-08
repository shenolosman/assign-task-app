﻿using SO.ToDo.Entities.Concrete;
using System.Linq.Expressions;

namespace SO.ToDo.BusinessLayer.Interfaces
{
    public interface IMyTaskService : IGenericService<MyTask>
    {
        Task<List<MyTask>> GetUnDoneStatesofUrgent();
        Task<List<MyTask>> GetAllTables();
        Task<MyTask> GetStateOfUrgentWithId(int id);
        Task<List<MyTask>> GetByAppUserId(int userId);
        Task<MyTask> GetByReportId(int reportId);
        Task<List<MyTask>> GetAllTables(Expression<Func<MyTask, bool>> filter);
    }
}
