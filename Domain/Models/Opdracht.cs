using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Models;

public class Opdracht
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid OpdrachtId { get; set; }
    public string Naam { get; set; }

    [NotMapped]
    [JsonIgnore]
    public virtual List<StudentOpdrachtVoortgang> StudentOpdrachtVoortgangen { get; set; }
}