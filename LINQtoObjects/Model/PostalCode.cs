using System.ComponentModel;

namespace LINQtoObjects.Model
{
    [DefaultValue(Country.FICKEN)]
    public enum Country : short
    {
        FICKEN,
        Austria,
        Germany,
        Swiss
    }
    
    public class PostalCode
    {
        public long Number { get; init; }
        public Country Country { get; init; }
    }
}