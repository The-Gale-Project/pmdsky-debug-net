// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array DS_DOWNLOAD_TEAMS defined within pmdsky.
    /// </summary>
    public partial class DsDownloadTeamsArray : KaitaiStruct
    {
        public static DsDownloadTeamsArray FromFile(string fileName)
        {
            return new DsDownloadTeamsArray(new KaitaiStream(fileName));
        }

        public DsDownloadTeamsArray(KaitaiStream p__io, KaitaiStruct p__parent = null, DsDownloadTeamsArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new DsDownloadTeamsArrayDim0(m_io, this, m_root);
        }
        public partial class DsDownloadTeamsArrayDim0 : KaitaiStruct
        {
            public static DsDownloadTeamsArrayDim0 FromFile(string fileName)
            {
                return new DsDownloadTeamsArrayDim0(new KaitaiStream(fileName));
            }

            public DsDownloadTeamsArrayDim0(KaitaiStream p__io, DsDownloadTeamsArray p__parent = null, DsDownloadTeamsArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterId16>();
                for (var i = 0; i < 56; i++)
                {
                    _entries.Add(new MonsterId16(m_io));
                }
            }
            private List<MonsterId16> _entries;
            private DsDownloadTeamsArray m_root;
            private DsDownloadTeamsArray m_parent;
            public List<MonsterId16> Entries { get { return _entries; } }
            public DsDownloadTeamsArray M_Root { get { return m_root; } }
            public DsDownloadTeamsArray M_Parent { get { return m_parent; } }
        }
        private DsDownloadTeamsArrayDim0 _entries;
        private DsDownloadTeamsArray m_root;
        private KaitaiStruct m_parent;
        public DsDownloadTeamsArrayDim0 Entries { get { return _entries; } }
        public DsDownloadTeamsArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
