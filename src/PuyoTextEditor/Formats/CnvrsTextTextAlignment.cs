using System.Xml.Serialization;

namespace PuyoTextEditor.Formats
{
    /// <summary>
    /// Specifies the horizontal alignment of text.
    /// </summary>
    public enum CnvrsTextTextAlignment : int
    {
        /// <summary>
        /// Text is aligned to the left.
        /// </summary>
        [XmlEnum("left")]
        Left = 0,

        /// <summary>
        /// Text is centered.
        /// </summary>
        [XmlEnum("center")]
        Center = 1,

        /// <summary>
        /// Text is aligned to the right.
        /// </summary>
        [XmlEnum("right")]
        Right = 2,
        
        /// <summary>
        /// New value for Sonic Frontiers
        /// </summary>
        [XmlEnum("sfrvalue")]
        Sfrvalue = 3,
    }
}
