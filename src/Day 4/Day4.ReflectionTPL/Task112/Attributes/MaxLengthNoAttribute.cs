using System;

namespace Day4.ReflectionTPL.Task112.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MaxLengthNoAttribute : Attribute
    {
        public int Length { get; }

        public MaxLengthNoAttribute(int length)
        {
            Length = length;
        }
    }
}