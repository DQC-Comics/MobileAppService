﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using DqccomicsMobileapiService.Models;
using Newtonsoft.Json.Linq;

namespace DqccomicsMobileapiService.Models
{
    public static partial class ApiHeroLimitedCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<ApiHeroLimited> DeserializeJson(JToken inputObject)
        {
            IList<ApiHeroLimited> deserializedObject = new List<ApiHeroLimited>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                ApiHeroLimited apiHeroLimited = new ApiHeroLimited();
                apiHeroLimited.DeserializeJson(iListValue);
                deserializedObject.Add(apiHeroLimited);
            }
            return deserializedObject;
        }
    }
}
