//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// The Node class provides a wrapper for manipulating DOM Nodes.
    /// Node properties can be accessed via the set/get methods.
    /// Use `Y.one()` to retrieve Node instances.
    /// <strong>NOTE:</strong> Node properties are accessed using
    /// the <code>set</code> and <code>get</code> methods.
    /// </summary>
    public partial class Node
    {
        /// <summary>
        /// The implementation for hiding nodes.
        /// Default is to toggle the style.display property.
        /// </summary>
        protected void _hide(){}
        /// <summary>
        /// The default IO complete handler.
        /// </summary>
        protected void _ioComplete(object code, object response, Y_.Array args){}
        /// <summary>
        /// The implementation for showing nodes.
        /// Default is to toggle the style.display property.
        /// </summary>
        protected void _show(){}
        /// <summary>
        /// Adds a class name to each node.
        /// </summary>
        public void addClass(object className){}
        /// <summary>
        /// Adds methods to the Y.Node prototype, routing through scrubVal.
        /// </summary>
        public object addMethod(object name, JsAction fn, object context){return null;}
        /// <summary>
        /// Retrieves a NodeList based on the given CSS selector.
        /// </summary>
        public NodeList all(object selector){return null;}
        /// <summary>
        /// Returns the nearest ancestor that passes the test applied by supplied boolean method.
        /// </summary>
        public Node ancestor(object fn, object testSelf, object stopFn){return null;}
        /// <summary>
        /// Returns the ancestors that pass the test applied by supplied boolean method.
        /// </summary>
        public NodeList ancestors(object fn, object testSelf){return null;}
        /// <summary>
        /// Inserts the content as the lastChild of the node.
        /// </summary>
        public void append(object content){}
        public Node appendChild(object node){return null;}
        /// <summary>
        /// Appends the node to the given node.
        /// </summary>
        public void appendTo(object node){}
        /// <summary>
        /// Passes through to DOM method.
        /// </summary>
        public void blur(){}
        /// <summary>
        /// Clears internally stored data.
        /// </summary>
        public void clearData(object name){}
        /// <summary>
        /// Passes through to DOM method.
        /// </summary>
        public Node cloneNode(object deep){return null;}
        /// <summary>
        /// Compares nodes to determine if they match.
        /// Node instances can be compared to each other and/or HTMLElements.
        /// </summary>
        public object compareTo(object refNode){return null;}
        /// <summary>
        /// Determines whether the node is an ancestor of another HTML element in the DOM hierarchy.
        /// </summary>
        public object contains(object needle){return null;}
        /// <summary>
        /// Returns a new dom node using the provided markup string.
        /// </summary>
        public Node create(object html, object doc){return null;}
        /// <summary>
        /// Passes through to DOM method.
        /// Only valid on TABLE elements
        /// </summary>
        public void createCaption(){}
        /// <summary>
        /// The default getter for DOM properties
        /// Called with instance context (this === the Node instance)
        /// </summary>
        public object DEFAULT_GETTER(object name){return null;}
        /// <summary>
        /// The default setter for DOM properties
        /// Called with instance context (this === the Node instance)
        /// </summary>
        public object DEFAULT_SETTER(object name, object val){return null;}
        /// <summary>
        /// <p>Sets up a delegation listener for an event occurring inside the Node.
        /// The delegated event will be verified against a supplied selector or
        /// filtering function to test if the event references at least one node that
        /// should trigger the subscription callback.</p>
        /// <p>Selector string filters will trigger the callback if the event originated
        /// from a node that matches it or is contained in a node that matches it.
        /// Function filters are called for each Node up the parent axis to the
        /// subscribing container node, and receive at each level the Node and the event
        /// object.  The function should return true (or a truthy value) if that Node
        /// should trigger the subscription callback.  Note, it is possible for filters
        /// to match multiple Nodes for a single event.  In this case, the delegate
        /// callback will be executed for each matching Node.</p>
        /// <p>For each matching Node, the callback will be executed with its 'this'
        /// object set to the Node matched by the filter (unless a specific context was
        /// provided during subscription), and the provided event's
        /// <code>currentTarget</code> will also be set to the matching Node.  The
        /// containing Node from which the subscription was originally made can be
        /// referenced as <code>e.container</code>.
        /// </summary>
        public EventHandle @delegate(object type, JsAction fn, object spec, object context, object args){return null;}
        /// <summary>
        /// Nulls internal node references, removes any plugins and event listeners
        /// </summary>
        public void destroy(object recursivePurge){}
        /// <summary>
        /// Applies the given function to each Node in the NodeList.
        /// </summary>
        public void each(JsAction fn, object context){}
        /// <summary>
        /// Removes and destroys all of the nodes within the node.
        /// </summary>
        public void empty(){}
        /// <summary>
        /// Passes through to DOM method.
        /// </summary>
        public void focus(){}
        /// <summary>
        /// Applies a unique ID to the node if none exists
        /// </summary>
        public object generateID(){return null;}
        /// <summary>
        /// Returns an attribute value on the Node instance.
        /// Unless pre-configured (via `Node.ATTRS`), get hands
        /// off to the underlying DOM node.  Only valid
        /// attributes/properties for the node will be queried.
        /// </summary>
        public object get(object attr){return null;}
        /// <summary>
        /// Returns a single Node instance bound to the node or the
        /// first element matching the given selector.
        /// </summary>
        public void get(object node, object doc){}
        /// <summary>
        /// Allows getting attributes on DOM nodes, normalizing in some cases.
        /// This passes through to the DOM node, allowing for custom attributes.
        /// </summary>
        public object getAttribute(object name){return null;}
        /// <summary>
        /// Returns an object containing the values for the requested attributes.
        /// </summary>
        public object getAttrs(Y_.Array attrs){return null;}
        /// <summary>
        /// Returns the computed value for the given style property.
        /// Use camelCase (e.g. 'backgroundColor') for multi-word properties.
        /// </summary>
        public object getComputedStyle(object attr){return null;}
        /// <summary>
        /// Returns the node's current content (e.g. innerHTML)
        /// </summary>
        public object getContent(){return null;}
        /// <summary>
        /// Retrieves arbitrary data stored on a Node instance.
        /// If no data is associated with the Node, it will attempt to retrieve
        /// a value from the corresponding HTML data attribute. (e.g. node.getData('foo')
        /// will check node.getAttribute('data-foo')).
        /// </summary>
        public object getData(object name){return null;}
        /// <summary>
        /// Returns the DOM node bound to the Node instance
        /// </summary>
        public object getDOMNode(){return null;}
        /// <summary>
        /// Retrieves the DOM node bound to a Node instance
        /// </summary>
        public object getDOMNode(object node){return null;}
        /// <summary>
        /// Passes through to DOM method.
        /// </summary>
        public NodeList getElementsByTagName(object tagName){return null;}
        /// <summary>
        /// Returns the node's current html content (e.g. innerHTML)
        /// </summary>
        public object getHTML(){return null;}
        /// <summary>
        /// Returns the style's current value.
        /// Use camelCase (e.g. 'backgroundColor') for multi-word properties.
        /// </summary>
        public object getStyle(object attr){return null;}
        /// <summary>
        /// Gets the current position of the node in page coordinates.
        /// </summary>
        public object getX(){return null;}
        /// <summary>
        /// Gets the current position of the node in page coordinates.
        /// </summary>
        public Y_.Array getXY(){return null;}
        /// <summary>
        /// Gets the current position of the node in page coordinates.
        /// </summary>
        public object getY(){return null;}
        /// <summary>
        /// Passes through to DOM method.
        /// </summary>
        public object hasAttribute(object attribute){return null;}
        /// <summary>
        /// Passes through to DOM method.
        /// </summary>
        public object hasChildNodes(){return null;}
        /// <summary>
        /// Determines whether each node has the given className.
        /// </summary>
        public object hasClass(object className){return null;}
        /// <summary>
        /// Hides the node.
        /// If the "transition" module is loaded, hide optionally
        /// animates the hiding of the node using either the default
        /// transition effect ('fadeOut'), or the given named effect.
        /// </summary>
        public void hide(object name, object config, JsAction callback){}
        /// <summary>
        /// Imports utility methods to be added as Y.Node methods.
        /// </summary>
        public void importMethod(object host, object name, object altName, object context){}
        /// <summary>
        /// Determines whether the node is appended to the document.
        /// </summary>
        public object inDoc(object doc){return null;}
        /// <summary>
        /// Determines whether or not the node is within the giving region.
        /// </summary>
        public object inRegion(object node2, object all, object altRegion){return null;}
        /// <summary>
        /// Inserts the content before the reference node.
        /// </summary>
        public void insert(object content, object where){}
        public Node insertBefore(object newNode, object refNode){return null;}
        /// <summary>
        /// Compares the intersection of the node with another node or region
        /// </summary>
        public object intersect(object node2, object altRegion){return null;}
        /// <summary>
        /// Invokes a method on the Node instance
        /// </summary>
        public object invoke(object method, object a_){return null;}
        /// <summary>
        /// Retrieves the Node instance at the given index.
        /// </summary>
        public Node item(Y_.DataType_.Number index){return null;}
        /// <summary>
        /// Loads content from the given url and replaces the Node's
        /// existing content with the remote content.
        /// </summary>
        public void load(object url, object selector, JsAction callback){}
        /// <summary>
        /// Returns the next matching sibling.
        /// Returns the nearest element node sibling if no method provided.
        /// </summary>
        public Node next(object fn){return null;}
        /// <summary>
        /// Subscribe a callback function to execute in response to a DOM event or custom
        /// event.
        /// Most DOM events are associated with a preventable default behavior such as
        /// link clicks navigating to a new page.  Callbacks are passed a `DOMEventFacade`
        /// object as their first argument (usually called `e`) that can be used to
        /// prevent this default behavior with `e.preventDefault()`. See the
        /// `DOMEventFacade` API for all available properties and methods on the object.
        /// If the event name passed as the first parameter is not a whitelisted DOM event,
        /// it will be treated as a custom event subscriptions, allowing
        /// `node.fire('customEventName')` later in the code.  Refer to the Event user guide
        /// for the full DOM event whitelist.
        /// By default, the `this` object in the callback will refer to the subscribed
        /// `Node`.
        /// Returning `false` from a callback is supported as an alternative to calling
        /// `e.preventDefault(); e.stopPropagation();`.  However, it is recommended to use
        /// the event methods.
        /// </summary>
        public EventHandle on(object type, JsAction fn){return null;}
        /// <summary>
        /// Subscribe a callback function to execute in response to a DOM event or custom
        /// event.
        /// Most DOM events are associated with a preventable default behavior such as
        /// link clicks navigating to a new page.  Callbacks are passed a `DOMEventFacade`
        /// object as their first argument (usually called `e`) that can be used to
        /// prevent this default behavior with `e.preventDefault()`. See the
        /// `DOMEventFacade` API for all available properties and methods on the object.
        /// If the event name passed as the first parameter is not a whitelisted DOM event,
        /// it will be treated as a custom event subscriptions, allowing
        /// `node.fire('customEventName')` later in the code.  Refer to the Event user guide
        /// for the full DOM event whitelist.
        /// By default, the `this` object in the callback will refer to the subscribed
        /// `Node`.
        /// Returning `false` from a callback is supported as an alternative to calling
        /// `e.preventDefault(); e.stopPropagation();`.  However, it is recommended to use
        /// the event methods.
        /// </summary>
        public EventHandle on(object type, JsAction fn, object arg_){return null;}
        /// <summary>
        /// Subscribe a callback function to execute in response to a DOM event or custom
        /// event.
        /// Most DOM events are associated with a preventable default behavior such as
        /// link clicks navigating to a new page.  Callbacks are passed a `DOMEventFacade`
        /// object as their first argument (usually called `e`) that can be used to
        /// prevent this default behavior with `e.preventDefault()`. See the
        /// `DOMEventFacade` API for all available properties and methods on the object.
        /// If the event name passed as the first parameter is not a whitelisted DOM event,
        /// it will be treated as a custom event subscriptions, allowing
        /// `node.fire('customEventName')` later in the code.  Refer to the Event user guide
        /// for the full DOM event whitelist.
        /// By default, the `this` object in the callback will refer to the subscribed
        /// `Node`.
        /// Returning `false` from a callback is supported as an alternative to calling
        /// `e.preventDefault(); e.stopPropagation();`.  However, it is recommended to use
        /// the event methods.
        /// </summary>
        public EventHandle on(object type, JsAction fn, object context, object arg_){return null;}
        /// <summary>
        /// Returns a single Node instance bound to the node or the
        /// first element matching the given selector. Returns null if no match found.
        /// <strong>Note:</strong> For chaining purposes you may want to
        /// use <code>Y.all</code>, which returns a NodeList when no match is found.
        /// </summary>
        public Node one(object node){return null;}
        /// <summary>
        /// Registers plugins to be instantiated at the class level (plugins
        /// which should be plugged into every instance of Node by default).
        /// </summary>
        public void plug(object plugin, object config){}
        /// <summary>
        /// Inserts the content as the firstChild of the node.
        /// </summary>
        public void prepend(object content){}
        /// <summary>
        /// Returns the previous matching sibling.
        /// Returns the nearest element node sibling if no method provided.
        /// </summary>
        public Node previous(object fn){return null;}
        /// <summary>
        /// Removes event listeners from the node and (optionally) its subtree
        /// </summary>
        public void purge(object recurse, object type){}
        /// <summary>
        /// Retrieves a Node instance of nodes based on the given CSS selector.
        /// </summary>
        public Node query(object selector){return null;}
        /// <summary>
        /// Retrieves a nodeList based on the given CSS selector.
        /// </summary>
        public NodeList queryAll(object selector){return null;}
        /// <summary>
        /// Removes the node from its parent.
        /// Shortcut for myNode.get('parentNode').removeChild(myNode);
        /// </summary>
        public void remove(object destroy){}
        /// <summary>
        /// Passes through to DOM method.
        /// </summary>
        public void removeAttribute(object attribute){}
        /// <summary>
        /// Passes through to DOM method.
        /// </summary>
        public Node removeChild(object node){return null;}
        /// <summary>
        /// Removes a class name from each node.
        /// </summary>
        public void removeClass(object className){}
        /// <summary>
        /// Replace the node with the other node. This is a DOM update only
        /// and does not change the node bound to the Node instance.
        /// Shortcut for myNode.get('parentNode').replaceChild(newNode, myNode);
        /// </summary>
        public void replace(object newNode){}
        public Node replaceChild(object node, object refNode){return null;}
        /// <summary>
        /// Replace a class with another class for each node.
        /// If no oldClassName is present, the newClassName is simply added.
        /// </summary>
        public void replaceClass(object oldClassName, object newClassName){}
        /// <summary>
        /// Passes through to DOM method.
        /// Only valid on FORM elements
        /// </summary>
        public void reset(){}
        /// <summary>
        /// Passes through to DOM method.
        /// </summary>
        public void scrollIntoView(){}
        /// <summary>
        /// Checks Node return values and wraps DOM Nodes as Y.Node instances
        /// and DOM Collections / Arrays as Y.NodeList instances.
        /// Other return values just pass thru.  If undefined is returned (e.g. no return)
        /// then the Node instance is returned for chainability.
        /// </summary>
        public Node scrubVal(object node){return null;}
        /// <summary>
        /// Passes through to DOM method.
        /// </summary>
        public void select(){}
        /// <summary>
        /// Sets an attribute on the Node instance.
        /// Unless pre-configured (via Node.ATTRS), set hands
        /// off to the underlying DOM node.  Only valid
        /// attributes/properties for the node will be set.
        /// To set custom attributes use setAttribute.
        /// </summary>
        public void set(object attr, object val){}
        /// <summary>
        /// Allows setting attributes on DOM nodes, normalizing in some cases.
        /// This passes through to the DOM node, allowing for custom attributes.
        /// </summary>
        public void setAttribute(object name, object value){}
        /// <summary>
        /// Sets multiple attributes.
        /// </summary>
        public void setAttrs(object attrMap){}
        /// <summary>
        /// Replaces the node's current content with the content.
        /// Note that this passes to innerHTML and is not escaped.
        /// Use `Y.Escape.html()` to escape HTML, or `set('text')` to add as text.
        /// </summary>
        public void setContent(object content){}
        /// <summary>
        /// Stores arbitrary data on a Node instance.
        /// This is not stored with the DOM node.
        /// </summary>
        public void setData(object name, object val){}
        /// <summary>
        /// Replaces the node's current html content with the content provided.
        /// Note that this passes to innerHTML and is not escaped.
        /// Use `Y.Escape.html()` to escape HTML, or `set('text')` to add as text.
        /// </summary>
        public void setHTML(object content){}
        /// <summary>
        /// Sets a style property of the node.
        /// Use camelCase (e.g. 'backgroundColor') for multi-word properties.
        /// </summary>
        public void setStyle(object attr, object val){}
        /// <summary>
        /// Sets multiple style properties on the node.
        /// Use camelCase (e.g. 'backgroundColor') for multi-word properties.
        /// </summary>
        public void setStyles(object hash){}
        /// <summary>
        /// Set the position of the node in page coordinates, regardless of how the node is positioned.
        /// </summary>
        public void setX(object x){}
        /// <summary>
        /// Set the position of the node in page coordinates, regardless of how the node is positioned.
        /// </summary>
        public void setXY(Y_.Array xy){}
        /// <summary>
        /// Set the position of the node in page coordinates, regardless of how the node is positioned.
        /// </summary>
        public void setY(object y){}
        /// <summary>
        /// Makes the node visible.
        /// If the "transition" module is loaded, show optionally
        /// animates the showing of the node using either the default
        /// transition effect ('fadeIn'), or the given named effect.
        /// </summary>
        public void show(object name, object config, JsAction callback){}
        /// <summary>
        /// Returns all matching siblings.
        /// Returns all siblings if no method provided.
        /// </summary>
        public NodeList siblings(object fn){return null;}
        /// <summary>
        /// Simulates an event on the node.
        /// </summary>
        public object simulate(object type, object options){return null;}
        /// <summary>
        /// Returns the current number of items in the Node.
        /// </summary>
        public object size(){return null;}
        /// <summary>
        /// Passes through to DOM method.
        /// Only valid on FORM elements
        /// </summary>
        public void submit(){}
        /// <summary>
        /// Swap DOM locations with the given node.
        /// This does not change which DOM node each Node instance refers to.
        /// </summary>
        public void swap(Node otherNode){}
        /// <summary>
        /// Swaps the XY position of this node with another node.
        /// </summary>
        public void swapXY(object otherNode){}
        /// <summary>
        /// Test if the supplied node matches the supplied selector.
        /// </summary>
        public object test(object selector){return null;}
        /// <summary>
        /// If the className exists on the node it is removed, if it doesn't exist it is added.
        /// </summary>
        public void toggleClass(object className, object force){}
        /// <summary>
        /// Displays or hides the node.
        /// If the "transition" module is loaded, toggleView optionally
        /// animates the toggling of the node using either the default
        /// transition effect ('fadeIn'), or the given named effect.
        /// </summary>
        public void toggleView(){}
        /// <summary>
        /// Displays or hides the node.
        /// If the "transition" module is loaded, toggleView optionally
        /// animates the toggling of the node using either the default
        /// transition effect ('fadeIn'), or the given named effect.
        /// </summary>
        public void toggleView(JsAction callback){}
        /// <summary>
        /// Displays or hides the node.
        /// If the "transition" module is loaded, toggleView optionally
        /// animates the toggling of the node using either the default
        /// transition effect ('fadeIn'), or the given named effect.
        /// </summary>
        public void toggleView(object on){}
        /// <summary>
        /// Displays or hides the node.
        /// If the "transition" module is loaded, toggleView optionally
        /// animates the toggling of the node using either the default
        /// transition effect ('fadeIn'), or the given named effect.
        /// </summary>
        public void toggleView(object on, JsAction callback){}
        /// <summary>
        /// The method called when outputting Node instances as strings
        /// </summary>
        public object toString(){return null;}
        /// <summary>
        /// Animate one or more css properties to a given value. Requires the "transition" module.
        /// <pre>example usage:
        /// Y.one('#demo').transition({
        /// duration: 1, // in seconds, default is 0.5
        /// easing: 'ease-out', // default is 'ease'
        /// delay: '1', // delay start for 1 second, default is 0
        /// height: '10px',
        /// width: '10px',
        /// opacity: { // per property
        /// value: 0,
        /// duration: 2,
        /// delay: 2,
        /// easing: 'ease-in'
        /// }
        /// });
        /// </pre>
        /// </summary>
        public void transition(object config, JsAction callback){}
        /// <summary>
        /// Unregisters any class level plugins which have been registered by the Node
        /// </summary>
        public void unplug(object plugin){}
        /// <summary>
        /// Removes the node's parent node.
        /// </summary>
        public void unwrap(){}
        /// <summary>
        /// Wraps the given HTML around the node.
        /// </summary>
        public void wrap(object html){}
        /// <summary>
        /// Static collection of configuration attributes for special handling
        /// </summary>
        public object ATTRS{get;set;}
        /// <summary>
        /// List of events that route to DOM events
        /// </summary>
        public object DOM_EVENTS{get;set;}
        /// <summary>
        /// The name of the component
        /// </summary>
        public object NAME{get;set;}
    }
}
