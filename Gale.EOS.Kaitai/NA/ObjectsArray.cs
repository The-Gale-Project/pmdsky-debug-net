// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array OBJECTS defined within pmdsky.
    /// </summary>
    public partial class ObjectsArray : KaitaiStruct
    {
        public static ObjectsArray FromFile(string fileName)
        {
            return new ObjectsArray(new KaitaiStream(fileName));
        }

        public ObjectsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ObjectsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ObjectsArrayDim0(m_io, this, m_root);
        }
        public partial class ObjectsArrayDim0 : KaitaiStruct
        {
            public static ObjectsArrayDim0 FromFile(string fileName)
            {
                return new ObjectsArrayDim0(new KaitaiStream(fileName));
            }

            public ObjectsArrayDim0(KaitaiStream p__io, ObjectsArray p__parent = null, ObjectsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ScriptObject>();
                for (var i = 0; i < 0; i++)
                {
                    _entries.Add(new ScriptObject(m_io));
                }
            }
            private List<ScriptObject> _entries;
            private ObjectsArray m_root;
            private ObjectsArray m_parent;
            public List<ScriptObject> Entries { get { return _entries; } }
            public ObjectsArray M_Root { get { return m_root; } }
            public ObjectsArray M_Parent { get { return m_parent; } }
        }
        private ObjectsArrayDim0 _entries;
        private ObjectsArray m_root;
        private KaitaiStruct m_parent;
        public ObjectsArrayDim0 Entries { get { return _entries; } }
        public ObjectsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
