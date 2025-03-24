using Labo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.Domain.Entities
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Location { get; set; }

        [Range(2, 32)]
        public int MinPlayers { get; set; }

        [Range(2, 32)]
        public int MaxPlayers { get; set; }

        [Range(0, 3000)]
        public int? MinElo { get; set; }

        [Range(0, 3000)]
        public int? MaxElo { get; set; }

        public Category[] Categories { get; set; } 

        public TournamentStatus Status { get; set; }

        public int CurrentRound { get; set; }

        public bool WomenOnly { get; set; }

        public DateTime RegistrationEndDate { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
