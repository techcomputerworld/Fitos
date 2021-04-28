using System;
using System.Collections.Generic;
using System.Text;
using Fitos.Models;

namespace Fitos.Datos.Data.Repository
{
    public interface IFitosRepository : IRepository<Fitosanitario>
    {
        void Update(Fitosanitario fitos);
    }
}
