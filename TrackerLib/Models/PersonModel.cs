using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Person's First name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Person's Last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Person's Email address.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Person's Cellphone number.
        /// </summary>
        public string CellPhoneNumber { get; set; }
    }
}
