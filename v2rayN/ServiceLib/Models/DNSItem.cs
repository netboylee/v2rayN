﻿using SQLite;

namespace ServiceLib.Models
{
    [Serializable]
    public class DNSItem
    {
        [PrimaryKey]
        public string id { get; set; }

        public string remarks { get; set; }
        public bool enabled { get; set; } = true;
        public ECoreType coreType { get; set; }
        public bool useSystemHosts { get; set; }
        public string? normalDNS { get; set; }
        public string? tunDNS { get; set; }
        public string? domainStrategy4Freedom { get; set; }
        public string? domainDNSAddress { get; set; }
    }
}