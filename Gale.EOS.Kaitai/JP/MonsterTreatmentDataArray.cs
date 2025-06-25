// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array MONSTER_TREATMENT_DATA defined within pmdsky.
    /// </summary>
    public partial class MonsterTreatmentDataArray : KaitaiStruct
    {
        public static MonsterTreatmentDataArray FromFile(string fileName)
        {
            return new MonsterTreatmentDataArray(new KaitaiStream(fileName));
        }

        public MonsterTreatmentDataArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MonsterTreatmentDataArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MonsterTreatmentDataArrayDim3(m_io, this, m_root);
        }
        public partial class MonsterTreatmentDataArrayDim0 : KaitaiStruct
        {
            public static MonsterTreatmentDataArrayDim0 FromFile(string fileName)
            {
                return new MonsterTreatmentDataArrayDim0(new KaitaiStream(fileName));
            }

            public MonsterTreatmentDataArrayDim0(KaitaiStream p__io, MonsterTreatmentDataArray.MonsterTreatmentDataArrayDim1 p__parent = null, MonsterTreatmentDataArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterTreatment>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(new MonsterTreatment(m_io));
                }
            }
            private List<MonsterTreatment> _entries;
            private MonsterTreatmentDataArray m_root;
            private MonsterTreatmentDataArray.MonsterTreatmentDataArrayDim1 m_parent;
            public List<MonsterTreatment> Entries { get { return _entries; } }
            public MonsterTreatmentDataArray M_Root { get { return m_root; } }
            public MonsterTreatmentDataArray.MonsterTreatmentDataArrayDim1 M_Parent { get { return m_parent; } }
        }
        public partial class MonsterTreatmentDataArrayDim1 : KaitaiStruct
        {
            public static MonsterTreatmentDataArrayDim1 FromFile(string fileName)
            {
                return new MonsterTreatmentDataArrayDim1(new KaitaiStream(fileName));
            }

            public MonsterTreatmentDataArrayDim1(KaitaiStream p__io, MonsterTreatmentDataArray.MonsterTreatmentDataArrayDim2 p__parent = null, MonsterTreatmentDataArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterTreatmentDataArrayDim0>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(new MonsterTreatmentDataArrayDim0(m_io, this, m_root));
                }
            }
            private List<MonsterTreatmentDataArrayDim0> _entries;
            private MonsterTreatmentDataArray m_root;
            private MonsterTreatmentDataArray.MonsterTreatmentDataArrayDim2 m_parent;
            public List<MonsterTreatmentDataArrayDim0> Entries { get { return _entries; } }
            public MonsterTreatmentDataArray M_Root { get { return m_root; } }
            public MonsterTreatmentDataArray.MonsterTreatmentDataArrayDim2 M_Parent { get { return m_parent; } }
        }
        public partial class MonsterTreatmentDataArrayDim2 : KaitaiStruct
        {
            public static MonsterTreatmentDataArrayDim2 FromFile(string fileName)
            {
                return new MonsterTreatmentDataArrayDim2(new KaitaiStream(fileName));
            }

            public MonsterTreatmentDataArrayDim2(KaitaiStream p__io, MonsterTreatmentDataArray.MonsterTreatmentDataArrayDim3 p__parent = null, MonsterTreatmentDataArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterTreatmentDataArrayDim1>();
                for (var i = 0; i < 2; i++)
                {
                    _entries.Add(new MonsterTreatmentDataArrayDim1(m_io, this, m_root));
                }
            }
            private List<MonsterTreatmentDataArrayDim1> _entries;
            private MonsterTreatmentDataArray m_root;
            private MonsterTreatmentDataArray.MonsterTreatmentDataArrayDim3 m_parent;
            public List<MonsterTreatmentDataArrayDim1> Entries { get { return _entries; } }
            public MonsterTreatmentDataArray M_Root { get { return m_root; } }
            public MonsterTreatmentDataArray.MonsterTreatmentDataArrayDim3 M_Parent { get { return m_parent; } }
        }
        public partial class MonsterTreatmentDataArrayDim3 : KaitaiStruct
        {
            public static MonsterTreatmentDataArrayDim3 FromFile(string fileName)
            {
                return new MonsterTreatmentDataArrayDim3(new KaitaiStream(fileName));
            }

            public MonsterTreatmentDataArrayDim3(KaitaiStream p__io, MonsterTreatmentDataArray p__parent = null, MonsterTreatmentDataArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<MonsterTreatmentDataArrayDim2>();
                for (var i = 0; i < 4; i++)
                {
                    _entries.Add(new MonsterTreatmentDataArrayDim2(m_io, this, m_root));
                }
            }
            private List<MonsterTreatmentDataArrayDim2> _entries;
            private MonsterTreatmentDataArray m_root;
            private MonsterTreatmentDataArray m_parent;
            public List<MonsterTreatmentDataArrayDim2> Entries { get { return _entries; } }
            public MonsterTreatmentDataArray M_Root { get { return m_root; } }
            public MonsterTreatmentDataArray M_Parent { get { return m_parent; } }
        }
        private MonsterTreatmentDataArrayDim3 _entries;
        private MonsterTreatmentDataArray m_root;
        private KaitaiStruct m_parent;
        public MonsterTreatmentDataArrayDim3 Entries { get { return _entries; } }
        public MonsterTreatmentDataArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
