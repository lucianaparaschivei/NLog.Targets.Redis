﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// allow access to internals by unit test dll
[assembly: InternalsVisibleTo("NLog.Targets.Redis.Tests")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("cd9e781e-e999-4547-b43f-788c562055be")]