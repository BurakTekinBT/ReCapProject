﻿using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module //
    {
        protected override void Load(ContainerBuilder builder)
        {//içinde data tutmadığını bildiğimiz için tek bir instance oluşturuyoruz singleinstance ile
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance(); //eğer biri ICarService isterse ona bir tane car manager instance ver
            builder.RegisterType<EFCarDal>().As<ICarDal>().SingleInstance();
        }

    }
}
