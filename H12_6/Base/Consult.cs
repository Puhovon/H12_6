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
    internal class Consult : Service, IViewData, IChangeData
    {
        MainWindow w;
        Repository rep;
        public Consult(MainWindow w) : base(w)
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
                    if (w.ComboBox_1.SelectedIndex == 0 || w.ComboBox_1.SelectedIndex == 1 ||
                        w.ComboBox_1.SelectedIndex == 2 || w.ComboBox_1.SelectedIndex == 4)
                    {
                        MessageBox.Show("Warning");
                    }
                    else
                    {
                        Client temp = new Client(client.FirstName, client.MidleName, client.LastName,
                            (w.TextBoxToChange.Text != string.Empty) ? w.TextBoxToChange.Text : client.PhoneNumber,
                            client.PassportData, DateTime.Now, "Consult");
                        cl.clientsList[w.logList.SelectedIndex] = temp;
                        w.logList.Items[w.logList.SelectedIndex] = temp;
                        rep.SaveDataToFile(cl.clientsList);
                        break;
                    }
                }
            }
        }

        public void ViewClientData()
        {
            w.logList.Items.Clear();
            foreach (Client cl in cl.clientsList)
            {
                Client temp = new Client(cl.MidleName, cl.FirstName, cl.LastName, cl.PhoneNumber, "*********", cl.DateOfChange, cl.WhoChanged);
                w.logList.Items.Add(temp);
            }
        }
    }
}
