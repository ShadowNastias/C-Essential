﻿namespace Lesson1.AdressBook
{
    public class Address
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private int _house;
        private int _apartment;

        public int Index
        {
            get { return _index; }
            set { }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public int House
        {
            get { return _house; }
            set { _house = value; }
        }

        public int Apartment
        {
            get { return _apartment; }
            set { _apartment = value; }
        }

        public Address(int index, string country, string city, string street, int house, int apartment)
        {
            this._index = index;
            this._country = country;
            this._city = city;
            this._street = street;
            this._house = house;
            this._apartment = apartment;
        }

        public void ShowAdress()
        {
            Console.WriteLine($"Index: {Index},\n" +
                              $"Country: {Country},\n" +
                              $"City: {City},\n" +
                              $"Street: {Street},\n" +
                              $"House: {House},\n" +
                              $"Apartment: {Apartment}");
        }
    }
}