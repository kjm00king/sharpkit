//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE.dom
{
    /// <summary>
    /// Utility class for various DOM manipulation and retrival functions.
    /// </summary>
    [JsType(JsMode.Prototype, Name="tinymce.dom.DOMUtils", Export=false)]
    public  partial class DOMUtils
    {
        /// <summary>
        /// Adds the specified element to another element or elements.
        /// </summary>
        /// <param name="a">Optional object collection with arguments to add to the new element(s).</param>
        /// <param name="h">Optional inner HTML contents to add for each element.</param>
        /// <param name="c">Optional internal state to indicate if it should create or add.</param>
        public SharpKit.TinyMCE.dom.Element add(object a, string h, bool c){return null;}
        /// <summary>
        /// Adds a class to the specified element or elements.
        /// </summary>
        /// <param name="c">Class name to add to each element.</param>
        public string addClass(string c){return null;}
        /// <summary>
        /// Adds a style element at the top of the document with the specified cssText content.
        /// </summary>
        /// <param name="cssText">CSS Text style to add to top of head of document.</param>
        public object addStyle(string cssText){return null;}
        /// <summary>
        /// Adds an event handler to the specified object.
        /// </summary>
        /// <param name="n">Name of event handler to add for example: click.</param>
        /// <param name="f">Function to execute when the event occurs.</param>
        /// <param name="s">Optional scope to execute the function in.</param>
        public object bind(string n, object f, object s){return null;}
        /// <summary>
        /// Creates a new element.
        /// </summary>
        /// <param name="n">Name of new element.</param>
        /// <param name="a">Optional object name/value collection with element attributes.</param>
        /// <param name="h">Optional HTML string to set as inner HTML of the element.</param>
        public SharpKit.TinyMCE.dom.Element create(string n, object a, string h){return null;}
        /// <summary>
        /// Create HTML string for element. The element will be closed unless an empty inner HTML string is passed.
        /// </summary>
        /// <param name="n">Name of new element.</param>
        /// <param name="a">Optional object name/value collection with element attributes.</param>
        /// <param name="h">Optional HTML string to set as inner HTML of the element.</param>
        public string createHTML(string n, object a, string h){return null;}
        /// <summary>
        /// Created a new DOM Range object. This will use the native DOM Range API if it's
        /// available if it's not it will fallback to the custom TinyMCE implementation.
        /// </summary>
        public object createRng(){return null;}
        /// <summary>
        /// Entity decode a string, resolves any HTML entities like &aring;.
        /// </summary>
        /// <param name="s">String to decode entities on.</param>
        public string decode(string s){return null;}
        /// <summary>
        /// Destroys all internal references to the DOM to solve IE leak issues.
        /// </summary>
        public object destroy(){return null;}
        /// <summary>
        /// Constructs a new DOMUtils instance. Consult the Wiki for more details on settings etc for this class.
        /// </summary>
        /// <param name="d">Document reference to bind the utility class to.</param>
        /// <param name="s">Optional settings collection.</param>
        public DOMUtils(object d, object s){}
        /// <summary>
        /// Entity encodes a string, encodes the most common entities <>"& into entities.
        /// </summary>
        /// <param name="text">String to encode with entities.</param>
        public string encode(string text){return null;}
        /// <summary>
        /// Find the common ancestor of two elements. This is a shorter method than using the DOM Range logic.
        /// </summary>
        /// <param name="a">Element to find common ancestor of.</param>
        /// <param name="b">Element to find common ancestor of.</param>
        public SharpKit.TinyMCE.dom.Element findCommonAncestor(SharpKit.TinyMCE.dom.Element a, SharpKit.TinyMCE.dom.Element b){return null;}
        /// <summary>
        /// Fires the specified event name with object on target.
        /// </summary>
        /// <param name="name">Name of the event to fire.</param>
        /// <param name="evt">Event object to send.</param>
        public object fire(string name, object evt){return null;}
        /// <summary>
        /// Returns the specified element by ID or the input element if it isn't a string.
        /// </summary>
        public SharpKit.TinyMCE.dom.Element get(){return null;}
        /// <summary>
        /// Returns the specified attribute by name.
        /// </summary>
        /// <param name="n">Name of attribute to get.</param>
        /// <param name="dv">Optional default value to return if the attribute didn't exist.</param>
        public string getAttrib(string n, string dv){return null;}
        /// <summary>
        /// Returns an NodeList with attributes for the element.
        /// </summary>
        public object getAttribs(){return null;}
        /// <summary>
        /// Returns a array of all single CSS classes in the document. A single CSS class is a simple
        /// rule like ".class" complex ones like "div td.class" will not be added to output.
        /// </summary>
        public Array getClasses(){return null;}
        /// <summary>
        /// Returns the next node that matches selector or function
        /// </summary>
        /// <param name="node">Node to find siblings from.</param>
        public SharpKit.TinyMCE.html.Node getNext(SharpKit.TinyMCE.html.Node node){return null;}
        /// <summary>
        /// Returns the outer HTML of an element.
        /// </summary>
        public string getOuterHTML(){return null;}
        /// <summary>
        /// Returns a node by the specified selector function. This function will
        /// loop through all parent nodes and call the specified function for each node.
        /// If the function then returns true indicating that it has found what it was looking for, the loop execution will then end
        /// and the node it found will be returned.
        /// </summary>
        /// <param name="f">Selection function to execute on each node or CSS pattern.</param>
        /// <param name="r">Optional root element, never go below this point.</param>
        public SharpKit.TinyMCE.html.Node getParent(object f, SharpKit.TinyMCE.html.Node r){return null;}
        /// <summary>
        /// Returns a node list of all parents matching the specified selector function or pattern.
        /// If the function then returns true indicating that it has found what it was looking for and that node will be collected.
        /// </summary>
        /// <param name="f">Selection function to execute on each node or CSS pattern.</param>
        /// <param name="r">Optional root element, never go below this point.</param>
        public Array getParents(object f, SharpKit.TinyMCE.html.Node r){return null;}
        /// <summary>
        /// Returns the absolute x, y position of a node. The position will be returned in a object with x, y fields.
        /// </summary>
        /// <param name="ro">Optional root element to stop calculations at.</param>
        public object getPos(SharpKit.TinyMCE.dom.Element ro){return null;}
        /// <summary>
        /// Returns the previous node that matches selector or function
        /// </summary>
        /// <param name="node">Node to find siblings from.</param>
        public SharpKit.TinyMCE.html.Node getPrev(SharpKit.TinyMCE.html.Node node){return null;}
        /// <summary>
        /// Returns the rectangle for a specific element.
        /// </summary>
        public object getRect(){return null;}
        /// <summary>
        /// Returns the root node of the document this is normally the body but might be a DIV. Parents like getParent will not
        /// go above the point of this root node.
        /// </summary>
        public SharpKit.TinyMCE.dom.Element getRoot(){return null;}
        /// <summary>
        /// Returns the size dimensions of the specified element.
        /// </summary>
        public object getSize(){return null;}
        /// <summary>
        /// Returns the current style or runtime/computed value of a element.
        /// </summary>
        /// <param name="na">Style name to return.</param>
        /// <param name="c">Computed style.</param>
        public string getStyle(string na, bool c){return null;}
        /// <summary>
        /// Returns the viewport of the window.
        /// </summary>
        /// <param name="w">Optional window to get viewport of.</param>
        public object getViewPort(object w){return null;}
        /// <summary>
        /// Returns true if the specified element has the specified class.
        /// </summary>
        /// <param name="c">CSS class to check for.</param>
        public bool hasClass(string c){return false;}
        /// <summary>
        /// Hides the specified element(s) by ID by setting the "display" style.
        /// </summary>
        public object hide(){return null;}
        /// <summary>
        /// Inserts a element after the reference element.
        /// </summary>
        /// <param name="node">Element to insert after the reference.</param>
        public SharpKit.TinyMCE.dom.Element insertAfter(SharpKit.TinyMCE.dom.Element node){return null;}
        /// <summary>
        /// Returns true/false if the specified element matches the specified css pattern.
        /// </summary>
        /// <param name="selector">CSS pattern to match the element agains.</param>
        public object @is(string selector){return null;}
        /// <summary>
        /// Returns true/false if the specified element is a block element or not.
        /// </summary>
        public bool isBlock(){return false;}
        /// <summary>
        /// Returns true/false if the specified node is to be considered empty or not.
        /// </summary>
        /// <param name="elements">Optional name/value object with elements that are automatically treated as non empty elements.</param>
        public bool isEmpty(object elements){return false;}
        /// <summary>
        /// Returns true/false if the element is hidden or not by checking the "display" style.
        /// </summary>
        public bool isHidden(){return false;}
        /// <summary>
        /// Imports/loads the specified CSS file into the document bound to the class.
        /// </summary>
        /// <param name="u">URL to CSS file to load.</param>
        public object loadCSS(string u){return null;}
        /// <summary>
        /// Parses the specified style value into an object collection. This parser will also
        /// merge and remove any redundant items that browsers might have added. It will also convert non hex
        /// colors to hex values. Urls inside the styles will also be converted to absolute/relative based on settings.
        /// </summary>
        /// <param name="st">Style value to parse for example: border:1px solid red;.</param>
        public object parseStyle(string st){return null;}
        /// <summary>
        /// Removes/deletes the specified element(s) from the DOM.
        /// </summary>
        /// <param name="keep_children">Optional state to keep children or not. If set to true all children will be placed at the location of the removed element.</param>
        public SharpKit.TinyMCE.dom.Element remove(bool keep_children){return null;}
        /// <summary>
        /// Removes a class from the specified element or elements.
        /// </summary>
        /// <param name="c">Class name to remove to each element.</param>
        public string removeClass(string c){return null;}
        /// <summary>
        /// Renames the specified element to a new name and keep it's attributes and children.
        /// </summary>
        /// <param name="elm">Element to rename.</param>
        /// <param name="name">Name of the new element.</param>
        public object rename(SharpKit.TinyMCE.dom.Element elm, string name){return null;}
        /// <summary>
        /// Replaces the specified element or elements with the specified element, the new element will
        /// be cloned if multiple inputs elements are passed.
        /// </summary>
        /// <param name="n">New element to replace old ones with.</param>
        /// <param name="k">Optional keep children state, if set to true child nodes from the old object will be added to new ones.</param>
        public object replace(SharpKit.TinyMCE.dom.Element n, bool k){return null;}
        /// <summary>
        /// Executes the specified function on the element by id or dom element node or array of elements/id.
        /// </summary>
        /// <param name="f">Function to execute for each item.</param>
        /// <param name="s">Optional scope to execute the function in.</param>
        public object run(object f, object s){return null;}
        /// <summary>
        /// Selects specific elements by a CSS level 3 pattern. For example "div#a1 p.test".
        /// This function is optimized for the most common patterns needed in TinyMCE but it also performes good enough
        /// on more complex patterns.
        /// </summary>
        /// <param name="p">CSS level 1 pattern to select/find elements by.</param>
        /// <param name="s">Optional root element/scope element to search in.</param>
        public Array select(string p, object s){return null;}
        /// <summary>
        /// Serializes the specified style object into a string.
        /// </summary>
        /// <param name="o">Object to serialize as string for example: {border : '1px solid red'}</param>
        /// <param name="name">Optional element name.</param>
        public string serializeStyle(object o, string name){return null;}
        /// <summary>
        /// Sets the specified attributes value of a element or elements.
        /// </summary>
        /// <param name="n">Name of attribute to set.</param>
        /// <param name="v">Value to set on the attribute of this value is falsy like null 0 or '' it will remove the attribute instead.</param>
        public object setAttrib(string n, string v){return null;}
        /// <summary>
        /// Sets the specified attributes of a element or elements.
        /// </summary>
        /// <param name="o">Name/Value collection of attribute items to add to the element(s).</param>
        public object setAttribs(object o){return null;}
        /// <summary>
        /// Sets the specified HTML content inside the element or elements. The HTML will first be processed this means
        /// URLs will get converted, hex color values fixed etc. Check processHTML for details.
        /// </summary>
        /// <param name="h">HTML content to set as inner HTML of the element.</param>
        public object setHTML(string h){return null;}
        /// <summary>
        /// Sets the specified outer HTML on a element or elements.
        /// </summary>
        /// <param name="h">HTML code to set as outer value for the element.</param>
        /// <param name="d">Optional document scope to use in this process defaults to the document of the DOM class.</param>
        public object setOuterHTML(object h, object d){return null;}
        /// <summary>
        /// Sets the CSS style value on a HTML element. The name can be a camelcase string
        /// or the CSS style name like background-color.
        /// </summary>
        /// <param name="na">Name of the style value to set.</param>
        /// <param name="v">Value to set on the style.</param>
        public object setStyle(string na, string v){return null;}
        /// <summary>
        /// Sets multiple styles on the specified element(s).
        /// </summary>
        /// <param name="o">Name/Value collection of style items to add to the element(s).</param>
        public object setStyles(object o){return null;}
        /// <summary>
        /// Shows the specified element(s) by ID by setting the "display" style.
        /// </summary>
        public object show(){return null;}
        /// <summary>
        /// Splits an element into two new elements and places the specified split
        /// element or element between the new ones. For example splitting the paragraph at the bold element in
        /// this example <p>abc<b>abc</b>123</p> would produce <p>abc</p><b>abc</b><p>123</p>.
        /// </summary>
        /// <param name="pe">Parent element to split.</param>
        /// <param name="e">Element to split at.</param>
        /// <param name="re">Optional replacement element to replace the split element by.</param>
        public SharpKit.TinyMCE.dom.Element split(SharpKit.TinyMCE.dom.Element pe, SharpKit.TinyMCE.dom.Element e, SharpKit.TinyMCE.dom.Element re){return null;}
        /// <summary>
        /// Parses the specified RGB color value and returns a hex version of that color.
        /// </summary>
        /// <param name="s">RGB string value like rgb(1,2,3)</param>
        public string toHex(string s){return null;}
        /// <summary>
        /// Removes the specified event handler by name and function from a element or collection of elements.
        /// </summary>
        /// <param name="n">Event handler name like for example: "click"</param>
        /// <param name="f">Function to remove.</param>
        public bool unbind(string n, object f){return false;}
        /// <summary>
        /// Returns a unique id. This can be useful when generating elements on the fly.
        /// This method will not check if the element allready exists.
        /// </summary>
        /// <param name="p">Optional prefix to add infront of all ids defaults to "mce_".</param>
        public string uniqueId(string p){return null;}
    }
}
