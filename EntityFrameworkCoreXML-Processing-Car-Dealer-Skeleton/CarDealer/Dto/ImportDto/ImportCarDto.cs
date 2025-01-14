﻿using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer.Dto.ImportDto
{
    [XmlType("Car")]
    public class ImportCarDto
    {
        [XmlElement("make")]
        public string Make { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }

        [XmlElement("TravelDistance")]
        public int TraveledDistance { get; set; }
        [XmlArray("parts")]
        public ImportCarPartDto[] Parts { get; set; }
    }
}
