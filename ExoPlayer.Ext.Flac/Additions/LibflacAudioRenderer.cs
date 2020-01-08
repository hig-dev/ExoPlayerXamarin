using System;
using System.Collections.Generic;
using Android.Runtime;
using Com.Google.Android.Exoplayer2.Decoder;
using Com.Google.Android.Exoplayer2.Drm;
using Java.Interop;

namespace Com.Google.Android.Exoplayer2.Ext.Flac
{
    public partial class LibflacAudioRenderer : global::Com.Google.Android.Exoplayer2.Audio.SimpleDecoderAudioRenderer
    {
        /// <summary>
        /// This method just exists to solve building errors of the binding project, so don't use it.
        /// </summary>
        /// <returns>null</returns>
        protected override SimpleDecoder CreateDecoder(Format format, IExoMediaCrypto mediaCrypto)
        {
            return null;
        }
    }
}
