// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array script_object_unused defined within pmdsky.
    /// </summary>
    public partial class ScriptObjectUnusedArray : KaitaiStruct
    {
        public static ScriptObjectUnusedArray FromFile(string fileName)
        {
            return new ScriptObjectUnusedArray(new KaitaiStream(fileName));
        }

        public ScriptObjectUnusedArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ScriptObjectUnusedArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ScriptObjectUnusedArrayDim0(m_io, this, m_root);
        }
        public partial class ScriptObjectUnusedArrayDim0 : KaitaiStruct
        {
            public static ScriptObjectUnusedArrayDim0 FromFile(string fileName)
            {
                return new ScriptObjectUnusedArrayDim0(new KaitaiStream(fileName));
            }

            public ScriptObjectUnusedArrayDim0(KaitaiStream p__io, ScriptObjectUnusedArray p__parent = null, ScriptObjectUnusedArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private ScriptObjectUnusedArray m_root;
            private ScriptObjectUnusedArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public ScriptObjectUnusedArray M_Root { get { return m_root; } }
            public ScriptObjectUnusedArray M_Parent { get { return m_parent; } }
        }
        private ScriptObjectUnusedArrayDim0 _entries;
        private ScriptObjectUnusedArray m_root;
        private KaitaiStruct m_parent;
        public ScriptObjectUnusedArrayDim0 Entries { get { return _entries; } }
        public ScriptObjectUnusedArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
