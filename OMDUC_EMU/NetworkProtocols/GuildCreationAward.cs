﻿using System;

namespace NetworkProtocols
{
	// Token: 0x02000552 RID: 1362
	public class GuildCreationAward : BaseAwardItem
	{
		// Token: 0x06002E78 RID: 11896 RVA: 0x00018A27 File Offset: 0x00016C27
		public GuildCreationAward()
		{
			this.InitRefTypes();
			this.UniqueClassID = 2917253745u;
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x000FEC8C File Offset: 0x000FCE8C
		public override byte[] SerializeMessage()
		{
			byte[] newArray = ArrayManager.GetNewArray();
			int num = 0;
			byte[] array = base.SerializeMessage();
			if (array.Length + num > newArray.Length)
			{
				Array.Resize<byte>(ref newArray, array.Length + num);
			}
			Array.Copy(array, 0, newArray, num, array.Length);
			num += array.Length;
			Array.Resize<byte>(ref newArray, num);
			return newArray;
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x000FECDC File Offset: 0x000FCEDC
		public override void DeserializeMessage(byte[] data)
		{
			int num = 0;
			byte[] array = new byte[data.Length - num];
			Array.Copy(data, num, array, 0, array.Length);
			base.DeserializeMessage(array);
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x00006297 File Offset: 0x00004497
		private void InitRefTypes()
		{
		}
	}
}
