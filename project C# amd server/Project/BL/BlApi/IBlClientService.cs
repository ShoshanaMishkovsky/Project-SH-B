﻿using Bl.BlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi
{
    public interface IBlClientService:Icrud<Client>
    {
        public Client Add(Client client);

    }
}
