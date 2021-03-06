﻿using System.Collections.Generic;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IClientAppService : IAppServiceBase<Client>
    {
        IEnumerable<Client> GetSpecialClients();
    }
}
