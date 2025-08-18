using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    internal class Range<T> where T : IComparable<T>
    {
        #region Properties

        public T Min { get; set; }

        public T Max { get; set; } 
        #endregion

        #region Constructor
        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }
        #endregion

        #region Methods
      public bool  IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;

        }

        public T Lenght() {
            if (Min == null || Max == null)
            {
                throw new InvalidOperationException("Min and Max cannot be null.");
            }
           
            return (dynamic) Max - (dynamic) Min;
        }

        public override string ToString()
        {
            return $"Range: [{Min} , {Max}]";
        }


        #endregion



    }
}
