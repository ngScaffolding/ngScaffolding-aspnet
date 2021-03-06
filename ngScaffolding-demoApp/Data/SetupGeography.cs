﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ngScacffolding.demoApp.Data;
using ngScaffolding.demoApp.Models;

namespace ngScaffolding.demoSetup
{
    public class SetupGeography
    {
        public static void Setup(DemoContext demoCtx)
        {
            if (!demoCtx.Continents.Any())
            {
                var africa = demoCtx.Continents.Add(new Continent() { Name = "Africa" });
                var asia = demoCtx.Continents.Add(new Continent() { Name = "Asia" });
                var europe = demoCtx.Continents.Add(new Continent() { Name = "Europe" });
                var na = demoCtx.Continents.Add(new Continent() { Name = "North America" });
                var o = demoCtx.Continents.Add(new Continent() { Name = "Oceania" });
                var sa = demoCtx.Continents.Add(new Continent() { Name = "South America" });

                demoCtx.SaveChanges();

                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Algeria" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Angola" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Benin" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Botswana" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Burkina" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Burundi" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Cameroon" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Cape Verde" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Central African Republic" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Chad" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Comoros" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Congo" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Congo, Democratic Republic of" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Djibouti" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Egypt" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Equatorial Guinea" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Eritrea" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Ethiopia" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Gabon" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Gambia" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Ghana" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Guinea" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Guinea-Bissau" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Ivory Coast" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Kenya" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Lesotho" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Liberia" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Libya" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Madagascar" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Malawi" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Mali" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Mauritania" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Mauritius" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Morocco" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Mozambique" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Namibia" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Niger" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Nigeria" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Rwanda" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Sao Tome and Principe" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Senegal" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Seychelles" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Sierra Leone" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Somalia" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "South Africa" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "South Sudan" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Sudan" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Swaziland" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Tanzania" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Togo" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Tunisia" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Uganda" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Zambia" });
                demoCtx.Countries.Add(new Country() { ContinentId = africa.Entity.Id, Name = "Zimbabwe" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Afghanistan" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Bahrain" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Bangladesh" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Bhutan" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Brunei" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Burma (Myanmar)" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Cambodia" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "China" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "East Timor" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "India" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Indonesia" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Iran" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Iraq" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Israel" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Japan" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Jordan" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Kazakhstan" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Korea, North" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Korea, South" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Kuwait" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Kyrgyzstan" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Laos" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Lebanon" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Malaysia" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Maldives" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Mongolia" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Nepal" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Oman" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Pakistan" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Philippines" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Qatar" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Russian Federation" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Saudi Arabia" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Singapore" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Sri Lanka" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Syria" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Tajikistan" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Thailand" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Turkey" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Turkmenistan" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "United Arab Emirates" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Uzbekistan" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Vietnam" });
                demoCtx.Countries.Add(new Country() { ContinentId = asia.Entity.Id, Name = "Yemen" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Albania" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Andorra" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Armenia" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Austria" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Azerbaijan" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Belarus" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Belgium" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Bosnia and Herzegovina" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Bulgaria" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Croatia" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Cyprus" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Czech Republic" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Denmark" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Estonia" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Finland" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "France" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Georgia" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Germany" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Greece" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Hungary" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Iceland" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Ireland" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Italy" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Latvia" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Liechtenstein" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Lithuania" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Luxembourg" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Macedonia" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Malta" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Moldova" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Monaco" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Montenegro" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Netherlands" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Norway" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Poland" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Portugal" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Romania" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "San Marino" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Serbia" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Slovakia" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Slovenia" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Spain" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Sweden" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Switzerland" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Ukraine" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "United Kingdom" });
                demoCtx.Countries.Add(new Country() { ContinentId = europe.Entity.Id, Name = "Vatican City" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Antigua and Barbuda" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Bahamas" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Barbados" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Belize" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Canada" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Costa Rica" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Cuba" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Dominica" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Dominican Republic" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "El Salvador" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Grenada" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Guatemala" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Haiti" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Honduras" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Jamaica" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Mexico" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Nicaragua" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Panama" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Saint Kitts and Nevis" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Saint Lucia" });
                demoCtx.Countries.Add(new Country()
                {
                    ContinentId = na.Entity.Id,
                    Name = "Saint Vincent and the Grenadines"
                });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "Trinidad and Tobago" });
                demoCtx.Countries.Add(new Country() { ContinentId = na.Entity.Id, Name = "United States" });
                demoCtx.Countries.Add(new Country() { ContinentId = o.Entity.Id, Name = "Australia" });
                demoCtx.Countries.Add(new Country() { ContinentId = o.Entity.Id, Name = "Fiji" });
                demoCtx.Countries.Add(new Country() { ContinentId = o.Entity.Id, Name = "Kiribati" });
                demoCtx.Countries.Add(new Country() { ContinentId = o.Entity.Id, Name = "Marshall Islands" });
                demoCtx.Countries.Add(new Country() { ContinentId = o.Entity.Id, Name = "Micronesia" });
                demoCtx.Countries.Add(new Country() { ContinentId = o.Entity.Id, Name = "Nauru" });
                demoCtx.Countries.Add(new Country() { ContinentId = o.Entity.Id, Name = "New Zealand" });
                demoCtx.Countries.Add(new Country() { ContinentId = o.Entity.Id, Name = "Palau" });
                demoCtx.Countries.Add(new Country() { ContinentId = o.Entity.Id, Name = "Papua New Guinea" });
                demoCtx.Countries.Add(new Country() { ContinentId = o.Entity.Id, Name = "Samoa" });
                demoCtx.Countries.Add(new Country() { ContinentId = o.Entity.Id, Name = "Solomon Islands" });
                demoCtx.Countries.Add(new Country() { ContinentId = o.Entity.Id, Name = "Tonga" });
                demoCtx.Countries.Add(new Country() { ContinentId = o.Entity.Id, Name = "Tuvalu" });
                demoCtx.Countries.Add(new Country() { ContinentId = o.Entity.Id, Name = "Vanuatu" });
                demoCtx.Countries.Add(new Country() { ContinentId = sa.Entity.Id, Name = "Argentina" });
                demoCtx.Countries.Add(new Country() { ContinentId = sa.Entity.Id, Name = "Bolivia" });
                demoCtx.Countries.Add(new Country() { ContinentId = sa.Entity.Id, Name = "Brazil" });
                demoCtx.Countries.Add(new Country() { ContinentId = sa.Entity.Id, Name = "Chile" });
                demoCtx.Countries.Add(new Country() { ContinentId = sa.Entity.Id, Name = "Colombia" });
                demoCtx.Countries.Add(new Country() { ContinentId = sa.Entity.Id, Name = "Ecuador" });
                demoCtx.Countries.Add(new Country() { ContinentId = sa.Entity.Id, Name = "Guyana" });
                demoCtx.Countries.Add(new Country() { ContinentId = sa.Entity.Id, Name = "Paraguay" });
                demoCtx.Countries.Add(new Country() { ContinentId = sa.Entity.Id, Name = "Peru" });
                demoCtx.Countries.Add(new Country() { ContinentId = sa.Entity.Id, Name = "Suriname" });
                demoCtx.Countries.Add(new Country() { ContinentId = sa.Entity.Id, Name = "Uruguay" });
                demoCtx.Countries.Add(new Country() { ContinentId = sa.Entity.Id, Name = "Venezuela" });
            }

            demoCtx.SaveChanges();

        }
    }
}
