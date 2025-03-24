using Labo.Application.Interfaces.Repositories;
using Labo.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labo.Domain.Entities;
using Labo.Domain.Enums;
using System.Runtime.ConstrainedExecution;
using Labo.Infrastructure.Repositories;
using Labo.Application.Interfaces.Services;
using Labo.Application.DTO;

namespace Labo.Application.Services
{ 
   
    public class TournamentService(ITournamentRepository tournamentRepository, IMemberRepository memberRepository): ITournamentService
    {
        
        // Méthode pour créer un tournoi
    public Tournament CreateTournament(RegisterTournamentDTO dto)
        {
           
            // Initialisation des valeurs par défaut // ici IouI dans la config de la   tablde (+ ds api avec un attrrbitu et côté angular)
            int currentRound = 0;
            
            DateTime created = DateTime.UtcNow;
            DateTime updated = DateTime.UtcNow;


            // Envoi des invitations par e-mail aux joueurs éligibles
              // Eventuellement plus tard (Bonus)

            // Sauvegarder le tournoi dans la base de données
            Tournament t = tournamentRepository.Add(new Tournament
            {
                Name = dto.Name,
                Location = dto.Location,
                MinPlayers = dto.MinPlayers,
                MaxPlayers = dto.MaxPlayers,
                MinElo = dto.MinElo,
                MaxElo = dto.MaxElo,
                Categories = dto.Categories,
                Status = dto.Status,
                CurrentRound = currentRound,
                WomenOnly = dto.WomenOnly,
                RegistrationEndDate = dto.RegistrationEndDate,
                CreatedAt = created,
                UpdatedAt = updated
            });
            return t;
        }

        // Vérifie que le nombre minimum de joueurs est inférieur ou égal au nombre maximum
        private bool IsValidMinMaxPlayers(Tournament tournament)
        {
            return tournament.MinPlayers <= tournament.MaxPlayers;
        }

       // Vérifie que l'ELO minimum est inférieur ou égal à l'ELO maximum
        private bool IsValidMinMaxElo(Tournament tournament)
        {
            return (!tournament.MinElo.HasValue || !tournament.MaxElo.HasValue || tournament.MinElo <= tournament.MaxElo);
        }

       // Vérifie que la date de fin des inscriptions est supérieure à la date actuelle + le nombre minimum de joueurs
         private bool IsValidRegistrationEndDate(Tournament tournament)
         {
             DateTime minEndDate = DateTime.UtcNow.AddDays(tournament.MinPlayers);
             return tournament.RegistrationEndDate > minEndDate;
         }



    }


}
