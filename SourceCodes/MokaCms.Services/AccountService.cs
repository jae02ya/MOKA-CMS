using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MokaCms.Services
{
	/// <summary>
	/// This represents the account service entity.
	/// </summary>
	public class AccountService
	{
		/// <summary>
		/// Authenticate a user by username and password.
		/// </summary>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <returns>Returns <c>True</c>, if authenticated; otherwise returns <c>False</c>.</returns>
		public bool Authenticate(string username, string password)
		{
            var authenticated = false;

		    if (doc.Root == null)
		       throw new Exception("Invalid XML");

		    //var xml = new XmlDocument();

            var doc = XDocument.Load("C:\\Users\\moka\\Documents\\Visual Studio 2012\\Projects\\MokaStudy-w3\\MOKA-CMS\\Documents\\XML Files\\Users-justin.xml");
            var user = doc.Root.Elements("User").
                SingleOrDefault(p => p.Element("Username").Value.ToLower() ==username.ToLower() && 
                    p.Element("password").Value==password );

            if (user != null)
                authenticated = true;
            
            //var authenticated = username == "robin" && password == "robin";

			return authenticated;
		}
	}
}
