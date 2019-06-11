﻿using System;

namespace NetworkProtocols
{
	// Token: 0x02000570 RID: 1392
	public class RequestFullPlayerAccountPush : BotNetMessage
	{
		// Token: 0x06002F98 RID: 12184 RVA: 0x000194C3 File Offset: 0x000176C3
		public RequestFullPlayerAccountPush()
		{
			this.InitRefTypes();
			base.PacketType = 562925610u;
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x000194DC File Offset: 0x000176DC
		public RequestFullPlayerAccountPush(ulong sessionToken)
		{
			this.InitRefTypes();
			base.SessionToken = sessionToken;
			base.PacketType = 562925610u;
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x000FBBEC File Offset: 0x000F9DEC
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

		// Token: 0x06002F9B RID: 12187 RVA: 0x000FBC5C File Offset: 0x000F9E5C
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

		// Token: 0x06002F9C RID: 12188 RVA: 0x000167D3 File Offset: 0x000149D3
		private void InitRefTypes()
		{
			base.RequestID = uint.MaxValue;
		}

		// Token: 0x04001B42 RID: 6978
		public const uint cPacketType = 562925610u;
	}
}
