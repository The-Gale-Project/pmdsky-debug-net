// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array DIRECTIONS_XY defined within pmdsky.
    /// </summary>
    public partial class DirectionsXyArray : KaitaiStruct
    {
        public static DirectionsXyArray FromFile(string fileName)
        {
            return new DirectionsXyArray(new KaitaiStream(fileName));
        }

        public DirectionsXyArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DirectionsXyArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DirectionsXyArrayDim1(m_io, this, m_root);
        }
        public partial class DirectionsXyArrayDim0 : KaitaiStruct
        {
            public static DirectionsXyArrayDim0 FromFile(string fileName)
            {
                return new DirectionsXyArrayDim0(new KaitaiStream(fileName));
            }

            public DirectionsXyArrayDim0(KaitaiStream p__io, DirectionsXyArray.DirectionsXyArrayDim1 p__parent = null, DirectionsXyArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<short>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(m_io.ReadS2le());
                }
            }
            private List<short> _entries;
            private DirectionsXyArray m_root;
            private DirectionsXyArray.DirectionsXyArrayDim1 m_parent;
            public List<short> Entries { get { return _entries; } }
            public DirectionsXyArray M_Root { get { return m_root; } }
            public DirectionsXyArray.DirectionsXyArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class DirectionsXyArrayDim1 : KaitaiStruct
        {
            public static DirectionsXyArrayDim1 FromFile(string fileName)
            {
                return new DirectionsXyArrayDim1(new KaitaiStream(fileName));
            }

            public DirectionsXyArrayDim1(KaitaiStream p__io, DirectionsXyArray p__parent = null, DirectionsXyArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DirectionsXyArrayDim0>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new DirectionsXyArrayDim0(m_io, this, m_root));
                }
            }
            private List<DirectionsXyArrayDim0> _entries;
            private DirectionsXyArray m_root;
            private DirectionsXyArray m_parent;
            public List<DirectionsXyArrayDim0> Entries { get { return _entries; } }
            public DirectionsXyArray M_Root { get { return m_root; } }
            public DirectionsXyArray M_Parent { get { return m_parent; } }
        }
        private DirectionsXyArrayDim1 _entries;
        private DirectionsXyArray m_root;
        private KaitaiStruct m_parent;
        public DirectionsXyArrayDim1 Entries { get { return _entries; } }
        public DirectionsXyArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
