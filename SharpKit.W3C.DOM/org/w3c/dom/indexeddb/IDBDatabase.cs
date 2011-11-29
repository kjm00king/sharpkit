//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.indexeddb
{

using SharpKit.JavaScript;
using DOMStringList = org.w3c.dom.DOMStringList;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class IDBDatabase
{

	// IDBDatabase
	public string name {get;private set;}
	public string description {get;private set;}
	public string version {get;private set;}
	public DOMStringList objectStores {get;private set;}
	public DOMStringList indexes {get;private set;}
	public IDBTransaction currentTransaction {get;private set;}
}

}