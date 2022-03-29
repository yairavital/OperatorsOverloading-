using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOperation
{
   public class Camp
    {
    
        readonly int id;
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public int NumberOfPeople { get; private set; }
        public int NumberOfTents { get; private set; }
        public int NumberOfFleshLights { get; private set; }
        public static int lastcampId = 0;

        public Camp(double latitude, double longitude, int numberOfPeople, int numberOfTents, int numberOfFleshLights)
        {
            this.id = lastcampId;
            lastcampId++;
            Latitude = latitude;
            Longitude = longitude;
            NumberOfPeople = numberOfPeople;
            NumberOfTents = numberOfTents;
            NumberOfFleshLights = numberOfFleshLights;
        }
        public override bool Equals(object? obj)
        {
            Camp? camp = obj as Camp;
            return camp?.id == id;
        }
        public override string ToString()
        {
            return "The id is: " + id+"Number of people is : " + NumberOfPeople+"\nthe Number of flesh lights is: "+NumberOfFleshLights
                +"\nthe number of tents is: " + NumberOfTents;

        }
        public override int GetHashCode()
        {
            return id;
        }
        public static bool operator ==(Camp c1, Camp c2)
        {
            return c1.id == c2.id;
        }
        public static bool operator !=(Camp c1, Camp c2)
        {
            return !(c1 == c2);
        }
        public static bool operator <(Camp c1, Camp c2)
        {
            return c1.NumberOfPeople < c2.NumberOfPeople;
        }
        public static bool operator >(Camp c1, Camp c2)
        {
            return c1.NumberOfPeople > c2.NumberOfPeople;
        }
        public static Camp operator +(Camp c1, Camp c2)
        {
            double lat = c1.Latitude + c2.Latitude;
            double longitude = c1.Longitude + c2.Longitude;
            int numOfPeople = c1.NumberOfPeople + c2.NumberOfPeople;
            int numTents = c1.NumberOfTents + c2.NumberOfTents;
            int numFlesh = c1.NumberOfFleshLights + c2.NumberOfFleshLights;

            Camp newCamp = new Camp(lat, longitude, numOfPeople, numTents, numFlesh);
            return newCamp;
        }
  

     
 
    }

    }


