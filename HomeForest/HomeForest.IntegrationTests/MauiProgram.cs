﻿using Xunit.Runners.Maui;

namespace HomeForest.IntegrationTests
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            return MauiApp
                .CreateBuilder()
                .ConfigureTests(new TestOptions
                {
                    Assemblies =  {
                        typeof(MauiProgram).Assembly
                    }
                })
                .UseVisualRunner()
                .Build();
        }
    }
}