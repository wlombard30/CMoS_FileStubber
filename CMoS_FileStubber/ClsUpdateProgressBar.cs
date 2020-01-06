using System.Windows.Forms;

namespace CMoS_FileStubber
{
    public class UpdateProgressbarDuringWrite
    {
        internal delegate void UpdateProgressDelegate(int ProgressPercentage);

        internal event UpdateProgressDelegate UpdateProgress;

        internal void DoSomething()
        {

            for (int i = 0; i <= 100; i++)
            {

                System.Threading.Thread.Sleep(100);

                UpdateProgress(i);

                Application.DoEvents();

            }

        }
    }
}
