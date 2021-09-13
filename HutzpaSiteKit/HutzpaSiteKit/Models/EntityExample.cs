using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutzpaSiteKit.Models
{
    /// <summary>
    /// ORM DBO 
    /// </summary>
    public class EntityExample
    {
        /// <summary>
        /// Uniqe entity identifyer 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Example of string DBO property
        /// </summary>
        public string ExampleStringProperty { get; set; }

        /// <summary>
        /// Example of numeric DBO property
        /// </summary>
        public int ExampleNumericProperty { get; set; }

        /// <summary>
        /// Example of DBO property with floating point
        /// </summary>
        public float ExampleFloatProperty { get; set; }

        /// <summary>
        /// Here is the example of DateTime property, that was initialized, by the current year, month, day and hour. 
        /// </summary>
        public DateTime ExampleDateTimeProperty { get; set;} = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day, DateTime.UtcNow.Hour + 1 >= 24 ? 0 : DateTime.UtcNow.Hour + 1, 0, 0);

        /// <summary>
        /// Example of DBO logic property
        /// </summary>
        public bool ExampleBoolProperty { get; set; }

       
        /// <summary>
        /// Composite key relationship
        /// </summary>
        public List<CompositeKeyEntityExample> CompositeKeyEntityExamples { get; set; }


    }
}
