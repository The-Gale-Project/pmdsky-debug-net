// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array render_3d_element_64_vec defined within pmdsky.
    /// </summary>
    public partial class Render3dElement64VecArray : KaitaiStruct
    {
        public static Render3dElement64VecArray FromFile(string fileName)
        {
            return new Render3dElement64VecArray(new KaitaiStream(fileName));
        }

        public Render3dElement64VecArray(KaitaiStream p__io, KaitaiStruct p__parent = null, Render3dElement64VecArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new Render3dElement64VecArrayDim0(m_io, this, m_root);
        }
        public partial class Render3dElement64VecArrayDim0 : KaitaiStruct
        {
            public static Render3dElement64VecArrayDim0 FromFile(string fileName)
            {
                return new Render3dElement64VecArrayDim0(new KaitaiStream(fileName));
            }

            public Render3dElement64VecArrayDim0(KaitaiStream p__io, Render3dElement64VecArray p__parent = null, Render3dElement64VecArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Vec216>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new Vec216(m_io));
                }
            }
            private List<Vec216> _entries;
            private Render3dElement64VecArray m_root;
            private Render3dElement64VecArray m_parent;
            public List<Vec216> Entries { get { return _entries; } }
            public Render3dElement64VecArray M_Root { get { return m_root; } }
            public Render3dElement64VecArray M_Parent { get { return m_parent; } }
        }
        private Render3dElement64VecArrayDim0 _entries;
        private Render3dElement64VecArray m_root;
        private KaitaiStruct m_parent;
        public Render3dElement64VecArrayDim0 Entries { get { return _entries; } }
        public Render3dElement64VecArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
