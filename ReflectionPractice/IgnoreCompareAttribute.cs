using System;

namespace ReflectionPractice
{
    [AttributeUsage(AttributeTargets.Property)]
    public class IgnoreCompareAttribute :  Attribute
    {
    }
}
