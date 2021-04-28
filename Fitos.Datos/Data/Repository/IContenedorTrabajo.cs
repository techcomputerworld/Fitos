using System;
using System.Collections.Generic;
using System.Text;

namespace Fitos.Datos.Data.Repository
{
    public interface IContenedorTrabajo : IDisposable
    {
        IFitosRepository Fitos { get; }
    }
}
