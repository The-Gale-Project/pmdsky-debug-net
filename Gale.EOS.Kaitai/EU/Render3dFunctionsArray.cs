// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array RENDER_3D_FUNCTIONS defined within pmdsky.
    /// </summary>
    public partial class Render3dFunctionsArray : KaitaiStruct
    {
        public static Render3dFunctionsArray FromFile(string fileName)
        {
            return new Render3dFunctionsArray(new KaitaiStream(fileName));
        }

        public Render3dFunctionsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, Render3dFunctionsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new Render3dFunctionsArrayDim0(m_io, this, m_root);
        }
        public partial class Render3dFunctionsArrayDim0 : KaitaiStruct
        {
            public static Render3dFunctionsArrayDim0 FromFile(string fileName)
            {
                return new Render3dFunctionsArrayDim0(new KaitaiStream(fileName));
            }

            public Render3dFunctionsArrayDim0(KaitaiStream p__io, Render3dFunctionsArray p__parent = null, Render3dFunctionsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private Render3dFunctionsArray m_root;
            private Render3dFunctionsArray m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public Render3dFunctionsArray M_Root { get { return m_root; } }
            public Render3dFunctionsArray M_Parent { get { return m_parent; } }
        }
        private Render3dFunctionsArrayDim0 _entries;
        private Render3dFunctionsArray m_root;
        private KaitaiStruct m_parent;
        public Render3dFunctionsArrayDim0 Entries { get { return _entries; } }
        public Render3dFunctionsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
