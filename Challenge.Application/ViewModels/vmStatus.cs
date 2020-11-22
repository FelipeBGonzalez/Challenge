using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Challenge.Application.ViewModels
{
    [Serializable]
    [DataContract]
    public class vmStatus
    { 
        [DataMember]
        public string status { get; set; }
    }
}
