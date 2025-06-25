// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace Gale.EOS.Kaitai.EU
{

    /// <summary>
    /// Represents an array MALE_EVASION_STAGE_MULTIPLIERS defined within pmdsky.
    /// </summary>
    public partial class MaleEvasionStageMultipliersArray : KaitaiStruct
    {
        public static MaleEvasionStageMultipliersArray FromFile(string fileName)
        {
            return new MaleEvasionStageMultipliersArray(new KaitaiStream(fileName));
        }

        public MaleEvasionStageMultipliersArray(KaitaiStream p__io, KaitaiStruct p__parent = null, MaleEvasionStageMultipliersArray p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _entries = new MaleEvasionStageMultipliersArrayDim0(m_io, this, m_root);
        }
        public partial class MaleEvasionStageMultipliersArrayDim0 : KaitaiStruct
        {
            public static MaleEvasionStageMultipliersArrayDim0 FromFile(string fileName)
            {
                return new MaleEvasionStageMultipliersArrayDim0(new KaitaiStream(fileName));
            }

            public MaleEvasionStageMultipliersArrayDim0(KaitaiStream p__io, MaleEvasionStageMultipliersArray p__parent = null, MaleEvasionStageMultipliersArray p__root = null) : base(p__io)
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
            private MaleEvasionStageMultipliersArray m_root;
            private MaleEvasionStageMultipliersArray m_parent;
            public List<int> Entries { get { return _entries; } }
            public MaleEvasionStageMultipliersArray M_Root { get { return m_root; } }
            public MaleEvasionStageMultipliersArray M_Parent { get { return m_parent; } }
        }
        private MaleEvasionStageMultipliersArrayDim0 _entries;
        private MaleEvasionStageMultipliersArray m_root;
        private KaitaiStruct m_parent;
        public MaleEvasionStageMultipliersArrayDim0 Entries { get { return _entries; } }
        public MaleEvasionStageMultipliersArray M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
