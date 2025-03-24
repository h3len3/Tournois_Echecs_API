using Labo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.Application.Interfaces.Services
{
    public interface ITournamentService
    {
        Tournament CreateTournament(Tournament tournament);
    }
}
