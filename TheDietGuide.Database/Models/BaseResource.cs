using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace TheDietGuide.Database.Models;

public abstract class BaseResource
{
    [Required] [BsonId] public string Id { get; set; }
    [Required] public DateTime CreatedAt { get; set; }
    [Required] public DateTime UpdatedAt { get; set; }
}