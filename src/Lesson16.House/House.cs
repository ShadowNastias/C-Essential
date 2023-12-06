using Newtonsoft.Json;

namespace Lesson16.House;

class House
{
    public string Address { get; set; }
    public int Area { get; set; }

    public House(string address, int area)
    {
        Address = address;
        Area = area;
    }

    public House Clone()
    {
        return (House)this.MemberwiseClone();
    }

    public House DeepClone()
    {
        string json = JsonConvert.SerializeObject(this);
        return JsonConvert.DeserializeObject<House>(json);
    }
}