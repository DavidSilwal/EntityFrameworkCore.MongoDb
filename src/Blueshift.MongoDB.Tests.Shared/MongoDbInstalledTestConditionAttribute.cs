﻿using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore.TestUtilities.Xunit;

namespace Blueshift.MongoDB.Tests.Shared
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Assembly)]
    public class MongoDbInstalledTestConditionAttribute : Attribute, ITestCondition
    {
        public bool IsMet => RuntimeInformation.IsOSPlatform(OSPlatform.Windows) && File.Exists(MongoDbConstants.MongodExe);

        public string SkipReason => "MongoDB is not installed on the local system or its location is unknown.";
    }
}