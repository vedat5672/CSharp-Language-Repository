using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Customer : CustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void CheckCustomer()
        {
            throw new NotImplementedException();
        }

        public void CheckCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public void CheckCustomerByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
