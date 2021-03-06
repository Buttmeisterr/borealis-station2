﻿using ProtoBuf;
using VRage.ObjectBuilders;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_RemoteControlDefinition : MyObjectBuilder_ShipControllerDefinition
    {
        [ProtoMember]
        public float RequiredPowerInput;
    }
}
