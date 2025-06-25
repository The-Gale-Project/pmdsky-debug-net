// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array METRONOME_TABLE defined within pmdsky.
    /// </summary>
    public partial class MetronomeTableArray : KaitaiStruct
    {
        public static MetronomeTableArray FromFile(string fileName)
        {
            return new MetronomeTableArray(new KaitaiStream(fileName));
        }

        public MetronomeTableArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MetronomeTableArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MetronomeTableArrayDim0(m_io, this, m_root);
        }
        public partial class MetronomeTableArrayDim0 : KaitaiStruct
        {
            public static MetronomeTableArrayDim0 FromFile(string fileName)
            {
                return new MetronomeTableArrayDim0(new KaitaiStream(fileName));
            }

            public MetronomeTableArrayDim0(KaitaiStream p__io, MetronomeTableArray p__parent = null, MetronomeTableArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<WildcardMoveDesc>();
                for (var i = 0; i < 168; i++)
                {
                    _entries.Add(new WildcardMoveDesc(m_io));
                }
            }
            private List<WildcardMoveDesc> _entries;
            private MetronomeTableArray m_root;
            private MetronomeTableArray m_parent;
            public List<WildcardMoveDesc> Entries { get { return _entries; } }
            public MetronomeTableArray M_Root { get { return m_root; } }
            public MetronomeTableArray M_Parent { get { return m_parent; } }
        }
        private MetronomeTableArrayDim0 _entries;
        private MetronomeTableArray m_root;
        private KaitaiStruct m_parent;
        public MetronomeTableArrayDim0 Entries { get { return _entries; } }
        public MetronomeTableArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
