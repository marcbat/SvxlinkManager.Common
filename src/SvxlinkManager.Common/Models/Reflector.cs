﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SvxlinkManager.Common.Models
{
  public class Reflector : IModelEntity
  {
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Config { get; set; }

    public bool Enable { get; set; }

    [NotMapped]
    public Dictionary<string, string> TrackProperties => new Dictionary<string, string> {
        { nameof(Name), Name }
        };
  }
}