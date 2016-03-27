using System;
using Newtonsoft.Json;
using Sagar_Auto_Mobiles_API.Utility;

namespace Sagar_Auto_Mobiles_API.Models
{
    /// <summary>
    /// Model for Admin
    /// </summary>
    public class Admin
    {
        private string _email;

        /// <summary>
        /// Email Address of Admin
        /// </summary>
        [JsonProperty(PropertyName="email")]
        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
            
        }

        private string _firstName;

        /// <summary>
        /// First name of Admin
        /// </summary>
        [JsonProperty(PropertyName = "firstname")]
        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;
            }
        }

        private string _lastName;

        /// <summary>
        /// LastName of Admin
        /// </summary>
        [JsonProperty(PropertyName = "lastname")]
        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                this._lastName = value;
            }
        }

        private string _password;

        /// <summary>
        /// Password of Admin
        /// </summary>
        [JsonProperty(PropertyName = "password")]       
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }

        public static bool Authenticate(Admin admin)
        {
            
            return true;

        }
    }
}