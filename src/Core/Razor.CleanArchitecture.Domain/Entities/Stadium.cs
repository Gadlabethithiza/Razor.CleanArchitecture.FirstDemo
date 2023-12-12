﻿using Razor.CleanArchitecture.Domain.Common;
namespace Razor.CleanArchitecture.Domain.Entities;
public class Stadium : BaseAuditableEntity
    {
        public Stadium()
        {
            Clubs = new List<Club>();
        }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public int? Capacity { get; set; }
        public int? BuiltYear { get; set; }
        public int? PitchLength { get; set; }
        public int? PitchWidth { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public int? CountryId { get; set; }

        public Country Country { get; set; }
        public IList<Club> Clubs { get; set; }
         
    }
