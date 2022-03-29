using Lesson22;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

Person p1 = new Person(12, "Aro");
XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(Person));
using (Stream streamPerson = new FileStream(@"C:\Files\person.txt", FileMode.Append))
{
    xmlSerializer1.Serialize(streamPerson, p1);
}
Person p2;
using (Stream sr = new FileStream(@"C:\Files\perso.txt", FileMode.Append))
{
     p2 = (Person)xmlSerializer1.Deserialize(sr);
}  
 Console.WriteLine(JsonSerializer.Serialize(p2));