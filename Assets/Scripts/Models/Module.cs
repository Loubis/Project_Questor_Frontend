using System;
using UnityEditor.Experimental.UIElements;

namespace Models
{
    public class Module
    {
        public int id;
        public Module success;
        public Module failure;
        public String moduleType;
        public String message;
        public int originId;
        public int nextMarkerId;
    }
}