﻿using OSIsoft.AF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace TwitterQueryer.PI_AF
{
    public class PIConnection
    {
        public static AFDatabase afDB;

        /// <summary>
        /// Connects to the PI AF machine
        /// </summary>
        public static void Connect(string systemName, string databaseName, string user, string pass)
        {
            // Get the PI System
            PISystems pisystems = new PISystems();
            PISystem pisystem = pisystems[systemName];

            // Connect
            pisystem.Connect(new NetworkCredential(user, pass, "vcampus"));

            // Grab the database
            afDB = pisystem.Databases[databaseName];
        }
    }
}
