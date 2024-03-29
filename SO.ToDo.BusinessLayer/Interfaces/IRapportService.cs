﻿using SO.ToDo.Entities.Concrete;

namespace SO.ToDo.BusinessLayer.Interfaces
{
    public interface IRapportService : IGenericService<Rapport>

    {
        Rapport GetByTaskId(int id);
        int GetReportsByUserId(int id);
        int GetReportCount();

    }
}
