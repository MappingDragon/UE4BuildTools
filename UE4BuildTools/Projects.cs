using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace UE4BuildTools
{
    [XmlRoot(ElementName = "project")]
    public class Project
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "version")]
        public string Version { get; set; }
        [XmlElement(ElementName = "projectsource")]
        public string ProjectSource { get; set; }
        [XmlElement(ElementName = "source")]
        public string Source { get; set; }
        [XmlElement(ElementName = "destination")]
        public string Destination { get; set; }
    }

    [XmlRoot(ElementName = "projects")]
    public class Projects
    {
        [XmlElement(ElementName = "project")]
        public List<Project> Project { get; set; }
    }
}
