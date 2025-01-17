﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="WildGums">
//   Copyright (c) 2008 - 2015 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.FileAssociation.Example.NET40
{
    using System.Globalization;
    using System.Windows;
    using Catel.IoC;
    using Catel.Logging;
    using Catel.Services;
    using Catel.Windows;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
#if DEBUG
            LogManager.AddDebugListener(false);
#endif
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var languageService = ServiceLocator.Default.ResolveType<ILanguageService>();

            // Note: it's best to use .CurrentUICulture in actual apps since it will use the preferred language
            // of the user. But in order to demo multilingual features for devs (who mostly have en-US as .CurrentUICulture),
            // we use .CurrentCulture for the sake of the demo
            languageService.PreferredCulture = CultureInfo.CurrentCulture;
            languageService.FallbackCulture = new CultureInfo("en-US");

            base.OnStartup(e);

            StyleHelper.CreateStyleForwardersForDefaultStyles();
        }
    }
}