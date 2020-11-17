using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ReflectionPractice
{
    public class Player
    {
        public string Name { get; set; }

        public string Class { get; set; }

        [IgnoreCompare]
        public int PoisitionX { get; set; }

        [IgnoreCompare]
        public int PositionY { get; set; }

        [IgnoreCompare]
        public bool IsNpc { get; set; }

        public override bool Equals(object obj)
        {
            Type objType = obj.GetType();

            if (!objType.Equals(this.GetType()))
            {
                return false;
            }

            PropertyInfo[] objproperties = objType.GetProperties().Where(x=> x.GetCustomAttribute<IgnoreCompareAttribute>() == null).ToArray();

            foreach (PropertyInfo info in objproperties)
            {
                PropertyInfo thisProp = GetType().GetProperty(info.Name);
                if (!info.GetValue(obj).Equals(thisProp.GetValue(this)))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
