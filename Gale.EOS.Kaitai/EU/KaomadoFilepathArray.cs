// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array KAOMADO_FILEPATH defined within pmdsky.
    /// </summary>
    public partial class KaomadoFilepathArray : KaitaiStruct
    {
        public static KaomadoFilepathArray FromFile(string fileName)
        {
            return new KaomadoFilepathArray(new KaitaiStream(fileName));
        }

        public KaomadoFilepathArray(KaitaiStream p__io, KaitaiStruct p__parent = null, KaomadoFilepathArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new KaomadoFilepathArrayDim0(m_io, this, m_root);
        }
        public partial class KaomadoFilepathArrayDim0 : KaitaiStruct
        {
            public static KaomadoFilepathArrayDim0 FromFile(string fileName)
            {
                return new KaomadoFilepathArrayDim0(new KaitaiStream(fileName));
            }

            public KaomadoFilepathArrayDim0(KaitaiStream p__io, KaomadoFilepathArray p__parent = null, KaomadoFilepathArray p__root = null) : base(p__io)
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
            private KaomadoFilepathArray m_root;
            private KaomadoFilepathArray m_parent;
            public List<sbyte> Entries { get { return _entries; } }
            public KaomadoFilepathArray M_Root { get { return m_root; } }
            public KaomadoFilepathArray M_Parent { get { return m_parent; } }
        }
        private KaomadoFilepathArrayDim0 _entries;
        private KaomadoFilepathArray m_root;
        private KaitaiStruct m_parent;
        public KaomadoFilepathArrayDim0 Entries { get { return _entries; } }
        public KaomadoFilepathArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
