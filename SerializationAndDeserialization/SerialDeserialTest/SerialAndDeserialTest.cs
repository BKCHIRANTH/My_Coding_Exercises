using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerializationAndDeserialization;

namespace SerialDeserialTest
{
    [TestClass]
    public class SerialAndDeserialTest
    {
        [TestMethod]
        public void SerialAndDeserialTest_01()
        {
            Student address = new Student { HouseNo = 11, StreetName = "Example_Street", City = "Mangalore", Country = "India" };
            String[] expectedResult = { "11", "Example_Street", "Mangalore", "India" };


            Serializer<Student> serilaizeAddress = new Serializer<Student>();
            string serailizedAddress = serilaizeAddress.SerializeData(address);
            Student result = serilaizeAddress.DeserializeData(serailizedAddress);
            String[] actualResult = new string[expectedResult.Length];
            actualResult[0] = result.HouseNo.ToString();
            actualResult[1] = result.StreetName;
            actualResult[2] = result.City;
            actualResult[3] = result.Country;

            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }


        }
    }
}
