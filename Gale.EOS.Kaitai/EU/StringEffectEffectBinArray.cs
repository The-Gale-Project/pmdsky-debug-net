// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array STRING_EFFECT_EFFECT_BIN defined within pmdsky.
    /// </summary>
    public partial class StringEffectEffectBinArray : KaitaiStruct
    {
        public static StringEffectEffectBinArray FromFile(string fileName)
        {
            return new StringEffectEffectBinArray(new KaitaiStream(fileName));
        }

        public StringEffectEffectBinArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StringEffectEffectBinArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StringEffectEffectBinArrayDim0(m_io, this, m_root);
        }
        public partial class StringEffectEffectBinArrayDim0 : KaitaiStruct
        {
            public static StringEffectEffectBinArrayDim0 FromFile(string fileName)
            {
                return new StringEffectEffectBinArrayDim0(new KaitaiStream(fileName));
            }

            public StringEffectEffectBinArrayDim0(KaitaiStream p__io, StringEffectEffectBinArray p__parent = null, StringEffectEffectBinArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<sbyte>();
                for (var i = 0; i < 20; i++)
                {
                    _entries.Add(m_io.ReadS1());
                }
            }
            private List<sbyte> _entries;
            private StringEffectEffectBinArray m_root;
            private StringEffectEffectBinArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public StringEffectEffectBinArray M_Root { get { return m_root; } }
            public StringEffectEffectBinArray M_Parent { get { return m_parent; } }
        }
        private StringEffectEffectBinArrayDim0 _entries;
        private StringEffectEffectBinArray m_root;
        private KaitaiStruct m_parent;
        public StringEffectEffectBinArrayDim0 Entries { get { return _entries; } }
        public StringEffectEffectBinArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
