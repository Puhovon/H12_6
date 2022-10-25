using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H12_6
{
    internal class ClientsList
    {
        public ObservableCollection<Client> clientsList;

        public ClientsList(ObservableCollection<Client> _clientsList)
        {
            clientsList = new ObservableCollection<Client>();
            clientsList = _clientsList;
        }
    }
}
