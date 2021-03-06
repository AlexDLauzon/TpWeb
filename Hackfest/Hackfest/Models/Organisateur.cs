﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackfest.Models
{
    public sealed class Organisateur
    {
        public enum LesRolesOrganisateur { PCO, PCP, RF, RA }

        [Key]
        public int IdOrganisateur { get; set; }
        [ForeignKey("IdParticipantNavigation")]
        public int IdParticipant { get; set; }
        [Required(ErrorMessage = "SVP entrez le mot de passe")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Votre mot de passe doit inclure au moins 8 caractères")]
        [RegularExpression(@"^(?=.*\d).+$", ErrorMessage = "Votre mot de passe doit inclure au moins un chiffre")]
        [DataType(DataType.Password)]
        public string MotDePasse { get; set; }
        [Required(ErrorMessage = "SVP entrez le rôle")]
        [EnumDataType(typeof(LesRolesOrganisateur), ErrorMessage = "Veuillez entrer une des quatre valeurs suivantes: " +
                                                                    "PCO, PCP, RF, RA.")]
        public string RôleOrganisateur { get; set; }
        public Participant IdParticipantNavigation { get; set; }
    }
}
