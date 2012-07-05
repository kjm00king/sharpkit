//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region Cookies
    /// <summary>
    /// Utility class for setting/reading values from browser cookies.
    /// Values can be written using the set method.
    /// Values can be read using the get method.
    /// A cookie can be invalidated on the client machine using the clear method.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Cookies : Ext.Base
    {
        /// <summary>
        /// Removes a cookie with the provided name from the browser
        /// if found by setting its expiration date to sometime in the p...
        /// </summary>
        public static object clear(JsString name, JsString path=null){return null;}
        /// <summary>
        /// Retrieves cookies that are accessible by the current page. ...
        /// </summary>
        public static object get(JsString name){return null;}
        /// <summary>
        /// Create a cookie with the specified name and value. ...
        /// </summary>
        public static object set(JsString name, object value, object expires, JsString path, JsString domain, bool secure){return null;}
        public Cookies(CookiesConfig config){}
        public Cookies(){}
    }
    #endregion
    #region CookiesConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class CookiesConfig : Ext.BaseConfig
    {
    }
    #endregion
    #region CookiesEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class CookiesEvents : Ext.BaseEvents
    {
    }
    #endregion
}
#endregion