using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Trainerfinder.Entities;

[Table("experience", Schema = "Prasanna")]
public class Experience
{
    [Column("user_id")]
    public int? UserId { get; set; }

    [Key]
    [Column("companyid")]
    public int Companyid { get; set; }

    [Column("company")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Company { get; set; }

    [Column("job_role")]
    [StringLength(25)]
    [Unicode(false)]
    public string? JobRole { get; set; }

    [Column("experience")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Experience1 { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Experiences")]
    public virtual User? User { get; set; }
}
