﻿using System;

namespace NetworkProtocols
{
	// Token: 0x02000749 RID: 1865
	public class RequestLeaveGuild : BotNetMessage
	{
		// Token: 0x0600420A RID: 16906 RVA: 0x00025DFA File Offset: 0x00023FFA
		public RequestLeaveGuild()
		{
			this.InitRefTypes();
			base.PacketType = 3763689372u;
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x00025E13 File Offset: 0x00024013
		public RequestLeaveGuild(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 3763689372u;
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x000FBBEC File Offset: 0x000F9DEC
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int newSize = 0;
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.PacketType);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SessionToken);
			ArrayManager.WriteUInt64(ref newArray, ref newSize, base.SecurityToken);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, base.RequestID);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			ArrayManager.WriteUInt32(ref newArray, ref newSize, 0u);
			Array.Resize<byte>(ref newArray, newSize);
			return newArray;
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x000FBC5C File Offset: 0x000F9E5C
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			base.PacketType = ArrayManager.ReadUInt32(data, ref num);
			base.SessionToken = ArrayManager.ReadUInt64(data, ref num);
			base.SecurityToken = ArrayManager.ReadUInt64(data, ref num);
			base.RequestID = ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
			ArrayManager.ReadUInt32(data, ref num);
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x000167D3 File Offset: 0x000149D3
		private void InitRefTypes()
		{
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04002297 RID: 8855
		public const uint cPacketType = 3763689372u;
	}
}
