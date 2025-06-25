// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array render_3d_element_64_color defined within pmdsky.
    /// </summary>
    public partial class Render3dElement64ColorArray : KaitaiStruct
    {
        public static Render3dElement64ColorArray FromFile(string fileName)
        {
            return new Render3dElement64ColorArray(new KaitaiStream(fileName));
        }

        public Render3dElement64ColorArray(KaitaiStream p__io, KaitaiStruct p__parent = null, Render3dElement64ColorArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new Render3dElement64ColorArrayDim0(m_io, this, m_root);
        }
        public partial class Render3dElement64ColorArrayDim0 : KaitaiStruct
        {
            public static Render3dElement64ColorArrayDim0 FromFile(string fileName)
            {
                return new Render3dElement64ColorArrayDim0(new KaitaiStream(fileName));
            }

            public Render3dElement64ColorArrayDim0(KaitaiStream p__io, Render3dElement64ColorArray p__parent = null, Render3dElement64ColorArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Rgba>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new Rgba(m_io));
                }
            }
            private List<Rgba> _entries;
            private Render3dElement64ColorArray m_root;
            private Render3dElement64ColorArray m_parent;
            public List<Rgba> Entries { get { return _entries; } }
            public Render3dElement64ColorArray M_Root { get { return m_root; } }
            public Render3dElement64ColorArray M_Parent { get { return m_parent; } }
        }
        private Render3dElement64ColorArrayDim0 _entries;
        private Render3dElement64ColorArray m_root;
        private KaitaiStruct m_parent;
        public Render3dElement64ColorArrayDim0 Entries { get { return _entries; } }
        public Render3dElement64ColorArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
