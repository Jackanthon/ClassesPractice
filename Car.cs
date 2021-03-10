using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPractice
{
    class Car
    {
        public string make;
        public string model;
        public int year;
        public int mileage;
        public static int carCount = 0;


        public Car(string aMake, string aModel, int aYear, int aMileage)
        {
            make = aMake;
            model = aModel;
            year = aYear;
            mileage = aMileage;
            carCount++;
        }
        public bool New()
        {
            if (year >= 2020)
            {
                return true;
            }
            return false;
        }

    }
}
