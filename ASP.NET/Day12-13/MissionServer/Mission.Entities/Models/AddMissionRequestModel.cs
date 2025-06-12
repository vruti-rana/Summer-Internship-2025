﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
namespace Mission.Entities.Models
{
    public class AddMissionRequestModel
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public string MissionTitle { get; set; }
        public int MissionThemeId { get; set; }
        public string MissionDescription { get; set; }

        [JsonPropertyName("totalSheets")]
        public int TotalSeats { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string MissionImages { get; set; }
        public string MissionSkillId { get; set; }
    }
}
