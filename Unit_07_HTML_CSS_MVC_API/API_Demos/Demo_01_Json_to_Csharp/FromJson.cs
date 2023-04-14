using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01_Json_to_Csharp
{
    // To generate C# classes from json:

    /*
     *  - Copy the entire JSON file
     *  - Create a new .cs file
     *  - Make sure your cursor is active in the new .cs file
     *  - Go to Edit / Paste Special / Paste JSON as classes
     *  
     */

    // It's okay to rename your classes!!
    // BUT, do NOT rename your properties.

    // The special paste feature is not available in the macOS version,
    // And not natively available in VS Code, BUT there is an extension for VS Code: Paste JSON as Classes

    public class Dog
    {
        public int id { get; set; }
        public string name { get; set; }
        public string breed { get; set; }
        public string birthday { get; set; }
        public float weight { get; set; }
        public SpecialNeeds specialNeeds { get; set; }
        public bool vaccinated { get; set; }
    }

    public class SpecialNeeds
    {
        public string diet { get; set; }
        public string exercise { get; set; }
    }

}
