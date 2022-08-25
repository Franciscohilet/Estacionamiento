using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Data
{
    internal class Vehiculos
    {
        List<vehiculo> Vehiculos = new List<vehiculo>();

        public void Add(vehiculo aux)
        {
            if (!this.Exist(X.Name))
            {
                Vehiculos.Add(aux);
            }

        }

        public bool Exist(string nombre)
        {
            bool exist = false;

            foreach (User X in users)
            {
                if (X.Name == nombre)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }
        public void Delete(User X)
        {
            users.Remove(X);
        }

        public List<User> ViewList()
        {
            return users;
        }

        public User ViewUser(string name)
        {
            foreach (User user in users)
            {
                if (user.Name == name)
                {
                    return user;

                }
            }
            return null;
        }
        public void Update(User X)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Name == X.Name)
                {

                    users[i].Password = X.Password;
                }
            }
        }

        public int Count { get { return users.Count; } }
    }
}
}
