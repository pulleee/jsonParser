using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ConsoleApp1.DOs
{
    [DataContract]
    public class Project : AbstractDo
    {
        [DataMember]
        public string expand { get; set; }
        [DataMember]
        public string key { get; set; }
        [DataMember]
        public Lead lead { get; set; } = new Lead();
        [DataMember]
        public List<Component> components { get; set; } = new List<Component>();
        [DataMember]
        public List<IssueType> issueTypes { get; set; } = new List<IssueType>();
        [DataMember]
        public string assigneeType { get; set; }
        [DataMember]
        public List<string> versions { get; set; } = new List<string>();
        [DataMember]
        public Dictionary<string, string> roles { get; set; } = new Dictionary<string, string>();
        [DataMember]
        public Dictionary<string, string> avatarUrls { get; set; } = new Dictionary<string, string>();
        [DataMember]
        public ProjectCategory projectCategory { get; set; } = new ProjectCategory();
    }

    [DataContract]
    public class Lead : AbstractDo
    {
        [DataMember]
        public string key { get; set; }
        [DataMember]
        Dictionary<string, string> avatarUrls { get; set; } = new Dictionary<string, string>();
        [DataMember]
        public string displayName { get; set; }
        [DataMember]
        public bool active { get; set; }
    }

    [DataContract]
    public class IssueType : AbstractIdentDo
    {
        [DataMember]
        public string iconUrl { get; set; }
        [DataMember]
        public bool subTask { get; set; }
        [DataMember]
        public long avatarId { get; set; }
    }

    [DataContract]
    public class ProjectCategory : AbstractIdentDo { }

    [DataContract]
    public class Component { }

    /// <summary>
    /// Composition Object
    /// Dient nur dazu, Redundanzen zu vermeiden? DERZEIT UNUSED
    /// </summary>
    public class AvatarDo
    {
        Dictionary<string, string> AvatarUrls { get; set; } = new Dictionary<string, string>();
        public string Key { get; set; }
    }

    #region Abstract Classes 

    [DataContract]
    public abstract class AbstractDo
    {
        [DataMember]
        public string self { get; set; }
        [DataMember]
        public string name { get; set; }
    }

    [DataContract]
    public abstract class AbstractIdentDo : AbstractDo
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string description { get; set; }
    }

    #endregion 
}
