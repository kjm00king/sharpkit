//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.indexeddb
{

using SharpKit.JavaScript;
using DOMStringList = org.w3c.dom.DOMStringList;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class IDBDatabaseRequest : IDBDatabase
{

	// IDBDatabaseRequest
	public IDBRequest request {get;private set;}
	public void createObjectStore(string name, string keyPath) {}
	public void createObjectStore(string name, string keyPath, bool autoIncrement) {}
	public void openObjectStore(string name) {}
	public void openObjectStore(string name, short mode) {}
	public void createIndex(string name, string storeName, string keyPath) {}
	public void createIndex(string name, string storeName, string keyPath, bool unique) {}
	public void openIndex(string name) {}
	public void removeObjectStore(string storeName) {}
	public void removeIndex(string indexName) {}
	public void setVersion(string version) {}
	public void openTransaction() {}
	public void openTransaction(DOMStringList storeNames) {}
	public void openTransaction(DOMStringList storeNames, int timeout) {}
}

}