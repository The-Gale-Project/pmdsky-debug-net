// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array RENDER_3D_FUNCTIONS_64 defined within pmdsky.
    /// </summary>
    public partial class Render3dFunctions64Array : KaitaiStruct
    {
        public static Render3dFunctions64Array FromFile(string fileName)
        {
            return new Render3dFunctions64Array(new KaitaiStream(fileName));
        }

        public Render3dFunctions64Array(KaitaiStream p__io, KaitaiStruct p__parent = null, Render3dFunctions64Array p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new Render3dFunctions64ArrayDim0(m_io, this, m_root);
        }
        public partial class Render3dFunctions64ArrayDim0 : KaitaiStruct
        {
            public static Render3dFunctions64ArrayDim0 FromFile(string fileName)
            {
                return new Render3dFunctions64ArrayDim0(new KaitaiStream(fileName));
            }

            public Render3dFunctions64ArrayDim0(KaitaiStream p__io, Render3dFunctions64Array p__parent = null, Render3dFunctions64Array p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<Pointer>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(new Pointer(m_io));
                }
            }
            private List<Pointer> _entries;
            private Render3dFunctions64Array m_root;
            private Render3dFunctions64Array m_parent;
            public List<Pointer> Entries { get { return _entries; } }
            public Render3dFunctions64Array M_Root { get { return m_root; } }
            public Render3dFunctions64Array M_Parent { get { return m_parent; } }
        }
        private Render3dFunctions64ArrayDim0 _entries;
        private Render3dFunctions64Array m_root;
        private KaitaiStruct m_parent;
        public Render3dFunctions64ArrayDim0 Entries { get { return _entries; } }
        public Render3dFunctions64Array M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
