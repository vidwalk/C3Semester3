using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Exercise2 {
    [Serializable]
    public class Person : IXmlSerializable {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }

        public XmlSchema GetSchema () {
            return (null);
        }

        public Person () {

        }
        public Person (String firstName, String lastName, int ssn) {
            FirstName = firstName;
            LastName = lastName;
            Ssn = ssn;
        }
        public void ReadXml (XmlReader reader) {
            //FirstName = reader.ReadContentAsString().Split(" ")[1];
            reader.ReadStartElement("Person");
            reader.ReadStartElement("FirstName");
            FirstName = reader.ReadContentAsString();
            reader.ReadEndElement();
            reader.ReadStartElement("LastName");
            LastName = reader.ReadContentAsString();
            reader.ReadEndElement();
            reader.ReadStartElement("Ssn");
            Ssn = reader.ReadContentAsInt();
            reader.ReadEndElement();
            reader.ReadEndElement();

        }

        public override String ToString () {
            return FirstName + " " + LastName + " " + Ssn;
        }

        public void WriteXml (XmlWriter writer) {
            writer.WriteStartElement("FirstName");
            writer.WriteString (FirstName);
            writer.WriteEndElement();
            writer.WriteStartElement("LastName");
            writer.WriteString (LastName);
            writer.WriteEndElement();
            writer.WriteStartElement("Ssn");
            writer.WriteString ("" + Ssn);
            writer.WriteEndElement();
        }
    }
    class Program {
        static void Main (string[] args) {
            const string fileName = "PersonStore.bin";
            const string xmlName = "test.xml";
            Person personIn = new Person () { FirstName = "Carl", LastName = "Jung", Ssn = 2442 };
            IFormatter formatter = new BinaryFormatter ();
            Stream streamIn = new FileStream (fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize (streamIn, personIn);
            streamIn.Close ();
            Stream streamOut = new FileStream (fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            Person personOut = (Person) formatter.Deserialize (streamOut);
            streamOut.Close ();
            System.Console.WriteLine (personOut);
            Person personIn2 = new Person () { FirstName = "Friedrich", LastName = "Nietzche", Ssn = 2552 };
            string json = JsonConvert.SerializeObject (personIn2);
            Person personOut2 = JsonConvert.DeserializeObject<Person> (json);
            System.Console.WriteLine (personOut2);
            XmlSerializer serializer = new XmlSerializer (typeof (Person));
            streamIn = new FileStream (xmlName, FileMode.Create, FileAccess.Write, FileShare.None);
            streamIn.Close ();
            XmlTextWriter writer = new XmlTextWriter (xmlName, null);
            Person personIn3 = new Person () { FirstName = "Sigmund", LastName = "Freud", Ssn = 2662 };
            serializer.Serialize (writer, personIn3);
            writer.Close ();
            streamOut = new FileStream (xmlName, FileMode.Open, FileAccess.Read, FileShare.Read);
            Person personOut3 = (Person) serializer.Deserialize (streamOut);
            Console.WriteLine (personOut3);
            streamOut.Close ();
        }
    }
}