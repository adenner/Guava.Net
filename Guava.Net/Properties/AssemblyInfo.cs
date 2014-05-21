using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

/*
 * Copyright (C) 2014 David Forshner
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Guava.Net")]
[assembly: AssemblyDescription("A Port of Google's Guava to C#")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("David Forshner")]
[assembly: AssemblyProduct("Guava.Net")]
[assembly: AssemblyCopyright("Copyright © David Forshner 2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("08291c0c-ffc0-4259-8691-897d777f66f7")]

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
[assembly: AssemblyVersion("0.1.*")]
[assembly: AssemblyFileVersion("0.1.0.0")]

// Make internal classes/methods available for testing
[assembly:InternalsVisibleTo("Guava.Net.Tests")]