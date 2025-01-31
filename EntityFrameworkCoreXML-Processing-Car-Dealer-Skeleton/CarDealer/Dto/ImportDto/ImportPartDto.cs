﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer.Dto.ImportDto
{
    [XmlType("Part")]
    public class ImportPartDto
    {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("price")]
        public string Price { get; set; }

        [XmlElement("quantity")]
        public int Quantity { get; set; }

        [XmlElement("supplierId")]
        public int SupplierId { get; set; }

    }
}
