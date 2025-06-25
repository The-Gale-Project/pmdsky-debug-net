// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array QUIZ_DEBUG_MENU_ITEMS defined within pmdsky.
    /// </summary>
    public partial class QuizDebugMenuItemsArray : KaitaiStruct
    {
        public static QuizDebugMenuItemsArray FromFile(string fileName)
        {
            return new QuizDebugMenuItemsArray(new KaitaiStream(fileName));
        }

        public QuizDebugMenuItemsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, QuizDebugMenuItemsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new QuizDebugMenuItemsArrayDim0(m_io, this, m_root);
        }
        public partial class QuizDebugMenuItemsArrayDim0 : KaitaiStruct
        {
            public static QuizDebugMenuItemsArrayDim0 FromFile(string fileName)
            {
                return new QuizDebugMenuItemsArrayDim0(new KaitaiStream(fileName));
            }

            public QuizDebugMenuItemsArrayDim0(KaitaiStream p__io, QuizDebugMenuItemsArray p__parent = null, QuizDebugMenuItemsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<SimpleMenuIdItem>();
                for (var i = 0; i < 9; i++)
                {
                    _entries.Add(new SimpleMenuIdItem(m_io));
                }
            }
            private List<SimpleMenuIdItem> _entries;
            private QuizDebugMenuItemsArray m_root;
            private QuizDebugMenuItemsArray m_parent;
            public List<SimpleMenuIdItem> Entries { get { return _entries; } }
            public QuizDebugMenuItemsArray M_Root { get { return m_root; } }
            public QuizDebugMenuItemsArray M_Parent { get { return m_parent; } }
        }
        private QuizDebugMenuItemsArrayDim0 _entries;
        private QuizDebugMenuItemsArray m_root;
        private KaitaiStruct m_parent;
        public QuizDebugMenuItemsArrayDim0 Entries { get { return _entries; } }
        public QuizDebugMenuItemsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
