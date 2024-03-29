﻿using System;
using System.Collections.Generic;
using System.Text;

/*
CAKE: CAKE_ID (PK), CATALOGUE_ID (FK), CAKE_NAME, PRICE (INT), DESCRIPTION (TEXT)
 */
namespace ConsoleApp2.db
{
    class Cake
    {
        public String Id { get; set; }
        public String Image { get; set; }
        public String CatalogueId { get; set; }
        public String Name { get; set; }
        public int Price { get; set; }
        public String Description { get; set; }

        public Cake(string id, string catalogueId, string name, int price, string DESCRIPTION)
        {
            Id = id;
            CatalogueId = catalogueId;
            Name = name;
            Price = price;
            Description = DESCRIPTION;
        }

        public Cake()
        {
            //do nothing
        }
    }
}
