﻿
namespace YooAsset
{
	public interface IDecryptServices
	{
		EDecryptMethod DecryptType { get; }

		/// <summary>
		/// 获取解密的数据偏移
		/// </summary>
		ulong GetDecryptOffset(AssetBundleInfo bundleInfo);

		/// <summary>
		/// 获取解密的字节数据
		/// </summary>
		byte[] GetDecryptBinary(AssetBundleInfo bundleInfo);
	}
}