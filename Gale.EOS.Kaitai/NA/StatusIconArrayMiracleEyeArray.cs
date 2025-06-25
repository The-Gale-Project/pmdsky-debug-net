// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.NA
{

    /// <summary>
    /// Represents an array STATUS_ICON_ARRAY_MIRACLE_EYE defined within pmdsky.
    /// </summary>
    public partial class StatusIconArrayMiracleEyeArray : KaitaiStruct
    {
        public static StatusIconArrayMiracleEyeArray FromFile(string fileName)
        {
            return new StatusIconArrayMiracleEyeArray(new KaitaiStream(fileName));
        }

        public StatusIconArrayMiracleEyeArray(KaitaiStream p__io, KaitaiStruct p__parent = null, StatusIconArrayMiracleEyeArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new StatusIconArrayMiracleEyeArrayDim0(m_io, this, m_root);
        }
        public partial class StatusIconArrayMiracleEyeArrayDim0 : KaitaiStruct
        {
            public static StatusIconArrayMiracleEyeArrayDim0 FromFile(string fileName)
            {
                return new StatusIconArrayMiracleEyeArrayDim0(new KaitaiStream(fileName));
            }

            public StatusIconArrayMiracleEyeArrayDim0(KaitaiStream p__io, StatusIconArrayMiracleEyeArray p__parent = null, StatusIconArrayMiracleEyeArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<StatusIconFlags>();
                for (var i = 0; i < 3; i++)
                {
                    _entries.Add(new StatusIconFlags(m_io));
                }
            }
            private List<StatusIconFlags> _entries;
            private StatusIconArrayMiracleEyeArray m_root;
            private StatusIconArrayMiracleEyeArray m_parent;
            public List<StatusIconFlags> Entries { get { return _entries; } }
            public StatusIconArrayMiracleEyeArray M_Root { get { return m_root; } }
            public StatusIconArrayMiracleEyeArray M_Parent { get { return m_parent; } }
        }
        private StatusIconArrayMiracleEyeArrayDim0 _entries;
        private StatusIconArrayMiracleEyeArray m_root;
        private KaitaiStruct m_parent;
        public StatusIconArrayMiracleEyeArrayDim0 Entries { get { return _entries; } }
        public StatusIconArrayMiracleEyeArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
