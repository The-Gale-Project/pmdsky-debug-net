// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array POSITION_DISPLACEMENT_TO_DIRECTION defined within pmdsky.
    /// </summary>
    public partial class PositionDisplacementToDirectionArray : KaitaiStruct
    {
        public static PositionDisplacementToDirectionArray FromFile(string fileName)
        {
            return new PositionDisplacementToDirectionArray(new KaitaiStream(fileName));
        }

        public PositionDisplacementToDirectionArray(KaitaiStream p__io, KaitaiStruct p__parent = null, PositionDisplacementToDirectionArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new PositionDisplacementToDirectionArrayDim1(m_io, this, m_root);
        }
        public partial class PositionDisplacementToDirectionArrayDim0 : KaitaiStruct
        {
            public static PositionDisplacementToDirectionArrayDim0 FromFile(string fileName)
            {
                return new PositionDisplacementToDirectionArrayDim0(new KaitaiStream(fileName));
            }

            public PositionDisplacementToDirectionArrayDim0(KaitaiStream p__io, PositionDisplacementToDirectionArray.PositionDisplacementToDirectionArrayDim1 p__parent = null, PositionDisplacementToDirectionArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<DirectionId>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(new DirectionId(m_io));
                }
            }
            private List<DirectionId> _entries;
            private PositionDisplacementToDirectionArray m_root;
            private PositionDisplacementToDirectionArray.PositionDisplacementToDirectionArrayDim1 m_parent;
            public List<DirectionId> Entries { get { return _entries; } }
            public PositionDisplacementToDirectionArray M_Root { get { return m_root; } }
            public PositionDisplacementToDirectionArray.PositionDisplacementToDirectionArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class PositionDisplacementToDirectionArrayDim1 : KaitaiStruct
        {
            public static PositionDisplacementToDirectionArrayDim1 FromFile(string fileName)
            {
                return new PositionDisplacementToDirectionArrayDim1(new KaitaiStream(fileName));
            }

            public PositionDisplacementToDirectionArrayDim1(KaitaiStream p__io, PositionDisplacementToDirectionArray p__parent = null, PositionDisplacementToDirectionArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<PositionDisplacementToDirectionArrayDim0>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(new PositionDisplacementToDirectionArrayDim0(m_io, this, m_root));
                }
            }
            private List<PositionDisplacementToDirectionArrayDim0> _entries;
            private PositionDisplacementToDirectionArray m_root;
            private PositionDisplacementToDirectionArray m_parent;
            public List<PositionDisplacementToDirectionArrayDim0> Entries { get { return _entries; } }
            public PositionDisplacementToDirectionArray M_Root { get { return m_root; } }
            public PositionDisplacementToDirectionArray M_Parent { get { return m_parent; } }
        }
        private PositionDisplacementToDirectionArrayDim1 _entries;
        private PositionDisplacementToDirectionArray m_root;
        private KaitaiStruct m_parent;
        public PositionDisplacementToDirectionArrayDim1 Entries { get { return _entries; } }
        public PositionDisplacementToDirectionArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
