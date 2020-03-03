﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrehistoricRealism.Data
{
    public class DinosaurInfo
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please make a valid entry")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please select Carnivore/Herbivore/Omnivore")]
        [Display(Name = "Diet")]
        public Food Diet { get; set; }
        public enum Food
        {
            Herbivore,
            Carnivore,
            Omnivore
        }

        [Required(ErrorMessage = "Please make a valid entry")]
        [Display(Name = "Need to know")]
        public string NeedToKnow { get; set; }

        [Required(ErrorMessage = "Please make a valid entry")]
        public string Behavior { get; set; }

        [Required(ErrorMessage = "Please make a valid entry")]
        [Display(Name = "Social Interaction")]
        public string SocialInteraction { get; set; }
        [Required(ErrorMessage = "Please make a valid entry")]
        public string PackLimits { get; set; }


        [Required(ErrorMessage = "Please make a valid entry")]
        public string Image { get; set; }
        [Required]
        public string Additionalinfo { get; set; } = "null";


    }
}
