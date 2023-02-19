using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Trainerfinder.Entities;

[Table("education", Schema = "Prasanna")]
public class Education
{
    [Key]
    [Column("educationid")]
    public int Educationid { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("sslc")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Sslc { get; set; }

    [Column("ssc")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Ssc { get; set; }

    [Column("ug")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Ug { get; set; }

    [Column("pg")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Pg { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Educations")]
    public virtual User? User { get; set; }
}
