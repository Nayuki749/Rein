using Rein.Utility;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// アセンブリに関する一般情報は以下の属性セットをとおして制御されます。
// アセンブリに関連付けられている情報を変更するには、
// これらの属性値を変更してください。
[assembly: AssemblyTitle("BasicPlugins")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("BasicPlugins")]
[assembly: AssemblyCopyright("Copyright ©  2021 Nayuki749")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// ComVisible を false に設定すると、このアセンブリ内の型は COM コンポーネントから
// 参照できなくなります。COM からこのアセンブリ内の型にアクセスする必要がある場合は、
// その型の ComVisible 属性を true に設定してください。
[assembly: ComVisible(false)]

// このプロジェクトが COM に公開される場合、次の GUID が typelib の ID になります
[assembly: Guid("e23bf2d8-1e69-42b9-9fe1-7c34e523190d")]

// アセンブリのバージョン情報は次の 4 つの値で構成されています:
//
//      メジャー バージョン
//      マイナー バージョン
//      ビルド番号
//      Revision
//
// すべての値を指定するか、次を使用してビルド番号とリビジョン番号を既定に設定できます
// 以下のように '*' を使用します:
// [assembly: AssemblyVersion("1.0.*")]
//[assembly: AssemblyVersion("0.0.1.0")]
//[assembly: AssemblyFileVersion("0.0.1.0")]
[assembly: AssemblyVersion(Common.MAJOR + "." + Common.MINOR + "." + Common.RELEASE + "." + Common.BUILD)]
[assembly: AssemblyFileVersion(Common.MAJOR + "." + Common.MINOR + "." + Common.RELEASE + "." + Common.BUILD)]
[assembly: AssemblyInformationalVersion(Common.PRODUCT_VERSION)]
