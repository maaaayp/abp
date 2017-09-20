﻿using System;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Volo.Abp.AspNetCore.Mvc
{
    public class AbpControllerAssemblySetting
    {
        public Assembly Assembly { get; }

        public string RootPath { get; }

        public Func<Type, bool> TypePredicate { get; set; }

        public Action<ControllerModel> ControllerModelConfigurer { get; set; }

        public AbpControllerAssemblySetting(Assembly assembly, string rootPath)
        {
            Assembly = assembly;
            RootPath = rootPath;

            TypePredicate = type => true;
            ControllerModelConfigurer = controller => { };
        }
    }
}