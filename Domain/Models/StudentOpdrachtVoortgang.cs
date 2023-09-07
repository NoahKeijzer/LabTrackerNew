using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Domain;

public class StudentOpdrachtVoortgang
{
    public Guid StudentId { get; set; }
    public virtual Student Student { get; set; }
    public Guid OpdrachtId { get; set; }
    public virtual Opdracht Opdracht { get; set; }
    public Voortgang Voortgang { get; set; }
}