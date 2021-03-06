using SoulWorkerResearch.SoulCore.IO.Network.Attributes;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoulWorkerResearch.SoulCore.IO.Network.Requests
{

    public readonly struct CubeQuickSlotsUpdateRequest
    {
        public IReadOnlyList<int> Values { get; }

        public CubeQuickSlotsUpdateRequest(BinaryReader br) => Values = Enumerable.Range(1, CommonDefines.QuickSlotsCubeCount).Select(_ => br.ReadInt32()).ToArray();
    }
}
