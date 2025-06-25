// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array AI_THROWN_ITEM_DIRECTION_IS_USED defined within pmdsky.
    /// </summary>
    public partial class AiThrownItemDirectionIsUsedArray : KaitaiStruct
    {
        public static AiThrownItemDirectionIsUsedArray FromFile(string fileName)
        {
            return new AiThrownItemDirectionIsUsedArray(new KaitaiStream(fileName));
        }

        public AiThrownItemDirectionIsUsedArray(KaitaiStream p__io, KaitaiStruct p__parent = null, AiThrownItemDirectionIsUsedArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new AiThrownItemDirectionIsUsedArrayDim0(m_io, this, m_root);
        }
        public partial class AiThrownItemDirectionIsUsedArrayDim0 : KaitaiStruct
        {
            public static AiThrownItemDirectionIsUsedArrayDim0 FromFile(string fileName)
            {
                return new AiThrownItemDirectionIsUsedArrayDim0(new KaitaiStream(fileName));
            }

            public AiThrownItemDirectionIsUsedArrayDim0(KaitaiStream p__io, AiThrownItemDirectionIsUsedArray p__parent = null, AiThrownItemDirectionIsUsedArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<byte>();
                for (var i = 0; i < 8; i++)
                {
                    _entries.Add(m_io.ReadU1());
                }
            }
            private List<byte> _entries;
            private AiThrownItemDirectionIsUsedArray m_root;
            private AiThrownItemDirectionIsUsedArray m_parent;
            public List<byte> Entries { get { return _entries; } }
            public AiThrownItemDirectionIsUsedArray M_Root { get { return m_root; } }
            public AiThrownItemDirectionIsUsedArray M_Parent { get { return m_parent; } }
        }
        private AiThrownItemDirectionIsUsedArrayDim0 _entries;
        private AiThrownItemDirectionIsUsedArray m_root;
        private KaitaiStruct m_parent;
        public AiThrownItemDirectionIsUsedArrayDim0 Entries { get { return _entries; } }
        public AiThrownItemDirectionIsUsedArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
