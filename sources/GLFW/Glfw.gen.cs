using System.Runtime.CompilerServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.GLFW;

partial class Glfw(INativeContext nativeContext) : IDisposable
{
    public partial class ThisThread : IGlfw.Static<ThisThread>
    {
        public static System.Threading.ThreadLocal<IGlfw> Underlying { get; } =
            new(static () => new StaticWrapper<DllImport>());

        public static void MakeCurrent(IGlfw ctx) => Underlying.Value = ctx;
    }

    public static IGlfw Create() => new StaticWrapper<DllImport>();

    public static IGlfw Create(INativeContext ctx) => new Glfw(ctx);

    /// <inheritdoc/>
    public void Dispose() => nativeContext.Dispose();
}
