using Autofac;
using DiscountCrazyAdmin.Core;
using DiscountCrazyAdmin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCrazyAdmin.Autofac.Integration
{

    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DiscountCrazyAdminContext>().As<DbContext>();
            builder.RegisterType<DiscountCrazyAdminUnitOfWork>().As<IUnitOfWork>();
        }
    }
}
