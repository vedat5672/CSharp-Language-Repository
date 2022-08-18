using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface CustomerDal
    {
        void Add();
        void Update();
        void Delete();
        void DeleteAll();
        void DeleteByName(string name);
        void DeleteById(int id);
        void CheckCustomer();
        void CheckCustomerByName(string name);
        void CheckCustomerById(int id);
        void UpdateCustomerByName(string name);
        void UpdateCustomerById(int id);
        void Get();
        void GetByName(string name);
        void GetById(int id);
        

    }

}