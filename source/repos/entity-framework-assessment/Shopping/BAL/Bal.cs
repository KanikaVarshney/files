using System.Data;
using Shopping.BusinessObject.models;
using Shopping.DAL.Context;

namespace BAL
{
    public class Bal
    {
        DAL dal = new DAL.Dal();

        public int AddUser(User user)
        {
            dal.AddUser(user);
            return 0;
        }
        public Role GetRole()
        {
            return dal.GetRole();
        }
    }
}