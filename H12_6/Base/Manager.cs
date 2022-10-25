using H12_6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace H12_6.Base
{
    internal class Manager : Service, IViewData, IChangeData
    {
        MainWindow w;
        Repository rep;
        public Manager(MainWindow w) : base(w)
        {
            this.w = w;
            rep = new Repository();
        }

        public void ChangeData()
        {
            for (int i = 0; i < cl.clientsList.Count; i++)
            {
                if (i == w.logList.SelectedIndex)
                {
                    Client client = cl.clientsList[i];

                    if (w.ComboBox_1.SelectedIndex == 0)
                    {

                        Client temp = new Client(
                            (w.TextBoxToChange.Text != string.Empty) ? w.TextBoxToChange.Text : client.FirstName,
                            client.MidleName, client.LastName,
                            client.PhoneNumber, client.PassportData, DateTime.Now, "Manager");
                        cl.clientsList[w.logList.SelectedIndex] = temp;
                        w.logList.Items[w.logList.SelectedIndex] = temp;
                        rep.SaveDataToFile(cl.clientsList);
                        break;
                    }
                    else if (w.ComboBox_1.SelectedIndex == 1)
                    {

                        Client temp = new Client(client.FirstName,
                            (w.TextBoxToChange.Text != string.Empty) ? w.TextBoxToChange.Text : client.MidleName,
                            client.LastName,
                            client.PhoneNumber, client.PassportData, DateTime.Now, "Manager");
                        cl.clientsList[w.logList.SelectedIndex] = temp;
                        w.logList.Items[w.logList.SelectedIndex] = temp;
                        rep.SaveDataToFile(cl.clientsList);
                        break;
                    }
                    else if (w.ComboBox_1.SelectedIndex == 2)
                    {

                        Client temp = new Client(client.FirstName, client.MidleName,
                            (w.TextBoxToChange.Text != string.Empty) ? w.TextBoxToChange.Text : client.LastName,
                            client.PhoneNumber, client.PassportData, DateTime.Now, "Manager");
                        cl.clientsList[w.logList.SelectedIndex] = temp;
                        w.logList.Items[w.logList.SelectedIndex] = temp;
                        rep.SaveDataToFile(cl.clientsList);
                        break;
                    }
                    else if (w.ComboBox_1.SelectedIndex == 3)
                    {

                        Client temp = new Client(client.FirstName, client.MidleName, client.LastName,
                            (w.TextBoxToChange.Text != string.Empty) ? w.TextBoxToChange.Text : client.PhoneNumber,
                            client.PassportData, DateTime.Now, "Manager");
                        cl.clientsList[w.logList.SelectedIndex] = temp;
                        w.logList.Items[w.logList.SelectedIndex] = temp;
                        rep.SaveDataToFile(cl.clientsList);
                        break;
                    }
                    else if (w.ComboBox_1.SelectedIndex == 4)
                    {

                        Client temp = new Client(client.FirstName, client.MidleName, client.LastName,
                            client.PhoneNumber,
                            (w.TextBoxToChange.Text != string.Empty) ? w.TextBoxToChange.Text : client.PassportData,
                            DateTime.Now, "Manager");
                        cl.clientsList[w.logList.SelectedIndex] = temp;
                        w.logList.Items[w.logList.SelectedIndex] = temp;
                        rep.SaveDataToFile(cl.clientsList);
                        break;
                    }
                }
            }
        }

        public void CreateNewClient()
        {
            string[] splitData = w.TextBoxToChange.Text.Split('#');
            Client temp = new Client(splitData[0], splitData[1], splitData[2], splitData[3], splitData[4], DateTime.Now,
                "Manager");
            cl.clientsList.Add(temp);
            rep.SaveDataToFile(cl.clientsList);
            ViewClientData();
        }

        public void ViewClientData()
        {
            w.logList.Items.Clear();
            foreach (Client cl in cl.clientsList)
            {
                Client temp = new Client(cl.MidleName, cl.FirstName, cl.LastName, cl.PhoneNumber, cl.PassportData, cl.DateOfChange, cl.WhoChanged);
                w.logList.Items.Add(temp);
            }
        }
    }
}
