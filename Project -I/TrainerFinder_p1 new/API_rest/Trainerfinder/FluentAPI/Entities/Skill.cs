using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Trainerfinder.Entities;

[Table("skills", Schema = "Prasanna")]
public class Skill
{
    [Key]
    [Column("skillid")]
    public int Skillid { get; set; }

    [Column("skills")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Skills { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("certification")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Certification { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Skills")]
    public virtual User? User { get; set; }
}
