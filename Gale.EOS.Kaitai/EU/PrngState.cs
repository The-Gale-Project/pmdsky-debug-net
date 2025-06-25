// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents a struct or union prng_state defined within pmdsky-debug.
    /// </summary>
    public partial class PrngState : KaitaiStruct
    {
        public static PrngState FromFile(string fileName)
        {
            return new PrngState(new KaitaiStream(fileName));
        }

        public PrngState(KaitaiStream p__io, KaitaiStruct p__parent = null, PrngState p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _useSecondary = m_io.ReadS4le();
            _seqNumPrimary = m_io.ReadU4le();
            _preseed = m_io.ReadU4le();
            _lastValuePrimary = m_io.ReadU4le();
            _idxSecondary = m_io.ReadS4le();
        }
        private int _useSecondary;
        private uint _seqNumPrimary;
        private uint _preseed;
        private uint _lastValuePrimary;
        private int _idxSecondary;
        private PrngState m_root;
        private KaitaiStruct m_parent;
        public int UseSecondary { get { return _useSecondary; } }
        public uint SeqNumPrimary { get { return _seqNumPrimary; } }
        public uint Preseed { get { return _preseed; } }
        public uint LastValuePrimary { get { return _lastValuePrimary; } }
        public int IdxSecondary { get { return _idxSecondary; } }
        public PrngState M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
