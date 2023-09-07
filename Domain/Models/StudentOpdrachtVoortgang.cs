using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class StudentOpdrachtVoortgang
{
    [Key]
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public virtual Student Student { get; set; }
    public Guid OpdrachtId { get; set; }
    public virtual Opdracht Opdracht { get; set; }
    public Voortgang Voortgang { get; set; }
}