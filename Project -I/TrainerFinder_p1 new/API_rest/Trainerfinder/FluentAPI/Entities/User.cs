using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Trainerfinder.Entities;

[Table("users", Schema = "Prasanna")]
public class User
{
    [Key]
    [Column("user_id")]
    public int UserId { get; set; }

    [Column("username")]
    [StringLength(25)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column("gender")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("email")]
    [StringLength(25)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column("pasword")]
    [StringLength(25)]
    [Unicode(false)]
    public string Pasword { get; set; } = null!;

    [Column("location")]
    [StringLength(25)]
    [Unicode(false)]
    public string Location { get; set; } = null!;

    [Column("aboutme")]
    [StringLength(25)]
    [Unicode(false)]
    public string Aboutme { get; set; } = null!;

    [Column("phoneno")]
    [StringLength(10)]
    [Unicode(false)]
    public string Phoneno { get; set; } = null!;

    [Column("website")]
    [StringLength(25)]
    [Unicode(false)]
    public string Website { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<Education> Educations { get; } = new List<Education>();

    [InverseProperty("User")]
    public virtual ICollection<Experience> Experiences { get; } = new List<Experience>();

    [InverseProperty("User")]
    public virtual ICollection<Skill> Skills { get; } = new List<Skill>();
}
