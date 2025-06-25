// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Holds the data for the enum hidden_stairs_type.
    /// </summary>
    public partial class HiddenStairsType : KaitaiStruct
    {
        public static HiddenStairsType FromFile(string fileName)
        {
            return new HiddenStairsType(new KaitaiStream(fileName));
        }


        public enum HiddenStairsTypeEnum
        {
            HiddenStairsNone = 0,
            HiddenStairsSecretBazaar = 1,
            HiddenStairsSecretRoom = 2,
            HiddenStairsRandomSecretBazaarOrSecretRoom = 255,
        }
        public HiddenStairsType(KaitaiStream p__io, KaitaiStruct p__parent = null, HiddenStairsType p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _hiddenStairsTypeValue = ((HiddenStairsTypeEnum) m_io.ReadBitsIntLe(32));
        }
        private HiddenStairsTypeEnum _hiddenStairsTypeValue;
        private HiddenStairsType m_root;
        private KaitaiStruct m_parent;
        public HiddenStairsTypeEnum HiddenStairsTypeValue { get { return _hiddenStairsTypeValue; } }
        public HiddenStairsType M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
