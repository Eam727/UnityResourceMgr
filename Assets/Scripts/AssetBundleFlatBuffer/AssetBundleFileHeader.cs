// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace AssetBundleFlatBuffer
{

using global::System;
using global::FlatBuffers;

public struct AssetBundleFileHeader : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static AssetBundleFileHeader GetRootAsAssetBundleFileHeader(ByteBuffer _bb) { return GetRootAsAssetBundleFileHeader(_bb, new AssetBundleFileHeader()); }
  public static AssetBundleFileHeader GetRootAsAssetBundleFileHeader(ByteBuffer _bb, AssetBundleFileHeader obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public AssetBundleFileHeader __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int SubFileCount { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int DependFileCount { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool IsScene { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsMainAsset { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int CompressType { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string AbFileName { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetAbFileNameBytes() { return __p.__vector_as_arraysegment(14); }

  public static Offset<AssetBundleFileHeader> CreateAssetBundleFileHeader(FlatBufferBuilder builder,
      int subFileCount = 0,
      int dependFileCount = 0,
      bool isScene = false,
      bool isMainAsset = false,
      int compressType = 0,
      StringOffset abFileNameOffset = default(StringOffset)) {
    builder.StartObject(6);
    AssetBundleFileHeader.AddAbFileName(builder, abFileNameOffset);
    AssetBundleFileHeader.AddCompressType(builder, compressType);
    AssetBundleFileHeader.AddDependFileCount(builder, dependFileCount);
    AssetBundleFileHeader.AddSubFileCount(builder, subFileCount);
    AssetBundleFileHeader.AddIsMainAsset(builder, isMainAsset);
    AssetBundleFileHeader.AddIsScene(builder, isScene);
    return AssetBundleFileHeader.EndAssetBundleFileHeader(builder);
  }

  public static void StartAssetBundleFileHeader(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddSubFileCount(FlatBufferBuilder builder, int subFileCount) { builder.AddInt(0, subFileCount, 0); }
  public static void AddDependFileCount(FlatBufferBuilder builder, int dependFileCount) { builder.AddInt(1, dependFileCount, 0); }
  public static void AddIsScene(FlatBufferBuilder builder, bool isScene) { builder.AddBool(2, isScene, false); }
  public static void AddIsMainAsset(FlatBufferBuilder builder, bool isMainAsset) { builder.AddBool(3, isMainAsset, false); }
  public static void AddCompressType(FlatBufferBuilder builder, int compressType) { builder.AddInt(4, compressType, 0); }
  public static void AddAbFileName(FlatBufferBuilder builder, StringOffset abFileNameOffset) { builder.AddOffset(5, abFileNameOffset.Value, 0); }
  public static Offset<AssetBundleFileHeader> EndAssetBundleFileHeader(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<AssetBundleFileHeader>(o);
  }
};


}
