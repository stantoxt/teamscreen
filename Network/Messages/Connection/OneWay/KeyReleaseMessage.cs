﻿using System;
using LiteNetLib.Utils;

namespace Network.Messages.Connection.OneWay
{
	public class KeyReleaseMessage: BaseMessage
	{
		public uint Key { get; set; }
		public String HostSystemId { get; set; }
		public String ClientSystemId { get; set; }

		public KeyReleaseMessage()
			: base((ushort)CustomMessageType.KeyRelease)
		{
		}

		public override void WritePayload(NetDataWriter message)
		{
			base.WritePayload(message);
			message.Put(HostSystemId);
			message.Put(ClientSystemId);
			message.Put(Key);

		}

		public override void ReadPayload(NetDataReader message)
		{
			base.ReadPayload(message);
			HostSystemId = message.GetString(100);
			ClientSystemId = message.GetString(100);
			Key = message.GetUInt();
		}
	}
}