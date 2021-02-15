using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BirdSpotters.Models
{
    public class ObservationsModel
    {
        [Required(ErrorMessage = "Du måste fylla i fågelart")]
        [DisplayName("Fågelart")]
        [MaxLength(50, ErrorMessage = "Du får ange max 50 tecken.")]
        public string BirdSpecies { get; set; }

        [DisplayName("Tidigare observation")]
        public Boolean BirdBefore { get; set; } = false; 

        [DisplayName("Observationsplats")]
        [Required(ErrorMessage = "Du måste fylla i vart du observerat fågeln.")]
        [MinLength(5, ErrorMessage = "Du måste ange minst fem tecken.")]
        [MaxLength(100, ErrorMessage = "Du får ange max 100 tecken.")]
        public string BirdLocation { get; set; }

        [DisplayName("Datum")]
        [Required(ErrorMessage = "Du måste fylla i datum.")]
        [DataType(DataType.Date, ErrorMessage = "Du måste fylla i datum.")]   
        [Range(typeof(DateTime), "01/01/2000", "01/01/2100", ErrorMessage = "Du måste ange ett korrekt värde för datum.")]
        public DateTime BirdDate { get; set; }

        [DisplayName("Tid")]
        [Required(ErrorMessage = "Du måste välja tid för observation.")]
        public Times? BirdTime { get; set; }

        

        public ObservationsModel()
        {

        }

    }
    public enum Times
    {
        Morgon,
        Dag,
        Kväll, 
        Natt
    }

    
}
