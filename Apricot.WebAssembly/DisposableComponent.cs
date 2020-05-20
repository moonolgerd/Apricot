using Microsoft.AspNetCore.Components;
using System;
using System.Diagnostics;

namespace Apricot
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class DisposableComponent : ComponentBase, IDisposable
    {
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
