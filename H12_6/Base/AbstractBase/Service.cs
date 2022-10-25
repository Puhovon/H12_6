using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace H12_6
{
    abstract class Service
    {
        private MainWindow w;

        Repository rep;

        public ClientsList cl;

        public ObservableCollection<Client> clientsToClientList;

        public Service(MainWindow w)
        {
            this.w = w;
            rep = new Repository();
            clientsToClientList = rep.ReadData();
            cl = new ClientsList(clientsToClientList);
        }
    }
}
