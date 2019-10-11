using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace _001_CreatingAnOpenTkWindow
{
    class Window : GameWindow
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.1f, 0.3f, 0.2f, 1f);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit);

            SwapBuffers();
        }
    }
}
