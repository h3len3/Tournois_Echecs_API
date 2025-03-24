using Be.Khunly.EFRepository;
using Labo.Application.Interfaces.Repositories;
using Labo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.Infrastructure.Repositories
{
    public class TournamentRepository(LaboContext context) : RepositoryBase<Member>(context), IMemberRepository
    {
    }

}
