using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H12_6
{
    internal class Repository
    {
        public ObservableCollection<Client> ReadData(string path = "Data.txt")
        {
            ObservableCollection<Client> collection = new ObservableCollection<Client>();
            string stringData = "";
            int index = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    index++;
                    stringData += sr.ReadLine();
                    string[] splitData = stringData.Split('#');
                    if (splitData.Length == 5)
                    {
                        Client clientToAdd = new Client(splitData[0], splitData[1], splitData[2], splitData[3], splitData[4], DateTime.Now, "God");
                        collection.Add(clientToAdd);
                        Array.Clear(splitData, 0, splitData.Length);
                        stringData = "";
                    }
                    else if (splitData.Length == 7)
                    {
                        Client clientToAdd = new Client(splitData[0], splitData[1], splitData[2], splitData[3], splitData[4], Convert.ToDateTime(splitData[5]), splitData[6]);
                        collection.Add(clientToAdd);
                        Array.Clear(splitData, 0, splitData.Length);
                        stringData = "";
                    }
                }
            }
            return collection;
        }

        public void SaveDataToFile(ObservableCollection<Client> collectionOfClients,string path = "Data.txt")
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach(Client client in collectionOfClients)
                {
                    sw.Write($"{client.FirstName}#{client.MidleName}#{client.LastName}#{client.PhoneNumber}#{client.PassportData}#{client.DateOfChange}#{client.WhoChanged}\n");
                }
            }
        }
    }
}
