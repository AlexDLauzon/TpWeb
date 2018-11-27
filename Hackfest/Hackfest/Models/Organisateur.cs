using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hackfest.Models
{
    public class Organisateur
    {
        public enum LesRolesOrganisateur { PCO, PCP, RF, RA }

        [Key]
        public int IdOrganisateur { get; set; }
        [EnumDataType(typeof(LesRolesOrganisateur), ErrorMessage = "")]
        public string RôleOrganisateur { get; set; }
    }
}
