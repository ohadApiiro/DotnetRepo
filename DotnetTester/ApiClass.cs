using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DotnetTester
{
    public abstract class BaseDocument<T>
    {
        public int Age { get; set; }
        public string Name { get; set; }
        
        public T Foo { get; set; }
        
        [BsonIgnore]
        public string Dum { get; set; }
    }

    [Route("api")]
    public class ApiClass : ControllerBase
    {
        private int? optionalField;
        
        [HttpGet("get")]
        public string Get()
        {
            return "get";
        }
        [HttpPost("poster")]
        public string Poster(string s)
        {
            return Foo();
        }

        private string Foo()
        {
            return "bla";
        }
    }
}