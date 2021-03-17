using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SvxlinkManager.Common.Models
{
  public class ChannelBase
  {
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Host { get; set; }

    [Required]
    public string CallSign { get; set; }

    public int Dtmf { get; set; }

    public override bool Equals(object obj)
    {
      return Id == ((ChannelBase)obj).Id;
    }

    [NotMapped]
    public virtual Dictionary<string, string> TrackProperties { get; }
  }
}