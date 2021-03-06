﻿using System;
using LiteNetLib.Utils;
using Messages.Connection;

namespace Messages.Connection
{
	public class StartScreenSharingMessage: BaseMessage
	{

		public StartScreenSharingMessage()
			: base((ushort)CustomMessageType.StartScreenSharing)
		{
     	}

		public override void WritePayload(NetDataWriter message)
		{
			base.WritePayload(message);
        }

		public override void ReadPayload(NetDataReader message)
		{
			base.ReadPayload(message);
		}
        

	}
}
