﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace DqccomicsMobileapiService.Models
{
    public partial class ApiBookingRating
    {
        private string _id;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private double? _rating;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public double? Rating
        {
            get { return this._rating; }
            set { this._rating = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ApiBookingRating class.
        /// </summary>
        public ApiBookingRating()
        {
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type ApiBookingRating
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Id != null)
            {
                outputObject["Id"] = this.Id;
            }
            if (this.Rating != null)
            {
                outputObject["Rating"] = this.Rating.Value;
            }
            return outputObject;
        }
    }
}