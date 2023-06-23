using PavilionsWPF.data.entity;
using System;
using System.Linq;

namespace PavilionsWPF.data.Repository
{
    public class EfShoppingMall
    {
        public shops_centers DeleteSession(shops_centers entity) //Удаление ТЦ
        {
            try
            {
                using (db_PavilionsEntities db = new db_PavilionsEntities())
                {
                    var s1 = db.shops_centers.FirstOrDefault(x => x.status_id == entity.shop_center_id);
                    db.SaveChanges();
                    return s1;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
    }
}
