using eStore.BL.BO;
using System.Linq;

namespace eStore.DBO
{
    public class UserManager
    {        
        private eStoreDBContext db = new eStoreDBContext();

        public void Add(User user)
        {

            User sysUser = new User();
            sysUser.Name = user.Name;
            sysUser.Surname = user.Surname;
            sysUser.Phone = user.Phone;
            sysUser.LoginName = user.LoginName;
            sysUser.Password = user.Password;

            db.User.Add(sysUser);
            db.SaveChanges();
        }

        public bool IsUserLoginIDExist(string userLogIn)
        {
            return (from o in db.User where o.LoginName == userLogIn select o).Any();
        }

        public string GetUserPassword(string userLogIn)
        {
            var user = from o in db.User where o.LoginName == userLogIn select o;
            if (user.ToList().Count > 0)
                return user.First().Password;
            else
                return string.Empty;
        }
    }
}
