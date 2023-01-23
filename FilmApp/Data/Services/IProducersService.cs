using FilmApp.Data.Base;
using FilmApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmApp.Data.Services
{
    public interface IProducersService: IEntityBaseRepository<Producer>
    {
    }
}
