using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.DataContext
{
    public static class AppDbContext<T> where T : BaseEntity
    {
        public static List<T> Datas { get; set; } = new List<T>();


    }
}
