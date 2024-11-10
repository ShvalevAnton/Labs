using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct, AllowMultiple = true)]
    public class DeveloperInfoAttribute : System.Attribute
    {
        private string developerName;
        private string dateCreated;
        // Constructor. Developer name is the only
        // mandatory parameter for this attribute.
        public DeveloperInfoAttribute(string developerName)
        {
            this.developerName = developerName;
        }
        public string Developer
        {
            get
            {
                return developerName;
            }
        }
        // Optional parameter
        public string Date
        {
            get
            {
                return dateCreated;
            }
            set
            {
                dateCreated = value;
            }
        }
    }
}
