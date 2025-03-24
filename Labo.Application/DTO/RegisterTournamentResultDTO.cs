using Labo.Domain.Entities;
using Labo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo.Application.DTO
{
    public class RegisterTournamentResultDTO(Tournament t)
    {
        public int Id { get; set; } = t.Id;
        public string Name { get; set; } = t.Name;
        public string? Location { get; set; } = t.Location;

        public int MinPlayers { get; set; } = t.MinPlayers;

        public int MaxPlayers { get; set; } = t.MaxPlayers;
        public int? MinElo { get; set; } = t.MinElo;

        public int? MaxElo { get; set; } = t.MaxElo;

        public Category[] Categories { get; set; } = t.Categories;

        public TournamentStatus Status { get; set; } = t.Status;

        public int CurrentRound { get; set; } = t.CurrentRound;

        public bool WomenOnly { get; set; } = t.WomenOnly;

        public DateTime RegistrationEndDate { get; set; } = t.RegistrationEndDate;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }

}
