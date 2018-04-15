﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EVEStandard.Models
{
    public class CharacterMining : ModelBase<CharacterMining>
    {
        /// <summary>
        /// date string
        /// </summary>
        /// <value>date string</value>
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        /// <value>solar_system_id integer</value>
        [JsonProperty("solar_system_id")]
        public int? SolarSystemId { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        /// <value>type_id integer</value>
        [JsonProperty("type_id")]
        public int? TypeId { get; set; }

        /// <summary>
        /// quantity integer
        /// </summary>
        /// <value>quantity integer</value>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }
    }
}