// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AllowPartiallyTrustedCallers]
[assembly: ReferenceAssembly]
[assembly: AssemblyTitle("Microsoft.Extensions.DependencyModel")]
[assembly: AssemblyDescription("Microsoft.Extensions.DependencyModel")]
[assembly: AssemblyDefaultAlias("Microsoft.Extensions.DependencyModel")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("2.1.0")]
[assembly: AssemblyInformationalVersion("2.1.0 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("2.1.0.0")]




namespace Microsoft.Extensions.DependencyModel
{
    public partial class CompilationLibrary : Microsoft.Extensions.DependencyModel.Library
    {
        public CompilationLibrary(string type, string name, string version, string hash, System.Collections.Generic.IEnumerable<string> assemblies, System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.Dependency> dependencies, bool serviceable) : base (default(string), default(string), default(string), default(string), default(System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.Dependency>), default(bool)) { }
        public CompilationLibrary(string type, string name, string version, string hash, System.Collections.Generic.IEnumerable<string> assemblies, System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.Dependency> dependencies, bool serviceable, string path, string hashPath) : base (default(string), default(string), default(string), default(string), default(System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.Dependency>), default(bool)) { }
        public System.Collections.Generic.IReadOnlyList<string> Assemblies { get { throw null; } }
    }
    public partial class CompilationOptions
    {
        public CompilationOptions(System.Collections.Generic.IEnumerable<string> defines, string languageVersion, string platform, System.Nullable<bool> allowUnsafe, System.Nullable<bool> warningsAsErrors, System.Nullable<bool> optimize, string keyFile, System.Nullable<bool> delaySign, System.Nullable<bool> publicSign, string debugType, System.Nullable<bool> emitEntryPoint, System.Nullable<bool> generateXmlDocumentation) { }
        public System.Nullable<bool> AllowUnsafe { get { throw null; } }
        public string DebugType { get { throw null; } }
        public static Microsoft.Extensions.DependencyModel.CompilationOptions Default { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Defines { get { throw null; } }
        public System.Nullable<bool> DelaySign { get { throw null; } }
        public System.Nullable<bool> EmitEntryPoint { get { throw null; } }
        public System.Nullable<bool> GenerateXmlDocumentation { get { throw null; } }
        public string KeyFile { get { throw null; } }
        public string LanguageVersion { get { throw null; } }
        public System.Nullable<bool> Optimize { get { throw null; } }
        public string Platform { get { throw null; } }
        public System.Nullable<bool> PublicSign { get { throw null; } }
        public System.Nullable<bool> WarningsAsErrors { get { throw null; } }
    }
    public partial struct Dependency
    {
        private object _dummy;
        public Dependency(string name, string version) { throw null; }
        public string Name { get { throw null; } }
        public string Version { get { throw null; } }
        public bool Equals(Microsoft.Extensions.DependencyModel.Dependency other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class DependencyContext
    {
        public DependencyContext(Microsoft.Extensions.DependencyModel.TargetInfo target, Microsoft.Extensions.DependencyModel.CompilationOptions compilationOptions, System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.CompilationLibrary> compileLibraries, System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.RuntimeLibrary> runtimeLibraries, System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.RuntimeFallbacks> runtimeGraph) { }
        public Microsoft.Extensions.DependencyModel.CompilationOptions CompilationOptions { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.DependencyModel.CompilationLibrary> CompileLibraries { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.DependencyModel.RuntimeFallbacks> RuntimeGraph { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.DependencyModel.RuntimeLibrary> RuntimeLibraries { get { throw null; } }
        public Microsoft.Extensions.DependencyModel.TargetInfo Target { get { throw null; } }
        public Microsoft.Extensions.DependencyModel.DependencyContext Merge(Microsoft.Extensions.DependencyModel.DependencyContext other) { throw null; }
    }
    public static partial class DependencyContextExtensions
    {
        public static System.Collections.Generic.IEnumerable<System.Reflection.AssemblyName> GetDefaultAssemblyNames(this Microsoft.Extensions.DependencyModel.DependencyContext self) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Reflection.AssemblyName> GetDefaultAssemblyNames(this Microsoft.Extensions.DependencyModel.RuntimeLibrary self, Microsoft.Extensions.DependencyModel.DependencyContext context) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> GetDefaultNativeAssets(this Microsoft.Extensions.DependencyModel.DependencyContext self) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> GetDefaultNativeAssets(this Microsoft.Extensions.DependencyModel.RuntimeLibrary self, Microsoft.Extensions.DependencyModel.DependencyContext context) { throw null; }
        public static System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.RuntimeFile> GetDefaultNativeRuntimeFileAssets(this Microsoft.Extensions.DependencyModel.DependencyContext self) { throw null; }
        public static System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.RuntimeFile> GetDefaultNativeRuntimeFileAssets(this Microsoft.Extensions.DependencyModel.RuntimeLibrary self, Microsoft.Extensions.DependencyModel.DependencyContext context) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Reflection.AssemblyName> GetRuntimeAssemblyNames(this Microsoft.Extensions.DependencyModel.DependencyContext self, string runtimeIdentifier) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Reflection.AssemblyName> GetRuntimeAssemblyNames(this Microsoft.Extensions.DependencyModel.RuntimeLibrary self, Microsoft.Extensions.DependencyModel.DependencyContext context, string runtimeIdentifier) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> GetRuntimeNativeAssets(this Microsoft.Extensions.DependencyModel.DependencyContext self, string runtimeIdentifier) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> GetRuntimeNativeAssets(this Microsoft.Extensions.DependencyModel.RuntimeLibrary self, Microsoft.Extensions.DependencyModel.DependencyContext context, string runtimeIdentifier) { throw null; }
        public static System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.RuntimeFile> GetRuntimeNativeRuntimeFileAssets(this Microsoft.Extensions.DependencyModel.DependencyContext self, string runtimeIdentifier) { throw null; }
        public static System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.RuntimeFile> GetRuntimeNativeRuntimeFileAssets(this Microsoft.Extensions.DependencyModel.RuntimeLibrary self, Microsoft.Extensions.DependencyModel.DependencyContext context, string runtimeIdentifier) { throw null; }
    }
    public partial class DependencyContextJsonReader : Microsoft.Extensions.DependencyModel.IDependencyContextReader, System.IDisposable
    {
        public DependencyContextJsonReader() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public Microsoft.Extensions.DependencyModel.DependencyContext Read(System.IO.Stream stream) { throw null; }
        public System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.Dependency> ReadTargetLibraryDependencies(Newtonsoft.Json.JsonTextReader reader) { throw null; }
    }
    public partial class DependencyContextWriter
    {
        public DependencyContextWriter() { }
        public void Write(Microsoft.Extensions.DependencyModel.DependencyContext context, System.IO.Stream stream) { }
    }
    public partial interface IDependencyContextReader : System.IDisposable
    {
        Microsoft.Extensions.DependencyModel.DependencyContext Read(System.IO.Stream stream);
    }
    public partial class Library
    {
        public Library(string type, string name, string version, string hash, System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.Dependency> dependencies, bool serviceable) { }
        public Library(string type, string name, string version, string hash, System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.Dependency> dependencies, bool serviceable, string path, string hashPath) { }
        public Library(string type, string name, string version, string hash, System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.Dependency> dependencies, bool serviceable, string path, string hashPath, string runtimeStoreManifestName = null) { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.DependencyModel.Dependency> Dependencies { get { throw null; } }
        public string Hash { get { throw null; } }
        public string HashPath { get { throw null; } }
        public string Name { get { throw null; } }
        public string Path { get { throw null; } }
        public string RuntimeStoreManifestName { get { throw null; } }
        public bool Serviceable { get { throw null; } }
        public string Type { get { throw null; } }
        public string Version { get { throw null; } }
    }
    public partial class ResourceAssembly
    {
        public ResourceAssembly(string path, string locale) { }
        public string Locale { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
    }
    public partial class RuntimeAssembly
    {
        public RuntimeAssembly(string assemblyName, string path) { }
        public System.Reflection.AssemblyName Name { get { throw null; } }
        public string Path { get { throw null; } }
        public static Microsoft.Extensions.DependencyModel.RuntimeAssembly Create(string path) { throw null; }
    }
    public partial class RuntimeAssetGroup
    {
        public RuntimeAssetGroup(string runtime, System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.RuntimeFile> runtimeFiles) { }
        public RuntimeAssetGroup(string runtime, System.Collections.Generic.IEnumerable<string> assetPaths) { }
        public RuntimeAssetGroup(string runtime, params string[] assetPaths) { }
        public System.Collections.Generic.IReadOnlyList<string> AssetPaths { get { throw null; } }
        public string Runtime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.DependencyModel.RuntimeFile> RuntimeFiles { get { throw null; } }
    }
    public partial class RuntimeFallbacks
    {
        public RuntimeFallbacks(string runtime, System.Collections.Generic.IEnumerable<string> fallbacks) { }
        public RuntimeFallbacks(string runtime, params string[] fallbacks) { }
        public System.Collections.Generic.IReadOnlyList<string> Fallbacks { get { throw null; } set { } }
        public string Runtime { get { throw null; } set { } }
    }
    public partial class RuntimeFile
    {
        public RuntimeFile(string path, string assemblyVersion, string fileVersion) { }
        public string AssemblyVersion { get { throw null; } }
        public string FileVersion { get { throw null; } }
        public string Path { get { throw null; } }
    }
    public partial class RuntimeLibrary : Microsoft.Extensions.DependencyModel.Library
    {
        public RuntimeLibrary(string type, string name, string version, string hash, System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.DependencyModel.RuntimeAssetGroup> runtimeAssemblyGroups, System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.DependencyModel.RuntimeAssetGroup> nativeLibraryGroups, System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.ResourceAssembly> resourceAssemblies, System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.Dependency> dependencies, bool serviceable) : base (default(string), default(string), default(string), default(string), default(System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.Dependency>), default(bool)) { }
        public RuntimeLibrary(string type, string name, string version, string hash, System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.DependencyModel.RuntimeAssetGroup> runtimeAssemblyGroups, System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.DependencyModel.RuntimeAssetGroup> nativeLibraryGroups, System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.ResourceAssembly> resourceAssemblies, System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.Dependency> dependencies, bool serviceable, string path, string hashPath) : base (default(string), default(string), default(string), default(string), default(System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.Dependency>), default(bool)) { }
        public RuntimeLibrary(string type, string name, string version, string hash, System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.DependencyModel.RuntimeAssetGroup> runtimeAssemblyGroups, System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.DependencyModel.RuntimeAssetGroup> nativeLibraryGroups, System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.ResourceAssembly> resourceAssemblies, System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.Dependency> dependencies, bool serviceable, string path, string hashPath, string runtimeStoreManifestName) : base (default(string), default(string), default(string), default(string), default(System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.Dependency>), default(bool)) { }
        public System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.DependencyModel.RuntimeAssetGroup> NativeLibraryGroups { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.DependencyModel.ResourceAssembly> ResourceAssemblies { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Microsoft.Extensions.DependencyModel.RuntimeAssetGroup> RuntimeAssemblyGroups { get { throw null; } }
    }
    public partial class TargetInfo
    {
        public TargetInfo(string framework, string runtime, string runtimeSignature, bool isPortable) { }
        public string Framework { get { throw null; } }
        public bool IsPortable { get { throw null; } }
        public string Runtime { get { throw null; } }
        public string RuntimeSignature { get { throw null; } }
    }
}
namespace Microsoft.Extensions.DependencyModel.Resolution
{
    public partial class CompositeCompilationAssemblyResolver : Microsoft.Extensions.DependencyModel.Resolution.ICompilationAssemblyResolver
    {
        public CompositeCompilationAssemblyResolver(Microsoft.Extensions.DependencyModel.Resolution.ICompilationAssemblyResolver[] resolvers) { }
        public bool TryResolveAssemblyPaths(Microsoft.Extensions.DependencyModel.CompilationLibrary library, System.Collections.Generic.List<string> assemblies) { throw null; }
    }
    public partial class DotNetReferenceAssembliesPathResolver
    {
        public static readonly string DotNetReferenceAssembliesPathEnv;
        public DotNetReferenceAssembliesPathResolver() { }
        public static string Resolve() { throw null; }
    }
    public partial interface ICompilationAssemblyResolver
    {
        bool TryResolveAssemblyPaths(Microsoft.Extensions.DependencyModel.CompilationLibrary library, System.Collections.Generic.List<string> assemblies);
    }
    public partial class PackageCompilationAssemblyResolver : Microsoft.Extensions.DependencyModel.Resolution.ICompilationAssemblyResolver
    {
        public PackageCompilationAssemblyResolver() { }
        public PackageCompilationAssemblyResolver(string nugetPackageDirectory) { }
        public bool TryResolveAssemblyPaths(Microsoft.Extensions.DependencyModel.CompilationLibrary library, System.Collections.Generic.List<string> assemblies) { throw null; }
    }
    public partial class ReferenceAssemblyPathResolver : Microsoft.Extensions.DependencyModel.Resolution.ICompilationAssemblyResolver
    {
        public ReferenceAssemblyPathResolver() { }
        public ReferenceAssemblyPathResolver(string defaultReferenceAssembliesPath, string[] fallbackSearchPaths) { }
        public bool TryResolveAssemblyPaths(Microsoft.Extensions.DependencyModel.CompilationLibrary library, System.Collections.Generic.List<string> assemblies) { throw null; }
    }
}
namespace System.Collections.Generic
{
    public static partial class CollectionExtensions
    {
        public static System.Collections.Generic.IEnumerable<string> GetDefaultAssets(this System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.RuntimeAssetGroup> self) { throw null; }
        public static Microsoft.Extensions.DependencyModel.RuntimeAssetGroup GetDefaultGroup(this System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.RuntimeAssetGroup> self) { throw null; }
        public static System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.RuntimeFile> GetDefaultRuntimeFileAssets(this System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.RuntimeAssetGroup> self) { throw null; }
        public static System.Collections.Generic.IEnumerable<string> GetRuntimeAssets(this System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.RuntimeAssetGroup> self, string runtime) { throw null; }
        public static System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.RuntimeFile> GetRuntimeFileAssets(this System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.RuntimeAssetGroup> self, string runtime) { throw null; }
        public static Microsoft.Extensions.DependencyModel.RuntimeAssetGroup GetRuntimeGroup(this System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyModel.RuntimeAssetGroup> self, string runtime) { throw null; }
    }
}
