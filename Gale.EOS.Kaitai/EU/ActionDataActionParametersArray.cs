// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array action_data_action_parameters defined within pmdsky.
    /// </summary>
    public partial class ActionDataActionParametersArray : KaitaiStruct
    {
        public static ActionDataActionParametersArray FromFile(string fileName)
        {
            return new ActionDataActionParametersArray(new KaitaiStream(fileName));
        }

        public ActionDataActionParametersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, ActionDataActionParametersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new ActionDataActionParametersArrayDim0(m_io, this, m_root);
        }
        public partial class ActionDataActionParametersArrayDim0 : KaitaiStruct
        {
            public static ActionDataActionParametersArrayDim0 FromFile(string fileName)
            {
                return new ActionDataActionParametersArrayDim0(new KaitaiStream(fileName));
            }

            public ActionDataActionParametersArrayDim0(KaitaiStream p__io, ActionDataActionParametersArray p__parent = null, ActionDataActionParametersArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<ActionParameter>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(new ActionParameter(m_io));
                }
            }
            private List<ActionParameter> _entries;
            private ActionDataActionParametersArray m_root;
            private ActionDataActionParametersArray m_parent;
            public List<ActionParameter> Entries { get { return _entries; } }
            public ActionDataActionParametersArray M_Root { get { return m_root; } }
            public ActionDataActionParametersArray M_Parent { get { return m_parent; } }
        }
        private ActionDataActionParametersArrayDim0 _entries;
        private ActionDataActionParametersArray m_root;
        private KaitaiStruct m_parent;
        public ActionDataActionParametersArrayDim0 Entries { get { return _entries; } }
        public ActionDataActionParametersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
