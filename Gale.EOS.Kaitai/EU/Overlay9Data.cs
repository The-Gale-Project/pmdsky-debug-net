// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;

namespace Gale.EOS.Kaitai.EU
{
    public partial class Overlay9Data : KaitaiStruct
    {
        public static Overlay9Data FromFile(string fileName)
        {
            return new Overlay9Data(new KaitaiStream(fileName));
        }

        public Overlay9Data(KaitaiStream p__io, KaitaiStruct p__parent = null, Overlay9Data p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            f_jukeboxTrackMenuDefaultWindowParams = false;
            f_playbackControlsMenuDefaultWindowParams = false;
            f_inputLockBoxDefaultWindowParams = false;
            _read();
        }
        private void _read()
        {
        }
        private bool f_jukeboxTrackMenuDefaultWindowParams;
        private WindowParams _jukeboxTrackMenuDefaultWindowParams;

        /// <summary>
        /// Default window_params for a jukebox_track_menu.
        /// 
        /// Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateJukeboxTrackMenu.
        /// 
        /// Additionally, width and height are 0, and will be computed in CreateJukeboxTrackMenu.
        /// </summary>
        public WindowParams JukeboxTrackMenuDefaultWindowParams
        {
            get
            {
                if (f_jukeboxTrackMenuDefaultWindowParams)
                    return _jukeboxTrackMenuDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(11548);
                _jukeboxTrackMenuDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_jukeboxTrackMenuDefaultWindowParams = true;
                return _jukeboxTrackMenuDefaultWindowParams;
            }
        }
        private bool f_playbackControlsMenuDefaultWindowParams;
        private WindowParams _playbackControlsMenuDefaultWindowParams;

        /// <summary>
        /// Default window_params for a playback_controls_menu.
        /// 
        /// Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreatePlaybackControlsMenu.
        /// 
        /// Additionally, width and height are 0, and will be computed in CreatePlaybackControlsMenu.
        /// </summary>
        public WindowParams PlaybackControlsMenuDefaultWindowParams
        {
            get
            {
                if (f_playbackControlsMenuDefaultWindowParams)
                    return _playbackControlsMenuDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(11564);
                _playbackControlsMenuDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_playbackControlsMenuDefaultWindowParams = true;
                return _playbackControlsMenuDefaultWindowParams;
            }
        }
        private bool f_inputLockBoxDefaultWindowParams;
        private WindowParams _inputLockBoxDefaultWindowParams;

        /// <summary>
        /// Default window_params for an input_lock_box.
        /// </summary>
        public WindowParams InputLockBoxDefaultWindowParams
        {
            get
            {
                if (f_inputLockBoxDefaultWindowParams)
                    return _inputLockBoxDefaultWindowParams;
                long _pos = m_io.Pos;
                m_io.Seek(11580);
                _inputLockBoxDefaultWindowParams = new WindowParams(m_io);
                m_io.Seek(_pos);
                f_inputLockBoxDefaultWindowParams = true;
                return _inputLockBoxDefaultWindowParams;
            }
        }
        private Overlay9Data m_root;
        private KaitaiStruct m_parent;
        public Overlay9Data M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
