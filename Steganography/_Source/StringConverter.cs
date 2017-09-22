namespace Magikarp.Utility.Steganography
{
    /// <summary>
    /// 提供字串與位元組互轉功能。
    /// </summary>
    /// <remarks>
    /// Author: 黃竣祥
    /// Version: 20170904
    /// </remarks>
    public class StringConverter
    {
        #region -- 靜態方法 (Shared Method ) --

        /// <summary>
        /// 轉換位元組為字串。
        /// </summary>
        /// <param name="pi_objSource">待轉換位元組。</param>
        /// <returns>轉換後字串。</returns>
        /// <remarks>
        /// Author: 黃竣祥
        /// Time: 2017/09/04
        /// History: N/A
        /// DB Object: N/A      
        /// </remarks>
        public static string ToString(byte[] pi_objSource)
        {
            return System.Text.Encoding.GetEncoding(950).GetString(pi_objSource);
        }

        /// <summary>
        /// 轉換字串為位元組。
        /// </summary>
        /// <param name="pi_sSource">待轉換字串。</param>
        /// <returns>轉換後位元組。</returns>
        /// <remarks>
        /// Author: 黃竣祥
        /// Time: 2017/09/04
        /// History: N/A
        /// DB Object: N/A      
        /// </remarks>
        public static byte[] ToByte(string pi_sSource)
        {
            return System.Text.Encoding.GetEncoding(950).GetBytes(pi_sSource);
        }

        #endregion     
    }
}
