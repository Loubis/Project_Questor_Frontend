using System;
using System.Collections.Generic;

namespace Models
{
    public class Questmarker
    {
        public int id;
        public float longitude;
        public float latitude;
        public String name;
        public List<int> originsId;
        public List<int> nextMarkerIds;
        public List<Module> modules;
    }
}