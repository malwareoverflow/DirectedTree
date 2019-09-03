using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DirectedTree.Models;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DirectedTree.Controllers
{

    [DataContract]
    public class Tree
    {
        public int Id{get;set;}
        [DataMember]
            public string name{get; set;}
               [DataMember]
        public List<children> children{get;set;}
    }



     public class children
{
    public string name { get; set; }
    public int  value{get; set;}
    [JsonProperty(PropertyName = "children")]
    public List<children> child { get; set; }
}


}
