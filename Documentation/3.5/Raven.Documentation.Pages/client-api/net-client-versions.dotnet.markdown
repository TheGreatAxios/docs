# .NET Client versions

From version 3.5 there are two versions of the .NET Client available in each NuGet package.

## net45

This is a .NET Client that supports all the features described in the documentation and can be used in all applications that target **.NET Framework 4.5 or higher**.

## netstandard1.3

This client targets the netstandard1.3 profile which supports running on **.NET Framework 4.6+, .NET Core 1.0 and UWP (Universal Windows Platform) 10.0**.

Since this is a multi-platform profile then there are some features that are not supported:

- no DTC support,
- no `PrettifyGeneratedLinqExpressions` option in Conventions,
- ReplicationInformer does not support caching of Replication destinations

{INFO:Recommendation}

For applications that target full .NET Framework we suggest using **net45** client.

{INFO/}