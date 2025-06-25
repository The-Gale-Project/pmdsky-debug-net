// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents a struct or union exclusive_item_stat_boost_entry defined within pmdsky-debug.
    /// </summary>
    public partial class ExclusiveItemStatBoostEntry : KaitaiStruct
    {
        public static ExclusiveItemStatBoostEntry FromFile(string fileName)
        {
            return new ExclusiveItemStatBoostEntry(new KaitaiStream(fileName));
        }

        public ExclusiveItemStatBoostEntry(KaitaiStream p__io, KaitaiStruct p__parent = null, ExclusiveItemStatBoostEntry p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _atk = m_io.ReadS1();
            _def = m_io.ReadS1();
            _spAtk = m_io.ReadS1();
            _spDef = m_io.ReadS1();
        }
        private sbyte _atk;
        private sbyte _def;
        private sbyte _spAtk;
        private sbyte _spDef;
        private ExclusiveItemStatBoostEntry m_root;
        private KaitaiStruct m_parent;
        public sbyte Atk { get { return _atk; } }
        public sbyte Def { get { return _def; } }
        public sbyte SpAtk { get { return _spAtk; } }
        public sbyte SpDef { get { return _spDef; } }
        public ExclusiveItemStatBoostEntry M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
