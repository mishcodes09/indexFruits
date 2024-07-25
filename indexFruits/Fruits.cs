using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexFruits
{
    public class Fruits
    {
        string type, name, group;

        public Fruits(string type, string name, string group)
        {
            this.type = type;
            this.name = name;
            this.group = group;
        }

        public object this[int index] //since we cannot make another employee method we make an object which will get and set whatevr is being passed from the main program.
        {
            get
            {
                if (index == 0)
                    return this.type;

                if (index == 0)
                    return this.name;

                if (index == 0)
                    return this.group;

                return null;
            }

            set
            {
                if (index == 0)
                    this.type = (string)value;

                if (index == 0)
                    this.name = (string)value;

                if (index == 0)
                    this.group = (string)value;
            }
        }


        public object this[string attrName] //this is to access position
        {
            get
            {
                if (attrName.ToLower().Equals("type"))
                    return this.type;
                if (attrName.ToLower().Equals("name"))
                    return this.name;
                if (attrName.ToLower().Equals("group"))
                    return this.group;

                return null;

            }

            set
            {
                if (attrName.ToLower().Equals("type"))
                    this.type = (string)value;
                if (attrName.ToLower().Equals("name"))
                    this.name = (string)value;
                if (attrName.ToLower().Equals("group"))
                    this.group = (string)value;
            }
        }
    }
}
