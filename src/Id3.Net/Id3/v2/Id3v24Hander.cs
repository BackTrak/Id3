using Id3.Frames;
using Id3.v2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Id3.v2
{
    internal sealed partial class Id3V24Handler : Id3V23Handler
    {
        protected override void BuildFrameHandlers(FrameHandlers mappings)
        {
            base.BuildFrameHandlers(mappings);

            mappings.Add<MoodsFrame>("TMOO", EncodeText<MoodsFrame>, DecodeText<MoodsFrame>);
        }

        internal override Id3Version Version => Id3Version.V24;
    }
}
