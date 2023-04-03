﻿using CsvHelper.Configuration.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Models;

public class Listing : BaseEntity
{
  public Listing()
  {
  }

  [JsonProperty("listing_url")]
  public string? ListingUrl { get; set; }

  [JsonProperty("name")]
  public string Name { get; set; }

  [JsonProperty("description")]
  public string Description { get; set; }

  [JsonProperty("property_type")]
  //public PropertyTypes PropertyType { get; set; }
  public string PropertyType { get; set; }

  public List<Review>? Reviews { get; set; }

  public List<Calendar>? Calendars { get; set; }
}
