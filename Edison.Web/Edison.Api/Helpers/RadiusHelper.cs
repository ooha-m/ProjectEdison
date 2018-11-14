﻿using Edison.Common.DAO;
using Edison.Core.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edison.Api.Helpers
{
    public static class RadiusHelper
    {
        private const double EARTH_RADIUS_KM = 6371;
        private const double EARTH_CIRCUM_POLE_KM = 40008;

        public static bool IsWithinRadius(GeolocationDAOObject testPoint, GeolocationDAOObject center, double radius)
        {
            return IsWithinRadius(testPoint.Longitude, center.Longitude, testPoint.Latitude, center.Latitude, radius);
        }

        public static bool IsWithinRadius(Geolocation testPoint, Geolocation center, double radius)
        {
            return IsWithinRadius(testPoint.Longitude, center.Longitude, testPoint.Latitude, center.Latitude, radius);
        }

        public static bool IsWithinRadius(GeolocationDAOObject testPoint, Geolocation center, double radius)
        {
            return IsWithinRadius(testPoint.Longitude, center.Longitude, testPoint.Latitude, center.Latitude, radius);
        }

        public static bool IsWithinRadius(Geolocation testPoint, GeolocationDAOObject center, double radius)
        {
            return IsWithinRadius(testPoint.Longitude, center.Longitude, testPoint.Latitude, center.Latitude, radius);
        }

        public static bool IsWithinRadius(double xCoord, double xCent, double yCoord, double yCent, double radius)
        {
            double radAtLat = Math.Cos((yCoord + yCent) * Math.PI / 360) * EARTH_RADIUS_KM;
            double lngDist = Math.Abs((xCoord - xCent) / 360 * (radAtLat * 2 * Math.PI));
            double latDist = Math.Abs((yCoord - yCent) / 360 * EARTH_CIRCUM_POLE_KM);
            return Math.Sqrt(Math.Pow(lngDist, 2) + Math.Pow(latDist, 2)) < radius;
        }
    }
}