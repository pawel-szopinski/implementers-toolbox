using AutoIt;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppAutomation
{
    public static class AutoImplementer
    {
        public static bool SendKeys(ushort iterations, string keyCombination, string window, IProgress<int> progress,
            ushort keyDelay = 150)
        {
            try
            {
                if (AutoItX.WinWaitActive(window, timeout: 15) == 1)
                {
                    if (MessageBox.Show(ActiveWindow.Active,
                        "Do you confirm that this is desired application instance and that cursor is set appropriately?",
                        "Confirmation Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return false;

                    Point mouseLocation = AutoItX.MouseGetPos();
                    int x = mouseLocation.X;
                    int y = mouseLocation.Y;

                    AutoItX.AutoItSetOption("SendKeyDelay", keyDelay);

                    AutoItX.Sleep(3000);

                    for (int i = 1; i <= iterations; i++)
                    {
                        mouseLocation = AutoItX.MouseGetPos();

                        if (mouseLocation.X - x < 150 && mouseLocation.X - x > -150 &&
                            mouseLocation.Y - y < 150 && mouseLocation.Y - y > -150)
                        {
                            progress.Report(i);
                            AutoItX.Send(keyCombination);
                        }
                        else
                        {
                            MessageBox.Show(ActiveWindow.Active, "Significant mouse move detected. Breaking execution.",
                                "Execution Stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }

                    return true;
                }

                MessageBox.Show("Application (" + window + ") window has not been activated within 15 seconds.",
                    "Execution Stopped", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            finally
            {
            }
        }

        /// <summary>
        ///     Implements IWin32Window where Handle returns the handle of the system's foreground window.
        ///     Can be used with MessageBox to display the box in front of the active window, such as:
        ///     MessageBox.Show(ActiveWindow.Active, "Hello, World!");
        ///     Used to get an IWin32Window for the active window.
        /// </summary>
        private class ActiveWindow : IWin32Window
        {
            #region Private Members

            /// <summary>Static instance to use for factory pattern.</summary>
            private static readonly ActiveWindow _window = new ActiveWindow();

            #endregion

            #region Construction

            /// <summary>Prevent external instantiation.</summary>
            private ActiveWindow()
            {
            }

            #endregion

            #region Public Properties

            /// <summary>Gets an IWin32Window for the active window.</summary>
            public static IWin32Window Active => _window;

            #endregion

            #region Private Functions

            /// <summary>Finds the frontmost window using the Win32 API.</summary>
            [DllImport("user32.dll")]
            private static extern int GetForegroundWindow();

            /// <summary>Gets a handle to the active window.</summary>
            IntPtr IWin32Window.Handle => new IntPtr(GetForegroundWindow());

            #endregion
        }
    }
}