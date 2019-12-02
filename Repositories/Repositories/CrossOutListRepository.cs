using Entities.DbEntities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Repositories.Repositories
{
    public class CrossOutListRepository : ICrossOutListRepository
    {
        public ApplicationDbContext DbContext
        {            
            get
            {
                if (HttpContext.Current.Items["ApplicationDbContext"] == null)
                {
                    var context = new ApplicationDbContext();
                    HttpContext.Current.Items["ApplicationDbContext"] = context;
                    return context;
                }
                else
                {
                    return (ApplicationDbContext)HttpContext.Current.Items["ApplicationDbContext"];
                }
            }
        }

        public void Update(ApplicationUser user)
        {
        }
    }
}
