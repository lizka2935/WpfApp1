using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Model;

namespace WpfApp1.Controllers
{
    public class ZakController
    {
        Core db=new Core();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idOrder"></param>
        /// <param name="seria"></param>
        /// <param name="servis"></param>
        /// <param name="prais"></param>
        /// <returns></returns>
        public bool AddZak(int idOrder, string seria, string servis,decimal prais)
        {
            try

            {
                zak newOrder = new zak()
                {
                  
                    seria = seria,
                    servis = servis,
                    prais = prais
                };

                db.context.zak.Add(newOrder);
                if (db.context.SaveChanges()>0)
                {
                    return true;
                }
                else { return false; }

                


            }
            catch
            {
                return false;
            }
        }    
    }
}
