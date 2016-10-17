﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GenericRepository.Data;

namespace GenericRepository.Models
{
    public class CustomerModel
    {
        [Key]
        public string CustomerID { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public Customer ToEntity()
        {
            return new Customer
            {
                Address = Address,
                City = City,
                CompanyName = CompanyName,
                ContactName = ContactName,
                ContactTitle = ContactTitle,
                Country = Country,
                CustomerID = CustomerID,
                Fax = Fax,
                Phone = Phone,
                PostalCode = PostalCode,
                Region = Region
            };
        }
    }
}