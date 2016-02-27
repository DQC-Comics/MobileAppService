﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace DqccomicsMobileapiService.Models
{
    public partial class ApiHeroSkill
    {
        private string _description;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private int? _id;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private double? _level;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public double? Level
        {
            get { return this._level; }
            set { this._level = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
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
        
        private double? _ratingCount;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public double? RatingCount
        {
            get { return this._ratingCount; }
            set { this._ratingCount = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ApiHeroSkill class.
        /// </summary>
        public ApiHeroSkill()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken descriptionValue = inputObject["Description"];
                if (descriptionValue != null && descriptionValue.Type != JTokenType.Null)
                {
                    this.Description = ((string)descriptionValue);
                }
                JToken idValue = inputObject["Id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.Id = ((int)idValue);
                }
                JToken levelValue = inputObject["Level"];
                if (levelValue != null && levelValue.Type != JTokenType.Null)
                {
                    this.Level = ((double)levelValue);
                }
                JToken nameValue = inputObject["Name"];
                if (nameValue != null && nameValue.Type != JTokenType.Null)
                {
                    this.Name = ((string)nameValue);
                }
                JToken ratingValue = inputObject["Rating"];
                if (ratingValue != null && ratingValue.Type != JTokenType.Null)
                {
                    this.Rating = ((double)ratingValue);
                }
                JToken ratingCountValue = inputObject["RatingCount"];
                if (ratingCountValue != null && ratingCountValue.Type != JTokenType.Null)
                {
                    this.RatingCount = ((double)ratingCountValue);
                }
            }
        }
    }
}
