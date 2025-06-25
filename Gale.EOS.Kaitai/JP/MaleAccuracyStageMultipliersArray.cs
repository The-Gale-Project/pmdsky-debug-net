// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.JP
{

    /// <summary>
    /// Represents an array MALE_ACCURACY_STAGE_MULTIPLIERS defined within pmdsky.
    /// </summary>
    public partial class MaleAccuracyStageMultipliersArray : KaitaiStruct
    {
        public static MaleAccuracyStageMultipliersArray FromFile(string fileName)
        {
            return new MaleAccuracyStageMultipliersArray(new KaitaiStream(fileName));
        }

        public MaleAccuracyStageMultipliersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MaleAccuracyStageMultipliersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MaleAccuracyStageMultipliersArrayDim0(m_io, this, m_root);
        }
        public partial class MaleAccuracyStageMultipliersArrayDim0 : KaitaiStruct
        {
            public static MaleAccuracyStageMultipliersArrayDim0 FromFile(string fileName)
            {
                return new MaleAccuracyStageMultipliersArrayDim0(new KaitaiStream(fileName));
            }

            public MaleAccuracyStageMultipliersArrayDim0(KaitaiStream p__io, MaleAccuracyStageMultipliersArray p__parent = null, MaleAccuracyStageMultipliersArray p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _entries = new List<int>();
                for (var i = 0; i < 21; i++)
                {
                    _entries.Add(m_io.ReadS4le());
                }
            }
            private List<int> _entries;
            private MaleAccuracyStageMultipliersArray m_root;
            private MaleAccuracyStageMultipliersArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public MaleAccuracyStageMultipliersArray M_Root { get { return m_root; } }
            public MaleAccuracyStageMultipliersArray M_Parent { get { return m_parent; } }
        }
        private MaleAccuracyStageMultipliersArrayDim0 _entries;
        private MaleAccuracyStageMultipliersArray m_root;
        private KaitaiStruct m_parent;
        public MaleAccuracyStageMultipliersArrayDim0 Entries { get { return _entries; } }
        public MaleAccuracyStageMultipliersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
