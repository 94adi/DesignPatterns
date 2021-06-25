using System;
using System.Collections.Generic;
using System.Dynamic;

namespace DynamicObjectExample
{
    public class DynamicDictionary : DynamicObject
    {
        Dictionary<string, object> dictionary
            = new Dictionary<string, object>();

        public int Count
        {
            get
            {
                return dictionary.Count;
            }
        }

        public override bool TryGetMember(
            GetMemberBinder binder, out object result)
        {

            string name = binder.Name.ToLower();

            return dictionary.TryGetValue(name, out result);
        }

        public override bool TrySetMember(
            SetMemberBinder binder, object value)
        {
            dictionary[binder.Name.ToLower()] = value;
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a dynamic dictionary.
            dynamic person = new DynamicDictionary();

            //Dictionary<string, object> staticDictionary = new Dictionary<string, object>();
            //staticDictionary["FirstName"] = "Adrian";
            person.FirstName = "Ellen";
            person.LastName = "Adams";

            Console.WriteLine(person.firstname + " " + person.lastname);

            Console.WriteLine(
                "Number of dynamic properties:" + person.Count);

            // The following statement throws an exception at run time.
            // There is no "address" property,
            // so the TryGetMember method returns false and this causes a
            // RuntimeBinderException.
            // Console.WriteLine(person.address);
        }
    }

}
