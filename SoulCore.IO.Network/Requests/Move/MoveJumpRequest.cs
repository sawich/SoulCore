using SoulCore.Extensions;
using SoulCore.IO.Network.Attributes;
using SoulCore.IO.Network.Commands;
using SoulCore.IO.Network.Responses.Shared;
using System.IO;
using System.Numerics;

namespace SoulCore.IO.Network.Requests
{
    [Request(CategoryCommand.Move, MoveCommand.Jump)]
    public readonly struct MoveJumpRequest
    {
        public readonly int CharacterId;
        public readonly MapIdPacketSharedStructure MapId;
        public readonly Vector3 Position;
        public readonly float Yaw;
        public readonly Vector2 TargetPosition;
        public readonly int JumpingMove;
        public readonly int JumpDrop;
        public readonly int BonusJump;

        public MoveJumpRequest(BinaryReader br)
        {
            CharacterId = br.ReadInt32();
            MapId = new(br);
            Position = br.ReadVector3();
            Yaw = br.ReadSingle();
            TargetPosition = br.ReadVector2();
            JumpingMove = br.ReadInt32();
            JumpDrop = br.ReadInt32();
            BonusJump = br.ReadInt32();
        }
    }
}