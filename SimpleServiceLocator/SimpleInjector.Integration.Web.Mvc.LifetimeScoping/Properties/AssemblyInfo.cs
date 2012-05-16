﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SimpleInjector.Integration.Web.Mvc.LifetimeScoping")]
[assembly: AssemblyDescription("Integrates lifetime scoping with ASP.NET MVC3 and up for the Simple Injector Inversion of Control library.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Cutting Edge Internet Technologies")]
[assembly: AssemblyProduct("SimpleInjector.Integration.Web.Mvc.LifetimeScoping")]
[assembly: AssemblyCopyright("Copyright © 2012 S. van Deursen")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("4451210c-795b-4d20-bf36-680bc7472d1d")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: CLSCompliant(true)]
[assembly: NeutralResourcesLanguageAttribute("en-US")]

[assembly: AllowPartiallyTrustedCallers]

[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
    MessageId = "Mvc",
    Justification = "Mvc is the word")]

[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
    Scope = "namespace",
    Target = "SimpleInjector.Integration.Web.Mvc.LifetimeScoping",
    MessageId = "Mvc",
    Justification = "Mvc is the word")]