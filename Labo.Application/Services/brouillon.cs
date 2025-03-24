//using Labo.Application.Interfaces.Repositories;
//using Labo.Application.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Labo.Domain.Entities;
//using Labo.Domain.Enums;
//using System.Runtime.ConstrainedExecution;

//namespace Labo.Application.Services
//{

//    public class TournamentService(ITournamentRepository tournamentRepository, IMemberRepository memberRepository)
//    {

//        // Méthode pour créer un tournoi
//        public Tournament CreateTournament(Tournament tournament)
//        {
//            // Validation des règles métier
//            if (!IsValidMinMaxPlayers(tournament))
//                throw new ArgumentException("Le nombre minimum de joueurs doit être inférieur ou égal au nombre maximum de joueurs.");

//            if (!IsValidMinMaxElo(tournament))
//                throw new ArgumentException("L'ELO minimum doit être inférieur ou égal à l'ELO maximum.");

//            if (!IsValidRegistrationEndDate(tournament))
//                throw new ArgumentException($"La date de fin des inscriptions doit être supérieure à {DateTime.UtcNow.AddDays(tournament.MinPlayers):yyyy-MM-dd}.");

//            // Initialisation des valeurs par défaut
//            tournament.CurrentRound = 0;
//            tournament.Status = TournamentStatus.WaitingForPlayers;
//            tournament.CreatedAt = DateTime.UtcNow;
//            tournament.UpdatedAt = DateTime.UtcNow;

//            // Envoi des invitations par e-mail aux joueurs éligibles
//            // Eventuellement plus tard (Bonus)

//            // Sauvegarder le tournoi dans la base de données
//            Tournament t = tournamentRepository.Add(new Tournament
//            {
//                Name = t.Name,
//                Location = t.Location,
//                MinPlayers = t.MinPlayers,
//                MaxPlayers = t.MaxPlayers,
//                MinElo = t.MinElo,
//                MaxElo = t.MaxElo,
//                Categories = t.Categories,
//                Status = t.Status,
//                CurrentRound = t.CurrentRound,
//                WomenOnly = t.WomenOnly,
//                RegistrationEndDate = t.RegistrationEndDate,
//                CreatedAt = DateTime.UtcNow,
//                UpdatedAt = DateTime.UtcNow

//            }
//             );

//        }

//        // Vérifie que le nombre minimum de joueurs est inférieur ou égal au nombre maximum
//        private bool IsValidMinMaxPlayers(Tournament tournament)
//        {
//            return tournament.MinPlayers <= tournament.MaxPlayers;
//        }

//        // Vérifie que l'ELO minimum est inférieur ou égal à l'ELO maximum
//        private bool IsValidMinMaxElo(Tournament tournament)
//        {
//            return (!tournament.MinElo.HasValue || !tournament.MaxElo.HasValue || tournament.MinElo <= tournament.MaxElo);
//        }

//        // Vérifie que la date de fin des inscriptions est supérieure à la date actuelle + le nombre minimum de joueurs
//        private bool IsValidRegistrationEndDate(Tournament tournament)
//        {
//            DateTime minEndDate = DateTime.UtcNow.AddDays(tournament.MinPlayers);
//            return tournament.RegistrationEndDate > minEndDate;
//        }

//        // Méthode pour envoyer des e-mails aux joueurs éligibles
//        // Eventuellement plus tard (Bonus)


//    }


//}

