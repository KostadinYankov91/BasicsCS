﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer.Dto.ExportDto
{
    [XmlType("car")]
    public class ExportCarsWithDistanceDto
    {
        [XmlElement("make")]
        public string Make { get; set; }
        [XmlElement("model")]
        public string Model { get; set; }
        [XmlElement("travelled-distance")]
        public string TraveledDistance { get; set; }
    }
}
