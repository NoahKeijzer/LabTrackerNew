using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Models;

public class Student
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid StudentId { get; set; }
    public string Name { get; set; }
    public virtual List<StudentOpdrachtVoortgang> StudentOpdrachtVoortgangen { get; set; }

}