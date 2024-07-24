﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoringDataInArray
{
    public class BusRouteRepository
    {
        public static BusRoute[] InitializeRoutes()
        {
            return new BusRoute[] {
                new BusRoute(40, new string[] {
                    "Morecambe", "Lancaster", "Garstang", "Preston" }),
                new BusRoute(42, new string[] { "Lancaster", "Garstang", "Blackpool" }),
                new BusRoute(100, new string[] { "University", "Lancaster", "Morecambe" }),
                new BusRoute(555, new string[] {
                    "Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick" }),
                new BusRoute(1_000, new string[] { "Test origin", "Test destination" })
            };

        }
    }
}
